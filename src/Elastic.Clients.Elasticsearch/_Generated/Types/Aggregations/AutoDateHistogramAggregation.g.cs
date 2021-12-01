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
	public partial class AutoDateHistogramAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant
	{
		public AutoDateHistogramAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "auto_date_histogram";
		[JsonInclude]
		[JsonPropertyName("buckets")]
		public int? Buckets { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_interval")]
		public Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public string? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public string? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }
	}

	public sealed partial class AutoDateHistogramAggregationDescriptor<T> : DescriptorBase<AutoDateHistogramAggregationDescriptor<T>>
	{
		public AutoDateHistogramAggregationDescriptor()
		{
		}

		internal AutoDateHistogramAggregationDescriptor(Action<AutoDateHistogramAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal int? BucketsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? MinimumIntervalValue { get; private set; }

		internal string? MissingValue { get; private set; }

		internal string? OffsetValue { get; private set; }

		internal Dictionary<string, object>? ParamsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal string? TimeZoneValue { get; private set; }

		public AutoDateHistogramAggregationDescriptor<T> Buckets(int? buckets) => Assign(buckets, (a, v) => a.BucketsValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public AutoDateHistogramAggregationDescriptor<T> MinimumInterval(Elastic.Clients.Elasticsearch.Aggregations.MinimumInterval? minimumInterval) => Assign(minimumInterval, (a, v) => a.MinimumIntervalValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Missing(string? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Offset(string? offset) => Assign(offset, (a, v) => a.OffsetValue = v);
		public AutoDateHistogramAggregationDescriptor<T> Params(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.ParamsValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public AutoDateHistogramAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public AutoDateHistogramAggregationDescriptor<T> TimeZone(string? timeZone) => Assign(timeZone, (a, v) => a.TimeZoneValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (BucketsValue.HasValue)
			{
				writer.WritePropertyName("buckets");
				writer.WriteNumberValue(BucketsValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinimumIntervalValue is not null)
			{
				writer.WritePropertyName("minimum_interval");
				JsonSerializer.Serialize(writer, MinimumIntervalValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (!string.IsNullOrEmpty(OffsetValue))
			{
				writer.WritePropertyName("offset");
				writer.WriteStringValue(OffsetValue);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (!string.IsNullOrEmpty(TimeZoneValue))
			{
				writer.WritePropertyName("time_zone");
				writer.WriteStringValue(TimeZoneValue);
			}

			writer.WriteEndObject();
		}
	}
}