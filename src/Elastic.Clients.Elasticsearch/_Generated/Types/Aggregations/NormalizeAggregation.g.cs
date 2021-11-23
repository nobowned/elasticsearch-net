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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class NormalizeAggregation : Aggregations.PipelineAggregationBase, IAggregationContainerVariant
	{
		public NormalizeAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "normalize";
		[JsonInclude]
		[JsonPropertyName("method")]
		public Elastic.Clients.Elasticsearch.Aggregations.NormalizeMethod? Method { get; set; }
	}

	public sealed partial class NormalizeAggregationDescriptor : DescriptorBase<NormalizeAggregationDescriptor>
	{
		public NormalizeAggregationDescriptor()
		{
		}

		internal NormalizeAggregationDescriptor(Action<NormalizeAggregationDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.NormalizeMethod? MethodValue { get; private set; }

		public NormalizeAggregationDescriptor Method(Elastic.Clients.Elasticsearch.Aggregations.NormalizeMethod? method) => Assign(method, (a, v) => a.MethodValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (MethodValue is not null)
			{
				writer.WritePropertyName("method");
				JsonSerializer.Serialize(writer, MethodValue, options);
			}

			writer.WriteEndObject();
		}
	}
}