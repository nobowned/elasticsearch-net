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
	internal sealed class WildcardQueryConverter : FieldNameQueryConverterBase<WildcardQuery>
	{
		internal override WildcardQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			var variant = new WildcardQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "case_insensitive")
					{
						variant.CaseInsensitive = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "rewrite")
					{
						variant.Rewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "value")
					{
						variant.Value = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "wildcard")
					{
						variant.Wildcard = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
						continue;
					}

					if (property == "_name")
					{
						variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}
				}
			}

			return variant;
		}

		internal override void WriteInternal(Utf8JsonWriter writer, WildcardQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.CaseInsensitive.HasValue)
			{
				writer.WritePropertyName("case_insensitive");
				writer.WriteBooleanValue(value.CaseInsensitive.Value);
			}

			if (value.Rewrite is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, value.Rewrite, options);
			}

			if (!string.IsNullOrEmpty(value.Value))
			{
				writer.WritePropertyName("value");
				writer.WriteStringValue(value.Value);
			}

			if (!string.IsNullOrEmpty(value.Wildcard))
			{
				writer.WritePropertyName("wildcard");
				writer.WriteStringValue(value.Wildcard);
			}

			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(WildcardQueryConverter))]
	public partial class WildcardQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "wildcard";
		[JsonInclude]
		[JsonPropertyName("case_insensitive")]
		public bool? CaseInsensitive { get; set; }

		[JsonInclude]
		[JsonPropertyName("rewrite")]
		public string? Rewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public string? Value { get; set; }

		[JsonInclude]
		[JsonPropertyName("wildcard")]
		public string? Wildcard { get; set; }
	}

	public sealed partial class WildcardQueryDescriptor<T> : FieldNameQueryDescriptorBase<WildcardQueryDescriptor<T>, T>
	{
		public WildcardQueryDescriptor()
		{
		}

		internal WildcardQueryDescriptor(Action<WildcardQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal bool? CaseInsensitiveValue { get; private set; }

		internal string? RewriteValue { get; private set; }

		internal string? ValueValue { get; private set; }

		internal string? WildcardValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		public WildcardQueryDescriptor<T> CaseInsensitive(bool? caseInsensitive = true) => Assign(caseInsensitive, (a, v) => a.CaseInsensitiveValue = v);
		public WildcardQueryDescriptor<T> Rewrite(string? rewrite) => Assign(rewrite, (a, v) => a.RewriteValue = v);
		public WildcardQueryDescriptor<T> Value(string? value) => Assign(value, (a, v) => a.ValueValue = v);
		public WildcardQueryDescriptor<T> Wildcard(string? wildcard) => Assign(wildcard, (a, v) => a.WildcardValue = v);
		public WildcardQueryDescriptor<T> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public WildcardQueryDescriptor<T> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (CaseInsensitiveValue.HasValue)
			{
				writer.WritePropertyName("case_insensitive");
				writer.WriteBooleanValue(CaseInsensitiveValue.Value);
			}

			if (RewriteValue is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, RewriteValue, options);
			}

			if (!string.IsNullOrEmpty(ValueValue))
			{
				writer.WritePropertyName("value");
				writer.WriteStringValue(ValueValue);
			}

			if (!string.IsNullOrEmpty(WildcardValue))
			{
				writer.WritePropertyName("wildcard");
				writer.WriteStringValue(WildcardValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}