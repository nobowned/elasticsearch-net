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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public class CountRequestParameters : RequestParameters<CountRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public double? MinScore { get => Q<double?>("min_score"); set => Q("min_score", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }
	}

	public partial class CountRequest : PlainRequestBase<CountRequestParameters>
	{
		public CountRequest()
		{
		}

		public CountRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public string? Analyzer { get => Q<string?>("analyzer"); set => Q("analyzer", value); }

		[JsonIgnore]
		public bool? AnalyzeWildcard { get => Q<bool?>("analyze_wildcard"); set => Q("analyze_wildcard", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? DefaultOperator { get => Q<Elastic.Clients.Elasticsearch.QueryDsl.Operator?>("default_operator"); set => Q("default_operator", value); }

		[JsonIgnore]
		public string? Df { get => Q<string?>("df"); set => Q("df", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Lenient { get => Q<bool?>("lenient"); set => Q("lenient", value); }

		[JsonIgnore]
		public double? MinScore { get => Q<double?>("min_score"); set => Q("min_score", value); }

		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public string? Routing { get => Q<string?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public long? TerminateAfter { get => Q<long?>("terminate_after"); set => Q("terminate_after", value); }

		[JsonIgnore]
		public string? QueryLuceneSyntax { get => Q<string?>("q"); set => Q("q", value); }

		[JsonInclude]
		[JsonPropertyName("query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Query { get; set; }
	}

	public sealed partial class CountRequestDescriptor<T> : RequestDescriptorBase<CountRequestDescriptor<T>, CountRequestParameters>
	{
		public CountRequestDescriptor()
		{
		}

		public CountRequestDescriptor(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal CountRequestDescriptor(Action<CountRequestDescriptor<T>> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public CountRequestDescriptor<T> AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public CountRequestDescriptor<T> Analyzer(string? analyzer) => Qs("analyzer", analyzer);
		public CountRequestDescriptor<T> AnalyzeWildcard(bool? analyzeWildcard) => Qs("analyze_wildcard", analyzeWildcard);
		public CountRequestDescriptor<T> DefaultOperator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? defaultOperator) => Qs("default_operator", defaultOperator);
		public CountRequestDescriptor<T> Df(string? df) => Qs("df", df);
		public CountRequestDescriptor<T> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public CountRequestDescriptor<T> IgnoreThrottled(bool? ignoreThrottled) => Qs("ignore_throttled", ignoreThrottled);
		public CountRequestDescriptor<T> IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public CountRequestDescriptor<T> Lenient(bool? lenient) => Qs("lenient", lenient);
		public CountRequestDescriptor<T> MinScore(double? minScore) => Qs("min_score", minScore);
		public CountRequestDescriptor<T> Preference(string? preference) => Qs("preference", preference);
		public CountRequestDescriptor<T> Routing(string? routing) => Qs("routing", routing);
		public CountRequestDescriptor<T> TerminateAfter(long? terminateAfter) => Qs("terminate_after", terminateAfter);
		public CountRequestDescriptor<T> QueryLuceneSyntax(string? q) => Qs("q", q);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? QueryValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<T> QueryDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<T>> QueryDescriptorAction { get; private set; }

		public CountRequestDescriptor<T> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public CountRequestDescriptor<T> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor<T> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public CountRequestDescriptor<T> Query(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainerDescriptor<T>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<T>(QueryDescriptorAction), options);
			}
			else if (QueryValue is not null)
			{
				writer.WritePropertyName("query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			writer.WriteEndObject();
		}
	}
}