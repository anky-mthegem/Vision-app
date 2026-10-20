using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Cognex.AnomalyDetector.Client.Tool.Interfaces;
using Cognex.WebCommunicationBridge.Wpf;
using Cognex.WebToolEditControl.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Cognex.AnomalyDetector.Client.Tool;

public class AnomalyDetectorToolService : IToolService
{
	internal class ToolMessageArgs
	{
		public string toolId;

		public string action;

		public object args;
	}

	internal class LabelingParams
	{
		public string sampleId { get; set; }

		public AnomalyDetectorLabels label { get; set; }
	}

	internal class SampleParams
	{
		public string sampleId { get; set; }

		public bool metadataOnly { get; set; }
	}

	internal class DeleteSampleParams
	{
		public string[] sampleIds { get; set; }
	}

	private readonly Dictionary<string, CommunicationRegistration> _registrations = new Dictionary<string, CommunicationRegistration>();

	private IAnomalyDetectorAdapter _anomalyDetectorAdapter;

	internal IAnomalyDetectorAdapter AnomalyDetectorAdapter
	{
		get
		{
			return _anomalyDetectorAdapter;
		}
		set
		{
			if (_anomalyDetectorAdapter != null)
			{
				_anomalyDetectorAdapter.NewResult -= OnNewResult;
				_anomalyDetectorAdapter.ThresholdUpdated -= OnThresholdUpdated;
				_anomalyDetectorAdapter.FeatureSizeUpdated -= OnFeatureSizeUpdated;
			}
			_anomalyDetectorAdapter = value;
			if (_anomalyDetectorAdapter != null)
			{
				_anomalyDetectorAdapter.NewResult += OnNewResult;
				_anomalyDetectorAdapter.ThresholdUpdated += OnThresholdUpdated;
				_anomalyDetectorAdapter.FeatureSizeUpdated += OnFeatureSizeUpdated;
			}
		}
	}

	private void OnNewResult(object sender, NewResultArgs args)
	{
		foreach (CommunicationRegistration value in _registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerNewResults", args.ToolId).Forget();
		}
	}

	private void OnThresholdUpdated(object sender, ThresholdUpdatedArgs args)
	{
		foreach (CommunicationRegistration value in _registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerThresholdUpdated", args.ToolId).Forget();
		}
	}

	private void OnFeatureSizeUpdated(object sender, FeatureSizeArgs args)
	{
		foreach (CommunicationRegistration value in _registrations.Values)
		{
			value.Methods.CallWebActionAsync("triggerFeatureSizeUpdated", args.ToolId).Forget();
		}
	}

	public void Register(IComponentWrapper wrapper)
	{
		if (_registrations.ContainsKey(wrapper.WrapperId.ToString()))
		{
			throw new Exception("ToolService: Component with the provided key already registered");
		}
		WebMethodBridge<WebEditControlMessage> methods = new WebMethodBridge<WebEditControlMessage>(wrapper.Component.WebView, "ToolCommunication", (WebEditControlMessage msg) => HandleToolMessageAsync(msg, wrapper.WrapperId.ToString()));
		CommunicationRegistration value = new CommunicationRegistration(wrapper, methods);
		_registrations.Add(wrapper.WrapperId.ToString(), value);
	}

