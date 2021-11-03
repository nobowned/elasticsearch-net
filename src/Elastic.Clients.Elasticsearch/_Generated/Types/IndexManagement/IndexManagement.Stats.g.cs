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
namespace Elastic.Clients.Elasticsearch.IndexManagement.Stats
{
	public partial class IndexStats
	{
		[JsonInclude]
		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.CompletionStats? Completion { get; init; }

		[JsonInclude]
		[JsonPropertyName("docs")]
		public Elastic.Clients.Elasticsearch.DocStats? Docs { get; init; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.FielddataStats? Fielddata { get; init; }

		[JsonInclude]
		[JsonPropertyName("flush")]
		public Elastic.Clients.Elasticsearch.FlushStats? Flush { get; init; }

		[JsonInclude]
		[JsonPropertyName("get")]
		public Elastic.Clients.Elasticsearch.GetStats? Get { get; init; }

		[JsonInclude]
		[JsonPropertyName("indexing")]
		public Elastic.Clients.Elasticsearch.IndexingStats? Indexing { get; init; }

		[JsonInclude]
		[JsonPropertyName("merges")]
		public Elastic.Clients.Elasticsearch.MergesStats? Merges { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_cache")]
		public Elastic.Clients.Elasticsearch.QueryCacheStats? QueryCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("recovery")]
		public Elastic.Clients.Elasticsearch.RecoveryStats? Recovery { get; init; }

		[JsonInclude]
		[JsonPropertyName("refresh")]
		public Elastic.Clients.Elasticsearch.RefreshStats? Refresh { get; init; }

		[JsonInclude]
		[JsonPropertyName("request_cache")]
		public Elastic.Clients.Elasticsearch.RequestCacheStats? RequestCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("search")]
		public Elastic.Clients.Elasticsearch.SearchStats? Search { get; init; }

		[JsonInclude]
		[JsonPropertyName("segments")]
		public Elastic.Clients.Elasticsearch.SegmentsStats? Segments { get; init; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.StoreStats? Store { get; init; }

		[JsonInclude]
		[JsonPropertyName("translog")]
		public Elastic.Clients.Elasticsearch.TranslogStats? Translog { get; init; }

		[JsonInclude]
		[JsonPropertyName("warmer")]
		public Elastic.Clients.Elasticsearch.WarmerStats? Warmer { get; init; }

		[JsonInclude]
		[JsonPropertyName("bulk")]
		public Elastic.Clients.Elasticsearch.BulkStats? Bulk { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardsTotalStats? Shards { get; init; }
	}

	public partial class IndicesStats
	{
		[JsonInclude]
		[JsonPropertyName("primaries")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.IndexStats Primaries { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Dictionary<string, IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardStats>>? Shards { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.IndexStats Total { get; init; }

		[JsonInclude]
		[JsonPropertyName("uuid")]
		public string? Uuid { get; init; }
	}

	public partial class ShardCommit
	{
		[JsonInclude]
		[JsonPropertyName("generation")]
		public int Generation { get; init; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("num_docs")]
		public object NumDocs { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_data")]
		public Dictionary<string, string> UserData { get; init; }
	}

	public partial class ShardFileSizeInfo
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description { get; init; }

		[JsonInclude]
		[JsonPropertyName("size_in_bytes")]
		public object SizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_size_in_bytes")]
		public object? MinSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_size_in_bytes")]
		public object? MaxSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("average_size_in_bytes")]
		public object? AverageSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public object? Count { get; init; }
	}

	public partial class ShardLease
	{
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("retaining_seq_no")]
		public object RetainingSeqNo { get; init; }

		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public object Timestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("source")]
		public string Source { get; init; }
	}

	public partial class ShardPath
	{
		[JsonInclude]
		[JsonPropertyName("data_path")]
		public string DataPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("is_custom_data_path")]
		public bool IsCustomDataPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("state_path")]
		public string StatePath { get; init; }
	}

