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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class Cpu
	{
		[JsonInclude]
		[JsonPropertyName("load_average")]
		public Dictionary<string, double>? LoadAverage { get; init; }

		[JsonInclude]
		[JsonPropertyName("percent")]
		public int? Percent { get; init; }

		[JsonInclude]
		[JsonPropertyName("sys")]
		public string? Sys { get; init; }

		[JsonInclude]
		[JsonPropertyName("sys_in_millis")]
		public long? SysInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public string? Total { get; init; }

		[JsonInclude]
		[JsonPropertyName("total_in_millis")]
		public long? TotalInMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("user")]
		public string? User { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_in_millis")]
		public long? UserInMillis { get; init; }
	}
}