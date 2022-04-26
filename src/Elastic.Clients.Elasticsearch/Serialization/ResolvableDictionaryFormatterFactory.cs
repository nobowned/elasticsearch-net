// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch
{
	internal sealed class ResolvableDictionaryFormatterFactory : JsonConverterFactory
	{
		public override bool CanConvert(Type typeToConvert) => false;

		public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
	}
}