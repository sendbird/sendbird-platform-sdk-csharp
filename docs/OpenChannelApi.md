# sendbird_platform_sdk.Api.OpenChannelApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OcCancelTheRegistrationOfOperators**](OpenChannelApi.md#occanceltheregistrationofoperators) | **DELETE** /v3/open_channels/{channel_url}/operators | Cancel the registration of operators
[**OcCreateChannel**](OpenChannelApi.md#occreatechannel) | **POST** /v3/open_channels | Create a channel
[**OcDeleteChannelByUrl**](OpenChannelApi.md#ocdeletechannelbyurl) | **DELETE** /v3/open_channels/{channel_url} | Delete a channel
[**OcListChannels**](OpenChannelApi.md#oclistchannels) | **GET** /v3/open_channels | List channels
[**OcListOperators**](OpenChannelApi.md#oclistoperators) | **GET** /v3/open_channels/{channel_url}/operators | List operators
[**OcListParticipants**](OpenChannelApi.md#oclistparticipants) | **GET** /v3/open_channels/{channel_url}/participants | List participants
[**OcRegisterOperators**](OpenChannelApi.md#ocregisteroperators) | **POST** /v3/open_channels/{channel_url}/operators | Register operators
[**OcUpdateChannelByUrl**](OpenChannelApi.md#ocupdatechannelbyurl) | **PUT** /v3/open_channels/{channel_url} | Update a channel
[**OcViewChannelByUrl**](OpenChannelApi.md#ocviewchannelbyurl) | **GET** /v3/open_channels/{channel_url} | View a channel



## OcCancelTheRegistrationOfOperators

> void OcCancelTheRegistrationOfOperators (string apiToken, string channelUrl, List<string> operatorIds, bool? deleteAll = null)

Cancel the registration of operators

## Cancel the registration of operators  Cancels the registration of operators from an open channel but leave them as participants.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-cancel-the-registration-of-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to cancel the registration of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcCancelTheRegistrationOfOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var operatorIds = new List<string>(); // List<string> | 
            var deleteAll = true;  // bool? |  (optional) 

            try
            {
                // Cancel the registration of operators
                apiInstance.OcCancelTheRegistrationOfOperators(apiToken, channelUrl, operatorIds, deleteAll);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcCancelTheRegistrationOfOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **operatorIds** | [**List&lt;string&gt;**](string.md)|  | 
 **deleteAll** | **bool?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OcCreateChannel

> SendBirdOpenChannel OcCreateChannel (string apiToken, OcCreateChannelData ocCreateChannelData = null)

Create a channel

## Create a channel  Creates an open channel.  >__Note__: Classic open channels created before the deprecation date of March 2021 will maintain their original form and functions. However, new applications created after December 15, 2020, will be able to create dynamic partitioning open channels only.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcCreateChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var ocCreateChannelData = new OcCreateChannelData(); // OcCreateChannelData |  (optional) 

            try
            {
                // Create a channel
                SendBirdOpenChannel result = apiInstance.OcCreateChannel(apiToken, ocCreateChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcCreateChannel: " + e.Message );
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
 **ocCreateChannelData** | [**OcCreateChannelData**](OcCreateChannelData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcDeleteChannelByUrl

> InlineResponse2001 OcDeleteChannelByUrl (string apiToken, string channelUrl)

Delete a channel

## Delete a channel  Deletes an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-delete-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcDeleteChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 

            try
            {
                // Delete a channel
                InlineResponse2001 result = apiInstance.OcDeleteChannelByUrl(apiToken, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcDeleteChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## OcListChannels

> OcListChannelsResponse OcListChannels (string apiToken, string token = null, int? limit = null, string customTypes = null, string nameContains = null, string urlContains = null, bool? showFrozen = null, bool? showMetadata = null, string customType = null)

List channels

## List channels  Retrieves a list of open channels. You can query the list using various parameters.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var nameContains = nameContains_example;  // string |  (optional) 
            var urlContains = urlContains_example;  // string |  (optional) 
            var showFrozen = true;  // bool? |  (optional) 
            var showMetadata = true;  // bool? |  (optional) 
            var customType = customType_example;  // string |  (optional) 

            try
            {
                // List channels
                OcListChannelsResponse result = apiInstance.OcListChannels(apiToken, token, limit, customTypes, nameContains, urlContains, showFrozen, showMetadata, customType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListChannels: " + e.Message );
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
 **customTypes** | **string**|  | [optional] 
 **nameContains** | **string**|  | [optional] 
 **urlContains** | **string**|  | [optional] 
 **showFrozen** | **bool?**|  | [optional] 
 **showMetadata** | **bool?**|  | [optional] 
 **customType** | **string**|  | [optional] 

### Return type

[**OcListChannelsResponse**](OcListChannelsResponse.md)

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


## OcListOperators

> OcListOperatorsResponse OcListOperators (string apiToken, string channelUrl, string token = null, int? limit = null)

List operators

## List operators  Retrieves a list of operators of an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List operators
                OcListOperatorsResponse result = apiInstance.OcListOperators(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListOperatorsResponse**](OcListOperatorsResponse.md)

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


## OcListParticipants

> OcListParticipantsResponse OcListParticipants (string apiToken, string channelUrl, string token = null, int? limit = null)

List participants

## List participants  Retrieves a list of the participants of an open channel. A participant refers to a user who has entered the open channel and is currently online.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-participants - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of participants in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListParticipantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List participants
                OcListParticipantsResponse result = apiInstance.OcListParticipants(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListParticipants: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListParticipantsResponse**](OcListParticipantsResponse.md)

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


## OcRegisterOperators

> InlineResponse2001 OcRegisterOperators (string apiToken, string channelUrl, OcRegisterOperatorsData ocRegisterOperatorsData = null)

Register operators

## Register operators  Registers one or more operators to an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-register-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcRegisterOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var ocRegisterOperatorsData = new OcRegisterOperatorsData(); // OcRegisterOperatorsData |  (optional) 

            try
            {
                // Register operators
                InlineResponse2001 result = apiInstance.OcRegisterOperators(apiToken, channelUrl, ocRegisterOperatorsData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcRegisterOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **ocRegisterOperatorsData** | [**OcRegisterOperatorsData**](OcRegisterOperatorsData.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## OcUpdateChannelByUrl

> SendBirdOpenChannel OcUpdateChannelByUrl (string apiToken, string channelUrl, OcUpdateChannelByUrlData ocUpdateChannelByUrlData = null)

Update a channel

## Update a channel  Updates information on an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-update-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUpdateChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var ocUpdateChannelByUrlData = new OcUpdateChannelByUrlData(); // OcUpdateChannelByUrlData |  (optional) 

            try
            {
                // Update a channel
                SendBirdOpenChannel result = apiInstance.OcUpdateChannelByUrl(apiToken, channelUrl, ocUpdateChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcUpdateChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **ocUpdateChannelByUrlData** | [**OcUpdateChannelByUrlData**](OcUpdateChannelByUrlData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcViewChannelByUrl

> SendBirdOpenChannel OcViewChannelByUrl (string apiToken, string channelUrl)

View a channel

## View a channel  Retrieves information on a specific open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 

            try
            {
                // View a channel
                SendBirdOpenChannel result = apiInstance.OcViewChannelByUrl(apiToken, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcViewChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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

