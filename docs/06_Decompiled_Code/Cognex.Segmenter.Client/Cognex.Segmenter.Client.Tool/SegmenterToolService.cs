using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.Segmenter.Client.Tool.Interfaces;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cognex.Segmenter.Client.Tool;

public class SegmenterToolService : IToolService
{
	internal class LabelingParams
	{
		public string sampleId { get; set; }

		public MaskBitmap labelImage { get; set; }
	}

	internal class MaskBitmap : IMaskBitmap
	{
		public byte[] byteArray { get; set; }

		public int row { get; set; }

		public int col { get; set; }
	}

	internal class JsonFriendlyMaskBitmap
	{
		public string byteArray { get; set; }

		public int row { get; set; }

		public int col { get; set; }

		public JsonFriendlyMaskBitmap()
		{
		}

		public JsonFriendlyMaskBitmap(string byteArray, int row, int col)
		{
			this.byteArray = byteArray;
			this.row = row;
			this.col = col;
		}
	}

	internal class UpdateClasses
	{
		public SegmenterClass[] editedClasses { get; set; }

		public int[] deletedClassIDs { get; set; }
	}

	internal class SegmenterClass : ISegmenterClass
	{
		public int classID { get; set; }

		public string className { get; set; }

		public string classBackColor { get; set; }
	}

	internal class ToolMessageArgs
	{
		public string toolId;

		public string action;

		public object args;
	}

	internal class DeleteSampleParams
	{
		public string[] sampleIds { get; set; }
	}

	private readonly Dictionary<string, CommunicationRegistration> registrations = new Dictionary<string, CommunicationRegistration>();

	private ISegmenterToolAdapter toolAdapter;

	internal ISegmenterToolAdapter ToolAdapter
	{
		get
		{
			return toolAdapter;
		}
		set
		{
			if (toolAdapter != null)
			{
				toolAdapter.NewResult -= OnNewResult;
				toolAdapter.ClassesUpdated -= OnClassesUpdated;
			}
			toolAdapter = value;
			if (toolAdapter != null)
			{
				toolAdapter.NewResult += OnNewResult;
				toolAdapter.ClassesUpdated += OnClassesUpdated;
			}
		}
	}

	private void OnNewResult(object sender, NewResultArgs args)
	{
		foreach (CommunicationRegistration value in registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerNewResults", args.toolId).Forget();
		}
	}

	private void OnClassesUpdated(object sender, ClassesUpdatedArgs args)
	{
		foreach (CommunicationRegistration value in registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerClassesUpdated", args.toolId).Forget();
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
		if (registrations.ContainsKey(component.WrapperId.ToString()))
		{
			registrations[component.WrapperId.ToString()].Methods.Dispose();
			registrations.Remove(component.WrapperId.ToString());
		}
	}

	private async Task HandleToolMessageAsync(WebEditControlMessage message, string wrapperId)
	{
		if (message.Message != "ToolMessage")
		{
			return;
		}
		ToolMessageArgs toolMessageArgs = JsonConvert.DeserializeObject<ToolMessageArgs>(message.Args?.ToString() ?? "");
		string response = "";
		if (toolMessageArgs == null)
		{
			return;
		}
		switch (toolMessageArgs.action)
		{
		case "get stats":
			try
			{
				response = JsonConvert.SerializeObject(await ToolAdapter.GetStats(toolMessageArgs.toolId));
			}
			catch (Exception ex10)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex10.Message
				});
			}
			break;
		case "get sample":
			try
			{
				ISegmenterSample segmenterSample = await ToolAdapter.GetSample(toolMessageArgs.toolId, toolMessageArgs.args as string);
				object labelImage2 = convertBitmapToJsonFriendlyFormat(segmenterSample.labelImage);
				var value2 = new
				{
					id = segmenterSample.id,
					image = segmenterSample.image,
					labelImage = labelImage2
				};
				response = JsonConvert.SerializeObject(value2);
			}
			catch (Exception ex9)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex9.Message
				});
			}
			break;
		case "get samples":
			try
			{
				ICollection<ISegmenterSample> collection = await ToolAdapter.GetSamples(toolMessageArgs.toolId, int.Parse(toolMessageArgs.args.ToString()));
				List<object> list = new List<object>();
				if (collection != null)
				{
					foreach (ISegmenterSample item2 in collection)
					{
						object labelImage = convertBitmapToJsonFriendlyFormat(item2.labelImage);
						var item = new { item2.id, item2.image, labelImage };
						list.Add(item);
					}
				}
				response = JsonConvert.SerializeObject(list);
			}
			catch (Exception ex8)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex8.Message
				});
			}
			break;
		case "get current result":
			try
			{
				ISegmenterResult segmenterResult = await ToolAdapter.GetCurrentResult(toolMessageArgs.toolId);
				object overlayImage = convertBitmapToJsonFriendlyFormat(segmenterResult.overlayImage);
				var value = new { segmenterResult.image, overlayImage, segmenterResult.isTrained };
				response = JsonConvert.SerializeObject(value);
			}
			catch (Exception ex7)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex7.Message
				});
			}
			break;
		case "label image":
			try
			{
				LabelingParams labelingParams = (toolMessageArgs.args as JObject)?.ToObject<LabelingParams>();
				await toolAdapter.LabelImage(toolMessageArgs.toolId, labelingParams.sampleId, labelingParams.labelImage);
			}
			catch (Exception ex6)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex6.Message
				});
			}
			break;
		case "skip labeling":
			try
			{
				await toolAdapter.Skip(toolMessageArgs.toolId);
			}
			catch (Exception ex5)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex5.Message
				});
			}
			break;
		case "delete samples":
			try
			{
				DeleteSampleParams deleteSampleParams = (toolMessageArgs.args as JObject)?.ToObject<DeleteSampleParams>();
				await ToolAdapter.DeleteSamples(toolMessageArgs.toolId, deleteSampleParams.sampleIds);
			}
			catch (Exception ex4)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex4.Message
				});
			}
			break;
		case "update classes":
			try
			{
				UpdateClasses updateClasses = (toolMessageArgs.args as JObject)?.ToObject<UpdateClasses>();
				await ToolAdapter.UpdateClasses(toolMessageArgs.toolId, updateClasses.editedClasses, updateClasses.deletedClassIDs);
			}
			catch (Exception ex3)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex3.Message
				});
			}
			break;
		case "add class":
			try
			{
				SegmenterClass classData = (toolMessageArgs.args as JObject)?.ToObject<SegmenterClass>();
				response = JsonConvert.SerializeObject(await ToolAdapter.AddClass(toolMessageArgs.toolId, classData));
			}
			catch (Exception ex2)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex2.Message
				});
			}
			break;
		case "get classes":
			try
			{
				response = JsonConvert.SerializeObject(await ToolAdapter.GetClasses(toolMessageArgs.toolId));
			}
			catch (Exception ex)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex.Message
				});
			}
			break;
		default:
			response = "{ errorMessage: 'unknown action' }";
			break;
		}
		if (!registrations.ContainsKey(wrapperId))
		{
			return;
		}
		try
		{
			await registrations[wrapperId].Methods.SendMessageProcessedAsync(message.MessageId, response);
		}
		catch (Exception)
		{
		}
	}

	private object convertBitmapToJsonFriendlyFormat(IMaskBitmap bitMap)
	{
		if (bitMap != null)
		{
			return new JsonFriendlyMaskBitmap(Convert.ToBase64String(bitMap.byteArray), bitMap.row, bitMap.col);
		}
		return null;
	}
}
