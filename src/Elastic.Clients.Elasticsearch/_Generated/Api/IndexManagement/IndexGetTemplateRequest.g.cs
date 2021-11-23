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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexGetTemplateRequestParameters : RequestParameters<IndexGetTemplateRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class IndexGetTemplateRequest : PlainRequestBase<IndexGetTemplateRequestParameters>
	{
		public IndexGetTemplateRequest()
		{
		}

		public IndexGetTemplateRequest(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public sealed partial class IndexGetTemplateRequestDescriptor : RequestDescriptorBase<IndexGetTemplateRequestDescriptor, IndexGetTemplateRequestParameters>
	{
		public IndexGetTemplateRequestDescriptor()
		{
		}

		public IndexGetTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("name", name))
		{
		}

		internal IndexGetTemplateRequestDescriptor(Action<IndexGetTemplateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementGetTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public IndexGetTemplateRequestDescriptor FlatSettings(bool? flatSettings) => Qs("flat_settings", flatSettings);
		public IndexGetTemplateRequestDescriptor IncludeTypeName(bool? includeTypeName) => Qs("include_type_name", includeTypeName);
		public IndexGetTemplateRequestDescriptor Local(bool? local) => Qs("local", local);
		public IndexGetTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}