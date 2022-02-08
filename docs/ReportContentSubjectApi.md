# sendbird_platform_sdk.Api.ReportContentSubjectApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListReports**](ReportContentSubjectApi.md#listreports) | **GET** /v3/report | List reports
[**ListReportsOnChannelByUrl**](ReportContentSubjectApi.md#listreportsonchannelbyurl) | **GET** /v3/report/{channel_type}/{channel_url} | List reports on a channel
[**ListReportsOnMessageById**](ReportContentSubjectApi.md#listreportsonmessagebyid) | **GET** /v3/report/{channel_type}/{channel_url}/messages/{message_id} | List reports on a message
[**ListReportsOnUserById**](ReportContentSubjectApi.md#listreportsonuserbyid) | **GET** /v3/report/users/{offending_user_id} | List reports on a user
[**ReportChannelByUrl**](ReportContentSubjectApi.md#reportchannelbyurl) | **POST** /v3/report/{channel_type}/{channel_url} | Report a channel
[**ReportMessageById**](ReportContentSubjectApi.md#reportmessagebyid) | **POST** /v3/report/{channel_type}/{channel_url}/messages/{message_id} | Report a message
[**ReportUserById**](ReportContentSubjectApi.md#reportuserbyid) | **POST** /v3/report/users/{offending_user_id} | Report a user
[**ViewModeratedMessageById**](ReportContentSubjectApi.md#viewmoderatedmessagebyid) | **GET** /v3/report/{channel_type}/{channel_url}/profanity_messages/{message_id} | View a moderated message



## ListReports

> InlineResponse20070 ListReports (string apiToken = null, string token = null, int? limit = null, int? startTs = null, int? endTs = null)

List reports

## List reports  Retrieves a list of reports within an application regardless of object types.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-list-reports - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListReportsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var startTs = 56;  // int? |  (optional) 
            var endTs = 56;  // int? |  (optional) 

            try
            {
                // List reports
                InlineResponse20070 result = apiInstance.ListReports(apiToken, token, limit, startTs, endTs);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ListReports: " + e.Message );
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
 **startTs** | **int?**|  | [optional] 
 **endTs** | **int?**|  | [optional] 

### Return type

[**InlineResponse20070**](InlineResponse20070.md)

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


## ListReportsOnChannelByUrl

> InlineResponse20071 ListReportsOnChannelByUrl (string channelType, string channelUrl, string apiToken = null, string token = null, int? limit = null)

List reports on a channel

## List reports on a channel  Retrieves a list of reports on a channel that has offensive messages or abusive activities.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-list-reports-on-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which is reported for offensive messages or inappropriate activities.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListReportsOnChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List reports on a channel
                InlineResponse20071 result = apiInstance.ListReportsOnChannelByUrl(channelType, channelUrl, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ListReportsOnChannelByUrl: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20071**](InlineResponse20071.md)

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


## ListReportsOnMessageById

> InlineResponse20071 ListReportsOnMessageById (string channelType, string channelUrl, string messageId, string apiToken = null, string token = null, int? limit = null)

List reports on a message

## List reports on a message  Retrieves a list of reports on a message which contains suspicious, harassing, or inappropriate content.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-list-reports-on-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel where the reported message is in.  `message_id`      Type: string      Description: Specifies the unique ID of the reported message.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListReportsOnMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List reports on a message
                InlineResponse20071 result = apiInstance.ListReportsOnMessageById(channelType, channelUrl, messageId, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ListReportsOnMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20071**](InlineResponse20071.md)

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


## ListReportsOnUserById

> InlineResponse20071 ListReportsOnUserById (string offendingUserId, string apiToken = null, string token = null, int? limit = null)

List reports on a user

## List reports on a user  Retrieves a list of reports on a user who sends an offensive message.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-list-reports-on-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `offending_user_id`      Type: string      Description: Specifies the unique ID of the user who has sent the message to report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListReportsOnUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var offendingUserId = offendingUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List reports on a user
                InlineResponse20071 result = apiInstance.ListReportsOnUserById(offendingUserId, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ListReportsOnUserById: " + e.Message );
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
 **offendingUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20071**](InlineResponse20071.md)

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


## ReportChannelByUrl

> InlineResponse20071ReportLogs ReportChannelByUrl (string channelType, string channelUrl, string apiToken = null, ReportChannelByUrlData reportChannelByUrlData = null)

Report a channel

## Report a channel  Reports a channel that has offensive messages or abusive activities.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-report-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ReportChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var reportChannelByUrlData = new ReportChannelByUrlData(); // ReportChannelByUrlData |  (optional) 

            try
            {
                // Report a channel
                InlineResponse20071ReportLogs result = apiInstance.ReportChannelByUrl(channelType, channelUrl, apiToken, reportChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ReportChannelByUrl: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **reportChannelByUrlData** | [**ReportChannelByUrlData**](ReportChannelByUrlData.md)|  | [optional] 

### Return type

[**InlineResponse20071ReportLogs**](InlineResponse20071ReportLogs.md)

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


## ReportMessageById

> InlineResponse20071ReportLogs ReportMessageById (string channelType, string channelUrl, string messageId, string apiToken = null, ReportMessageByIdData reportMessageByIdData = null)

Report a message

## Report a message  Reports a message which contains suspicious, harassing, or inappropriate content.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-report-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ReportMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var reportMessageByIdData = new ReportMessageByIdData(); // ReportMessageByIdData |  (optional) 

            try
            {
                // Report a message
                InlineResponse20071ReportLogs result = apiInstance.ReportMessageById(channelType, channelUrl, messageId, apiToken, reportMessageByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ReportMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **reportMessageByIdData** | [**ReportMessageByIdData**](ReportMessageByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20071ReportLogs**](InlineResponse20071ReportLogs.md)

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


## ReportUserById

> InlineResponse20071ReportLogs ReportUserById (string offendingUserId, string apiToken = null, ReportUserByIdData reportUserByIdData = null)

Report a user

## Report a user  Reports a user who sends an offensive message in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-report-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ReportUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var offendingUserId = offendingUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var reportUserByIdData = new ReportUserByIdData(); // ReportUserByIdData |  (optional) 

            try
            {
                // Report a user
                InlineResponse20071ReportLogs result = apiInstance.ReportUserById(offendingUserId, apiToken, reportUserByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ReportUserById: " + e.Message );
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
 **offendingUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **reportUserByIdData** | [**ReportUserByIdData**](ReportUserByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20071ReportLogs**](InlineResponse20071ReportLogs.md)

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


## ViewModeratedMessageById

> Dictionary&lt;string, string&gt; ViewModeratedMessageById (string channelType, string channelUrl, string messageId, string apiToken = null)

View a moderated message

## View a moderated message  Retrieves information on a message that has been moderated by the [profanity filter](https://sendbird.com/docs/chat/v3/platform-api/guides/filter-and-moderation#2-profanity-filter).  https://sendbird.com/docs/chat/v3/platform-api/guides/report-content-and-subject#2-view-a-moderated-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewModeratedMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ReportContentSubjectApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a moderated message
                Dictionary<string, string> result = apiInstance.ViewModeratedMessageById(channelType, channelUrl, messageId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ReportContentSubjectApi.ViewModeratedMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

**Dictionary<string, string>**

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

