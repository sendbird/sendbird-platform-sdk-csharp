# sendbird_platform_sdk.Api.MetadataApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateChannelMetacounter**](MetadataApi.md#createchannelmetacounter) | **POST** /v3/{channel_type}/{channel_url}/metacounter | Create a channel metacounter
[**CreateChannelMetadata**](MetadataApi.md#createchannelmetadata) | **POST** /v3/{channel_type}/{channel_url}/metadata | Create a channel metadata
[**CreateUserMetadata**](MetadataApi.md#createusermetadata) | **POST** /v3/users/{user_id}/metadata | Create a user metadata
[**DeleteChannelMetacounter**](MetadataApi.md#deletechannelmetacounter) | **DELETE** /v3/{channel_type}/{channel_url}/metacounter | Delete a channel metacounter - When deleting all items of a channel metacounter
[**DeleteChannelMetacounterByKey**](MetadataApi.md#deletechannelmetacounterbykey) | **DELETE** /v3/{channel_type}/{channel_url}/metacounter/{key} | Delete a channel metacounter - When deleting a specific item of a channel metacounter by its key
[**DeleteChannelMetadata**](MetadataApi.md#deletechannelmetadata) | **DELETE** /v3/{channel_type}/{channel_url}/metadata | Delete a channel metadata - When deleting all items of a channel metadata
[**DeleteChannelMetadataByKey**](MetadataApi.md#deletechannelmetadatabykey) | **DELETE** /v3/{channel_type}/{channel_url}/metadata/{key} | Delete a channel metadata - When deleting a specific item of a channel metadata by its key
[**DeleteUserMetadata**](MetadataApi.md#deleteusermetadata) | **DELETE** /v3/users/{user_id}/metadata | Delete a user metadata - When deleting all items of a user metadata
[**DeleteUserMetadataByKey**](MetadataApi.md#deleteusermetadatabykey) | **DELETE** /v3/users/{user_id}/metadata/{key} | Delete a user metadata - When deleting a specific item of a user metadata by its key
[**UpdateChannelMetacounter**](MetadataApi.md#updatechannelmetacounter) | **PUT** /v3/{channel_type}/{channel_url}/metacounter | Update a channel metacounter - When updating existing items of a channel metacounter by their keys or adding new items to the metacounter
[**UpdateChannelMetacounterByKey**](MetadataApi.md#updatechannelmetacounterbykey) | **PUT** /v3/{channel_type}/{channel_url}/metacounter/{key} | Update a channel metacounter - When updating a specific item of a channel metacounter by its key
[**UpdateChannelMetadata**](MetadataApi.md#updatechannelmetadata) | **PUT** /v3/{channel_type}/{channel_url}/metadata | Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
[**UpdateChannelMetadataByKey**](MetadataApi.md#updatechannelmetadatabykey) | **PUT** /v3/{channel_type}/{channel_url}/metadata/{key} | Update a channel metadata - When updating a specific item of a channel metadata by its key
[**UpdateUserMetadata**](MetadataApi.md#updateusermetadata) | **PUT** /v3/users/{user_id}/metadata | Update a user metadata - When updating existing items of a user metadata by their keys or adding new items to the metadata
[**UpdateUserMetadataByKey**](MetadataApi.md#updateusermetadatabykey) | **PUT** /v3/users/{user_id}/metadata/{key} | Update a user metadata - When updating a specific item of a user metadata by its key
[**ViewChannelMetacounter**](MetadataApi.md#viewchannelmetacounter) | **GET** /v3/{channel_type}/{channel_url}/metacounter | View a channel metacounter - When retrieving all items of a channel metacounter
[**ViewChannelMetacounterByKey**](MetadataApi.md#viewchannelmetacounterbykey) | **GET** /v3/{channel_type}/{channel_url}/metacounter/{key} | View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
[**ViewChannelMetadata**](MetadataApi.md#viewchannelmetadata) | **GET** /v3/{channel_type}/{channel_url}/metadata | View a channel metadata - When retrieving all items of a channel metadata
[**ViewChannelMetadataByKey**](MetadataApi.md#viewchannelmetadatabykey) | **GET** /v3/{channel_type}/{channel_url}/metadata/{key} | View a channel metadata - When retrieving a specific item of a channel metadata by its key
[**ViewUserMetadata**](MetadataApi.md#viewusermetadata) | **GET** /v3/users/{user_id}/metadata | View a user metadata - When retrieving all items of a user metadata
[**ViewUserMetadataByKey**](MetadataApi.md#viewusermetadatabykey) | **GET** /v3/users/{user_id}/metadata/{key} | View a user metadata - When retrieving a specific item of a user metadata by its key



## CreateChannelMetacounter

> Object CreateChannelMetacounter (string apiToken, string channelType, string channelUrl, CreateChannelMetacounterData createChannelMetacounterData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var createChannelMetacounterData = new CreateChannelMetacounterData(); // CreateChannelMetacounterData |  (optional) 

            try
            {
                // Create a channel metacounter
                Object result = apiInstance.CreateChannelMetacounter(apiToken, channelType, channelUrl, createChannelMetacounterData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateChannelMetacounter: " + e.Message );
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
 **createChannelMetacounterData** | [**CreateChannelMetacounterData**](CreateChannelMetacounterData.md)|  | [optional] 

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


## CreateChannelMetadata

> CreateChannelMetadataResponse CreateChannelMetadata (string apiToken, string channelType, string channelUrl, CreateChannelMetadataData createChannelMetadataData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var createChannelMetadataData = new CreateChannelMetadataData(); // CreateChannelMetadataData |  (optional) 

            try
            {
                // Create a channel metadata
                CreateChannelMetadataResponse result = apiInstance.CreateChannelMetadata(apiToken, channelType, channelUrl, createChannelMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateChannelMetadata: " + e.Message );
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
 **createChannelMetadataData** | [**CreateChannelMetadataData**](CreateChannelMetadataData.md)|  | [optional] 

### Return type

[**CreateChannelMetadataResponse**](CreateChannelMetadataResponse.md)

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

> CreateUserMetadataResponse CreateUserMetadata (string apiToken, string userId, CreateUserMetadataData createUserMetadataData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var createUserMetadataData = new CreateUserMetadataData(); // CreateUserMetadataData |  (optional) 

            try
            {
                // Create a user metadata
                CreateUserMetadataResponse result = apiInstance.CreateUserMetadata(apiToken, userId, createUserMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateUserMetadata: " + e.Message );
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
 **createUserMetadataData** | [**CreateUserMetadataData**](CreateUserMetadataData.md)|  | [optional] 

### Return type

[**CreateUserMetadataResponse**](CreateUserMetadataResponse.md)

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

> void DeleteChannelMetacounter (string apiToken, string channelType, string channelUrl)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 

            try
            {
                // Delete a channel metacounter - When deleting all items of a channel metacounter
                apiInstance.DeleteChannelMetacounter(apiToken, channelType, channelUrl);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteChannelMetacounter: " + e.Message );
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

> void DeleteChannelMetacounterByKey (string apiToken, string channelType, string channelUrl, string key)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Delete a channel metacounter - When deleting a specific item of a channel metacounter by its key
                apiInstance.DeleteChannelMetacounterByKey(apiToken, channelType, channelUrl, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteChannelMetacounterByKey: " + e.Message );
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

> void DeleteChannelMetadata (string apiToken, string channelType, string channelUrl, string key = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string |  (optional) 

            try
            {
                // Delete a channel metadata - When deleting all items of a channel metadata
                apiInstance.DeleteChannelMetadata(apiToken, channelType, channelUrl, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteChannelMetadata: " + e.Message );
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

> void DeleteChannelMetadataByKey (string apiToken, string channelType, string channelUrl, string key)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Delete a channel metadata - When deleting a specific item of a channel metadata by its key
                apiInstance.DeleteChannelMetadataByKey(apiToken, channelType, channelUrl, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteChannelMetadataByKey: " + e.Message );
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

> void DeleteUserMetadata (string apiToken, string userId, string key = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var key = "key_example";  // string |  (optional) 

            try
            {
                // Delete a user metadata - When deleting all items of a user metadata
                apiInstance.DeleteUserMetadata(apiToken, userId, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteUserMetadata: " + e.Message );
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

> void DeleteUserMetadataByKey (string apiToken, string userId, string key)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // Delete a user metadata - When deleting a specific item of a user metadata by its key
                apiInstance.DeleteUserMetadataByKey(apiToken, userId, key);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteUserMetadataByKey: " + e.Message );
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

> Object UpdateChannelMetacounter (string apiToken, string channelType, string channelUrl, UpdateChannelMetacounterData updateChannelMetacounterData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var updateChannelMetacounterData = new UpdateChannelMetacounterData(); // UpdateChannelMetacounterData |  (optional) 

            try
            {
                // Update a channel metacounter - When updating existing items of a channel metacounter by their keys or adding new items to the metacounter
                Object result = apiInstance.UpdateChannelMetacounter(apiToken, channelType, channelUrl, updateChannelMetacounterData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateChannelMetacounter: " + e.Message );
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
 **updateChannelMetacounterData** | [**UpdateChannelMetacounterData**](UpdateChannelMetacounterData.md)|  | [optional] 

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


## UpdateChannelMetacounterByKey

> Object UpdateChannelMetacounterByKey (string apiToken, string channelType, string channelUrl, string key, Object body = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Update a channel metacounter - When updating a specific item of a channel metacounter by its key
                Object result = apiInstance.UpdateChannelMetacounterByKey(apiToken, channelType, channelUrl, key, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateChannelMetacounterByKey: " + e.Message );
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
 **body** | **Object**|  | [optional] 

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


## UpdateChannelMetadata

> Object UpdateChannelMetadata (string apiToken, string channelType, string channelUrl, UpdateChannelMetadataData updateChannelMetadataData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var updateChannelMetadataData = new UpdateChannelMetadataData(); // UpdateChannelMetadataData |  (optional) 

            try
            {
                // Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
                Object result = apiInstance.UpdateChannelMetadata(apiToken, channelType, channelUrl, updateChannelMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateChannelMetadata: " + e.Message );
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
 **updateChannelMetadataData** | [**UpdateChannelMetadataData**](UpdateChannelMetadataData.md)|  | [optional] 

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


## UpdateChannelMetadataByKey

> Object UpdateChannelMetadataByKey (string apiToken, string channelType, string channelUrl, string key, Object body = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Update a channel metadata - When updating a specific item of a channel metadata by its key
                Object result = apiInstance.UpdateChannelMetadataByKey(apiToken, channelType, channelUrl, key, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateChannelMetadataByKey: " + e.Message );
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
 **body** | **Object**|  | [optional] 

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


## UpdateUserMetadata

> UpdateUserMetadataResponse UpdateUserMetadata (string apiToken, string userId, UpdateUserMetadataData updateUserMetadataData = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var updateUserMetadataData = new UpdateUserMetadataData(); // UpdateUserMetadataData |  (optional) 

            try
            {
                // Update a user metadata - When updating existing items of a user metadata by their keys or adding new items to the metadata
                UpdateUserMetadataResponse result = apiInstance.UpdateUserMetadata(apiToken, userId, updateUserMetadataData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateUserMetadata: " + e.Message );
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
 **updateUserMetadataData** | [**UpdateUserMetadataData**](UpdateUserMetadataData.md)|  | [optional] 

### Return type

[**UpdateUserMetadataResponse**](UpdateUserMetadataResponse.md)

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

> Object UpdateUserMetadataByKey (string apiToken, string userId, string key, Object body = null)

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
            var apiInstance = new MetadataApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var key = "key_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Update a user metadata - When updating a specific item of a user metadata by its key
                Object result = apiInstance.UpdateUserMetadataByKey(apiToken, userId, key, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateUserMetadataByKey: " + e.Message );
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
 **body** | **Object**|  | [optional] 

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


## ViewChannelMetacounter

> Object ViewChannelMetacounter (string apiToken, string channelType, string channelUrl, string key = null, List<string> keys = null)

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
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metacounter - When retrieving all items of a channel metacounter
                Object result = apiInstance.ViewChannelMetacounter(apiToken, channelType, channelUrl, key, keys);
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


## ViewChannelMetacounterByKey

> Object ViewChannelMetacounterByKey (string apiToken, string channelType, string channelUrl, string key)

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
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // View a channel metacounter - When retrieving a specific item of a channel metacounter by its key
                Object result = apiInstance.ViewChannelMetacounterByKey(apiToken, channelType, channelUrl, key);
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


## ViewChannelMetadata

> Object ViewChannelMetadata (string apiToken, string channelType, string channelUrl, string key = null, List<string> keys = null)

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
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string |  (optional) 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // View a channel metadata - When retrieving all items of a channel metadata
                Object result = apiInstance.ViewChannelMetadata(apiToken, channelType, channelUrl, key, keys);
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


## ViewChannelMetadataByKey

> Object ViewChannelMetadataByKey (string apiToken, string channelType, string channelUrl, string key)

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
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // View a channel metadata - When retrieving a specific item of a channel metadata by its key
                Object result = apiInstance.ViewChannelMetadataByKey(apiToken, channelType, channelUrl, key);
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
            var userId = "userId_example";  // string | 
            var key = "key_example";  // string |  (optional) 
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

> Object ViewUserMetadataByKey (string apiToken, string userId, string key)

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
            var userId = "userId_example";  // string | 
            var key = "key_example";  // string | 

            try
            {
                // View a user metadata - When retrieving a specific item of a user metadata by its key
                Object result = apiInstance.ViewUserMetadataByKey(apiToken, userId, key);
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

