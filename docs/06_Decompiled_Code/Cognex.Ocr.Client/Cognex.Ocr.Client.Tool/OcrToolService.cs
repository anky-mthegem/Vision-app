using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cognex.Ocr.Client.Tool;

internal class OcrToolService : IToolService
{
	internal class ToolMessageArgs
	{
		public string toolId;

		public string action;

		public object args;
	}

	internal class GetImageArgs
	{
		public string imageId;
	}

	internal class CharacterSizeArgs
	{
		public CharacterSizeParams size;
	}

	internal class CharacterSizeParams
	{
		public double width;

		public double height;
	}

	internal class CharacterParams
	{
		public double centerX;

		public double centerY;

		public string text;

		public double confidence;
	}

	internal class LabelingParams
	{
		public string resultId;

		public ICollection<CharacterParams> characters;
	}

	internal class RevisedCharacterParams
	{
		public double centerX;

		public double centerY;

		public string text;
	}

	internal class RevisedLabelingParams
	{
		public string resultId;

		public ICollection<RevisedCharacterParams> characters;
	}

	internal class SampleParams
	{
		public string id { get; }

		public ImageParams image { get; }

		public ICollection<CharacterParams> characters { get; }

		public static ICollection<SampleParams> FromSamples(ICollection<ISample> samples)
		{
			List<SampleParams> list = new List<SampleParams>(samples.Count);
			foreach (ISample sample in samples)
			{
				list.Add(new SampleParams(sample));
			}
			return list;
		}

		public SampleParams(ISample sample)
		{
			id = sample.Id;
			image = ImageParams.FromImage(sample.Image);
			characters = new List<CharacterParams>();
			foreach (Character character in sample.Characters)
			{
				characters.Add(new CharacterParams
				{
					centerX = character.CenterX,
					centerY = character.CenterY,
					confidence = character.Confidence,
					text = character.Text.ToString()
				});
			}
		}
	}

	internal class ResultImageParams
	{
		public string resultId;

		public ImageParams image;
	}

	internal class ImageParams
	{
		public string content;

		public int width;

		public int height;

		public static ImageParams FromImage(Image image)
		{
			if (image != null)
			{
				return new ImageParams
				{
					content = Convert.ToBase64String(image.Content),
					width = image.Width,
					height = image.Height
				};
			}
			return new ImageParams
			{
				content = null,
				width = 0,
				height = 0
			};
		}
	}

	internal class ChangeSampleParams
	{
		public string sampleId;

		public ICollection<CharacterParams> characters;
	}

	internal class DeleteSamplesParams
	{
		public string[] sampleIds;
	}

	internal class FieldingPatternParams
	{
		public string name { get; set; }

		public string pattern { get; set; }
	}

	internal class FieldingSettingsParams
	{
		public string fieldingType { get; set; }

		public string acceptedCharacters { get; set; }

		public int? numberOfLines { get; set; }

		public FieldingPatternParams[] patterns { get; set; }

		public string flexibleFieldingValue { get; set; }

		public string flexibleFieldingReference { get; set; }
	}

	internal class FieldingResultParams
	{
		public bool match { get; set; }

		public string patternName { get; set; }

		public string text { get; set; }
	}

	private readonly Dictionary<string, CommunicationRegistration> registrations = new Dictionary<string, CommunicationRegistration>();

	private IOcrToolAdapter toolAdapter;

	internal IOcrToolAdapter ToolAdapter
	{
		get
		{
			return toolAdapter;
		}
		set
		{
			if (toolAdapter != null)
			{
				toolAdapter.NewResult -= ToolAdapter_NewResult;
			}
			toolAdapter = value;
			if (toolAdapter != null)
			{
				toolAdapter.NewResult += ToolAdapter_NewResult;
			}
		}
	}

	private void ToolAdapter_NewResult(object sender, NewResultArgs args)
	{
		foreach (CommunicationRegistration value in registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerNewResults", args.toolId).Forget();
		}
	}