	public partial class ShardQueryCache
	{
		[JsonInclude]
		[JsonPropertyName("cache_count")]
		public object CacheCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("cache_size")]
		public object CacheSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("evictions")]
		public object Evictions { get; init; }

		[JsonInclude]
		[JsonPropertyName("hit_count")]
		public object HitCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("memory_size_in_bytes")]
		public object MemorySizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("miss_count")]
		public object MissCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_count")]
		public object TotalCount { get; init; }
	}

	public partial class ShardRetentionLeases
	{
		[JsonInclude]
		[JsonPropertyName("primary_term")]
		public object PrimaryTerm { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public object Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("leases")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardLease> Leases { get; init; }
	}

	public partial class ShardRouting
	{
		[JsonInclude]
		[JsonPropertyName("node")]
		public string Node { get; init; }

		[JsonInclude]
		[JsonPropertyName("primary")]
		public bool Primary { get; init; }

		[JsonInclude]
		[JsonPropertyName("relocating_node")]
		public string? RelocatingNode { get; init; }

		[JsonInclude]
		[JsonPropertyName("state")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardRoutingState State { get; init; }
	}

	public partial class ShardSequenceNumber
	{
		[JsonInclude]
		[JsonPropertyName("global_checkpoint")]
		public object GlobalCheckpoint { get; init; }

		[JsonInclude]
		[JsonPropertyName("local_checkpoint")]
		public object LocalCheckpoint { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_seq_no")]
		public object MaxSeqNo { get; init; }
	}

	public partial class ShardStats
	{
		[JsonInclude]
		[JsonPropertyName("commit")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardCommit Commit { get; init; }

		[JsonInclude]
		[JsonPropertyName("completion")]
		public Elastic.Clients.Elasticsearch.CompletionStats Completion { get; init; }

		[JsonInclude]
		[JsonPropertyName("docs")]
		public Elastic.Clients.Elasticsearch.DocStats Docs { get; init; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.FielddataStats Fielddata { get; init; }

		[JsonInclude]
		[JsonPropertyName("flush")]
		public Elastic.Clients.Elasticsearch.FlushStats Flush { get; init; }

		[JsonInclude]
		[JsonPropertyName("get")]
		public Elastic.Clients.Elasticsearch.GetStats Get { get; init; }

		[JsonInclude]
		[JsonPropertyName("indexing")]
		public Elastic.Clients.Elasticsearch.IndexingStats Indexing { get; init; }

		[JsonInclude]
		[JsonPropertyName("merges")]
		public Elastic.Clients.Elasticsearch.MergesStats Merges { get; init; }

		[JsonInclude]
		[JsonPropertyName("shard_path")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardPath ShardPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_cache")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardQueryCache QueryCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("recovery")]
		public Elastic.Clients.Elasticsearch.RecoveryStats Recovery { get; init; }

		[JsonInclude]
		[JsonPropertyName("refresh")]
		public Elastic.Clients.Elasticsearch.RefreshStats Refresh { get; init; }

		[JsonInclude]
		[JsonPropertyName("request_cache")]
		public Elastic.Clients.Elasticsearch.RequestCacheStats RequestCache { get; init; }

		[JsonInclude]
		[JsonPropertyName("retention_leases")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardRetentionLeases RetentionLeases { get; init; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardRouting Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("search")]
		public Elastic.Clients.Elasticsearch.SearchStats Search { get; init; }

		[JsonInclude]
		[JsonPropertyName("segments")]
		public Elastic.Clients.Elasticsearch.SegmentsStats Segments { get; init; }

		[JsonInclude]
		[JsonPropertyName("seq_no")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardSequenceNumber SeqNo { get; init; }

		[JsonInclude]
		[JsonPropertyName("store")]
		public Elastic.Clients.Elasticsearch.StoreStats Store { get; init; }

		[JsonInclude]
		[JsonPropertyName("translog")]
		public Elastic.Clients.Elasticsearch.TranslogStats Translog { get; init; }

		[JsonInclude]
		[JsonPropertyName("warmer")]
		public Elastic.Clients.Elasticsearch.WarmerStats Warmer { get; init; }

		[JsonInclude]
		[JsonPropertyName("bulk")]
		public Elastic.Clients.Elasticsearch.BulkStats? Bulk { get; init; }

		[JsonInclude]
		[JsonPropertyName("shards")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Stats.ShardsTotalStats Shards { get; init; }
	}

	public partial class ShardsTotalStats
	{
		[JsonInclude]
		[JsonPropertyName("total_count")]
		public object TotalCount { get; init; }
	}
}