# sendbird_platform_sdk.Api.MetadataApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAChannelMetadata**](MetadataApi.md#createachannelmetadata) | **POST** /v3/{channel_type}/{channel_url}/metadata | Create a channel metadata
[**DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadata**](MetadataApi.md#deleteachannelmetadatawhendeletingallitemsofachannelmetadata) | **DELETE** /v3/{channel_type}/{channel_url}/metadata | Delete a channel metadata - When deleting all items of a channel metadata
[**UpdateAChannelMetadata**](MetadataApi.md#updateachannelmetadata) | **PUT** /v3/{channel_type}/{channel_url}/metadata | Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
[**ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadata**](MetadataApi.md#viewachannelmetadatawhenretrievingallitemsofachannelmetadata) | **GET** /v3/{channel_type}/{channel_url}/metadata | View a channel metadata - When retrieving all items of a channel metadata



## CreateAChannelMetadata

> CreateAChannelMetadataResponse CreateAChannelMetadata (string channelType, string channelUrl, string apiToken = null, CreateAChannelMetadataRequest createAChannelMetadataRequest = null)

Create a channel metadata

## Create a channel metadata  Creates a channel metadata's items to store in a channel.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-metadata/channel-create-metadata#1-create-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateAChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createAChannelMetadataRequest = new CreateAChannelMetadataRequest(); // CreateAChannelMetadataRequest |  (optional) 

            try
            {
                // Create a channel metadata
                CreateAChannelMetadataResponse result = apiInstance.CreateAChannelMetadata(channelType, channelUrl, apiToken, createAChannelMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.CreateAChannelMetadata: " + e.Message );
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
 **channelType** | **string**| (Required)  | 
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **createAChannelMetadataRequest** | [**CreateAChannelMetadataRequest**](CreateAChannelMetadataRequest.md)|  | [optional] 

### Return type

[**CreateAChannelMetadataResponse**](CreateAChannelMetadataResponse.md)

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


## DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadata

> Object DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadata (string channelType, string channelUrl, string key = null, string apiToken = null)

Delete a channel metadata - When deleting all items of a channel metadata

## Delete a channel metadata  Deletes a channel metadata's one or all items that are stored in a channel.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-metadata/channel-delete-metadata#1-delete-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel which has the metadata to delete.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var key = "key_example";  // string |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a channel metadata - When deleting all items of a channel metadata
                Object result = apiInstance.DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadata(channelType, channelUrl, key, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.DeleteAChannelMetadataWhenDeletingAllItemsOfAChannelMetadata: " + e.Message );
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
 **channelType** | **string**| (Required)  | 
 **channelUrl** | **string**| (Required)  | 
 **key** | **string**|  | [optional] 
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


## UpdateAChannelMetadata

> Object UpdateAChannelMetadata (string channelType, string channelUrl, string apiToken = null, UpdateAChannelMetadataRequest updateAChannelMetadataRequest = null)

Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata

## Update a channel metadata  Updates existing items of a channel metadata by their keys, or adds new items to the metadata.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-metadata/channel-update-metadata#1-update-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAChannelMetadataRequest = new UpdateAChannelMetadataRequest(); // UpdateAChannelMetadataRequest |  (optional) 

            try
            {
                // Update a channel metadata - When updating existing items of a channel metadata by their keys or adding new items to the metadata
                Object result = apiInstance.UpdateAChannelMetadata(channelType, channelUrl, apiToken, updateAChannelMetadataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.UpdateAChannelMetadata: " + e.Message );
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
 **channelType** | **string**| (Required)  | 
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateAChannelMetadataRequest** | [**UpdateAChannelMetadataRequest**](UpdateAChannelMetadataRequest.md)|  | [optional] 

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


## ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadata

> Object ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadata (string channelType, string channelUrl, string key = null, string keys = null, string apiToken = null)

View a channel metadata - When retrieving all items of a channel metadata

## View a channel metadata  Retrieves a channel metadata's one or more items that are stored in a channel.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-metadata/channel-get-metadata#1-get-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadataExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MetadataApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var key = "key_example";  // string |  (optional) 
            var keys = "keys_example";  // string | In a query string, specifies an array of one or more keys of the metadata items. If not specified, all items of the metadata are returned. If specified, only the items that match the parameter values are returned. URL encoding each key is recommended. (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a channel metadata - When retrieving all items of a channel metadata
                Object result = apiInstance.ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadata(channelType, channelUrl, key, keys, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MetadataApi.ViewAChannelMetadataWhenRetrievingAllItemsOfAChannelMetadata: " + e.Message );
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
 **channelType** | **string**| (Required)  | 
 **channelUrl** | **string**| (Required)  | 
 **key** | **string**|  | [optional] 
 **keys** | **string**| In a query string, specifies an array of one or more keys of the metadata items. If not specified, all items of the metadata are returned. If specified, only the items that match the parameter values are returned. URL encoding each key is recommended. | [optional] 
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

