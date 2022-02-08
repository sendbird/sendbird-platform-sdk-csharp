# sendbird_platform_sdk.Api.AdvancedAnalyticsApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveAdvancedAnalyticsMetrics**](AdvancedAnalyticsApi.md#retrieveadvancedanalyticsmetrics) | **GET** /v3/statistics/metric | Retrieve Advanced analytics metrics



## RetrieveAdvancedAnalyticsMetrics

> InlineResponse20062 RetrieveAdvancedAnalyticsMetrics (string apiToken = null)

Retrieve Advanced analytics metrics

## Retrieve Advanced analytics metrics  Retrieves Advanced analytics metrics based on the specified parameters. You can retrieve either daily or monthly metrics using the time_dimension parameter.  >__Note__: Daily metrics are calculated and updated every three hours, starting at 1 a.m. in UTC. Meanwhile, monthly metrics are calculated after the last day of the month.  https://sendbird.com/docs/chat/v3/platform-api/guides/advanced-analytics#2-retrieve-advanced-analytics-metrics - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RetrieveAdvancedAnalyticsMetricsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AdvancedAnalyticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Retrieve Advanced analytics metrics
                InlineResponse20062 result = apiInstance.RetrieveAdvancedAnalyticsMetrics(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdvancedAnalyticsApi.RetrieveAdvancedAnalyticsMetrics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20062**](InlineResponse20062.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

