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
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class Suggest<T>
	{
		[JsonInclude]
		[JsonPropertyName("length")]
		public int Length
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("offset")]
		public int Offset
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("options")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.SuggestOption<T>> Options
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class TermSuggestOption
	{
		[JsonInclude]
		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("freq")]
		public long? Freq
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PhraseSuggestOption
	{
		[JsonInclude]
		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("highlighted")]
		public string Highlighted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CompletionSuggestOption<TDocument>
	{
		[JsonInclude]
		[JsonPropertyName("collate_match")]
		public string? CollateMatch
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("contexts")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.Context>>? Contexts
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_index")]
		public string Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_type")]
		public string? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public string? Routing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_score")]
		public double Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("text")]
		public string Text
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Profile
	{
		[JsonInclude]
		[JsonPropertyName("shards")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ShardProfile> Shards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardProfile
	{
		[JsonInclude]
		[JsonPropertyName("aggregations")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.AggregationProfile> Aggregations
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("searches")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.SearchProfile> Searches
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class SearchProfile
	{
		[JsonInclude]
		[JsonPropertyName("collector")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Collector> Collector
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("query")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.QueryProfile> Query
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("rewrite_time")]
		public long RewriteTime
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class QueryProfile
	{
		[JsonInclude]
		[JsonPropertyName("breakdown")]
		public Elastic.Clients.Elasticsearch.QueryBreakdown Breakdown
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.QueryProfile>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class QueryBreakdown
	{
		[JsonInclude]
		[JsonPropertyName("advance")]
		public long Advance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("advance_count")]
		public long AdvanceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("build_scorer")]
		public long BuildScorer
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("build_scorer_count")]
		public long BuildScorerCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("create_weight")]
		public long CreateWeight
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("create_weight_count")]
		public long CreateWeightCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("match")]
		public long Match
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("match_count")]
		public long MatchCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("shallow_advance")]
		public long ShallowAdvance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("shallow_advance_count")]
		public long ShallowAdvanceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("next_doc")]
		public long NextDoc
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("next_doc_count")]
		public long NextDocCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("score")]
		public long Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("score_count")]
		public long ScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("compute_max_score")]
		public long ComputeMaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("compute_max_score_count")]
		public long ComputeMaxScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("set_min_competitive_score")]
		public long SetMinCompetitiveScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("set_min_competitive_score_count")]
		public long SetMinCompetitiveScoreCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Collector
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public string Name
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("reason")]
		public string Reason
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Collector>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AggregationProfile
	{
		[JsonInclude]
		[JsonPropertyName("breakdown")]
		public Elastic.Clients.Elasticsearch.AggregationBreakdown Breakdown
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("time_in_nanos")]
		public long TimeInNanos
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("debug")]
		public Elastic.Clients.Elasticsearch.AggregationProfileDebug? Debug
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("children")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.AggregationProfileDebug>? Children
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class AggregationProfileDebug
	{
	}

	public partial class AggregationBreakdown
	{
		[JsonInclude]
		[JsonPropertyName("build_aggregation")]
		public long BuildAggregation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("build_aggregation_count")]
		public long BuildAggregationCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("build_leaf_collector")]
		public long BuildLeafCollector
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("build_leaf_collector_count")]
		public long BuildLeafCollectorCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("collect")]
		public long Collect
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("collect_count")]
		public long CollectCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("initialize")]
		public long Initialize
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("initialize_count")]
		public long InitializeCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("post_collection")]
		public long? PostCollection
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("post_collection_count")]
		public long? PostCollectionCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("reduce")]
		public long Reduce
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("reduce_count")]
		public long ReduceCount
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ClusterStatistics
	{
		[JsonInclude]
		[JsonPropertyName("skipped")]
		public int Skipped
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("successful")]
		public int Successful
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("total")]
		public int Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class HitsMetadata<T>
	{
		[JsonInclude]
		[JsonPropertyName("hits")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Hit<T>> Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Hit<TDocument>
	{
		[JsonInclude]
		[JsonPropertyName("_index")]
		public string Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_score")]
		public double? Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_type")]
		public string? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_explanation")]
		public Elastic.Clients.Elasticsearch.Explanation? Explanation
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public Dictionary<string, IReadOnlyCollection<string>>? Highlight
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("inner_hits")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.InnerHitsResult>? InnerHits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("matched_queries")]
		public IReadOnlyCollection<string>? MatchedQueries
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_nested")]
		public Elastic.Clients.Elasticsearch.NestedIdentity? Nested
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_ignored")]
		public IReadOnlyCollection<string>? Ignored
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_shard")]
		public string? Shard
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_node")]
		public string? Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public string? Routing
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_seq_no")]
		public int? SeqNo
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_primary_term")]
		public long? PrimaryTerm
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_version")]
		public long? Version
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class NestedIdentity
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("offset")]
		public int Offset
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_nested")]
		public Elastic.Clients.Elasticsearch.NestedIdentity? Nested
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InnerHitsResult
	{
		[JsonInclude]
		[JsonPropertyName("hits")]
		public Elastic.Clients.Elasticsearch.InnerHitsMetadata Hits
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class InnerHitsMetadata
	{
		[JsonInclude]
		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Explanation
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("details")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ExplanationDetail> Details
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("value")]
		public float Value
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ExplanationDetail
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("details")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ExplanationDetail>? Details
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("value")]
		public float Value
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(LatLon))]
	public partial interface ILatLon
	{
		double Lat { get; set; }

		double Lon { get; set; }
	}

	public partial class LatLon : ILatLon
	{
		[JsonInclude]
		[JsonPropertyName("lat")]
		public double Lat { get; set; }

		[JsonInclude]
		[JsonPropertyName("lon")]
		public double Lon { get; set; }
	}

	public partial class LatLonDescriptor
	{
	}

	public partial class ShardStatistics
	{
		[JsonInclude]
		[JsonPropertyName("failures")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ShardFailure>? Failures
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ShardFailure
	{
		[JsonInclude]
		[JsonPropertyName("index")]
		public string? Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("node")]
		public string? Node
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("reason")]
		public Elastic.Clients.Elasticsearch.ErrorCause Reason
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("shard")]
		public int Shard
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("status")]
		public string? Status
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ErrorCause
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("reason")]
		public string Reason
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("caused_by")]
		public Elastic.Clients.Elasticsearch.ErrorCause? CausedBy
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("stack_trace")]
		public string? StackTrace
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("root_cause")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ErrorCause>? RootCause
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("bytes_limit")]
		public long? BytesLimit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("bytes_wanted")]
		public long? BytesWanted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("column")]
		public int? Column
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("col")]
		public int? Col
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("failed_shards")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.ShardFailure>? FailedShards
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("grouped")]
		public string? Grouped
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index")]
		public string? Index
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("index_uuid")]
		public string? IndexUuid
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("language")]
		public string? Language
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("licensed_expired_feature")]
		public string? LicensedExpiredFeature
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("line")]
		public int? Line
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("max_buckets")]
		public int? MaxBuckets
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("phase")]
		public string? Phase
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("property_name")]
		public string? PropertyName
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("processor_type")]
		public string? ProcessorType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("resource_id")]
		public Elastic.Clients.Elasticsearch.Ids? ResourceId
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("resource_type")]
		public string? ResourceType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("script")]
		public string? Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("script_stack")]
		public IReadOnlyCollection<string>? ScriptStack
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("lang")]
		public string? Lang
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("position")]
		public Elastic.Clients.Elasticsearch.PainlessExecutionPosition? Position
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PainlessExecutionPosition
	{
		[JsonInclude]
		[JsonPropertyName("offset")]
		public int Offset
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("start")]
		public int Start
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("end")]
		public int End
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(PointInTimeReference))]
	public partial interface IPointInTimeReference
	{
		string Id { get; set; }

		Elastic.Clients.Elasticsearch.Time? KeepAlive { get; set; }
	}

	public partial class PointInTimeReference : IPointInTimeReference
	{
		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("keep_alive")]
		public Elastic.Clients.Elasticsearch.Time? KeepAlive { get; set; }
	}

	public partial class PointInTimeReferenceDescriptor
	{
	}

	[ConvertAs(typeof(SlicedScroll))]
	public partial interface ISlicedScroll
	{
		string? Field { get; set; }

		int Id { get; set; }

		int Max { get; set; }
	}

	public partial class SlicedScroll : ISlicedScroll
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public string? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("max")]
		public int Max { get; set; }
	}

	public partial class SlicedScrollDescriptor
	{
	}

	[ConvertAs(typeof(ScriptField))]
	public partial interface IScriptField
	{
		Elastic.Clients.Elasticsearch.Script Script { get; set; }

		string? IgnoreFailure { get; set; }
	}

	public partial class ScriptField : IScriptField
	{
		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_failure")]
		public string? IgnoreFailure { get; set; }
	}

	public partial class ScriptFieldDescriptor
	{
	}

	public partial class IndexedScript
	{
		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(ScriptBase))]
	public partial interface IScriptBase
	{
	}

	public abstract partial class ScriptBase : IScriptBase
	{
	}

	public partial class ScriptBaseDescriptor
	{
	}

	[ConvertAs(typeof(InlineScript))]
	public partial interface IInlineScript
	{
		string Source { get; set; }
	}

	public partial class InlineScript : IInlineScript
	{
		[JsonInclude]
		[JsonPropertyName("source")]
		public string Source { get; set; }
	}

	public partial class InlineScriptDescriptor
	{
	}

	[ConvertAs(typeof(InnerHits))]
	public partial interface IInnerHits
	{
		string? Name { get; set; }

		int? Size { get; set; }

		int? From { get; set; }

		IFieldCollapse? Collapse { get; set; }

		IEnumerable<IFieldAndFormat>? DocvalueFields { get; set; }

		string? Explain { get; set; }

		IHighlight? Highlight { get; set; }

		string? IgnoreUnmapped { get; set; }

		Dictionary<string, IScriptField>? ScriptFields { get; set; }

		string? SeqNoPrimaryTerm { get; set; }

		Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		Elastic.Clients.Elasticsearch.Sort? Sort { get; set; }

		Elastic.Clients.Elasticsearch.Fields? StoredField { get; set; }

		string? TrackScores { get; set; }

		string? Version { get; set; }
	}

	public partial class InnerHits : IInnerHits
	{
		[JsonInclude]
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonInclude]
		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonInclude]
		[JsonPropertyName("collapse")]
		public IFieldCollapse? Collapse { get; set; }

		[JsonInclude]
		[JsonPropertyName("docvalue_fields")]
		public IEnumerable<IFieldAndFormat>? DocvalueFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("explain")]
		public string? Explain { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight")]
		public IHighlight? Highlight { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public string? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("script_fields")]
		public Dictionary<string, IScriptField>? ScriptFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("seq_no_primary_term")]
		public string? SeqNoPrimaryTerm { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("sort")]
		public Elastic.Clients.Elasticsearch.Sort? Sort { get; set; }

		[JsonInclude]
		[JsonPropertyName("stored_field")]
		public Elastic.Clients.Elasticsearch.Fields? StoredField { get; set; }

		[JsonInclude]
		[JsonPropertyName("track_scores")]
		public string? TrackScores { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; set; }
	}

	public partial class InnerHitsDescriptor
	{
	}

	public partial class SortContainer
	{
		[JsonInclude]
		[JsonPropertyName("_score")]
		public Elastic.Clients.Elasticsearch.ScoreSort? Score
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_doc")]
		public Elastic.Clients.Elasticsearch.ScoreSort? Doc
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_geo_distance")]
		public Elastic.Clients.Elasticsearch.GeoDistanceSort? GeoDistance
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("_script")]
		public Elastic.Clients.Elasticsearch.ScriptSort? Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ScriptSort
	{
		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("type")]
		public string? Type
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class GeoDistanceSort
	{
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.SortMode? Mode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("distance_type")]
		public Elastic.Clients.Elasticsearch.GeoDistanceType? DistanceType
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("unit")]
		public Elastic.Clients.Elasticsearch.DistanceUnit? Unit
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class ScoreSort
	{
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.SortMode? Mode
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.SortOrder? Order
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(Highlight))]
	public partial interface IHighlight
	{
		Dictionary<string, IHighlightField> Fields { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterType? Type { get; set; }

		string? BoundaryChars { get; set; }

		int? BoundaryMaxScan { get; set; }

		Elastic.Clients.Elasticsearch.BoundaryScanner? BoundaryScanner { get; set; }

		string? BoundaryScannerLocale { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterEncoder? Encoder { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterFragmenter? Fragmenter { get; set; }

		int? FragmentOffset { get; set; }

		int? FragmentSize { get; set; }

		int? MaxFragmentLength { get; set; }

		int? NoMatchSize { get; set; }

		int? NumberOfFragments { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterOrder? Order { get; set; }

		IEnumerable<string>? PostTags { get; set; }

		IEnumerable<string>? PreTags { get; set; }

		string? RequireFieldMatch { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterTagsSchema? TagsSchema { get; set; }

		QueryDsl.IQueryContainer? HighlightQuery { get; set; }
	}

	public partial class Highlight : IHighlight
	{
		[JsonInclude]
		[JsonPropertyName("fields")]
		public Dictionary<string, IHighlightField> Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.HighlighterType? Type { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_chars")]
		public string? BoundaryChars { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_max_scan")]
		public int? BoundaryMaxScan { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner")]
		public Elastic.Clients.Elasticsearch.BoundaryScanner? BoundaryScanner { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner_locale")]
		public string? BoundaryScannerLocale { get; set; }

		[JsonInclude]
		[JsonPropertyName("encoder")]
		public Elastic.Clients.Elasticsearch.HighlighterEncoder? Encoder { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragmenter")]
		public Elastic.Clients.Elasticsearch.HighlighterFragmenter? Fragmenter { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragment_offset")]
		public int? FragmentOffset { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragment_size")]
		public int? FragmentSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_fragment_length")]
		public int? MaxFragmentLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("no_match_size")]
		public int? NoMatchSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("number_of_fragments")]
		public int? NumberOfFragments { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.HighlighterOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("post_tags")]
		public IEnumerable<string>? PostTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("pre_tags")]
		public IEnumerable<string>? PreTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("require_field_match")]
		public string? RequireFieldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("tags_schema")]
		public Elastic.Clients.Elasticsearch.HighlighterTagsSchema? TagsSchema { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight_query")]
		public QueryDsl.IQueryContainer? HighlightQuery { get; set; }
	}

	public partial class HighlightDescriptor
	{
	}

	[ConvertAs(typeof(HighlightField))]
	public partial interface IHighlightField
	{
		string? BoundaryChars { get; set; }

		int? BoundaryMaxScan { get; set; }

		Elastic.Clients.Elasticsearch.BoundaryScanner? BoundaryScanner { get; set; }

		string? BoundaryScannerLocale { get; set; }

		string? Field { get; set; }

		string? ForceSource { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterFragmenter? Fragmenter { get; set; }

		int? FragmentOffset { get; set; }

		int? FragmentSize { get; set; }

		QueryDsl.IQueryContainer? HighlightQuery { get; set; }

		Elastic.Clients.Elasticsearch.Fields? MatchedFields { get; set; }

		int? MaxFragmentLength { get; set; }

		int? NoMatchSize { get; set; }

		int? NumberOfFragments { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterOrder? Order { get; set; }

		int? PhraseLimit { get; set; }

		IEnumerable<string>? PostTags { get; set; }

		IEnumerable<string>? PreTags { get; set; }

		string? RequireFieldMatch { get; set; }

		Elastic.Clients.Elasticsearch.HighlighterTagsSchema? TagsSchema { get; set; }
	}

	public partial class HighlightField : IHighlightField
	{
		[JsonInclude]
		[JsonPropertyName("boundary_chars")]
		public string? BoundaryChars { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_max_scan")]
		public int? BoundaryMaxScan { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner")]
		public Elastic.Clients.Elasticsearch.BoundaryScanner? BoundaryScanner { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner_locale")]
		public string? BoundaryScannerLocale { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public string? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("force_source")]
		public string? ForceSource { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragmenter")]
		public Elastic.Clients.Elasticsearch.HighlighterFragmenter? Fragmenter { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragment_offset")]
		public int? FragmentOffset { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragment_size")]
		public int? FragmentSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight_query")]
		public QueryDsl.IQueryContainer? HighlightQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("matched_fields")]
		public Elastic.Clients.Elasticsearch.Fields? MatchedFields { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_fragment_length")]
		public int? MaxFragmentLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("no_match_size")]
		public int? NoMatchSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("number_of_fragments")]
		public int? NumberOfFragments { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.HighlighterOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("phrase_limit")]
		public int? PhraseLimit { get; set; }

		[JsonInclude]
		[JsonPropertyName("post_tags")]
		public IEnumerable<string>? PostTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("pre_tags")]
		public IEnumerable<string>? PreTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("require_field_match")]
		public string? RequireFieldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("tags_schema")]
		public Elastic.Clients.Elasticsearch.HighlighterTagsSchema? TagsSchema { get; set; }
	}

	public partial class HighlightFieldDescriptor
	{
	}

	[ConvertAs(typeof(FieldAndFormat))]
	public partial interface IFieldAndFormat
	{
		string Field { get; set; }

		string? Format { get; set; }

		string? IncludeUnmapped { get; set; }
	}

	public partial class FieldAndFormat : IFieldAndFormat
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_unmapped")]
		public string? IncludeUnmapped { get; set; }
	}

	public partial class FieldAndFormatDescriptor
	{
	}

	[ConvertAs(typeof(FieldCollapse))]
	public partial interface IFieldCollapse
	{
		string Field { get; set; }

		int? MaxConcurrentGroupSearches { get; set; }
	}

	public partial class FieldCollapse : IFieldCollapse
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public string Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_concurrent_group_searches")]
		public int? MaxConcurrentGroupSearches { get; set; }
	}

	public partial class FieldCollapseDescriptor
	{
	}
}