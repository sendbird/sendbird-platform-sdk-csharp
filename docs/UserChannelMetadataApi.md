# sendbird_platform_sdk.Api.UserChannelMetadataApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChannelMetacounter**](UserChannelMetadataApi.md#createchannelmetacounter) | **POST** /v3/{channel_type}/{channel_url}/metacounter | Create a channel metacounter
[**CreateChannelMetadata**](UserChannelMetadataApi.md#createchannelmetadata) | **POST** /v3/{channel_type}/{channel_url}/metadata | Create a channel metadata
[**CreateUserMetadata**](UserChannelMetadataApi.md#createusermetadata) | **POST** /v3/users/{user_id}/metadata | Create a user metadata
[**DeleteChannelMetacounter**](UserChannelMetadataApi.md#deletechannelmetacounter) | **DELETE** /v3/{channel_type}/{channel_url}/metacounter | Delete a channel metacounter - When deleting all items of a channel metacounter
[**DeleteChannelMetacounterByKey**](UserChannelMetadataApi.md#deletechannelmetacounterbykey) | **DELETE** /v3/{channel_type}/{channel_url}/metacounter/{key} | Delete a channel metacounter - When deleting a specific item of a channel metacounter by its key
[**DeleteChannelMetadata**](UserChannelMetadataApi.md#deletechannelmetadata) | **DELETE** /v3/{channel_type}/{channel_url}/metadata | Delete a channel metadata - When deleting all items of a channel metadata
[**DeleteChannelMetadataByKey**](UserChannelMetadataApi.md#deletechannelmetadatabykey) | **DELETE** /v3/{channel_type}/{channel_url}/metadata/{key} | Delete a channel metadata - When deleting a specific item of a channel metadata by its key
[**DeleteUserMetadata**](UserChannelMetadataApi.md#deleteusermetadata) | **DELETE** /v3/users/{user_id}/metadata | Delete a user metadata - When deleting all items of a user metadata
[**DeleteUserMetadataByKey**](UserChannelMetadataApi.md#deleteusermetadatabykey) | **DELETE** /v3/users/{user_id}/metadata/{key} | Delete a user metadata - When deleting a specific item of a user metadata by its key
[**UpdateChannelMetacounter**](UserChannelMetadataApi.md#updatechannelmetacounter) | **PUT** /v3/{channel_type}/{channel_url}/metacounter | Update a channel metacounter - When updating existing items of a channel metacounter by their keys or adding new items to the metacounter
[**UpdateChannelMetacounterByKey**](UserChannelMetadataApi.md#updatechannelmetacounterbykey) | **PUT** /v3/{channel_type}/{channel_url}/metacounter/{key} | Update a channel metacounter - When updating a specific item of a channel metacounter by its key
[**UpdateChannelMetadata**](UserChannelMetadataApi.md#updatechannelmetadata) | **PUT** /v3/{channel_type}/{channel_url}/metadata | Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
[**UpdateChannelMetadataByKey**](UserChannelMetadataApi.md#updatechannelmetadatabykey) | **PUT** /v3/{channel_type}/{channel_url}/metadata/{key} | Update a channel metadata - When updating a specific item of a channel metadata by its key
[**UpdateUserMetadata**](UserChannelMetadataApi.md#updateusermetadata) | **PUT** /v3/users/{user_id}/metadata | Update a user metadata - When updating existing items of a user metadata by their keys or adding new items to the metadata
[**UpdateUserMetadataByKey**](UserChannelMetadataApi.md#updateusermetadatabykey) | **PUT** /v3/users/{user_id}/metadata/{key} | Update a user metadata - When updating a specific item of a user metadata by its key
[**ViewChannelMetacounter**](UserChannelMetadataApi.md#viewchannelmetacounter) | **GET** /v3/{channel_type}/{channel_url}/metacounter | View a channel metacounter - When retrieving all items of a channel metacounter
[**ViewChannelMetacounterByKey**](UserChannelMetadataApi.md#viewchannelmetacounterbykey) | **GET** /v3/{channel_type}/{channel_url}/metacounter/{key} | View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
[**ViewChannelMetadata**](UserChannelMetadataApi.md#viewchannelmetadata) | **GET** /v3/{channel_type}/{channel_url}/metadata | View a channel metadata - When retrieving all items of a channel metadata
[**ViewChannelMetadataByKey**](UserChannelMetadataApi.md#viewchannelmetadatabykey) | **GET** /v3/{channel_type}/{channel_url}/metadata/{key} | View a channel metadata - When retrieving a specific item of a channel metadata by its key
[**ViewUserMetadata**](UserChannelMetadataApi.md#viewusermetadata) | **GET** /v3/users/{user_id}/metadata | View a user metadata - When retrieving all items of a user metadata
[**ViewUserMetadataByKey**](UserChannelMetadataApi.md#viewusermetadatabykey) | **GET** /v3/users/{user_id}/metadata/{key} | View a user metadata - When retrieving a specific item of a user metadata by its key



## CreateChannelMetacounter

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; CreateChannelMetacounter (string channelType, string channelUrl, string apiToken = null, CreateChannelMetacounterData createChannelMetacounterData = null)

Create a channel metacounter

## Create a channel metacounter  Creates a channel metacounter's items to store in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-create-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateChannelMetacounterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createChannelMetacounterData = new CreateChannelMetacounterData(); // CreateChannelMetacounterData |  (optional) 

            try
            {
                // Create a channel metacounter
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.CreateChannelMetacounter(channelType, channelUrl, apiToken, createChannelMetacounterData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.CreateChannelMetacounter: " + e.Message );
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
 **createChannelMetacounterData** | [**CreateChannelMetacounterData**](CreateChannelMetacounterData.md)|  | [optional] 

### Return type

[**Dictionary&lt;string, SendBirdAdditionalProperties&gt;**](SendBirdAdditionalProperties.md)

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


## CreateChannelMetadata

> InlineResponse20061 CreateChannelMetadata (string channelType, string channelUrl, string apiToken = null, CreateChannelMetadataData createChannelMetadataData = null)

Create a channel metadata

## Create a channel metadata  Creates a channel metadata's items to store in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-create-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createChannelMetadataData = new CreateChannelMetadataData(); // CreateChannelMetadataData |  (optional) 

            try
            {
                // Create a channel metadata
                InlineResponse20061 result = apiInstance.CreateChannelMetadata(channelType, channelUrl, apiToken, createChannelMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.CreateChannelMetadata: " + e.Message );
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
 **createChannelMetadataData** | [**CreateChannelMetadataData**](CreateChannelMetadataData.md)|  | [optional] 

### Return type

[**InlineResponse20061**](InlineResponse20061.md)

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


## CreateUserMetadata

> InlineResponse20047UserMetadata CreateUserMetadata (string userId, string apiToken = null, CreateUserMetadataData createUserMetadataData = null)

Create a user metadata

## Create a user metadata  Creates a user metadata's items to store in a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-create-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateUserMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createUserMetadataData = new CreateUserMetadataData(); // CreateUserMetadataData |  (optional) 

            try
            {
                // Create a user metadata
                InlineResponse20047UserMetadata result = apiInstance.CreateUserMetadata(userId, apiToken, createUserMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.CreateUserMetadata: " + e.Message );
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
 **userId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **createUserMetadataData** | [**CreateUserMetadataData**](CreateUserMetadataData.md)|  | [optional] 

### Return type

[**InlineResponse20047UserMetadata**](InlineResponse20047UserMetadata.md)

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


## DeleteChannelMetacounter

> void DeleteChannelMetacounter (string channelType, string channelUrl, string apiToken = null)

Delete a channel metacounter - When deleting all items of a channel metacounter

## Delete a channel metacounter  Deletes a channel metacounter's item that is stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which has the metacounter to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteChannelMetacounterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a channel metacounter - When deleting all items of a channel metacounter
                apiInstance.DeleteChannelMetacounter(channelType, channelUrl, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteChannelMetacounter: " + e.Message );
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


## DeleteChannelMetacounterByKey

> void DeleteChannelMetacounterByKey (string channelType, string channelUrl, string key, string apiToken = null)

Delete a channel metacounter - When deleting a specific item of a channel metacounter by its key

## Delete a channel metacounter  Deletes a channel metacounter's item that is stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which has the metacounter to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteChannelMetacounterByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a channel metacounter - When deleting a specific item of a channel metacounter by its key
                apiInstance.DeleteChannelMetacounterByKey(channelType, channelUrl, key, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteChannelMetacounterByKey: " + e.Message );
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
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## DeleteChannelMetadata

> void DeleteChannelMetadata (string channelType, string channelUrl, string apiToken = null, string key = null)

Delete a channel metadata - When deleting all items of a channel metadata

## Delete a channel metadata  Deletes a channel metadata's one or all items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which has the metadata to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var key = key_example;  // string |  (optional) 

            try
            {
                // Delete a channel metadata - When deleting all items of a channel metadata
                apiInstance.DeleteChannelMetadata(channelType, channelUrl, apiToken, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteChannelMetadata: " + e.Message );
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
 **key** | **string**|  | [optional] 

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


## DeleteChannelMetadataByKey

> void DeleteChannelMetadataByKey (string channelType, string channelUrl, string key, string apiToken = null)

Delete a channel metadata - When deleting a specific item of a channel metadata by its key

## Delete a channel metadata  Deletes a channel metadata's one or all items that are stored in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which has the metadata to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteChannelMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a channel metadata - When deleting a specific item of a channel metadata by its key
                apiInstance.DeleteChannelMetadataByKey(channelType, channelUrl, key, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteChannelMetadataByKey: " + e.Message );
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
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## DeleteUserMetadata

> void DeleteUserMetadata (string userId, string apiToken = null, string key = null)

Delete a user metadata - When deleting all items of a user metadata

## Delete a user metadata  Deletes a user metadata's one or all items that are stored in a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user who has the metadata to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteUserMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var key = key_example;  // string |  (optional) 

            try
            {
                // Delete a user metadata - When deleting all items of a user metadata
                apiInstance.DeleteUserMetadata(userId, apiToken, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteUserMetadata: " + e.Message );
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
 **userId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **key** | **string**|  | [optional] 

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


## DeleteUserMetadataByKey

> void DeleteUserMetadataByKey (string userId, string key, string apiToken = null)

Delete a user metadata - When deleting a specific item of a user metadata by its key

## Delete a user metadata  Deletes a user metadata's one or all items that are stored in a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-delete-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user who has the metadata to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteUserMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a user metadata - When deleting a specific item of a user metadata by its key
                apiInstance.DeleteUserMetadataByKey(userId, key, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.DeleteUserMetadataByKey: " + e.Message );
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
 **userId** | **string**|  | 
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## UpdateChannelMetacounter

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; UpdateChannelMetacounter (string channelType, string channelUrl, string apiToken = null, UpdateChannelMetacounterData updateChannelMetacounterData = null)

Update a channel metacounter - When updating existing items of a channel metacounter by their keys or adding new items to the metacounter

## Update a channel metacounter  Updates existing items of a channel metacounter by their keys, or adds new items to the metacounter.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateChannelMetacounterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateChannelMetacounterData = new UpdateChannelMetacounterData(); // UpdateChannelMetacounterData |  (optional) 

            try
            {
                // Update a channel metacounter - When updating existing items of a channel metacounter by their keys or adding new items to the metacounter
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.UpdateChannelMetacounter(channelType, channelUrl, apiToken, updateChannelMetacounterData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateChannelMetacounter: " + e.Message );
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
 **updateChannelMetacounterData** | [**UpdateChannelMetacounterData**](UpdateChannelMetacounterData.md)|  | [optional] 

### Return type

[**Dictionary&lt;string, SendBirdAdditionalProperties&gt;**](SendBirdAdditionalProperties.md)

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


## UpdateChannelMetacounterByKey

> Dictionary&lt;string, string&gt; UpdateChannelMetacounterByKey (string channelType, string channelUrl, string key, string apiToken = null, Object body = null)

Update a channel metacounter - When updating a specific item of a channel metacounter by its key

## Update a channel metacounter  Updates existing items of a channel metacounter by their keys, or adds new items to the metacounter.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-channel-metacounter - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateChannelMetacounterByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // Update a channel metacounter - When updating a specific item of a channel metacounter by its key
                Dictionary<string, string> result = apiInstance.UpdateChannelMetacounterByKey(channelType, channelUrl, key, apiToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateChannelMetacounterByKey: " + e.Message );
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
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

**Dictionary<string, string>**

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


## UpdateChannelMetadata

> Dictionary&lt;string, string&gt; UpdateChannelMetadata (string channelType, string channelUrl, string apiToken = null, UpdateChannelMetadataData updateChannelMetadataData = null)

Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata

## Update a channel metadata  Updates existing items of a channel metadata by their keys, or adds new items to the metadata.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateChannelMetadataData = new UpdateChannelMetadataData(); // UpdateChannelMetadataData |  (optional) 

            try
            {
                // Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
                Dictionary<string, string> result = apiInstance.UpdateChannelMetadata(channelType, channelUrl, apiToken, updateChannelMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateChannelMetadata: " + e.Message );
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
 **updateChannelMetadataData** | [**UpdateChannelMetadataData**](UpdateChannelMetadataData.md)|  | [optional] 

### Return type

**Dictionary<string, string>**

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


## UpdateChannelMetadataByKey

> Dictionary&lt;string, string&gt; UpdateChannelMetadataByKey (string channelType, string channelUrl, string key, string apiToken = null, Object body = null)

Update a channel metadata - When updating a specific item of a channel metadata by its key

## Update a channel metadata  Updates existing items of a channel metadata by their keys, or adds new items to the metadata.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-channel-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateChannelMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // Update a channel metadata - When updating a specific item of a channel metadata by its key
                Dictionary<string, string> result = apiInstance.UpdateChannelMetadataByKey(channelType, channelUrl, key, apiToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateChannelMetadataByKey: " + e.Message );
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
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

**Dictionary<string, string>**

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


## UpdateUserMetadata

> InlineResponse20060 UpdateUserMetadata (string userId, string apiToken = null, UpdateUserMetadataData updateUserMetadataData = null)

Update a user metadata - When updating existing items of a user metadata by their keys or adding new items to the metadata

## Update a user metadata  Updates existing items of a user metadata by their keys, or adds new items to the metadata.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user to update the metadata in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateUserMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateUserMetadataData = new UpdateUserMetadataData(); // UpdateUserMetadataData |  (optional) 

            try
            {
                // Update a user metadata - When updating existing items of a user metadata by their keys or adding new items to the metadata
                InlineResponse20060 result = apiInstance.UpdateUserMetadata(userId, apiToken, updateUserMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateUserMetadata: " + e.Message );
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
 **userId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateUserMetadataData** | [**UpdateUserMetadataData**](UpdateUserMetadataData.md)|  | [optional] 

### Return type

[**InlineResponse20060**](InlineResponse20060.md)

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


## UpdateUserMetadataByKey

> Dictionary&lt;string, string&gt; UpdateUserMetadataByKey (string userId, string key, string apiToken = null, Object body = null)

Update a user metadata - When updating a specific item of a user metadata by its key

## Update a user metadata  Updates existing items of a user metadata by their keys, or adds new items to the metadata.  https://sendbird.com/docs/chat/v3/platform-api/guides/user-and-channel-metadata#2-update-a-user-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the ID of the user to update the metadata in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateUserMetadataByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // Update a user metadata - When updating a specific item of a user metadata by its key
                Dictionary<string, string> result = apiInstance.UpdateUserMetadataByKey(userId, key, apiToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.UpdateUserMetadataByKey: " + e.Message );
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
 **userId** | **string**|  | 
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **body** | **Object**|  | [optional] 

### Return type

**Dictionary<string, string>**

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


## ViewChannelMetacounter

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; ViewChannelMetacounter (string channelType, string channelUrl, string apiToken = null, string key = null, List<string> keys = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metacounter - When retrieving all items of a channel metacounter
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.ViewChannelMetacounter(channelType, channelUrl, apiToken, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewChannelMetacounter: " + e.Message );
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

> Dictionary&lt;string, SendBirdAdditionalProperties&gt; ViewChannelMetacounterByKey (string channelType, string channelUrl, string key, string apiToken = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
                Dictionary<string, SendBirdAdditionalProperties> result = apiInstance.ViewChannelMetacounterByKey(channelType, channelUrl, key, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewChannelMetacounterByKey: " + e.Message );
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
 **key** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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

> Dictionary&lt;string, string&gt; ViewChannelMetadata (string channelType, string channelUrl, string apiToken = null, string key = null, List<string> keys = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metadata - When retrieving all items of a channel metadata
                Dictionary<string, string> result = apiInstance.ViewChannelMetadata(channelType, channelUrl, apiToken, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewChannelMetadata: " + e.Message );
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

> Dictionary&lt;string, string&gt; ViewChannelMetadataByKey (string channelType, string channelUrl, string key, string apiToken = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a channel metadata - When retrieving a specific item of a channel metadata by its key
                Dictionary<string, string> result = apiInstance.ViewChannelMetadataByKey(channelType, channelUrl, key, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewChannelMetadataByKey: " + e.Message );
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
 **key** | **string**|  | 
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


## ViewUserMetadata

> InlineResponse20047UserMetadata ViewUserMetadata (string userId, string apiToken = null, string key = null, List<string> keys = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var key = key_example;  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a user metadata - When retrieving all items of a user metadata
                InlineResponse20047UserMetadata result = apiInstance.ViewUserMetadata(userId, apiToken, key, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewUserMetadata: " + e.Message );
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
 **userId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **key** | **string**|  | [optional] 
 **keys** | [**List&lt;string&gt;**](string.md)|  | [optional] 

### Return type

[**InlineResponse20047UserMetadata**](InlineResponse20047UserMetadata.md)

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

> Dictionary&lt;string, string&gt; ViewUserMetadataByKey (string userId, string key, string apiToken = null)

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
            var apiInstance = new UserChannelMetadataApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var key = key_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a user metadata - When retrieving a specific item of a user metadata by its key
                Dictionary<string, string> result = apiInstance.ViewUserMetadataByKey(userId, key, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserChannelMetadataApi.ViewUserMetadataByKey: " + e.Message );
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
 **userId** | **string**|  | 
 **key** | **string**|  | 
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

