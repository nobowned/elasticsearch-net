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
	public partial class GeoLineAggregation : Aggregations.AggregationBase, IAggregationContainerVariant
	{
		public GeoLineAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "geo_line";
		[JsonInclude]
		[JsonPropertyName("point")]
		public Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint Point { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_sort")]
		public bool? IncludeSort { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort_order")]
		public Elastic.Clients.Elasticsearch.SortOrder? SortOrder { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }
	}

	public sealed partial class GeoLineAggregationDescriptor<T> : DescriptorBase<GeoLineAggregationDescriptor<T>>
	{
		public GeoLineAggregationDescriptor()
		{
		}

		internal GeoLineAggregationDescriptor(Action<GeoLineAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint PointValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort SortValue { get; private set; }

		internal bool? IncludeSortValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SortOrder? SortOrderValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal GeoLinePointDescriptor<T> PointDescriptor { get; private set; }

		internal GeoLineSortDescriptor<T> SortDescriptor { get; private set; }

		internal Action<GeoLinePointDescriptor<T>> PointDescriptorAction { get; private set; }

		internal Action<GeoLineSortDescriptor<T>> SortDescriptorAction { get; private set; }

		public GeoLineAggregationDescriptor<T> Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePoint point)
		{
			PointDescriptor = null;
			PointDescriptorAction = null;
			return Assign(point, (a, v) => a.PointValue = v);
		}

		public GeoLineAggregationDescriptor<T> Point(Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<T> descriptor)
		{
			PointValue = null;
			PointDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PointDescriptor = v);
		}

		public GeoLineAggregationDescriptor<T> Point(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLinePointDescriptor<T>> configure)
		{
			PointValue = null;
			PointDescriptorAction = null;
			return Assign(configure, (a, v) => a.PointDescriptorAction = v);
		}

		public GeoLineAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSort sort)
		{
			SortDescriptor = null;
			SortDescriptorAction = null;
			return Assign(sort, (a, v) => a.SortValue = v);
		}

		public GeoLineAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<T> descriptor)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SortDescriptor = v);
		}

		public GeoLineAggregationDescriptor<T> Sort(Action<Elastic.Clients.Elasticsearch.Aggregations.GeoLineSortDescriptor<T>> configure)
		{
			SortValue = null;
			SortDescriptorAction = null;
			return Assign(configure, (a, v) => a.SortDescriptorAction = v);
		}

		public GeoLineAggregationDescriptor<T> IncludeSort(bool? includeSort = true) => Assign(includeSort, (a, v) => a.IncludeSortValue = v);
		public GeoLineAggregationDescriptor<T> SortOrder(Elastic.Clients.Elasticsearch.SortOrder? sortOrder) => Assign(sortOrder, (a, v) => a.SortOrderValue = v);
		public GeoLineAggregationDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (PointDescriptor is not null)
			{
				writer.WritePropertyName("point");
				JsonSerializer.Serialize(writer, PointDescriptor, options);
			}
			else if (PointDescriptorAction is not null)
			{
				writer.WritePropertyName("point");
				JsonSerializer.Serialize(writer, new GeoLinePointDescriptor<T>(PointDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("point");
				JsonSerializer.Serialize(writer, PointValue, options);
			}

			if (SortDescriptor is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortDescriptor, options);
			}
			else if (SortDescriptorAction is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, new GeoLineSortDescriptor<T>(SortDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortValue, options);
			}

			if (IncludeSortValue.HasValue)
			{
				writer.WritePropertyName("include_sort");
				writer.WriteBooleanValue(IncludeSortValue.Value);
			}

			if (SortOrderValue is not null)
			{
				writer.WritePropertyName("sort_order");
				JsonSerializer.Serialize(writer, SortOrderValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}