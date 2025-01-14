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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Features
{
	public class FeaturesNamespace : NamespacedClientProxy
	{
		internal FeaturesNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public FeaturesGetFeaturesResponse GetFeatures(FeaturesGetFeaturesRequest request)
		{
			request.BeforeRequest();
			return DoRequest<FeaturesGetFeaturesRequest, FeaturesGetFeaturesResponse>(request);
		}

		public Task<FeaturesGetFeaturesResponse> GetFeaturesAsync(FeaturesGetFeaturesRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<FeaturesGetFeaturesRequest, FeaturesGetFeaturesResponse>(request, cancellationToken);
		}

		public FeaturesGetFeaturesResponse GetFeatures(Action<FeaturesGetFeaturesRequestDescriptor> configureRequest = null)
		{
			var descriptor = new FeaturesGetFeaturesRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<FeaturesGetFeaturesRequestDescriptor, FeaturesGetFeaturesResponse>(descriptor);
		}

		public Task<FeaturesGetFeaturesResponse> GetFeaturesAsync(Action<FeaturesGetFeaturesRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new FeaturesGetFeaturesRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<FeaturesGetFeaturesRequestDescriptor, FeaturesGetFeaturesResponse>(descriptor);
		}
	}
}