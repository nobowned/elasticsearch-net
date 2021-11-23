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
namespace Elastic.Clients.Elasticsearch.Cluster.AllocationExplain
{
	public partial class AllocationStore
	{
		[JsonInclude]
		[JsonPropertyName("allocation_id")]
		public string AllocationId { get; init; }

		[JsonInclude]
		[JsonPropertyName("found")]
		public bool Found { get; init; }

		[JsonInclude]
		[JsonPropertyName("in_sync")]
		public bool InSync { get; init; }

		[JsonInclude]
		[JsonPropertyName("matching_size_in_bytes")]
		public long MatchingSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("matching_sync_id")]
		public bool MatchingSyncId { get; init; }

		[JsonInclude]
		[JsonPropertyName("store_exception")]
		public string StoreException { get; init; }
	}
}