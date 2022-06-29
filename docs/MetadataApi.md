# sendbird_platform_sdk.Api.MetadataApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ViewChannelMetacounter**](MetadataApi.md#viewchannelmetacounter) | **GET** /v3/{channel_type}/{channel_url}/metacounter | View a channel metacounter - When retrieving all items of a channel metacounter
[**ViewChannelMetacounterByKey**](MetadataApi.md#viewchannelmetacounterbykey) | **GET** /v3/{channel_type}/{channel_url}/metacounter/{key} | View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
[**ViewChannelMetadata**](MetadataApi.md#viewchannelmetadata) | **GET** /v3/{channel_type}/{channel_url}/metadata | View a channel metadata - When retrieving all items of a channel metadata
[**ViewChannelMetadataByKey**](MetadataApi.md#viewchannelmetadatabykey) | **GET** /v3/{channel_type}/{channel_url}/metadata/{key} | View a channel metadata - When retrieving a specific item of a channel metadata by its key
[**ViewUserMetadata**](MetadataApi.md#viewusermetadata) | **GET** /v3/users/{user_id}/metadata | View a user metadata - When retrieving all items of a user metadata
[**ViewUserMetadataByKey**](MetadataApi.md#viewusermetadatabykey) | **GET** /v3/users/{user_id}/metadata/{key} | View a user metadata - When retrieving a specific item of a user metadata by its key



## ViewChannelMetacounter

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; ViewChannelMetacounter (string apiToken, string channelType, string channelUrl, string key = null, List<string> keys = null)

View a channel metacounter - When retrieving all items of a channel metacounter

## View a channel metacounter  Retrieves channel metacounter's one or more items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewChannelMetacounterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metacounter - When retrieving all items of a channel metacounter
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.ViewChannelMetacounter(apiToken, channelType, channelUrl, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewChannelMetacounter: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **key** | **string**|  | [optional] 
 **keys** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**Dictionary&lt;string, SendBirdAdditionalProperties&gt;**](SendBirdAdditionalProperties.md)

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


## ViewChannelMetacounterByKey

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; ViewChannelMetacounterByKey (string apiToken, string channelType, string channelUrl, string key)

View a channel metacounter - When retrieving a specific item of a channel metacounter by its key

## View a channel metacounter  Retrieves channel metacounter's one or more items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewChannelMetacounterByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 

            try
            {
                // View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.ViewChannelMetacounterByKey(apiToken, channelType, channelUrl, key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewChannelMetacounterByKey: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **key** | **string**|  | 

### Return type

[**Dictionary&lt;string, SendBirdAdditionalProperties&gt;**](SendBirdAdditionalProperties.md)

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


## ViewChannelMetadata

> Dictionary&lt;string, string&gt; ViewChannelMetadata (string apiToken, string channelType, string channelUrl, string key = null, List<string> keys = null)

View a channel metadata - When retrieving all items of a channel metadata

## View a channel metadata  Retrieves a channel metadata's one or more items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metadata - When retrieving all items of a channel metadata
                Dictionary<string, string> result = apiInstance.ViewChannelMetadata(apiToken, channelType, channelUrl, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewChannelMetadata: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **key** | **string**|  | [optional] 
 **keys** | [**List&lt;string&gt;**](string.md)|  | [optional] 

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


## ViewChannelMetadataByKey

> Dictionary&lt;string, string&gt; ViewChannelMetadataByKey (string apiToken, string channelType, string channelUrl, string key)

View a channel metadata - When retrieving a specific item of a channel metadata by its key

## View a channel metadata  Retrieves a channel metadata's one or more items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewChannelMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 

            try
            {
                // View a channel metadata - When retrieving a specific item of a channel metadata by its key
                Dictionary<string, string> result = apiInstance.ViewChannelMetadataByKey(apiToken, channelType, channelUrl, key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewChannelMetadataByKey: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **key** | **string**|  | 

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


## ViewUserMetadata

> ViewUserMetadataResponse ViewUserMetadata (string apiToken, string userId, string key = null, List<string> keys = null)

View a user metadata - When retrieving all items of a user metadata

## View a user metadata  Retrieves a user metadata's one or more items that are stored in a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user to retrieve the metadata in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewUserMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = userId_example;  // string | 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a user metadata - When retrieving all items of a user metadata
                ViewUserMetadataResponse result = apiInstance.ViewUserMetadata(apiToken, userId, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewUserMetadata: " + e.Message );
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
 **userId** | **string**|  | 
 **key** | **string**|  | [optional] 
 **keys** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**ViewUserMetadataResponse**](ViewUserMetadataResponse.md)

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


## ViewUserMetadataByKey

> Dictionary&lt;string, string&gt; ViewUserMetadataByKey (string apiToken, string userId, string key)

View a user metadata - When retrieving a specific item of a user metadata by its key

## View a user metadata  Retrieves a user metadata's one or more items that are stored in a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-view-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user to retrieve the metadata in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewUserMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = userId_example;  // string | 
            var key = key_example;  // string | 

            try
            {
                // View a user metadata - When retrieving a specific item of a user metadata by its key
                Dictionary<string, string> result = apiInstance.ViewUserMetadataByKey(apiToken, userId, key);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewUserMetadataByKey: " + e.Message );
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
 **userId** | **string**|  | 
 **key** | **string**|  | 

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