	public void Unregister(IComponentWrapper component)
	{
		if (_registrations.ContainsKey(component.WrapperId.ToString()))
		{
			_registrations[component.WrapperId.ToString()].Methods.Dispose();
			_registrations.Remove(component.WrapperId.ToString());
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
		case "get result":
			try
			{
				IAnomalyDetectorResult anomalyDetectorResult = await _anomalyDetectorAdapter.GetResult(toolMessageArgs.toolId);
				var value2 = new
				{
					image = anomalyDetectorResult.Image,
					heatmap = anomalyDetectorResult.Heatmap,
					score = anomalyDetectorResult.Score,
					sampleId = anomalyDetectorResult.SampleId,
					isPredictionGood = anomalyDetectorResult.IsPredictionGood
				};
				response = JsonConvert.SerializeObject(value2);
			}
			catch (Exception ex13)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex13.Message
				});
			}
			break;
		case "skip":
			try
			{
				await _anomalyDetectorAdapter.Skip(toolMessageArgs.toolId);
			}
			catch (Exception ex12)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex12.Message
				});
			}
			break;
		case "label image":
			try
			{
				LabelingParams labelingParams = (toolMessageArgs.args as JObject)?.ToObject<LabelingParams>();
				await _anomalyDetectorAdapter.LabelImage(toolMessageArgs.toolId, labelingParams.sampleId, labelingParams.label);
			}
			catch (Exception ex11)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex11.Message
				});
			}
			break;
		case "get stats":
			try
			{
				response = JsonConvert.SerializeObject(await AnomalyDetectorAdapter.GetStats(toolMessageArgs.toolId));
			}
			catch (Exception ex10)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex10.Message
				});
			}
			break;
		case "get scaled threshold":
			try
			{
				response = JsonConvert.SerializeObject(await AnomalyDetectorAdapter.GetScaledThreshold(toolMessageArgs.toolId));
			}
			catch (Exception ex9)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex9.Message
				});
			}
			break;
		case "get auto threshold settings":
			try
			{
				response = JsonConvert.SerializeObject(await AnomalyDetectorAdapter.GetAutoThresholdSettings(toolMessageArgs.toolId));
			}
			catch (Exception ex8)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex8.Message
				});
			}
			break;
		case "set auto threshold settings":
			try
			{
				AutoThresholdSettings newSettings = (toolMessageArgs.args as JObject)?.ToObject<AutoThresholdSettings>();
				await AnomalyDetectorAdapter.SetAutoThresholdSettings(toolMessageArgs.toolId, newSettings);
			}
			catch (Exception ex7)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex7.Message
				});
			}
			break;
		case "get feature size settings":
			try
			{
				response = JsonConvert.SerializeObject(await AnomalyDetectorAdapter.GetFeatureSizeSettings(toolMessageArgs.toolId));
			}
			catch (Exception ex6)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex6.Message
				});
			}
			break;
		case "set feature size":
			try
			{
				await AnomalyDetectorAdapter.SetFeatureSize(toolMessageArgs.toolId, double.Parse(toolMessageArgs.args.ToString()));
			}
			catch (Exception ex5)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex5.Message
				});
			}
			break;
		case "optimize feature size":
			try
			{
				await AnomalyDetectorAdapter.OptimizeFeatureSize(toolMessageArgs.toolId);
			}
			catch (Exception ex4)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex4.Message
				});
			}
			break;
		case "get sample":
			try
			{
				SampleParams sampleParams = (toolMessageArgs.args as JObject)?.ToObject<SampleParams>();
				IAnomalyDetectorSample anomalyDetectorSample = await AnomalyDetectorAdapter.GetSample(toolMessageArgs.toolId, sampleParams.sampleId, sampleParams.metadataOnly);
				var value = new
				{
					id = anomalyDetectorSample.Id,
					image = anomalyDetectorSample.Image,
					label = anomalyDetectorSample.Label,
					date = anomalyDetectorSample.Date
				};
				response = JsonConvert.SerializeObject(value);
			}
			catch (Exception ex3)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex3.Message
				});
			}
			break;
		case "get samples":
			try
			{
				ICollection<IAnomalyDetectorSample> collection = await AnomalyDetectorAdapter.GetSamples(toolMessageArgs.toolId, int.Parse(toolMessageArgs.args.ToString()));
				List<object> list = new List<object>();
				if (collection != null)
				{
					foreach (IAnomalyDetectorSample item2 in collection)
					{
						var item = new
						{
							id = item2.Id,
							image = item2.Image,
							label = item2.Label,
							date = item2.Date
						};
						list.Add(item);
					}
				}
				response = JsonConvert.SerializeObject(list);
			}
			catch (Exception ex2)
			{
				response = JsonConvert.SerializeObject(new
				{
					errorMessage = ex2.Message
				});
			}
			break;
		case "delete samples":
			try
			{
				DeleteSampleParams deleteSampleParams = (toolMessageArgs.args as JObject)?.ToObject<DeleteSampleParams>();
				await AnomalyDetectorAdapter.DeleteSamples(toolMessageArgs.toolId, deleteSampleParams.sampleIds);
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
		if (!_registrations.ContainsKey(wrapperId))
		{
			return;
		}
		try
		{
			await _registrations[wrapperId].Methods.SendMessageProcessedAsync(message.MessageId, response);
		}
		catch (Exception)
		{
		}
	}
}