	public void Register(IComponentWrapper wrapper)
	{
		if (registrations.ContainsKey(wrapper.WrapperId.ToString()))
		{
			throw new Exception("ToolService: Component with the provided key already registered");
		}
		WebMethodBridge<WebEditControlMessage> methods = new WebMethodBridge<WebEditControlMessage>(wrapper.Component.WebView, "ToolCommunication", (WebEditControlMessage msg) => HandleToolMessageAsync(msg, wrapper.WrapperId.ToString()));
		CommunicationRegistration value = new CommunicationRegistration(wrapper, methods);
		registrations.Add(wrapper.WrapperId.ToString(), value);
	}

	public void Unregister(IComponentWrapper component)
	{
		if (!registrations.ContainsKey(component.WrapperId.ToString()))
		{
			ComponentManager.Instance.LogService.LogWarning($"ToolService: Unable to unregister component. WrapperId: {component.WrapperId}");
			return;
		}
		registrations[component.WrapperId.ToString()].Methods.Dispose();
		registrations.Remove(component.WrapperId.ToString());
	}

	private async Task HandleToolMessageAsync(WebEditControlMessage message, string wrapperId)
	{
		_ = 15;
		try
		{
			if (message.Message != "ToolMessage")
			{
				return;
			}
			if (!registrations.ContainsKey(wrapperId))
			{
				ComponentManager.Instance.LogService.LogWarning("ToolService: Registration not found. WrapperId: " + wrapperId);
				return;
			}
			ToolMessageArgs toolMessageArgs = JsonConvert.DeserializeObject<ToolMessageArgs>(message.Args?.ToString() ?? "");
			string response = "";
			switch (toolMessageArgs.action)
			{
			case "get confidence":
				response = (await toolAdapter.GetConfidencePercentage(toolMessageArgs.toolId)).ToString();
				break;
			case "get number of samples":
				response = (await toolAdapter.GetNumberOfSamples(toolMessageArgs.toolId)).ToString();
				break;
			case "get number of unique characters":
				response = (await toolAdapter.GetNumberOfUniqueCharacters(toolMessageArgs.toolId)).ToString();
				break;
			case "get image":
			{
				IResultImage resultImage = await toolAdapter.GetImage(toolMessageArgs.toolId);
				ImageParams image = ImageParams.FromImage(resultImage.Image);
				ResultImageParams value3 = new ResultImageParams
				{
					resultId = resultImage.Id,
					image = image
				};
				response = JsonConvert.SerializeObject(value3);
				break;
			}
			case "delete samples":
			{
				DeleteSamplesParams deleteSamplesParams = (toolMessageArgs.args as JObject)?.ToObject<DeleteSamplesParams>();
				await toolAdapter.DeleteSamples(toolMessageArgs.toolId, deleteSamplesParams.sampleIds);
				break;
			}
			case "skip":
				await toolAdapter.Skip(toolMessageArgs.toolId);
				break;
			case "get characters":
			{
				IResultCharacters resultCharacters = await toolAdapter.GetCharacters(toolMessageArgs.toolId);
				LabelingParams labelingParams = new LabelingParams
				{
					resultId = resultCharacters.Id,
					characters = new List<CharacterParams>()
				};
				foreach (Character character in resultCharacters.Characters)
				{
					CharacterParams item = new CharacterParams
					{
						centerX = character.CenterX,
						centerY = character.CenterY,
						confidence = character.Confidence,
						text = character.Text.ToString()
					};
					labelingParams.characters.Add(item);
				}
				response = JsonConvert.SerializeObject(labelingParams);
				break;
			}
			case "get fielding result":
			{
				FieldingResult fieldingResult = await toolAdapter.GetFieldingResult(toolMessageArgs.toolId);
				if (fieldingResult == null)
				{
					response = "undefined";
					break;
				}
				FieldingResultParams value = new FieldingResultParams
				{
					match = fieldingResult.Match,
					patternName = fieldingResult.PatternName,
					text = fieldingResult.Text
				};
				response = JsonConvert.SerializeObject(value);
				break;
			}
			case "get character size":
			{
				CharacterSize characterSize = await toolAdapter.GetCharacterSize(toolMessageArgs.toolId);
				CharacterSizeArgs value2 = new CharacterSizeArgs
				{
					size = new CharacterSizeParams
					{
						width = characterSize.Width,
						height = characterSize.Height
					}
				};
				response = JsonConvert.SerializeObject(value2);
				break;
			}
			case "set character size":
			{
				CharacterSizeArgs characterSizeArgs = (toolMessageArgs.args as JObject)?.ToObject<CharacterSizeArgs>();
				CharacterSize newCharacterSize = new CharacterSize
				{
					Width = characterSizeArgs.size.width,
					Height = characterSizeArgs.size.height
				};
				await toolAdapter.SetCharacterSize(toolMessageArgs.toolId, newCharacterSize);
				break;
			}
			case "accept":
			{
				RevisedLabelingParams revisedLabelingParams = (toolMessageArgs.args as JObject)?.ToObject<RevisedLabelingParams>();
				List<RevisedCharacter> revisedCharacters = ((revisedLabelingParams?.characters != null) ? revisedLabelingParams.characters.Select((RevisedCharacterParams x) => new RevisedCharacter
				{
					CenterX = x.centerX,
					CenterY = x.centerY,
					Text = (x.text?[0] ?? '?')
				}).ToList() : new List<RevisedCharacter>());
				string resultId = revisedLabelingParams.resultId;
				await toolAdapter.AcceptLabeling(toolMessageArgs.toolId, resultId, revisedCharacters);
				break;
			}
			case "get samples":
			{
				ICollection<SampleParams> value4 = SampleParams.FromSamples(await toolAdapter.GetSamples(toolMessageArgs.toolId));
				response = JsonConvert.SerializeObject(value4);
				break;
			}
			case "change sample":
			{
				ChangeSampleParams changeSampleParams = (toolMessageArgs.args as JObject)?.ToObject<ChangeSampleParams>();
				List<RevisedCharacter> revisedCharacters2 = ((changeSampleParams?.characters != null) ? changeSampleParams.characters.Select((CharacterParams x) => new RevisedCharacter
				{
					CenterX = x.centerX,
					CenterY = x.centerY,
					Text = (x.text?[0] ?? '?')
				}).ToList() : new List<RevisedCharacter>());
				await toolAdapter.ChangeSample(toolMessageArgs.toolId, changeSampleParams.sampleId, revisedCharacters2);
				break;
			}
			case "set fielding":
			{
				FieldingSettingsParams fieldingSettingsParams = (toolMessageArgs.args as JObject)?.ToObject<FieldingSettingsParams>();
				await toolAdapter.SetFielding(toolMessageArgs.toolId, new FieldingSettings
				{
					AcceptedCharacters = fieldingSettingsParams.acceptedCharacters,
					FieldingType = fieldingSettingsParams.fieldingType,
					NumberOfLines = fieldingSettingsParams.numberOfLines,
					Patterns = ((fieldingSettingsParams.patterns != null) ? fieldingSettingsParams.patterns.Select((FieldingPatternParams x) => new FieldingPattern
					{
						Name = x.name,
						Pattern = x.pattern
					}).ToArray() : null),
					FlexibleFieldingValue = fieldingSettingsParams.flexibleFieldingValue,
					FlexibleFieldingReference = fieldingSettingsParams.flexibleFieldingReference
				});
				break;
			}
			case "get fielding":
			{
				FieldingSettings fieldingSettings = await toolAdapter.GetFielding(toolMessageArgs.toolId);
				response = JsonConvert.SerializeObject(new FieldingSettingsParams
				{
					acceptedCharacters = fieldingSettings.AcceptedCharacters,
					fieldingType = fieldingSettings.FieldingType,
					numberOfLines = fieldingSettings.NumberOfLines,
					patterns = ((fieldingSettings.Patterns != null) ? fieldingSettings.Patterns.Select((FieldingPattern x) => new FieldingPatternParams
					{
						name = x.Name,
						pattern = x.Pattern
					}).ToArray() : null),
					flexibleFieldingValue = fieldingSettings.FlexibleFieldingValue,
					flexibleFieldingReference = fieldingSettings.FlexibleFieldingReference
				});
				break;
			}
			default:
				response = "{ error: 'unknown action' }";
				ComponentManager.Instance.LogService.LogError("ToolService: unknown action " + toolMessageArgs.action);
				break;
			}
			await registrations[wrapperId].Methods.SendMessageProcessedAsync(message.MessageId, response);
		}
		catch (Exception exception)
		{
			ComponentManager.Instance.LogService.LogException(exception);
		}
	}
}
