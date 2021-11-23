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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class JsonProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "json";
		[JsonInclude]
		[JsonPropertyName("add_to_root")]
		public bool AddToRoot { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public string TargetField { get; set; }
	}

	public sealed partial class JsonProcessorDescriptor<T> : DescriptorBase<JsonProcessorDescriptor<T>>
	{
		public JsonProcessorDescriptor()
		{
		}

		internal JsonProcessorDescriptor(Action<JsonProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal bool AddToRootValue { get; private set; }

		internal string FieldValue { get; private set; }

		internal string TargetFieldValue { get; private set; }

		public JsonProcessorDescriptor<T> AddToRoot(bool addToRoot = true) => Assign(addToRoot, (a, v) => a.AddToRootValue = v);
		public JsonProcessorDescriptor<T> Field(string field) => Assign(field, (a, v) => a.FieldValue = v);
		public JsonProcessorDescriptor<T> TargetField(string targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("add_to_root");
			writer.WriteBooleanValue(AddToRootValue);
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
			writer.WriteEndObject();
		}
	}
}