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
	public partial class TopHitsAggregation : Aggregations.MetricAggregationBase, IAggregationContainerVariant
	{
		public TopHitsAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "top_hits";
		[JsonInclude]
		[JsonPropertyName("docvalue_fields")]
		public Elastic.Clients.Elasticsearch.Fields? DocvalueFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("explain")]
		public bool? Explain { get; set; }

		[JsonInclude]
		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Elastic.Clients.Elasticsearch.Highlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Sort? Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.SourceConfig? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("stored_fields")]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("track_scores")]
		public bool? TrackScores { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public bool? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("seq_no_primary_term")]
		public bool? SeqNoPrimaryTerm { get; set; }
	}

	public sealed partial class TopHitsAggregationDescriptor<T> : DescriptorBase<TopHitsAggregationDescriptor<T>>
	{
		public TopHitsAggregationDescriptor()
		{
		}

		internal TopHitsAggregationDescriptor(Action<TopHitsAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Fields? DocvalueFieldsValue { get; private set; }

		internal bool? ExplainValue { get; private set; }

		internal int? FromValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Highlight? HighlightValue { get; private set; }

		internal Dictionary<string, Elastic.Clients.Elasticsearch.ScriptField>? ScriptFieldsValue { get; private set; }

		internal int? SizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Sort? SortValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.SourceConfig? SourceValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; private set; }

		internal bool? TrackScoresValue { get; private set; }

		internal bool? VersionValue { get; private set; }

		internal bool? SeqNoPrimaryTermValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.Missing? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Script? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal string? NameValue { get; private set; }

		internal HighlightDescriptor<T> HighlightDescriptor { get; private set; }

		internal Action<HighlightDescriptor<T>> HighlightDescriptorAction { get; private set; }

		public TopHitsAggregationDescriptor<T> DocvalueFields(Elastic.Clients.Elasticsearch.Fields? docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFieldsValue = v);
		public TopHitsAggregationDescriptor<T> DocvalueFields<TValue>(Expression<Func<T, TValue>> docvalueFields) => Assign(docvalueFields, (a, v) => a.DocvalueFieldsValue = v);
		public TopHitsAggregationDescriptor<T> Explain(bool? explain = true) => Assign(explain, (a, v) => a.ExplainValue = v);
		public TopHitsAggregationDescriptor<T> From(int? from) => Assign(from, (a, v) => a.FromValue = v);
		public TopHitsAggregationDescriptor<T> Highlight(Elastic.Clients.Elasticsearch.Highlight? highlight)
		{
			HighlightDescriptor = null;
			HighlightDescriptorAction = null;
			return Assign(highlight, (a, v) => a.HighlightValue = v);
		}

		public TopHitsAggregationDescriptor<T> Highlight(Elastic.Clients.Elasticsearch.HighlightDescriptor<T> descriptor)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.HighlightDescriptor = v);
		}

		public TopHitsAggregationDescriptor<T> Highlight(Action<Elastic.Clients.Elasticsearch.HighlightDescriptor<T>> configure)
		{
			HighlightValue = null;
			HighlightDescriptorAction = null;
			return Assign(configure, (a, v) => a.HighlightDescriptorAction = v);
		}

		public TopHitsAggregationDescriptor<T> ScriptFields(Func<FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>, FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>> selector) => Assign(selector, (a, v) => a.ScriptFieldsValue = v?.Invoke(new FluentDictionary<string?, Elastic.Clients.Elasticsearch.ScriptField?>()));
		public TopHitsAggregationDescriptor<T> Size(int? size) => Assign(size, (a, v) => a.SizeValue = v);
		public TopHitsAggregationDescriptor<T> Sort(Elastic.Clients.Elasticsearch.Sort? sort) => Assign(sort, (a, v) => a.SortValue = v);
		public TopHitsAggregationDescriptor<T> Source(Elastic.Clients.Elasticsearch.SourceConfig? source) => Assign(source, (a, v) => a.SourceValue = v);
		public TopHitsAggregationDescriptor<T> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Assign(storedFields, (a, v) => a.StoredFieldsValue = v);
		public TopHitsAggregationDescriptor<T> StoredFields<TValue>(Expression<Func<T, TValue>> storedFields) => Assign(storedFields, (a, v) => a.StoredFieldsValue = v);
		public TopHitsAggregationDescriptor<T> TrackScores(bool? trackScores = true) => Assign(trackScores, (a, v) => a.TrackScoresValue = v);
		public TopHitsAggregationDescriptor<T> Version(bool? version = true) => Assign(version, (a, v) => a.VersionValue = v);
		public TopHitsAggregationDescriptor<T> SeqNoPrimaryTerm(bool? seqNoPrimaryTerm = true) => Assign(seqNoPrimaryTerm, (a, v) => a.SeqNoPrimaryTermValue = v);
		public TopHitsAggregationDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopHitsAggregationDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public TopHitsAggregationDescriptor<T> Missing(Elastic.Clients.Elasticsearch.Aggregations.Missing? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public TopHitsAggregationDescriptor<T> Script(Elastic.Clients.Elasticsearch.Script? script) => Assign(script, (a, v) => a.ScriptValue = v);
		public TopHitsAggregationDescriptor<T> Meta(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public TopHitsAggregationDescriptor<T> Name(string? name) => Assign(name, (a, v) => a.NameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (DocvalueFieldsValue is not null)
			{
				writer.WritePropertyName("docvalue_fields");
				JsonSerializer.Serialize(writer, DocvalueFieldsValue, options);
			}

			if (ExplainValue.HasValue)
			{
				writer.WritePropertyName("explain");
				writer.WriteBooleanValue(ExplainValue.Value);
			}

			if (FromValue.HasValue)
			{
				writer.WritePropertyName("from");
				writer.WriteNumberValue(FromValue.Value);
			}

			if (HighlightDescriptor is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightDescriptor, options);
			}
			else if (HighlightDescriptorAction is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, new HighlightDescriptor<T>(HighlightDescriptorAction), options);
			}
			else if (HighlightValue is not null)
			{
				writer.WritePropertyName("highlight");
				JsonSerializer.Serialize(writer, HighlightValue, options);
			}

			if (ScriptFieldsValue is not null)
			{
				writer.WritePropertyName("script_fields");
				JsonSerializer.Serialize(writer, ScriptFieldsValue, options);
			}

			if (SizeValue.HasValue)
			{
				writer.WritePropertyName("size");
				writer.WriteNumberValue(SizeValue.Value);
			}

			if (SortValue is not null)
			{
				writer.WritePropertyName("sort");
				JsonSerializer.Serialize(writer, SortValue, options);
			}

			if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (StoredFieldsValue is not null)
			{
				writer.WritePropertyName("stored_fields");
				JsonSerializer.Serialize(writer, StoredFieldsValue, options);
			}

			if (TrackScoresValue.HasValue)
			{
				writer.WritePropertyName("track_scores");
				writer.WriteBooleanValue(TrackScoresValue.Value);
			}

			if (VersionValue.HasValue)
			{
				writer.WritePropertyName("version");
				writer.WriteBooleanValue(VersionValue.Value);
			}

			if (SeqNoPrimaryTermValue.HasValue)
			{
				writer.WritePropertyName("seq_no_primary_term");
				writer.WriteBooleanValue(SeqNoPrimaryTermValue.Value);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}