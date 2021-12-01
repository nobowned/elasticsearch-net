// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class ClassificationInferenceOptions
	{
		[JsonInclude]
		[JsonPropertyName("num_top_classes")]
		public int? NumTopClasses { get; set; }

		[JsonInclude]
		[JsonPropertyName("num_top_feature_importance_values")]
		public int? NumTopFeatureImportanceValues { get; set; }

		[JsonInclude]
		[JsonPropertyName("prediction_field_type")]
		public string? PredictionFieldType { get; set; }

		[JsonInclude]
		[JsonPropertyName("results_field")]
		public string? ResultsField { get; set; }

		[JsonInclude]
		[JsonPropertyName("top_classes_results_field")]
		public string? TopClassesResultsField { get; set; }
	}

	public sealed partial class ClassificationInferenceOptionsDescriptor : DescriptorBase<ClassificationInferenceOptionsDescriptor>
	{
		public ClassificationInferenceOptionsDescriptor()
		{
		}

		internal ClassificationInferenceOptionsDescriptor(Action<ClassificationInferenceOptionsDescriptor> configure) => configure.Invoke(this);
		internal int? NumTopClassesValue { get; private set; }

		internal int? NumTopFeatureImportanceValuesValue { get; private set; }

		internal string? PredictionFieldTypeValue { get; private set; }

		internal string? ResultsFieldValue { get; private set; }

		internal string? TopClassesResultsFieldValue { get; private set; }

		public ClassificationInferenceOptionsDescriptor NumTopClasses(int? numTopClasses) => Assign(numTopClasses, (a, v) => a.NumTopClassesValue = v);
		public ClassificationInferenceOptionsDescriptor NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues) => Assign(numTopFeatureImportanceValues, (a, v) => a.NumTopFeatureImportanceValuesValue = v);
		public ClassificationInferenceOptionsDescriptor PredictionFieldType(string? predictionFieldType) => Assign(predictionFieldType, (a, v) => a.PredictionFieldTypeValue = v);
		public ClassificationInferenceOptionsDescriptor ResultsField(string? resultsField) => Assign(resultsField, (a, v) => a.ResultsFieldValue = v);
		public ClassificationInferenceOptionsDescriptor TopClassesResultsField(string? topClassesResultsField) => Assign(topClassesResultsField, (a, v) => a.TopClassesResultsFieldValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumTopClassesValue.HasValue)
			{
				writer.WritePropertyName("num_top_classes");
				writer.WriteNumberValue(NumTopClassesValue.Value);
			}

			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (!string.IsNullOrEmpty(PredictionFieldTypeValue))
			{
				writer.WritePropertyName("prediction_field_type");
				writer.WriteStringValue(PredictionFieldTypeValue);
			}

			if (!string.IsNullOrEmpty(ResultsFieldValue))
			{
				writer.WritePropertyName("results_field");
				writer.WriteStringValue(ResultsFieldValue);
			}

			if (!string.IsNullOrEmpty(TopClassesResultsFieldValue))
			{
				writer.WritePropertyName("top_classes_results_field");
				writer.WriteStringValue(TopClassesResultsFieldValue);
			}

			writer.WriteEndObject();
		}
	}
}