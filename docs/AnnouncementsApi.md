# sendbird_platform_sdk.Api.AnnouncementsApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDetailedOpenRateOfAnnouncementById**](AnnouncementsApi.md#getdetailedopenrateofannouncementbyid) | **GET** /v3/announcement_open_rate/{unique_id} | Get detailed open rate of an announcement
[**GetDetailedOpenRateOfAnnouncementGroup**](AnnouncementsApi.md#getdetailedopenrateofannouncementgroup) | **GET** /v3/announcement_open_rate_by_group/{announcement_group} | Get detailed open rate of an announcement group
[**GetDetailedOpenStatusOfAnnouncementById**](AnnouncementsApi.md#getdetailedopenstatusofannouncementbyid) | **GET** /v3/announcement_open_status/{unique_id} | Get detailed open status of an announcement
[**GetStatistics**](AnnouncementsApi.md#getstatistics) | **GET** /v3/announcement_stats/weekly | Get statistics - weekly
[**GetStatisticsDaily**](AnnouncementsApi.md#getstatisticsdaily) | **GET** /v3/announcement_stats/daily | Get statistics - daily
[**GetStatisticsMonthly**](AnnouncementsApi.md#getstatisticsmonthly) | **GET** /v3/announcement_stats/monthly | Get statistics - monthly
[**ListAnnouncementGroups**](AnnouncementsApi.md#listannouncementgroups) | **GET** /v3/announcement_group | List announcement groups
[**ListAnnouncements**](AnnouncementsApi.md#listannouncements) | **GET** /v3/announcements | List announcements
[**ScheduleAnnouncement**](AnnouncementsApi.md#scheduleannouncement) | **POST** /v3/announcements | Schedule an announcement
[**UpdateAnnouncementById**](AnnouncementsApi.md#updateannouncementbyid) | **PUT** /v3/announcements/{unique_id} | Update an announcement
[**ViewAnnouncementById**](AnnouncementsApi.md#viewannouncementbyid) | **GET** /v3/announcements/{unique_id} | View an announcement



## GetDetailedOpenRateOfAnnouncementById

> InlineResponse20042 GetDetailedOpenRateOfAnnouncementById (string uniqueId, string apiToken = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var uniqueId = uniqueId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get detailed open rate of an announcement
                InlineResponse20042 result = apiInstance.GetDetailedOpenRateOfAnnouncementById(uniqueId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetDetailedOpenRateOfAnnouncementById: " + e.Message );
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
 **uniqueId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20042**](InlineResponse20042.md)

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


## GetDetailedOpenRateOfAnnouncementGroup

> InlineResponse20046 GetDetailedOpenRateOfAnnouncementGroup (string announcementGroup, string apiToken = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var announcementGroup = announcementGroup_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get detailed open rate of an announcement group
                InlineResponse20046 result = apiInstance.GetDetailedOpenRateOfAnnouncementGroup(announcementGroup, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetDetailedOpenRateOfAnnouncementGroup: " + e.Message );
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
 **announcementGroup** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20046**](InlineResponse20046.md)

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

> InlineResponse20043 GetDetailedOpenStatusOfAnnouncementById (string uniqueId, string apiToken = null, int? limit = null, string next = null, List<string> uniqueIds = null, List<string> channelUrls = null, bool? hasOpened = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var uniqueId = uniqueId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var next = next_example;  // string |  (optional) 
            var uniqueIds = new List<string>(); // List<string> |  (optional) 
            var channelUrls = new List<string>(); // List<string> |  (optional) 
            var hasOpened = true;  // bool? |  (optional) 

            try
            {
                // Get detailed open status of an announcement
                InlineResponse20043 result = apiInstance.GetDetailedOpenStatusOfAnnouncementById(uniqueId, apiToken, limit, next, uniqueIds, channelUrls, hasOpened);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetDetailedOpenStatusOfAnnouncementById: " + e.Message );
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
 **uniqueId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **next** | **string**|  | [optional] 
 **uniqueIds** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **channelUrls** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **hasOpened** | **bool?**|  | [optional] 

### Return type

[**InlineResponse20043**](InlineResponse20043.md)

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

> InlineResponse20044 GetStatistics (string apiToken = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get statistics - weekly
                InlineResponse20044 result = apiInstance.GetStatistics(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetStatistics: " + e.Message );
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

[**InlineResponse20044**](InlineResponse20044.md)

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

> InlineResponse20044 GetStatisticsDaily (string startDate, string endDate, string startWeek, string endWeek, string startMonth, string endMonth, string apiToken = null, string announcementGroup = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var startDate = startDate_example;  // string | 
            var endDate = endDate_example;  // string | 
            var startWeek = startWeek_example;  // string | 
            var endWeek = endWeek_example;  // string | 
            var startMonth = startMonth_example;  // string | 
            var endMonth = endMonth_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var announcementGroup = announcementGroup_example;  // string |  (optional) 

            try
            {
                // Get statistics - daily
                InlineResponse20044 result = apiInstance.GetStatisticsDaily(startDate, endDate, startWeek, endWeek, startMonth, endMonth, apiToken, announcementGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetStatisticsDaily: " + e.Message );
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
 **startDate** | **string**|  | 
 **endDate** | **string**|  | 
 **startWeek** | **string**|  | 
 **endWeek** | **string**|  | 
 **startMonth** | **string**|  | 
 **endMonth** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **announcementGroup** | **string**|  | [optional] 

### Return type

[**InlineResponse20044**](InlineResponse20044.md)

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

> InlineResponse20044 GetStatisticsMonthly (string apiToken = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get statistics - monthly
                InlineResponse20044 result = apiInstance.GetStatisticsMonthly(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.GetStatisticsMonthly: " + e.Message );
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

[**InlineResponse20044**](InlineResponse20044.md)

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

> InlineResponse20045 ListAnnouncementGroups (string apiToken = null, string token = null, int? limit = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List announcement groups
                InlineResponse20045 result = apiInstance.ListAnnouncementGroups(apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.ListAnnouncementGroups: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20045**](InlineResponse20045.md)

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


## ListAnnouncements

> InlineResponse20039 ListAnnouncements (string apiToken = null, string token = null, int? limit = null, string order = null, string status = null, string announcementGroup = null)

List announcements

## List announcements  Retrieves a list of announcements.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-list-announcements - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListAnnouncementsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var order = order_example;  // string |  (optional) 
            var status = status_example;  // string |  (optional) 
            var announcementGroup = announcementGroup_example;  // string |  (optional) 

            try
            {
                // List announcements
                InlineResponse20039 result = apiInstance.ListAnnouncements(apiToken, token, limit, order, status, announcementGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.ListAnnouncements: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **order** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **announcementGroup** | **string**|  | [optional] 

### Return type

[**InlineResponse20039**](InlineResponse20039.md)

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

> InlineResponse20040 ScheduleAnnouncement (string apiToken = null, ScheduleAnnouncementData scheduleAnnouncementData = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var scheduleAnnouncementData = new ScheduleAnnouncementData(); // ScheduleAnnouncementData |  (optional) 

            try
            {
                // Schedule an announcement
                InlineResponse20040 result = apiInstance.ScheduleAnnouncement(apiToken, scheduleAnnouncementData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.ScheduleAnnouncement: " + e.Message );
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
 **scheduleAnnouncementData** | [**ScheduleAnnouncementData**](ScheduleAnnouncementData.md)|  | [optional] 

### Return type

[**InlineResponse20040**](InlineResponse20040.md)

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

> InlineResponse20041 UpdateAnnouncementById (string uniqueId, string apiToken = null, UpdateAnnouncementByIdData updateAnnouncementByIdData = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var uniqueId = uniqueId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAnnouncementByIdData = new UpdateAnnouncementByIdData(); // UpdateAnnouncementByIdData |  (optional) 

            try
            {
                // Update an announcement
                InlineResponse20041 result = apiInstance.UpdateAnnouncementById(uniqueId, apiToken, updateAnnouncementByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.UpdateAnnouncementById: " + e.Message );
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
 **uniqueId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateAnnouncementByIdData** | [**UpdateAnnouncementByIdData**](UpdateAnnouncementByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20041**](InlineResponse20041.md)

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

> InlineResponse20039Announcements ViewAnnouncementById (string uniqueId, string apiToken = null)

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
            var apiInstance = new AnnouncementsApi(Configuration.Default);
            var uniqueId = uniqueId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View an announcement
                InlineResponse20039Announcements result = apiInstance.ViewAnnouncementById(uniqueId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementsApi.ViewAnnouncementById: " + e.Message );
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
 **uniqueId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20039Announcements**](InlineResponse20039Announcements.md)

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

