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
	public partial class RandomScoreFunction : QueryDsl.ScoreFunctionBase, IFunctionScoreContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IFunctionScoreContainerVariant.FunctionScoreContainerVariantName => "random_score";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("seed")]
		public Union<long?, string?>? Seed { get; set; }
	}

	public sealed partial class RandomScoreFunctionDescriptor<T> : DescriptorBase<RandomScoreFunctionDescriptor<T>>
	{
		public RandomScoreFunctionDescriptor()
		{
		}

		internal RandomScoreFunctionDescriptor(Action<RandomScoreFunctionDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Union<long?, string?>? SeedValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; private set; }

		internal double? WeightValue { get; private set; }

		internal QueryContainerDescriptor<T> FilterDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<T>> FilterDescriptorAction { get; private set; }

		public RandomScoreFunctionDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public RandomScoreFunctionDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public RandomScoreFunctionDescriptor<T> Seed(Union<long?, string?>? seed) => Assign(seed, (a, v) => a.SeedValue = v);
		public RandomScoreFunctionDescriptor<T> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public RandomScoreFunctionDescriptor<T> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor<T> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public RandomScoreFunctionDescriptor<T> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor<T>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public RandomScoreFunctionDescriptor<T> Weight(double? weight) => Assign(weight, (a, v) => a.WeightValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (SeedValue is not null)
			{
				writer.WritePropertyName("seed");
				JsonSerializer.Serialize(writer, SeedValue, options);
			}

			writer.WriteEndObject();
		}
	}
}