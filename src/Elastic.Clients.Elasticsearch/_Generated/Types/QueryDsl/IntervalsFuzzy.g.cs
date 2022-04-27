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
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class IntervalsFuzzy : IIntervalsContainerVariant, IIntervalsQueryVariant
	{
		[JsonIgnore]
		string IIntervalsContainerVariant.IntervalsContainerVariantName => "fuzzy";
		[JsonIgnore]
		string IIntervalsQueryVariant.IntervalsQueryVariantName => "fuzzy";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("term")]
		public string Term { get; set; }

		[JsonInclude]
		[JsonPropertyName("transpositions")]
		public bool? Transpositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("use_field")]
		public Elastic.Clients.Elasticsearch.Field? UseField { get; set; }
	}

	public sealed partial class IntervalsFuzzyDescriptor<TDocument> : SerializableDescriptorBase<IntervalsFuzzyDescriptor<TDocument>>
	{
		internal IntervalsFuzzyDescriptor(Action<IntervalsFuzzyDescriptor<TDocument>> configure) => configure.Invoke(this);
		public IntervalsFuzzyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string TermValue { get; set; }

		private bool? TranspositionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? UseFieldValue { get; set; }

		public IntervalsFuzzyDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> Term(string term)
		{
			TermValue = term;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> Transpositions(bool? transpositions = true)
		{
			TranspositionsValue = transpositions;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> UseField(Elastic.Clients.Elasticsearch.Field? useField)
		{
			UseFieldValue = useField;
			return Self;
		}

		public IntervalsFuzzyDescriptor<TDocument> UseField<TValue>(Expression<Func<TDocument, TValue>> useField)
		{
			UseFieldValue = useField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("term");
			writer.WriteStringValue(TermValue);
			if (TranspositionsValue.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(TranspositionsValue.Value);
			}

			if (UseFieldValue is not null)
			{
				writer.WritePropertyName("use_field");
				JsonSerializer.Serialize(writer, UseFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class IntervalsFuzzyDescriptor : SerializableDescriptorBase<IntervalsFuzzyDescriptor>
	{
		internal IntervalsFuzzyDescriptor(Action<IntervalsFuzzyDescriptor> configure) => configure.Invoke(this);
		public IntervalsFuzzyDescriptor() : base()
		{
		}

		private string? AnalyzerValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string TermValue { get; set; }

		private bool? TranspositionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? UseFieldValue { get; set; }

		public IntervalsFuzzyDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public IntervalsFuzzyDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public IntervalsFuzzyDescriptor PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public IntervalsFuzzyDescriptor Term(string term)
		{
			TermValue = term;
			return Self;
		}

		public IntervalsFuzzyDescriptor Transpositions(bool? transpositions = true)
		{
			TranspositionsValue = transpositions;
			return Self;
		}

		public IntervalsFuzzyDescriptor UseField(Elastic.Clients.Elasticsearch.Field? useField)
		{
			UseFieldValue = useField;
			return Self;
		}

		public IntervalsFuzzyDescriptor UseField<TDocument, TValue>(Expression<Func<TDocument, TValue>> useField)
		{
			UseFieldValue = useField;
			return Self;
		}

		public IntervalsFuzzyDescriptor UseField<TDocument>(Expression<Func<TDocument, object>> useField)
		{
			UseFieldValue = useField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("term");
			writer.WriteStringValue(TermValue);
			if (TranspositionsValue.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(TranspositionsValue.Value);
			}

			if (UseFieldValue is not null)
			{
				writer.WritePropertyName("use_field");
				JsonSerializer.Serialize(writer, UseFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}
}