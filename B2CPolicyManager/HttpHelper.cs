using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B2CPolicyManager
{
	class HttpHelper
	{
		protected HttpClient _httpClient;
		public AuthenticationHelperBase AuthenticationHelper { get; }

		public HttpHelper(
			AuthenticationHelperBase AuthenticationHelper,
			HttpClient httpClient = null
		)
		{
			this.AuthenticationHelper = AuthenticationHelper;
			this._httpClient = httpClient ?? new HttpClient();
		}

		public async Task<HttpResponseMessage> HttpGetAsync( string uri, CancellationToken cancellation = default )
		{
			var request = new HttpRequestMessage( HttpMethod.Get, uri );
			await AuthenticationHelper.AddHeadersAsync( request, cancellation: cancellation );
			var response = await _httpClient.SendAsync( request, HttpCompletionOption.ResponseContentRead, cancellationToken: cancellation );
			return response;
		}

		public async Task<HttpResponseMessage> HttpGetIDAsync( string uri, string id, CancellationToken cancellation = default )
		{
			string uriWithID = String.Format( uri, id );
			var request = new HttpRequestMessage( HttpMethod.Get, uriWithID );
			await AuthenticationHelper.AddHeadersAsync( request, cancellation: cancellation );
			var response = await _httpClient.SendAsync( request, HttpCompletionOption.ResponseContentRead, cancellationToken: cancellation );
			return response;
		}

		public async Task<HttpResponseMessage> HttpPutIDAsync( string uri, string id, string xml, CancellationToken cancellation = default )
		{
			string uriWithID = String.Format( uri, id );
			var request = new HttpRequestMessage( HttpMethod.Put, uriWithID );
			await AuthenticationHelper.AddHeadersAsync( request, cancellation: cancellation );
			request.Content = new StringContent( xml, Encoding.UTF8, "application/xml" );
			var response = await _httpClient.SendAsync( request, HttpCompletionOption.ResponseContentRead, cancellationToken: cancellation );
			return response;
		}

		public async Task<HttpResponseMessage> HttpDeleteIDAsync( string policyByIdURI, string id, CancellationToken cancellation = default )
		{
			string uriWithID = String.Format( policyByIdURI, id );
			var request = new HttpRequestMessage( HttpMethod.Delete, uriWithID );
			await AuthenticationHelper.AddHeadersAsync( request, cancellation: cancellation );
			var response = await _httpClient.SendAsync( request, HttpCompletionOption.ResponseContentRead, cancellationToken: cancellation );
			return response;
		}

	}
}
