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
	internal sealed class PercentilesAggregationConverter : JsonConverter<PercentilesAggregation>
	{
		public override PercentilesAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "percentiles")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new PercentilesAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("keyed"))
					{
						var value = JsonSerializer.Deserialize<bool?>(ref reader, options);
						if (value is not null)
						{
							agg.Keyed = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("percents"))
					{
						var value = JsonSerializer.Deserialize<IEnumerable<double>?>(ref reader, options);
						if (value is not null)
						{
							agg.Percents = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("hdr"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.HdrMethod?>(ref reader, options);
						if (value is not null)
						{
							agg.Hdr = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("tdigest"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.TDigest?>(ref reader, options);
						if (value is not null)
						{
							agg.TDigest = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, PercentilesAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("percentiles");
			writer.WriteStartObject();
			if (value.Keyed.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(value.Keyed.Value);
			}

			if (value.Percents is not null)
			{
				writer.WritePropertyName("percents");
				JsonSerializer.Serialize(writer, value.Percents, options);
			}

			if (value.Hdr is not null)
			{
				writer.WritePropertyName("hdr");
				JsonSerializer.Serialize(writer, value.Hdr, options);
			}

			if (value.TDigest is not null)
			{
				writer.WritePropertyName("tdigest");
				JsonSerializer.Serialize(writer, value.TDigest, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(PercentilesAggregationConverter))]
	public partial class PercentilesAggregation : Aggregations.FormatMetricAggregationBase
	{
		public PercentilesAggregation(string name, Field field) : base(name) => Field = field;
		public PercentilesAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("keyed")]
		public bool? Keyed { get; set; }

		[JsonInclude]
		[JsonPropertyName("percents")]
		public IEnumerable<double>? Percents { get; set; }

		[JsonInclude]
		[JsonPropertyName("hdr")]
		public Elastic.Clients.Elasticsearch.Aggregations.HdrMethod? Hdr { get; set; }

		[JsonInclude]
		[JsonPropertyName("tdigest")]
		public Elastic.Clients.Elasticsearch.Aggregations.TDigest? TDigest { get; set; }
	}

	public sealed partial class PercentilesAggregationDescriptor<TDocument> : DescriptorBase<PercentilesAggregationDescriptor<TDocument>>
	{
		public PercentilesAggregationDescriptor()
		{
		}

		internal PercentilesAggregationDescriptor(Action<PercentilesAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal bool? KeyedValue { get; private set; }

		internal IEnumerable<double>? PercentsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.HdrMethod? HdrValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.TDigest? TDigestValue { get; private set; }

		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal HdrMethodDescriptor HdrDescriptor { get; private set; }

		internal TDigestDescriptor TDigestDescriptor { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; private set; }

		internal Action<HdrMethodDescriptor> HdrDescriptorAction { get; private set; }

		internal Action<TDigestDescriptor> TDigestDescriptorAction { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; private set; }

		public PercentilesAggregationDescriptor<TDocument> Keyed(bool? keyed = true) => Assign(keyed, (a, v) => a.KeyedValue = v);
		public PercentilesAggregationDescriptor<TDocument> Percents(IEnumerable<double>? percents) => Assign(percents, (a, v) => a.PercentsValue = v);
		public PercentilesAggregationDescriptor<TDocument> Hdr(Elastic.Clients.Elasticsearch.Aggregations.HdrMethod? hdr)
		{
			HdrDescriptor = null;
			HdrDescriptorAction = null;
			return Assign(hdr, (a, v) => a.HdrValue = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Hdr(Aggregations.HdrMethodDescriptor descriptor)
		{
			HdrValue = null;
			HdrDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.HdrDescriptor = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Hdr(Action<Aggregations.HdrMethodDescriptor> configure)
		{
			HdrValue = null;
			HdrDescriptorAction = null;
			return Assign(configure, (a, v) => a.HdrDescriptorAction = v);
		}

		public PercentilesAggregationDescriptor<TDocument> TDigest(Elastic.Clients.Elasticsearch.Aggregations.TDigest? tDigest)
		{
			TDigestDescriptor = null;
			TDigestDescriptorAction = null;
			return Assign(tDigest, (a, v) => a.TDigestValue = v);
		}

		public PercentilesAggregationDescriptor<TDocument> TDigest(Aggregations.TDigestDescriptor descriptor)
		{
			TDigestValue = null;
			TDigestDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.TDigestDescriptor = v);
		}

		public PercentilesAggregationDescriptor<TDocument> TDigest(Action<Aggregations.TDigestDescriptor> configure)
		{
			TDigestValue = null;
			TDigestDescriptorAction = null;
			return Assign(configure, (a, v) => a.TDigestDescriptorAction = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public PercentilesAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public PercentilesAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public PercentilesAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			return Assign(script, (a, v) => a.ScriptValue = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptDescriptor = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptDescriptorAction = v);
		}

		public PercentilesAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("percentiles");
			writer.WriteStartObject();
			if (KeyedValue.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(KeyedValue.Value);
			}

			if (PercentsValue is not null)
			{
				writer.WritePropertyName("percents");
				JsonSerializer.Serialize(writer, PercentsValue, options);
			}

			if (HdrDescriptor is not null)
			{
				writer.WritePropertyName("hdr");
				JsonSerializer.Serialize(writer, HdrDescriptor, options);
			}
			else if (HdrDescriptorAction is not null)
			{
				writer.WritePropertyName("hdr");
				JsonSerializer.Serialize(writer, new Aggregations.HdrMethodDescriptor(HdrDescriptorAction), options);
			}
			else if (HdrValue is not null)
			{
				writer.WritePropertyName("hdr");
				JsonSerializer.Serialize(writer, HdrValue, options);
			}

			if (TDigestDescriptor is not null)
			{
				writer.WritePropertyName("tdigest");
				JsonSerializer.Serialize(writer, TDigestDescriptor, options);
			}
			else if (TDigestDescriptorAction is not null)
			{
				writer.WritePropertyName("tdigest");
				JsonSerializer.Serialize(writer, new Aggregations.TDigestDescriptor(TDigestDescriptorAction), options);
			}
			else if (TDigestValue is not null)
			{
				writer.WritePropertyName("tdigest");
				JsonSerializer.Serialize(writer, TDigestValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}