# sendbird_platform_sdk.Api.WebhooksApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChooseWhichEventsToSubscribeTo**](WebhooksApi.md#choosewhicheventstosubscribeto) | **PUT** /v3/applications/settings/webhook | Choose which events to subscribe to
[**RetrieveListOfSubscribedEvents**](WebhooksApi.md#retrievelistofsubscribedevents) | **GET** /v3/applications/settings/webhook | Retrieve a list of subscribed events



## ChooseWhichEventsToSubscribeTo

> InlineResponse20067 ChooseWhichEventsToSubscribeTo (string apiToken = null, ChooseWhichEventsToSubscribeToData chooseWhichEventsToSubscribeToData = null)

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
            var apiInstance = new WebhooksApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var chooseWhichEventsToSubscribeToData = new ChooseWhichEventsToSubscribeToData(); // ChooseWhichEventsToSubscribeToData |  (optional) 

            try
            {
                // Choose which events to subscribe to
                InlineResponse20067 result = apiInstance.ChooseWhichEventsToSubscribeTo(apiToken, chooseWhichEventsToSubscribeToData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhooksApi.ChooseWhichEventsToSubscribeTo: " + e.Message );
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
 **chooseWhichEventsToSubscribeToData** | [**ChooseWhichEventsToSubscribeToData**](ChooseWhichEventsToSubscribeToData.md)|  | [optional] 

### Return type

[**InlineResponse20067**](InlineResponse20067.md)

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

> InlineResponse20066 RetrieveListOfSubscribedEvents (string apiToken = null, bool? displayAllWebhookCategories = null)

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
            var apiInstance = new WebhooksApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var displayAllWebhookCategories = true;  // bool? |  (optional) 

            try
            {
                // Retrieve a list of subscribed events
                InlineResponse20066 result = apiInstance.RetrieveListOfSubscribedEvents(apiToken, displayAllWebhookCategories);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WebhooksApi.RetrieveListOfSubscribedEvents: " + e.Message );
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
 **displayAllWebhookCategories** | **bool?**|  | [optional] 

### Return type

[**InlineResponse20066**](InlineResponse20066.md)

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

