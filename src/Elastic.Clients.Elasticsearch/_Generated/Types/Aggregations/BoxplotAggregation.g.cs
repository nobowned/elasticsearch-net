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
	public partial class BoxplotAggregation : Aggregations.MetricAggregationBase, IAggregationContainerVariant
	{
		public BoxplotAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "boxplot";
		[JsonInclude]
		[JsonPropertyName("compression")]
		public double? Compression { get; set; }
	}

	public sealed partial class BoxplotAggregationDescriptor : DescriptorBase<BoxplotAggregationDescriptor>
	{
		public BoxplotAggregationDescriptor()
		{
		}

		internal BoxplotAggregationDescriptor(Action<BoxplotAggregationDescriptor> configure) => configure.Invoke(this);
		internal double? CompressionValue { get; private set; }

		public BoxplotAggregationDescriptor Compression(double? compression) => Assign(compression, (a, v) => a.CompressionValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CompressionValue.HasValue)
			{
				writer.WritePropertyName("compression");
				writer.WriteNumberValue(CompressionValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}