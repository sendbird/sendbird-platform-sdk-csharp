# sendbird_platform_sdk.Api.OpenChannelApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAnOpenChannel**](OpenChannelApi.md#createanopenchannel) | **POST** /v3/open_channels | Create an open channel
[**DeleteAnOpenChannel**](OpenChannelApi.md#deleteanopenchannel) | **DELETE** /v3/open_channels/{channel_url} | Delete an open channel
[**GetAnOpenChannel**](OpenChannelApi.md#getanopenchannel) | **GET** /v3/open_channels/{channel_url} | Get an open channel
[**ListChannelOperators**](OpenChannelApi.md#listchanneloperators) | **GET** /v3/open_channels/{channel_url}/operators | List operators of an open channel
[**ListOpenChannels**](OpenChannelApi.md#listopenchannels) | **GET** /v3/open_channels | List open channels
[**RegisterOperators**](OpenChannelApi.md#registeroperators) | **POST** /v3/open_channels/{channel_url}/operators | Register operators to an open channel
[**UnregisterOperators**](OpenChannelApi.md#unregisteroperators) | **DELETE** /v3/open_channels/{channel_url}/operators | Unregister operators from an open channel
[**UpdateAnOpenChannel**](OpenChannelApi.md#updateanopenchannel) | **PUT** /v3/open_channels/{channel_url} | Update an open channel



## CreateAnOpenChannel

> SendbirdOpenChannel CreateAnOpenChannel (string apiToken = null, CreateAnOpenChannelRequest createAnOpenChannelRequest = null)

Create an open channel

## Create an open channel  You can create an [open channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel) that facilitates conversations for millions of users. Open channels allow a seamless chat experience possible for all participants by using [dynamic partitioning](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#4-how-dynamic-partitioning-works) which creates subchannels that each handle up to tens of thousands of participants.  Because users don't need invitations to join open channels, short-lived live events like concerts or live streams that don't require a sustained membership are good use cases for open channels.  [https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel](https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateAnOpenChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createAnOpenChannelRequest = new CreateAnOpenChannelRequest(); // CreateAnOpenChannelRequest |  (optional) 

            try
            {
                // Create an open channel
                SendbirdOpenChannel result = apiInstance.CreateAnOpenChannel(apiToken, createAnOpenChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.CreateAnOpenChannel: " + e.Message );
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
 **createAnOpenChannelRequest** | [**CreateAnOpenChannelRequest**](CreateAnOpenChannelRequest.md)|  | [optional] 

### Return type

[**SendbirdOpenChannel**](SendbirdOpenChannel.md)

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


## DeleteAnOpenChannel

> Object DeleteAnOpenChannel (string channelUrl, string apiToken = null)

Delete an open channel

## Delete an open channel  You can delete an open channel using this API. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/delete-an-open-channel#1-delete-an-open-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAnOpenChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete an open channel
                Object result = apiInstance.DeleteAnOpenChannel(channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.DeleteAnOpenChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

**Object**

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


## GetAnOpenChannel

> SendbirdOpenChannel GetAnOpenChannel (string channelUrl, string apiToken = null, bool? includeOperators = null)

Get an open channel

## Get an open channel  This action retrieves information about a specific [open channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel).  [https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/get-an-open-channel#1-get-an-open-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/get-an-open-channel#1-get-an-open-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetAnOpenChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var includeOperators = true;  // bool? | Determines whether to include a list of operators in the response. (Default: false) (optional) 

            try
            {
                // Get an open channel
                SendbirdOpenChannel result = apiInstance.GetAnOpenChannel(channelUrl, apiToken, includeOperators);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.GetAnOpenChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **includeOperators** | **bool?**| Determines whether to include a list of operators in the response. (Default: false) | [optional] 

### Return type

[**SendbirdOpenChannel**](SendbirdOpenChannel.md)

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


## ListChannelOperators

> ListOperatorsResponse ListChannelOperators (string channelUrl, string token = null, int? limit = null, string apiToken = null)

List operators of an open channel

## List operators of an open channel  You can retrieve a list of operators of an open channel using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/list-operators-of-an-open-channel#1-list-operators-of-an-open-channel  `channel_url`   Type: string   Description: Specifies the URL of the channel to retrieve a list of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListChannelOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List operators of an open channel
                ListOperatorsResponse result = apiInstance.ListChannelOperators(channelUrl, token, limit, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.ListChannelOperators: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListOperatorsResponse**](ListOperatorsResponse.md)

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


## ListOpenChannels

> ListOpenChannelsResponse ListOpenChannels (string token = null, string channelUrls = null, int? limit = null, string customTypes = null, string nameContains = null, string urlContains = null, bool? showFrozen = null, bool? showMetadata = null, string apiToken = null)

List open channels

## List open channels  This action retrieves a list of [open channels](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel). You can use various query parameters to determine the search scope and select what kind of information you want to receive about the queried channels.  [https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/list-open-channels#1-list-open-channels](https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/list-open-channels#1-list-open-channels)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListOpenChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var token = "token_example";  // string |  (optional) 
            var channelUrls = "channelUrls_example";  // string | Specifies a comma-separated string of one or more open channel URLs to restrict the search scope. URL encoding each channel URL is recommended. (optional) 
            var limit = 56;  // int? |  (optional) 
            var customTypes = "customTypes_example";  // string | Specifies a comma-separated string of one or more custom types to filter open channels. Urlencoding each type is recommended (for example, ?custom_types=urlencoded_type_1,urlencoded_type_2). If not specified, all channels are returned, regardless of their custom type. (optional) 
            var nameContains = "nameContains_example";  // string |  (optional) 
            var urlContains = "urlContains_example";  // string |  (optional) 
            var showFrozen = true;  // bool? | Determines whether to include frozen channels in the response. Frozen channels are channels where only channel operators are allowed to send messages. (Default: true) (optional) 
            var showMetadata = true;  // bool? | Determines whether to include channel metadata in the response. (Default: false) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List open channels
                ListOpenChannelsResponse result = apiInstance.ListOpenChannels(token, channelUrls, limit, customTypes, nameContains, urlContains, showFrozen, showMetadata, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.ListOpenChannels: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **channelUrls** | **string**| Specifies a comma-separated string of one or more open channel URLs to restrict the search scope. URL encoding each channel URL is recommended. | [optional] 
 **limit** | **int?**|  | [optional] 
 **customTypes** | **string**| Specifies a comma-separated string of one or more custom types to filter open channels. Urlencoding each type is recommended (for example, ?custom_types&#x3D;urlencoded_type_1,urlencoded_type_2). If not specified, all channels are returned, regardless of their custom type. | [optional] 
 **nameContains** | **string**|  | [optional] 
 **urlContains** | **string**|  | [optional] 
 **showFrozen** | **bool?**| Determines whether to include frozen channels in the response. Frozen channels are channels where only channel operators are allowed to send messages. (Default: true) | [optional] 
 **showMetadata** | **bool?**| Determines whether to include channel metadata in the response. (Default: false) | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListOpenChannelsResponse**](ListOpenChannelsResponse.md)

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


## RegisterOperators

> Object RegisterOperators (string channelUrl, string apiToken = null, RegisterOperatorsToAGroupChannelRequest registerOperatorsToAGroupChannelRequest = null)

Register operators to an open channel

## Register operators to an open channel  You can register one or more operators to an open channel using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/register-operators-to-an-open-channel#1-register-operators-to-an-open-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RegisterOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var registerOperatorsToAGroupChannelRequest = new RegisterOperatorsToAGroupChannelRequest(); // RegisterOperatorsToAGroupChannelRequest |  (optional) 

            try
            {
                // Register operators to an open channel
                Object result = apiInstance.RegisterOperators(channelUrl, apiToken, registerOperatorsToAGroupChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.RegisterOperators: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **registerOperatorsToAGroupChannelRequest** | [**RegisterOperatorsToAGroupChannelRequest**](RegisterOperatorsToAGroupChannelRequest.md)|  | [optional] 

### Return type

**Object**

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


## UnregisterOperators

> Object UnregisterOperators (string channelUrl, string operatorIds, bool? deleteAll = null, string apiToken = null)

Unregister operators from an open channel

## Unregister operators from an open channel  You can unregister operators in an open channel but keep them in the channel as participants using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/unregister-operators-from-an-open-channel#1-unregister-operators-from-an-open-channel  `channel_url`   Type: string   Description: Specifies the URL of the channel to cancel the registration of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnregisterOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var operatorIds = "operatorIds_example";  // string | Specifies an array of one or more operator IDs to unregister from the channel. The operators in this array remain as participants of the channel after losing their operational roles. Urlencoding each operator ID is recommended. An example of a Urlencoded array would be ?operator_ids=urlencoded_id_1,urlencoded_id_2.
            var deleteAll = true;  // bool? | Determines whether to unregister all operators and leave them as the participants of the channel. When this is set to true, the operator_ids property isn't effective and doesn't need to be specified in the request. (Default: false) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unregister operators from an open channel
                Object result = apiInstance.UnregisterOperators(channelUrl, operatorIds, deleteAll, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.UnregisterOperators: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **operatorIds** | **string**| Specifies an array of one or more operator IDs to unregister from the channel. The operators in this array remain as participants of the channel after losing their operational roles. Urlencoding each operator ID is recommended. An example of a Urlencoded array would be ?operator_ids&#x3D;urlencoded_id_1,urlencoded_id_2. | 
 **deleteAll** | **bool?**| Determines whether to unregister all operators and leave them as the participants of the channel. When this is set to true, the operator_ids property isn&#39;t effective and doesn&#39;t need to be specified in the request. (Default: false) | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

**Object**

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


## UpdateAnOpenChannel

> SendbirdOpenChannel UpdateAnOpenChannel (string channelUrl, string apiToken = null, UpdateAnOpenChannelRequest updateAnOpenChannelRequest = null)

Update an open channel

## Update an open channel  You can update information about an open channel using this API. You can add a cover image to a channel to better identify the channel or specify a custom channel type for grouping channels by custom type. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/update-an-open-channel#1-update-an-open-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAnOpenChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAnOpenChannelRequest = new UpdateAnOpenChannelRequest(); // UpdateAnOpenChannelRequest |  (optional) 

            try
            {
                // Update an open channel
                SendbirdOpenChannel result = apiInstance.UpdateAnOpenChannel(channelUrl, apiToken, updateAnOpenChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.UpdateAnOpenChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateAnOpenChannelRequest** | [**UpdateAnOpenChannelRequest**](UpdateAnOpenChannelRequest.md)|  | [optional] 

### Return type

[**SendbirdOpenChannel**](SendbirdOpenChannel.md)

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

