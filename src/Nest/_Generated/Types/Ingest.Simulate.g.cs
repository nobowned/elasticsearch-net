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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Ingest.Simulate
{
	public partial class Document
	{
		[JsonPropertyName("_id")]
		public Nest.Id? Id { get; set; }

		[JsonPropertyName("_index")]
		public Nest.IndexName? Index { get; set; }

		[JsonPropertyName("_source")]
		public object Source { get; set; }
	}

	public partial class DocumentSimulation
	{
		[JsonPropertyName("_id")]
		public Nest.Id Id
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_index")]
		public Nest.IndexName Index
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_ingest")]
		public Nest.Ingest.Simulate.Ingest Ingest
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_parent")]
		public string? Parent
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_routing")]
		public string? Routing
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_source")]
		public Dictionary<string, object> Source
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_type")]
		public Nest.DocType? Type
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class Ingest
	{
		[JsonPropertyName("pipeline")]
		public Nest.Name? Pipeline
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timestamp")]
		public Nest.DateString Timestamp
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class PipelineSimulation
	{
		[JsonPropertyName("doc")]
		public Nest.Ingest.Simulate.DocumentSimulation? Doc
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processor_results")]
		public IReadOnlyCollection<Nest.Ingest.Simulate.PipelineSimulation>? ProcessorResults
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("processor_type")]
		public string? ProcessorType
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("status")]
		public Nest.Watcher.ActionStatusOptions? Status
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tag")]
		public string? Tag
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}