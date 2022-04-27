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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class Pipeline
	{
		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("on_failure")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailure { get; set; }

		[JsonInclude]
		[JsonPropertyName("processors")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? Processors { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }
	}

	public sealed partial class PipelineDescriptor : SerializableDescriptorBase<PipelineDescriptor>
	{
		internal PipelineDescriptor(Action<PipelineDescriptor> configure) => configure.Invoke(this);
		public PipelineDescriptor() : base()
		{
		}

		private string? DescriptionValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? ProcessorsValue { get; set; }

		private long? VersionValue { get; set; }

		public PipelineDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public PipelineDescriptor OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure)
		{
			OnFailureValue = onFailure;
			return Self;
		}

		public PipelineDescriptor Processors(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? processors)
		{
			ProcessorsValue = processors;
			return Self;
		}

		public PipelineDescriptor Version(long? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (OnFailureValue is not null)
			{
				writer.WritePropertyName("on_failure");
				JsonSerializer.Serialize(writer, OnFailureValue, options);
			}

			if (ProcessorsValue is not null)
			{
				writer.WritePropertyName("processors");
				JsonSerializer.Serialize(writer, ProcessorsValue, options);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}
	}
}