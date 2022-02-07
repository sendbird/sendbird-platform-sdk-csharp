/*
 * Sendbird Platform SDK
 *
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using sendbird-platform-sdk.Client;
using sendbird-platform-sdk.Model;

namespace sendbird-platform-sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAdvancedAnalyticsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Advanced analytics metrics
        /// </summary>
        /// <remarks>
        /// ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </remarks>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <returns>InlineResponse20062</returns>
        InlineResponse20062 RetrieveAdvancedAnalyticsMetrics (string apiToken = default(string));

        /// <summary>
        /// Retrieve Advanced analytics metrics
        /// </summary>
        /// <remarks>
        /// ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </remarks>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <returns>ApiResponse of InlineResponse20062</returns>
        ApiResponse<InlineResponse20062> RetrieveAdvancedAnalyticsMetricsWithHttpInfo (string apiToken = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Advanced analytics metrics
        /// </summary>
        /// <remarks>
        /// ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </remarks>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse20062</returns>
        System.Threading.Tasks.Task<InlineResponse20062> RetrieveAdvancedAnalyticsMetricsAsync (string apiToken = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve Advanced analytics metrics
        /// </summary>
        /// <remarks>
        /// ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </remarks>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse20062)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20062>> RetrieveAdvancedAnalyticsMetricsWithHttpInfoAsync (string apiToken = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AdvancedAnalyticsApi : IAdvancedAnalyticsApi
    {
        private sendbird-platform-sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedAnalyticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AdvancedAnalyticsApi(String basePath)
        {
            this.Configuration = new sendbird-platform-sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = sendbird-platform-sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedAnalyticsApi"/> class
        /// </summary>
        /// <returns></returns>
        public AdvancedAnalyticsApi()
        {
            this.Configuration = sendbird-platform-sdk.Client.Configuration.Default;

            ExceptionFactory = sendbird-platform-sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedAnalyticsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AdvancedAnalyticsApi(sendbird-platform-sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = sendbird-platform-sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = sendbird-platform-sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public sendbird-platform-sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public sendbird-platform-sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve Advanced analytics metrics ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </summary>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <returns>InlineResponse20062</returns>
        public InlineResponse20062 RetrieveAdvancedAnalyticsMetrics (string apiToken = default(string))
        {
             ApiResponse<InlineResponse20062> localVarResponse = RetrieveAdvancedAnalyticsMetricsWithHttpInfo(apiToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Advanced analytics metrics ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </summary>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <returns>ApiResponse of InlineResponse20062</returns>
        public ApiResponse<InlineResponse20062> RetrieveAdvancedAnalyticsMetricsWithHttpInfo (string apiToken = default(string))
        {

            var localVarPath = "/v3/statistics/metric";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiToken != null) localVarHeaderParams.Add("Api-Token", this.Configuration.ApiClient.ParameterToString(apiToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveAdvancedAnalyticsMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20062>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20062) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20062)));
        }

        /// <summary>
        /// Retrieve Advanced analytics metrics ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </summary>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of InlineResponse20062</returns>
        public async System.Threading.Tasks.Task<InlineResponse20062> RetrieveAdvancedAnalyticsMetricsAsync (string apiToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<InlineResponse20062> localVarResponse = await RetrieveAdvancedAnalyticsMetricsWithHttpInfoAsync(apiToken, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve Advanced analytics metrics ## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  &gt;__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -
        /// </summary>
        /// <exception cref="sendbird-platform-sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiToken"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (InlineResponse20062)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20062>> RetrieveAdvancedAnalyticsMetricsWithHttpInfoAsync (string apiToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/v3/statistics/metric";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiToken != null) localVarHeaderParams.Add("Api-Token", this.Configuration.ApiClient.ParameterToString(apiToken)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RetrieveAdvancedAnalyticsMetrics", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20062>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20062) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20062)));
        }

    }
}
