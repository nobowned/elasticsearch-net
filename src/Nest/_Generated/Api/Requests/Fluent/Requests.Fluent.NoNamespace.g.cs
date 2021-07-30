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

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public partial class ClearScrollDescriptor : RequestDescriptorBase<ClearScrollDescriptor, ClearScrollRequestParameters, IClearScrollRequest>, IClearScrollRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClearScroll;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_search/scroll</summary>
        public ClearScrollDescriptor() : base()
		{
		}
	}

	public partial class ClosePointInTimeDescriptor : RequestDescriptorBase<ClosePointInTimeDescriptor, ClosePointInTimeRequestParameters, IClosePointInTimeRequest>, IClosePointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceClosePointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_pit</summary>
        public ClosePointInTimeDescriptor() : base()
		{
		}
	}

	public partial class CountDescriptor : RequestDescriptorBase<CountDescriptor, CountRequestParameters, ICountRequest>, ICountRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCount;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_count</summary>
        public CountDescriptor() : base()
		{
		}

		///<summary>/{index}/_count</summary>
        public CountDescriptor(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class CreateDescriptor<TDocument> : RequestDescriptorBase<CreateDescriptor<TDocument>, CreateRequestParameters, ICreateRequest<TDocument>>, ICreateRequest<TDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_create/{id}</summary>
        public CreateDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class DeleteDescriptor : RequestDescriptorBase<DeleteDescriptor, DeleteRequestParameters, IDeleteRequest>, IDeleteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDelete;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public DeleteDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class DeleteByQueryDescriptor : RequestDescriptorBase<DeleteByQueryDescriptor, DeleteByQueryRequestParameters, IDeleteByQueryRequest>, IDeleteByQueryRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceDeleteByQuery;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_delete_by_query</summary>
        public DeleteByQueryDescriptor(Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class ExistsDescriptor : RequestDescriptorBase<ExistsDescriptor, ExistsRequestParameters, IExistsRequest>, IExistsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExists;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public ExistsDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class ExistsSourceDescriptor : RequestDescriptorBase<ExistsSourceDescriptor, ExistsSourceRequestParameters, IExistsSourceRequest>, IExistsSourceRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExistsSource;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_source/{id}</summary>
        public ExistsSourceDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class ExplainDescriptor : RequestDescriptorBase<ExplainDescriptor, ExplainRequestParameters, IExplainRequest>, IExplainRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_explain/{id}</summary>
        public ExplainDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class FieldCapsDescriptor : RequestDescriptorBase<FieldCapsDescriptor, FieldCapsRequestParameters, IFieldCapsRequest>, IFieldCapsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceFieldCaps;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_field_caps</summary>
        public FieldCapsDescriptor() : base()
		{
		}

		///<summary>/{index}/_field_caps</summary>
        public FieldCapsDescriptor(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class GetDescriptor : RequestDescriptorBase<GetDescriptor, GetRequestParameters, IGetRequest>, IGetRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public GetDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}
	}

	public partial class GetScriptDescriptor : RequestDescriptorBase<GetScriptDescriptor, GetScriptRequestParameters, IGetScriptRequest>, IGetScriptRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScript;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/{id}</summary>
        public GetScriptDescriptor(Id id) : base(r => r.Required("id", id))
		{
		}
	}

	public partial class GetScriptContextDescriptor : RequestDescriptorBase<GetScriptContextDescriptor, GetScriptContextRequestParameters, IGetScriptContextRequest>, IGetScriptContextRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptContext;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_script_context</summary>
        public GetScriptContextDescriptor() : base()
		{
		}
	}

	public partial class GetScriptLanguagesDescriptor : RequestDescriptorBase<GetScriptLanguagesDescriptor, GetScriptLanguagesRequestParameters, IGetScriptLanguagesRequest>, IGetScriptLanguagesRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetScriptLanguages;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_script_language</summary>
        public GetScriptLanguagesDescriptor() : base()
		{
		}
	}

	public partial class GetSourceDescriptor : RequestDescriptorBase<GetSourceDescriptor, GetSourceRequestParameters, IGetSourceRequest>, IGetSourceRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceGetSource;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_source/{id}</summary>
        public GetSourceDescriptor(Index index, Id id) : base(r => r)
		{
		}
	}

	public partial class IndexDescriptor<TDocument> : RequestDescriptorBase<IndexDescriptor<TDocument>, IndexRequestParameters, IIndexRequest<TDocument>>, IIndexRequest<TDocument>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceIndex;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/{index}/_doc/{id}</summary>
        public IndexDescriptor(IndexName index, Id id) : base(r => r.Required("index", index).Optional("id", id))
		{
		}

		///<summary>/{index}/_doc</summary>
        public IndexDescriptor(IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class InfoDescriptor : RequestDescriptorBase<InfoDescriptor, InfoRequestParameters, IInfoRequest>, IInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/</summary>
        public InfoDescriptor() : base()
		{
		}
	}

	public partial class OpenPointInTimeDescriptor : RequestDescriptorBase<OpenPointInTimeDescriptor, OpenPointInTimeRequestParameters, IOpenPointInTimeRequest>, IOpenPointInTimeRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceOpenPointInTime;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_pit</summary>
        public OpenPointInTimeDescriptor() : base()
		{
		}

		///<summary>/{index}/_pit</summary>
        public OpenPointInTimeDescriptor(Indices index) : base(r => r.Required("index", index))
		{
		}
	}

	public partial class PingDescriptor : RequestDescriptorBase<PingDescriptor, PingRequestParameters, IPingRequest>, IPingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		///<summary>/</summary>
        public PingDescriptor() : base()
		{
		}
	}

	public partial class PutScriptDescriptor : RequestDescriptorBase<PutScriptDescriptor, PutScriptRequestParameters, IPutScriptRequest>, IPutScriptRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePutScript;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_scripts/{id}</summary>
        public PutScriptDescriptor(Id id) : base(r => r.Required("id", id))
		{
		}

		///<summary>/_scripts/{id}/{context}</summary>
        public PutScriptDescriptor(Id id, Name context) : base(r => r.Required("id", id).Optional("context", context))
		{
		}
	}

	public partial class ReindexDescriptor : RequestDescriptorBase<ReindexDescriptor, ReindexRequestParameters, IReindexRequest>, IReindexRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceReindex;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_reindex</summary>
        public ReindexDescriptor() : base()
		{
		}
	}

	public partial class ScrollDescriptor : RequestDescriptorBase<ScrollDescriptor, ScrollRequestParameters, IScrollRequest>, IScrollRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceScroll;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search/scroll</summary>
        public ScrollDescriptor() : base()
		{
		}
	}

	public partial class SearchDescriptor : RequestDescriptorBase<SearchDescriptor, SearchRequestParameters, ISearchRequest>, ISearchRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearch;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search</summary>
        public SearchDescriptor() : base()
		{
		}

		///<summary>/{index}/_search</summary>
        public SearchDescriptor(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class SearchShardsDescriptor : RequestDescriptorBase<SearchShardsDescriptor, SearchShardsRequestParameters, ISearchShardsRequest>, ISearchShardsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceSearchShards;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_search_shards</summary>
        public SearchShardsDescriptor() : base()
		{
		}

		///<summary>/{index}/_search_shards</summary>
        public SearchShardsDescriptor(Indices index) : base(r => r.Optional("index", index))
		{
		}
	}
}