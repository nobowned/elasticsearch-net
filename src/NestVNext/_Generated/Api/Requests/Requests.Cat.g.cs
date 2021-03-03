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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;

namespace Nest
{
    public interface ICatAliasesRequest : IRequest<CatAliasesRequestParameters>
    {
    }

    public class CatAliasesRequest : PlainRequestBase<CatAliasesRequestParameters>, ICatAliasesRequest
    {
        protected ICatAliasesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAliases;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatAllocationRequest : IRequest<CatAllocationRequestParameters>
    {
    }

    public class CatAllocationRequest : PlainRequestBase<CatAllocationRequestParameters>, ICatAllocationRequest
    {
        protected ICatAllocationRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatAllocation;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatCountRequest : IRequest<CatCountRequestParameters>
    {
    }

    public class CatCountRequest : PlainRequestBase<CatCountRequestParameters>, ICatCountRequest
    {
        protected ICatCountRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatCount;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatDataFrameAnalyticsRequest : IRequest<CatDataFrameAnalyticsRequestParameters>
    {
    }

    public class CatDataFrameAnalyticsRequest : PlainRequestBase<CatDataFrameAnalyticsRequestParameters>, ICatDataFrameAnalyticsRequest
    {
        protected ICatDataFrameAnalyticsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDataFrameAnalytics;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatDatafeedsRequest : IRequest<CatDatafeedsRequestParameters>
    {
    }

    public class CatDatafeedsRequest : PlainRequestBase<CatDatafeedsRequestParameters>, ICatDatafeedsRequest
    {
        protected ICatDatafeedsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlDatafeeds;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatFielddataRequest : IRequest<CatFielddataRequestParameters>
    {
    }

    public class CatFielddataRequest : PlainRequestBase<CatFielddataRequestParameters>, ICatFielddataRequest
    {
        protected ICatFielddataRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatFielddata;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatHealthRequest : IRequest<CatHealthRequestParameters>
    {
    }

    public class CatHealthRequest : PlainRequestBase<CatHealthRequestParameters>, ICatHealthRequest
    {
        protected ICatHealthRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHealth;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatHelpRequest : IRequest<CatHelpRequestParameters>
    {
    }

    public class CatHelpRequest : PlainRequestBase<CatHelpRequestParameters>, ICatHelpRequest
    {
        protected ICatHelpRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatHelp;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatIndicesRequest : IRequest<CatIndicesRequestParameters>
    {
    }

    public class CatIndicesRequest : PlainRequestBase<CatIndicesRequestParameters>, ICatIndicesRequest
    {
        protected ICatIndicesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatIndices;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatJobsRequest : IRequest<CatJobsRequestParameters>
    {
    }

    public class CatJobsRequest : PlainRequestBase<CatJobsRequestParameters>, ICatJobsRequest
    {
        protected ICatJobsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlJobs;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatMasterRequest : IRequest<CatMasterRequestParameters>
    {
    }

    public class CatMasterRequest : PlainRequestBase<CatMasterRequestParameters>, ICatMasterRequest
    {
        protected ICatMasterRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMaster;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatNodeAttributesRequest : IRequest<CatNodeAttributesRequestParameters>
    {
    }

    public class CatNodeAttributesRequest : PlainRequestBase<CatNodeAttributesRequestParameters>, ICatNodeAttributesRequest
    {
        protected ICatNodeAttributesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodeattrs;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatNodesRequest : IRequest<CatNodesRequestParameters>
    {
    }

    public class CatNodesRequest : PlainRequestBase<CatNodesRequestParameters>, ICatNodesRequest
    {
        protected ICatNodesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatNodes;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatPendingTasksRequest : IRequest<CatPendingTasksRequestParameters>
    {
    }

    public class CatPendingTasksRequest : PlainRequestBase<CatPendingTasksRequestParameters>, ICatPendingTasksRequest
    {
        protected ICatPendingTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPendingTasks;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatPluginsRequest : IRequest<CatPluginsRequestParameters>
    {
    }

    public class CatPluginsRequest : PlainRequestBase<CatPluginsRequestParameters>, ICatPluginsRequest
    {
        protected ICatPluginsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatPlugins;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatRecoveryRequest : IRequest<CatRecoveryRequestParameters>
    {
    }

    public class CatRecoveryRequest : PlainRequestBase<CatRecoveryRequestParameters>, ICatRecoveryRequest
    {
        protected ICatRecoveryRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRecovery;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatRepositoriesRequest : IRequest<CatRepositoriesRequestParameters>
    {
    }

    public class CatRepositoriesRequest : PlainRequestBase<CatRepositoriesRequestParameters>, ICatRepositoriesRequest
    {
        protected ICatRepositoriesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatRepositories;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatSegmentsRequest : IRequest<CatSegmentsRequestParameters>
    {
    }

    public class CatSegmentsRequest : PlainRequestBase<CatSegmentsRequestParameters>, ICatSegmentsRequest
    {
        protected ICatSegmentsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSegments;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatShardsRequest : IRequest<CatShardsRequestParameters>
    {
    }

    public class CatShardsRequest : PlainRequestBase<CatShardsRequestParameters>, ICatShardsRequest
    {
        protected ICatShardsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatShards;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatSnapshotsRequest : IRequest<CatSnapshotsRequestParameters>
    {
    }

    public class CatSnapshotsRequest : PlainRequestBase<CatSnapshotsRequestParameters>, ICatSnapshotsRequest
    {
        protected ICatSnapshotsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatSnapshots;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatTasksRequest : IRequest<CatTasksRequestParameters>
    {
    }

    public class CatTasksRequest : PlainRequestBase<CatTasksRequestParameters>, ICatTasksRequest
    {
        protected ICatTasksRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTasks;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatTemplatesRequest : IRequest<CatTemplatesRequestParameters>
    {
    }

    public class CatTemplatesRequest : PlainRequestBase<CatTemplatesRequestParameters>, ICatTemplatesRequest
    {
        protected ICatTemplatesRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTemplates;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatThreadPoolRequest : IRequest<CatThreadPoolRequestParameters>
    {
    }

    public class CatThreadPoolRequest : PlainRequestBase<CatThreadPoolRequestParameters>, ICatThreadPoolRequest
    {
        protected ICatThreadPoolRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatThreadPool;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatTrainedModelsRequest : IRequest<CatTrainedModelsRequestParameters>
    {
    }

    public class CatTrainedModelsRequest : PlainRequestBase<CatTrainedModelsRequestParameters>, ICatTrainedModelsRequest
    {
        protected ICatTrainedModelsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatMlTrainedModels;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }

    public interface ICatTransformsRequest : IRequest<CatTransformsRequestParameters>
    {
    }

    public class CatTransformsRequest : PlainRequestBase<CatTransformsRequestParameters>, ICatTransformsRequest
    {
        protected ICatTransformsRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.CatTransforms;
        protected override HttpMethod HttpMethod => HttpMethod.GET;
        protected override bool SupportsBody => false;
    }
}