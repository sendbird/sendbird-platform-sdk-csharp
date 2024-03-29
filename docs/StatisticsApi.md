# sendbird_platform_sdk.Api.StatisticsApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDetailedOpenRateOfAnnouncementById**](StatisticsApi.md#getdetailedopenrateofannouncementbyid) | **GET** /v3/announcement_open_rate/{unique_id} | Get detailed open rate of an announcement
[**GetDetailedOpenStatusOfAnnouncementById**](StatisticsApi.md#getdetailedopenstatusofannouncementbyid) | **GET** /v3/announcement_open_status/{unique_id} | Get detailed open status of an announcement
[**RetrieveAdvancedAnalyticsMetrics**](StatisticsApi.md#retrieveadvancedanalyticsmetrics) | **GET** /v3/statistics/metric | Retrieve Advanced analytics metrics
[**ViewNumberOfConcurrentConnections**](StatisticsApi.md#viewnumberofconcurrentconnections) | **GET** /v3/applications/ccu | View number of concurrent connections
[**ViewNumberOfDailyActiveUsers**](StatisticsApi.md#viewnumberofdailyactiveusers) | **GET** /v3/applications/dau | View number of daily active users
[**ViewNumberOfMonthlyActiveUsers**](StatisticsApi.md#viewnumberofmonthlyactiveusers) | **GET** /v3/applications/mau | View number of monthly active users
[**ViewNumberOfPeakConnections**](StatisticsApi.md#viewnumberofpeakconnections) | **GET** /v3/applications/peak_connections | View number of peak connections



## GetDetailedOpenRateOfAnnouncementById

> GetDetailedOpenRateOfAnnouncementByIdResponse GetDetailedOpenRateOfAnnouncementById (string apiToken, string uniqueId)

Get detailed open rate of an announcement

## Get detailed open rate of an announcement  Retrieves the detailed open rate information of an announcement.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-detailed-open-rate-of-an-announcement - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `unique_id`      Type: string      Description: Specifies the unique ID of the announcement to get its open rate.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetDetailedOpenRateOfAnnouncementByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var uniqueId = "uniqueId_example";  // string | 

            try
            {
                // Get detailed open rate of an announcement
                GetDetailedOpenRateOfAnnouncementByIdResponse result = apiInstance.GetDetailedOpenRateOfAnnouncementById(apiToken, uniqueId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetDetailedOpenRateOfAnnouncementById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **uniqueId** | **string**|  | 

### Return type

[**GetDetailedOpenRateOfAnnouncementByIdResponse**](GetDetailedOpenRateOfAnnouncementByIdResponse.md)

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


## GetDetailedOpenStatusOfAnnouncementById

> GetDetailedOpenStatusOfAnnouncementByIdResponse GetDetailedOpenStatusOfAnnouncementById (string apiToken, string uniqueId, int? limit = null, string next = null, List<string> uniqueIds = null, List<string> channelUrls = null, bool? hasOpened = null)

Get detailed open status of an announcement

## Get detailed open status of an announcement  Retrieves the detailed open status information of a specific announcement.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-detailed-open-status-of-an-announcement - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetDetailedOpenStatusOfAnnouncementByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var uniqueId = "uniqueId_example";  // string | 
            var limit = 56;  // int? |  (optional) 
            var next = "next_example";  // string |  (optional) 
            var uniqueIds = new List<string>(); // List<string> |  (optional) 
            var channelUrls = new List<string>(); // List<string> |  (optional) 
            var hasOpened = true;  // bool? |  (optional) 

            try
            {
                // Get detailed open status of an announcement
                GetDetailedOpenStatusOfAnnouncementByIdResponse result = apiInstance.GetDetailedOpenStatusOfAnnouncementById(apiToken, uniqueId, limit, next, uniqueIds, channelUrls, hasOpened);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetDetailedOpenStatusOfAnnouncementById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **uniqueId** | **string**|  | 
 **limit** | **int?**|  | [optional] 
 **next** | **string**|  | [optional] 
 **uniqueIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **channelUrls** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **hasOpened** | **bool?**|  | [optional] 

### Return type

[**GetDetailedOpenStatusOfAnnouncementByIdResponse**](GetDetailedOpenStatusOfAnnouncementByIdResponse.md)

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


## RetrieveAdvancedAnalyticsMetrics

> RetrieveAdvancedAnalyticsMetricsResponse RetrieveAdvancedAnalyticsMetrics (string apiToken)

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
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // Retrieve Advanced analytics metrics
                RetrieveAdvancedAnalyticsMetricsResponse result = apiInstance.RetrieveAdvancedAnalyticsMetrics(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.RetrieveAdvancedAnalyticsMetrics: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**RetrieveAdvancedAnalyticsMetricsResponse**](RetrieveAdvancedAnalyticsMetricsResponse.md)

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


## ViewNumberOfConcurrentConnections

> ViewNumberOfConcurrentConnectionsResponse ViewNumberOfConcurrentConnections (string apiToken)

View number of concurrent connections

## View number of concurrent connections  Retrieves the number of devices and opened browser tabs which are currently connected to Sendbird server.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-concurrent-connections

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfConcurrentConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // View number of concurrent connections
                ViewNumberOfConcurrentConnectionsResponse result = apiInstance.ViewNumberOfConcurrentConnections(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.ViewNumberOfConcurrentConnections: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**ViewNumberOfConcurrentConnectionsResponse**](ViewNumberOfConcurrentConnectionsResponse.md)

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


## ViewNumberOfDailyActiveUsers

> ViewNumberOfDailyActiveUsersResponse ViewNumberOfDailyActiveUsers (string apiToken, string date = null)

View number of daily active users

## View number of daily active users  Retrieves the number of daily active users of the application (DAU).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-daily-active-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfDailyActiveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var date = "date_example";  // string |  (optional) 

            try
            {
                // View number of daily active users
                ViewNumberOfDailyActiveUsersResponse result = apiInstance.ViewNumberOfDailyActiveUsers(apiToken, date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.ViewNumberOfDailyActiveUsers: " + e.Message );
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
 **apiToken** | **string**|  | 
 **date** | **string**|  | [optional] 

### Return type

[**ViewNumberOfDailyActiveUsersResponse**](ViewNumberOfDailyActiveUsersResponse.md)

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


## ViewNumberOfMonthlyActiveUsers

> ViewNumberOfMonthlyActiveUsersResponse ViewNumberOfMonthlyActiveUsers (string apiToken, string date = null)

View number of monthly active users

## View number of monthly active users  Retrieves the number of monthly active users of the application (MAU).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-monthly-active-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfMonthlyActiveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var date = "date_example";  // string |  (optional) 

            try
            {
                // View number of monthly active users
                ViewNumberOfMonthlyActiveUsersResponse result = apiInstance.ViewNumberOfMonthlyActiveUsers(apiToken, date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.ViewNumberOfMonthlyActiveUsers: " + e.Message );
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
 **apiToken** | **string**|  | 
 **date** | **string**|  | [optional] 

### Return type

[**ViewNumberOfMonthlyActiveUsersResponse**](ViewNumberOfMonthlyActiveUsersResponse.md)

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


## ViewNumberOfPeakConnections

> ViewNumberOfPeakConnectionsResponse ViewNumberOfPeakConnections (string apiToken, string timeDimension, int startYear, int startMonth, int endYear, int endMonth, int? startDay = null, int? endDay = null)

View number of peak connections

## View number of peak connections  Retrieves the number of concurrently connected devices to Sendbird server during the requested time period.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-peak-connections - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfPeakConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new StatisticsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var timeDimension = "timeDimension_example";  // string | 
            var startYear = 56;  // int | 
            var startMonth = 56;  // int | 
            var endYear = 56;  // int | 
            var endMonth = 56;  // int | 
            var startDay = 56;  // int? |  (optional) 
            var endDay = 56;  // int? |  (optional) 

            try
            {
                // View number of peak connections
                ViewNumberOfPeakConnectionsResponse result = apiInstance.ViewNumberOfPeakConnections(apiToken, timeDimension, startYear, startMonth, endYear, endMonth, startDay, endDay);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatisticsApi.ViewNumberOfPeakConnections: " + e.Message );
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
 **apiToken** | **string**|  | 
 **timeDimension** | **string**|  | 
 **startYear** | **int**|  | 
 **startMonth** | **int**|  | 
 **endYear** | **int**|  | 
 **endMonth** | **int**|  | 
 **startDay** | **int?**|  | [optional] 
 **endDay** | **int?**|  | [optional] 

### Return type

[**ViewNumberOfPeakConnectionsResponse**](ViewNumberOfPeakConnectionsResponse.md)

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

