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
	public partial class NestedAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant
	{
		public NestedAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "nested";
		[JsonInclude]
		[JsonPropertyName("path")]
		public string? Path { get; set; }
	}

	public sealed partial class NestedAggregationDescriptor<T> : DescriptorBase<NestedAggregationDescriptor<T>>
	{
		public NestedAggregationDescriptor()
		{
		}

		internal NestedAggregationDescriptor(Action<NestedAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal string? PathValue { get; private set; }

		public NestedAggregationDescriptor<T> Path(string? path) => Assign(path, (a, v) => a.PathValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (PathValue is not null)
			{
				writer.WritePropertyName("path");
				JsonSerializer.Serialize(writer, PathValue, options);
			}

			writer.WriteEndObject();
		}
	}
}