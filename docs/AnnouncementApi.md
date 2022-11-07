# sendbird_platform_sdk.Api.AnnouncementApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDetailedOpenRateOfAnnouncementGroup**](AnnouncementApi.md#getdetailedopenrateofannouncementgroup) | **GET** /v3/announcement_open_rate_by_group/{announcement_group} | Get detailed open rate of an announcement group
[**GetStatistics**](AnnouncementApi.md#getstatistics) | **GET** /v3/announcement_stats/weekly | Get statistics - weekly
[**GetStatisticsDaily**](AnnouncementApi.md#getstatisticsdaily) | **GET** /v3/announcement_stats/daily | Get statistics - daily
[**GetStatisticsMonthly**](AnnouncementApi.md#getstatisticsmonthly) | **GET** /v3/announcement_stats/monthly | Get statistics - monthly
[**ListAnnouncementGroups**](AnnouncementApi.md#listannouncementgroups) | **GET** /v3/announcement_group | List announcement groups
[**ScheduleAnnouncement**](AnnouncementApi.md#scheduleannouncement) | **POST** /v3/announcements | Schedule an announcement
[**UpdateAnnouncementById**](AnnouncementApi.md#updateannouncementbyid) | **PUT** /v3/announcements/{unique_id} | Update an announcement
[**ViewAnnouncementById**](AnnouncementApi.md#viewannouncementbyid) | **GET** /v3/announcements/{unique_id} | View an announcement



## GetDetailedOpenRateOfAnnouncementGroup

> GetDetailedOpenRateOfAnnouncementGroupResponse GetDetailedOpenRateOfAnnouncementGroup (string apiToken, string announcementGroup)

Get detailed open rate of an announcement group

## Get detailed open rate of an announcement group  Retrieves the detailed open rate information of an announcement group.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-detailed-open-rate-of-an-announcement-group - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetDetailedOpenRateOfAnnouncementGroupExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var announcementGroup = "announcementGroup_example";  // string | 

            try
            {
                // Get detailed open rate of an announcement group
                GetDetailedOpenRateOfAnnouncementGroupResponse result = apiInstance.GetDetailedOpenRateOfAnnouncementGroup(apiToken, announcementGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.GetDetailedOpenRateOfAnnouncementGroup: " + e.Message );
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
 **announcementGroup** | **string**|  | 

### Return type

[**GetDetailedOpenRateOfAnnouncementGroupResponse**](GetDetailedOpenRateOfAnnouncementGroupResponse.md)

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


## GetStatistics

> GetStatisticsResponse GetStatistics (string apiToken)

Get statistics - weekly

## Get statistics  Retrieves the daily, weekly or monthly statistics of an announcement or an announcement group.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-statistics - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // Get statistics - weekly
                GetStatisticsResponse result = apiInstance.GetStatistics(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.GetStatistics: " + e.Message );
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

[**GetStatisticsResponse**](GetStatisticsResponse.md)

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


## GetStatisticsDaily

> GetStatisticsDailyResponse GetStatisticsDaily (string apiToken, string startDate, string endDate, string startWeek, string endWeek, string startMonth, string endMonth, string announcementGroup = null)

Get statistics - daily

## Get statistics  Retrieves the daily, weekly or monthly statistics of an announcement or an announcement group.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-statistics - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetStatisticsDailyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var startDate = "startDate_example";  // string | 
            var endDate = "endDate_example";  // string | 
            var startWeek = "startWeek_example";  // string | 
            var endWeek = "endWeek_example";  // string | 
            var startMonth = "startMonth_example";  // string | 
            var endMonth = "endMonth_example";  // string | 
            var announcementGroup = "announcementGroup_example";  // string |  (optional) 

            try
            {
                // Get statistics - daily
                GetStatisticsDailyResponse result = apiInstance.GetStatisticsDaily(apiToken, startDate, endDate, startWeek, endWeek, startMonth, endMonth, announcementGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.GetStatisticsDaily: " + e.Message );
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
 **startDate** | **string**|  | 
 **endDate** | **string**|  | 
 **startWeek** | **string**|  | 
 **endWeek** | **string**|  | 
 **startMonth** | **string**|  | 
 **endMonth** | **string**|  | 
 **announcementGroup** | **string**|  | [optional] 

### Return type

[**GetStatisticsDailyResponse**](GetStatisticsDailyResponse.md)

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


## GetStatisticsMonthly

> GetStatisticsMonthlyResponse GetStatisticsMonthly (string apiToken)

Get statistics - monthly

## Get statistics  Retrieves the daily, weekly or monthly statistics of an announcement or an announcement group.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-get-statistics - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetStatisticsMonthlyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // Get statistics - monthly
                GetStatisticsMonthlyResponse result = apiInstance.GetStatisticsMonthly(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.GetStatisticsMonthly: " + e.Message );
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

[**GetStatisticsMonthlyResponse**](GetStatisticsMonthlyResponse.md)

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


## ListAnnouncementGroups

> ListAnnouncementGroupsResponse ListAnnouncementGroups (string apiToken, string token = null, int? limit = null)

List announcement groups

## List announcement groups  Retrieves a list of announcement groups.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-list-announcement-groups - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListAnnouncementGroupsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List announcement groups
                ListAnnouncementGroupsResponse result = apiInstance.ListAnnouncementGroups(apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.ListAnnouncementGroups: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**ListAnnouncementGroupsResponse**](ListAnnouncementGroupsResponse.md)

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


## ScheduleAnnouncement

> ScheduleAnnouncementResponse ScheduleAnnouncement (string apiToken, ScheduleAnnouncementData scheduleAnnouncementData = null)

Schedule an announcement

## Schedule an announcement  Schedules a new announcement. You can also schedule an announcement in the [Sendbird Dashboard](https://dashboard.sendbird.com).  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-schedule-an-announcement

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ScheduleAnnouncementExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var scheduleAnnouncementData = new ScheduleAnnouncementData(); // ScheduleAnnouncementData |  (optional) 

            try
            {
                // Schedule an announcement
                ScheduleAnnouncementResponse result = apiInstance.ScheduleAnnouncement(apiToken, scheduleAnnouncementData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.ScheduleAnnouncement: " + e.Message );
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
 **scheduleAnnouncementData** | [**ScheduleAnnouncementData**](ScheduleAnnouncementData.md)|  | [optional] 

### Return type

[**ScheduleAnnouncementResponse**](ScheduleAnnouncementResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateAnnouncementById

> UpdateAnnouncementByIdResponse UpdateAnnouncementById (string apiToken, string uniqueId, UpdateAnnouncementByIdData updateAnnouncementByIdData = null)

Update an announcement

## Update an announcement  Updates information of a specific announcement before it starts or changes the status of a specific announcement after it starts. For the 2 different applications, refer to the request body below.  >__Note__: Updating information of an announcement is possible only when the announcement status is scheduled, indicating it hasn't started yet.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-update-an-announcement - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAnnouncementByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var uniqueId = "uniqueId_example";  // string | 
            var updateAnnouncementByIdData = new UpdateAnnouncementByIdData(); // UpdateAnnouncementByIdData |  (optional) 

            try
            {
                // Update an announcement
                UpdateAnnouncementByIdResponse result = apiInstance.UpdateAnnouncementById(apiToken, uniqueId, updateAnnouncementByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.UpdateAnnouncementById: " + e.Message );
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
 **updateAnnouncementByIdData** | [**UpdateAnnouncementByIdData**](UpdateAnnouncementByIdData.md)|  | [optional] 

### Return type

[**UpdateAnnouncementByIdResponse**](UpdateAnnouncementByIdResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ViewAnnouncementById

> ViewAnnouncementByIdResponse ViewAnnouncementById (string apiToken, string uniqueId)

View an announcement

## View an announcement  Retrieves information on a specific announcement.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-view-an-announcement - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewAnnouncementByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var uniqueId = "uniqueId_example";  // string | 

            try
            {
                // View an announcement
                ViewAnnouncementByIdResponse result = apiInstance.ViewAnnouncementById(apiToken, uniqueId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.ViewAnnouncementById: " + e.Message );
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

[**ViewAnnouncementByIdResponse**](ViewAnnouncementByIdResponse.md)

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

