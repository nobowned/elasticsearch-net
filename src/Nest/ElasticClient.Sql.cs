// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.SqlApi;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.SqlApi
{
	///<summary>
	/// Sql APIs.
	/// <para>Not intended to be instantiated directly. Use the <see cref = "IElasticClient.Sql"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class SqlNamespace : NamespacedClientProxy
	{
		internal SqlNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</a>
		/// </summary>
		public ClearSqlCursorResponse ClearCursor(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector) => ClearCursor(selector.InvokeOrDefault(new ClearSqlCursorDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</a>
		/// </summary>
		public Task<ClearSqlCursorResponse> ClearCursorAsync(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector, CancellationToken ct = default) => ClearCursorAsync(selector.InvokeOrDefault(new ClearSqlCursorDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</a>
		/// </summary>
		public ClearSqlCursorResponse ClearCursor(IClearSqlCursorRequest request) => DoRequest<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-pagination.html</a>
		/// </summary>
		public Task<ClearSqlCursorResponse> ClearCursorAsync(IClearSqlCursorRequest request, CancellationToken ct = default) => DoRequestAsync<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>sql.delete_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</a>
		/// </summary>
		public SqlDeleteResponse Delete(Id id, Func<SqlDeleteDescriptor, ISqlDeleteRequest> selector = null) => Delete(selector.InvokeOrDefault(new SqlDeleteDescriptor(id: id)));
		/// <summary>
		/// <c>DELETE</c> request to the <c>sql.delete_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</a>
		/// </summary>
		public Task<SqlDeleteResponse> DeleteAsync(Id id, Func<SqlDeleteDescriptor, ISqlDeleteRequest> selector = null, CancellationToken ct = default) => DeleteAsync(selector.InvokeOrDefault(new SqlDeleteDescriptor(id: id)), ct);
		/// <summary>
		/// <c>DELETE</c> request to the <c>sql.delete_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</a>
		/// </summary>
		public SqlDeleteResponse Delete(ISqlDeleteRequest request) => DoRequest<ISqlDeleteRequest, SqlDeleteResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>DELETE</c> request to the <c>sql.delete_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-async-sql-search-api.html</a>
		/// </summary>
		public Task<SqlDeleteResponse> DeleteAsync(ISqlDeleteRequest request, CancellationToken ct = default) => DoRequestAsync<ISqlDeleteRequest, SqlDeleteResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</a>
		/// </summary>
		public SqlGetResponse Get(Id id, Func<SqlGetDescriptor, ISqlGetRequest> selector = null) => Get(selector.InvokeOrDefault(new SqlGetDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</a>
		/// </summary>
		public Task<SqlGetResponse> GetAsync(Id id, Func<SqlGetDescriptor, ISqlGetRequest> selector = null, CancellationToken ct = default) => GetAsync(selector.InvokeOrDefault(new SqlGetDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</a>
		/// </summary>
		public SqlGetResponse Get(ISqlGetRequest request) => DoRequest<ISqlGetRequest, SqlGetResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-api.html</a>
		/// </summary>
		public Task<SqlGetResponse> GetAsync(ISqlGetRequest request, CancellationToken ct = default) => DoRequestAsync<ISqlGetRequest, SqlGetResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</a>
		/// </summary>
		public SqlSearchStatusResponse SearchStatus(Id id, Func<SqlSearchStatusDescriptor, ISqlSearchStatusRequest> selector = null) => SearchStatus(selector.InvokeOrDefault(new SqlSearchStatusDescriptor(id: id)));
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</a>
		/// </summary>
		public Task<SqlSearchStatusResponse> SearchStatusAsync(Id id, Func<SqlSearchStatusDescriptor, ISqlSearchStatusRequest> selector = null, CancellationToken ct = default) => SearchStatusAsync(selector.InvokeOrDefault(new SqlSearchStatusDescriptor(id: id)), ct);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</a>
		/// </summary>
		public SqlSearchStatusResponse SearchStatus(ISqlSearchStatusRequest request) => DoRequest<ISqlSearchStatusRequest, SqlSearchStatusResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>GET</c> request to the <c>sql.get_async_status</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html">https://www.elastic.co/guide/en/elasticsearch/reference/master/get-async-sql-search-status-api.html</a>
		/// </summary>
		public Task<SqlSearchStatusResponse> SearchStatusAsync(ISqlSearchStatusRequest request, CancellationToken ct = default) => DoRequestAsync<ISqlSearchStatusRequest, SqlSearchStatusResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</a>
		/// </summary>
		public QuerySqlResponse Query(Func<QuerySqlDescriptor, IQuerySqlRequest> selector = null) => Query(selector.InvokeOrDefault(new QuerySqlDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</a>
		/// </summary>
		public Task<QuerySqlResponse> QueryAsync(Func<QuerySqlDescriptor, IQuerySqlRequest> selector = null, CancellationToken ct = default) => QueryAsync(selector.InvokeOrDefault(new QuerySqlDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</a>
		/// </summary>
		public QuerySqlResponse Query(IQuerySqlRequest request) => DoRequest<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-rest-overview.html</a>
		/// </summary>
		public Task<QuerySqlResponse> QueryAsync(IQuerySqlRequest request, CancellationToken ct = default) => DoRequestAsync<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</a>
		/// </summary>
		public TranslateSqlResponse Translate(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector = null) => Translate(selector.InvokeOrDefault(new TranslateSqlDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</a>
		/// </summary>
		public Task<TranslateSqlResponse> TranslateAsync(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector = null, CancellationToken ct = default) => TranslateAsync(selector.InvokeOrDefault(new TranslateSqlDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</a>
		/// </summary>
		public TranslateSqlResponse Translate(ITranslateSqlRequest request) => DoRequest<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para></para>
		/// <a href = "https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html">https://www.elastic.co/guide/en/elasticsearch/reference/current/sql-translate.html</a>
		/// </summary>
		public Task<TranslateSqlResponse> TranslateAsync(ITranslateSqlRequest request, CancellationToken ct = default) => DoRequestAsync<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters, ct);
	}
}