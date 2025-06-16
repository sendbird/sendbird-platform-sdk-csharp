# sendbird_platform_sdk.Api.AnnouncementApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScheduleAnAnnouncement**](AnnouncementApi.md#scheduleanannouncement) | **POST** /v3/announcements | Schedule an announcement



## ScheduleAnAnnouncement

> ScheduleAnAnnouncementResponse ScheduleAnAnnouncement (string apiToken = null, ScheduleAnAnnouncementRequest scheduleAnAnnouncementRequest = null)

Schedule an announcement

## Schedule an announcement  Creates an announcement. You can also schedule an announcement in the [Sendbird Dashboard](https://dashboard.sendbird.com).  [https://sendbird.com/docs/chat/platform-api/v3/message/announcements/create-an-announcement#1-create-an-announcement](https://sendbird.com/docs/chat/platform-api/v3/message/announcements/create-an-announcement#1-create-an-announcement)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ScheduleAnAnnouncementExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new AnnouncementApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var scheduleAnAnnouncementRequest = new ScheduleAnAnnouncementRequest(); // ScheduleAnAnnouncementRequest |  (optional) 

            try
            {
                // Schedule an announcement
                ScheduleAnAnnouncementResponse result = apiInstance.ScheduleAnAnnouncement(apiToken, scheduleAnAnnouncementRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AnnouncementApi.ScheduleAnAnnouncement: " + e.Message );
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
 **scheduleAnAnnouncementRequest** | [**ScheduleAnAnnouncementRequest**](ScheduleAnAnnouncementRequest.md)|  | [optional] 

### Return type

[**ScheduleAnAnnouncementResponse**](ScheduleAnAnnouncementResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

