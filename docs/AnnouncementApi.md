# sendbird_platform_sdk.Api.AnnouncementApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDetailedOpenRateOfAnnouncementById**](AnnouncementApi.md#getdetailedopenrateofannouncementbyid) | **GET** /v3/announcement_open_rate/{unique_id} | Get detailed open rate of an announcement
[**GetDetailedOpenRateOfAnnouncementGroup**](AnnouncementApi.md#getdetailedopenrateofannouncementgroup) | **GET** /v3/announcement_open_rate_by_group/{announcement_group} | Get detailed open rate of an announcement group
[**GetDetailedOpenStatusOfAnnouncementById**](AnnouncementApi.md#getdetailedopenstatusofannouncementbyid) | **GET** /v3/announcement_open_status/{unique_id} | Get detailed open status of an announcement
[**ViewAnnouncementById**](AnnouncementApi.md#viewannouncementbyid) | **GET** /v3/announcements/{unique_id} | View an announcement



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
            var apiInstance = new AnnouncementApi(Configuration.Default);
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
                Debug.Print("Exception when calling AnnouncementApi.GetDetailedOpenRateOfAnnouncementById: " + e.Message );
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
            var apiInstance = new AnnouncementApi(Configuration.Default);
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
                Debug.Print("Exception when calling AnnouncementApi.GetDetailedOpenStatusOfAnnouncementById: " + e.Message );
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

