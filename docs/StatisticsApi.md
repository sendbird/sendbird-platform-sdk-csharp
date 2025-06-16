# sendbird_platform_sdk.Api.StatisticsApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewNumberOfDailyActiveUsers**](StatisticsApi.md#viewnumberofdailyactiveusers) | **GET** /v3/applications/dau | View number of daily active users
[**ViewNumberOfMonthlyActiveUsers**](StatisticsApi.md#viewnumberofmonthlyactiveusers) | **GET** /v3/applications/mau | View number of monthly active users



## ViewNumberOfDailyActiveUsers

> ViewNumberOfDailyActiveUsersResponse ViewNumberOfDailyActiveUsers (string date = null, string apiToken = null)

View number of daily active users

## View number of daily active users  Retrieves the number of daily active users of an application.  > **Note**: This metric is scheduled to be calculated every 30 minutes, starting at 00:00 UTC, with the first update at 00:30 UTC.      [https://sendbird.com/docs/chat/platform-api/v3/statistics/daus-and-maus/get-number-of-daily-active-users#1-get-number-of-daily-active-users](https://sendbird.com/docs/chat/platform-api/v3/statistics/daus-and-maus/get-number-of-daily-active-users#1-get-number-of-daily-active-users)

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
            var date = "date_example";  // string | YYYY-MM-DD (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View number of daily active users
                ViewNumberOfDailyActiveUsersResponse result = apiInstance.ViewNumberOfDailyActiveUsers(date, apiToken);
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
 **date** | **string**| YYYY-MM-DD | [optional] 
 **apiToken** | **string**|  | [optional] 

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

> ViewNumberOfMonthlyActiveUsersResponse ViewNumberOfMonthlyActiveUsers (string date = null, string apiToken = null)

View number of monthly active users

## View number of monthly active users  Retrieves the number of monthly active users of an application.  > **Note**: This metric is scheduled to be calculated every 30 minutes, starting at 00:00 UTC, with the first update at 00:30 UTC.      [https://sendbird.com/docs/chat/platform-api/v3/statistics/daus-and-maus/get-number-of-monthly-active-users#1-get-number-of-monthly-active-users](https://sendbird.com/docs/chat/platform-api/v3/statistics/daus-and-maus/get-number-of-monthly-active-users#1-get-number-of-monthly-active-users)

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
            var date = "date_example";  // string | YYYY-MM-DD (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View number of monthly active users
                ViewNumberOfMonthlyActiveUsersResponse result = apiInstance.ViewNumberOfMonthlyActiveUsers(date, apiToken);
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
 **date** | **string**| YYYY-MM-DD | [optional] 
 **apiToken** | **string**|  | [optional] 

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

