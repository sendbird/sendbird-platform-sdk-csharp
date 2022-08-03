# sendbird_platform_sdk.Api.WebhookApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChooseWhichEventsToSubscribeTo**](WebhookApi.md#choosewhicheventstosubscribeto) | **PUT** /v3/applications/settings/webhook | Choose which events to subscribe to
[**RetrieveListOfSubscribedEvents**](WebhookApi.md#retrievelistofsubscribedevents) | **GET** /v3/applications/settings/webhook | Retrieve a list of subscribed events



## ChooseWhichEventsToSubscribeTo

> ChooseWhichEventsToSubscribeToResponse ChooseWhichEventsToSubscribeTo (string apiToken, ChooseWhichEventsToSubscribeToData chooseWhichEventsToSubscribeToData = null)

Choose which events to subscribe to

## Choose which events to subscribe to  Chooses which events for your webhook server to receive payloads for. By subscribing to specific events based on your own needs, you can control the number of HTTP requests to your webhook server.  https://sendbird.com/docs/chat/v3/platform-api/guides/webhooks#2-choose-which-events-to-subscribe-to

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ChooseWhichEventsToSubscribeToExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new WebhookApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var chooseWhichEventsToSubscribeToData = new ChooseWhichEventsToSubscribeToData(); // ChooseWhichEventsToSubscribeToData |  (optional) 

            try
            {
                // Choose which events to subscribe to
                ChooseWhichEventsToSubscribeToResponse result = apiInstance.ChooseWhichEventsToSubscribeTo(apiToken, chooseWhichEventsToSubscribeToData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhookApi.ChooseWhichEventsToSubscribeTo: " + e.Message );
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
 **chooseWhichEventsToSubscribeToData** | [**ChooseWhichEventsToSubscribeToData**](ChooseWhichEventsToSubscribeToData.md)|  | [optional] 

### Return type

[**ChooseWhichEventsToSubscribeToResponse**](ChooseWhichEventsToSubscribeToResponse.md)

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


## RetrieveListOfSubscribedEvents

> RetrieveListOfSubscribedEventsResponse RetrieveListOfSubscribedEvents (string apiToken, bool? displayAllWebhookCategories = null)

Retrieve a list of subscribed events

## Retrieve a list of subscribed events  Retrieves a list of events for your webhook server to receive payloads for.  https://sendbird.com/docs/chat/v3/platform-api/guides/webhooks#2-retrieve-a-list-of-subscribed-events - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RetrieveListOfSubscribedEventsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new WebhookApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var displayAllWebhookCategories = true;  // bool? |  (optional) 

            try
            {
                // Retrieve a list of subscribed events
                RetrieveListOfSubscribedEventsResponse result = apiInstance.RetrieveListOfSubscribedEvents(apiToken, displayAllWebhookCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhookApi.RetrieveListOfSubscribedEvents: " + e.Message );
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
 **displayAllWebhookCategories** | **bool?**|  | [optional] 

### Return type

[**RetrieveListOfSubscribedEventsResponse**](RetrieveListOfSubscribedEventsResponse.md)

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

