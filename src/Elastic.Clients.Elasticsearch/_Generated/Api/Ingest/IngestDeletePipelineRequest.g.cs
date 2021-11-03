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

using Elastic.Clients.Elasticsearch.Experimental;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public class IngestDeletePipelineRequestParameters : RequestParameters<IngestDeletePipelineRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class IngestDeletePipelineRequest : PlainRequestBase<IngestDeletePipelineRequestParameters>
	{
		public IngestDeletePipelineRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonConverter(typeof(IngestDeletePipelineRequestDescriptorConverter))]
	public partial class IngestDeletePipelineRequestDescriptor : RequestDescriptorBase<IngestDeletePipelineRequestDescriptor, IngestDeletePipelineRequestParameters>
	{
		public IngestDeletePipelineRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestDeletePipeline;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public IngestDeletePipelineRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IngestDeletePipelineRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
	}

	internal sealed class IngestDeletePipelineRequestDescriptorConverter : JsonConverter<IngestDeletePipelineRequestDescriptor>
	{
		public override IngestDeletePipelineRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IngestDeletePipelineRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}