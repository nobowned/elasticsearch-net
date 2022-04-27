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
	internal sealed class MatchQueryConverter : FieldNameQueryConverterBase<MatchQuery>
	{
		internal override MatchQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new MatchQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "analyzer")
					{
						variant.Analyzer = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "auto_generate_synonyms_phrase_query")
					{
						variant.AutoGenerateSynonymsPhraseQuery = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "fuzziness")
					{
						variant.Fuzziness = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fuzziness?>(ref reader, options);
						continue;
					}

					if (property == "fuzzy_rewrite")
					{
						variant.FuzzyRewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "fuzzy_transpositions")
					{
						variant.FuzzyTranspositions = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "lenient")
					{
						variant.Lenient = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "max_expansions")
					{
						variant.MaxExpansions = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "minimum_should_match")
					{
						variant.MinimumShouldMatch = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.MinimumShouldMatch?>(ref reader, options);
						continue;
					}

					if (property == "operator")
					{
						variant.Operator = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>(ref reader, options);
						continue;
					}

					if (property == "prefix_length")
					{
						variant.PrefixLength = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "query")
					{
						variant.Query = JsonSerializer.Deserialize<string>(ref reader, options);
						continue;
					}

					if (property == "zero_terms_query")
					{
						variant.ZeroTermsQuery = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery?>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}
				}
			}

			reader.Read();
			return variant;
		}

		internal override void WriteInternal(Utf8JsonWriter writer, MatchQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Analyzer))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(value.Analyzer);
			}

			if (value.AutoGenerateSynonymsPhraseQuery.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(value.AutoGenerateSynonymsPhraseQuery.Value);
			}

			if (value.Fuzziness is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, value.Fuzziness, options);
			}

			if (value.FuzzyRewrite is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, value.FuzzyRewrite, options);
			}

			if (value.FuzzyTranspositions.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(value.FuzzyTranspositions.Value);
			}

			if (value.Lenient.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(value.Lenient.Value);
			}

			if (value.MaxExpansions.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(value.MaxExpansions.Value);
			}

			if (value.MinimumShouldMatch is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, value.MinimumShouldMatch, options);
			}

			if (value.Operator is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, value.Operator, options);
			}

			if (value.PrefixLength.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(value.PrefixLength.Value);
			}

			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, value.Query, options);
			if (value.ZeroTermsQuery is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, value.ZeroTermsQuery, options);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(MatchQueryConverter))]
	public partial class MatchQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "match";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public sealed partial class MatchQueryDescriptor<TDocument> : SerializableDescriptorBase<MatchQueryDescriptor<TDocument>>
	{
		internal MatchQueryDescriptor(Action<MatchQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MatchQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string QueryValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MatchQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op)
		{
			OperatorValue = op;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MatchQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}

	public sealed partial class MatchQueryDescriptor : SerializableDescriptorBase<MatchQueryDescriptor>
	{
		internal MatchQueryDescriptor(Action<MatchQueryDescriptor> configure) => configure.Invoke(this);
		public MatchQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private string? AnalyzerValue { get; set; }

		private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; set; }

		private string? FuzzyRewriteValue { get; set; }

		private bool? FuzzyTranspositionsValue { get; set; }

		private bool? LenientValue { get; set; }

		private int? MaxExpansionsValue { get; set; }

		private Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; set; }

		private int? PrefixLengthValue { get; set; }

		private string QueryValue { get; set; }

		private Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

		public MatchQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public MatchQueryDescriptor Analyzer(string? analyzer)
		{
			AnalyzerValue = analyzer;
			return Self;
		}

		public MatchQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
		{
			AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
			return Self;
		}

		public MatchQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public MatchQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public MatchQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness)
		{
			FuzzinessValue = fuzziness;
			return Self;
		}

		public MatchQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
		{
			FuzzyRewriteValue = fuzzyRewrite;
			return Self;
		}

		public MatchQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
		{
			FuzzyTranspositionsValue = fuzzyTranspositions;
			return Self;
		}

		public MatchQueryDescriptor Lenient(bool? lenient = true)
		{
			LenientValue = lenient;
			return Self;
		}

		public MatchQueryDescriptor MaxExpansions(int? maxExpansions)
		{
			MaxExpansionsValue = maxExpansions;
			return Self;
		}

		public MatchQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch)
		{
			MinimumShouldMatchValue = minimumShouldMatch;
			return Self;
		}

		public MatchQueryDescriptor Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op)
		{
			OperatorValue = op;
			return Self;
		}

		public MatchQueryDescriptor PrefixLength(int? prefixLength)
		{
			PrefixLengthValue = prefixLength;
			return Self;
		}

		public MatchQueryDescriptor Query(string query)
		{
			QueryValue = query;
			return Self;
		}

		public MatchQueryDescriptor ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
		{
			ZeroTermsQueryValue = zeroTermsQuery;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
			}

			writer.WriteEndObject();
			writer.WriteEndObject();
		}
	}
}