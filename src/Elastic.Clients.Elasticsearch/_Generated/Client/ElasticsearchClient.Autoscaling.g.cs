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
namespace Elastic.Clients.Elasticsearch.Autoscaling
{
	public class AutoscalingNamespace : NamespacedClientProxy
	{
		internal AutoscalingNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public AutoscalingDeleteAutoscalingPolicyResponse DeleteAutoscalingPolicy(AutoscalingDeleteAutoscalingPolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AutoscalingDeleteAutoscalingPolicyRequest, AutoscalingDeleteAutoscalingPolicyResponse>(request);
		}

		public Task<AutoscalingDeleteAutoscalingPolicyResponse> DeleteAutoscalingPolicyAsync(AutoscalingDeleteAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AutoscalingDeleteAutoscalingPolicyRequest, AutoscalingDeleteAutoscalingPolicyResponse>(request, cancellationToken);
		}

		public AutoscalingDeleteAutoscalingPolicyResponse DeleteAutoscalingPolicy(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingDeleteAutoscalingPolicyRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AutoscalingDeleteAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AutoscalingDeleteAutoscalingPolicyRequestDescriptor, AutoscalingDeleteAutoscalingPolicyResponse>(descriptor);
		}

		public Task<AutoscalingDeleteAutoscalingPolicyResponse> DeleteAutoscalingPolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingDeleteAutoscalingPolicyRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AutoscalingDeleteAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AutoscalingDeleteAutoscalingPolicyRequestDescriptor, AutoscalingDeleteAutoscalingPolicyResponse>(descriptor);
		}

		public AutoscalingGetAutoscalingCapacityResponse GetAutoscalingCapacity(AutoscalingGetAutoscalingCapacityRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AutoscalingGetAutoscalingCapacityRequest, AutoscalingGetAutoscalingCapacityResponse>(request);
		}

		public Task<AutoscalingGetAutoscalingCapacityResponse> GetAutoscalingCapacityAsync(AutoscalingGetAutoscalingCapacityRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AutoscalingGetAutoscalingCapacityRequest, AutoscalingGetAutoscalingCapacityResponse>(request, cancellationToken);
		}

		public AutoscalingGetAutoscalingCapacityResponse GetAutoscalingCapacity(Action<AutoscalingGetAutoscalingCapacityRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AutoscalingGetAutoscalingCapacityRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AutoscalingGetAutoscalingCapacityRequestDescriptor, AutoscalingGetAutoscalingCapacityResponse>(descriptor);
		}

		public Task<AutoscalingGetAutoscalingCapacityResponse> GetAutoscalingCapacityAsync(Action<AutoscalingGetAutoscalingCapacityRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AutoscalingGetAutoscalingCapacityRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AutoscalingGetAutoscalingCapacityRequestDescriptor, AutoscalingGetAutoscalingCapacityResponse>(descriptor);
		}

		public AutoscalingGetAutoscalingPolicyResponse GetAutoscalingPolicy(AutoscalingGetAutoscalingPolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AutoscalingGetAutoscalingPolicyRequest, AutoscalingGetAutoscalingPolicyResponse>(request);
		}

		public Task<AutoscalingGetAutoscalingPolicyResponse> GetAutoscalingPolicyAsync(AutoscalingGetAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AutoscalingGetAutoscalingPolicyRequest, AutoscalingGetAutoscalingPolicyResponse>(request, cancellationToken);
		}

		public AutoscalingGetAutoscalingPolicyResponse GetAutoscalingPolicy(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingGetAutoscalingPolicyRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AutoscalingGetAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AutoscalingGetAutoscalingPolicyRequestDescriptor, AutoscalingGetAutoscalingPolicyResponse>(descriptor);
		}

		public Task<AutoscalingGetAutoscalingPolicyResponse> GetAutoscalingPolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingGetAutoscalingPolicyRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AutoscalingGetAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AutoscalingGetAutoscalingPolicyRequestDescriptor, AutoscalingGetAutoscalingPolicyResponse>(descriptor);
		}

		public AutoscalingPutAutoscalingPolicyResponse PutAutoscalingPolicy(AutoscalingPutAutoscalingPolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<AutoscalingPutAutoscalingPolicyRequest, AutoscalingPutAutoscalingPolicyResponse>(request);
		}

		public Task<AutoscalingPutAutoscalingPolicyResponse> PutAutoscalingPolicyAsync(AutoscalingPutAutoscalingPolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<AutoscalingPutAutoscalingPolicyRequest, AutoscalingPutAutoscalingPolicyResponse>(request, cancellationToken);
		}

		public AutoscalingPutAutoscalingPolicyResponse PutAutoscalingPolicy(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingPutAutoscalingPolicyRequestDescriptor> configureRequest = null)
		{
			var descriptor = new AutoscalingPutAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<AutoscalingPutAutoscalingPolicyRequestDescriptor, AutoscalingPutAutoscalingPolicyResponse>(descriptor);
		}

		public Task<AutoscalingPutAutoscalingPolicyResponse> PutAutoscalingPolicyAsync(Elastic.Clients.Elasticsearch.Name name, Action<AutoscalingPutAutoscalingPolicyRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new AutoscalingPutAutoscalingPolicyRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<AutoscalingPutAutoscalingPolicyRequestDescriptor, AutoscalingPutAutoscalingPolicyResponse>(descriptor);
		}
	}
}