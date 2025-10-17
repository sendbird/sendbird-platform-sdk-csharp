# sendbird_platform_sdk.Api.ModerationApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BlockAUser**](ModerationApi.md#blockauser) | **POST** /v3/users/{user_id}/block | Block a user
[**FreezeAGroupChannel**](ModerationApi.md#freezeagroupchannel) | **PUT** /v3/group_channels/{channel_url}/freeze | Freeze a group channel
[**FreezeAnOpenChannel**](ModerationApi.md#freezeanopenchannel) | **PUT** /v3/open_channels/{channel_url}/freeze | Freeze an open channel
[**ListBlockedUsers**](ModerationApi.md#listblockedusers) | **GET** /v3/users/{user_id}/block | List blocked users
[**UnblockAUser**](ModerationApi.md#unblockauser) | **DELETE** /v3/users/{user_id}/block/{target_id} | Unblock a user



## BlockAUser

> BlockAUserResponse BlockAUser (string userId, string apiToken = null, BlockAUserRequest blockAUserRequest = null)

Block a user

## Block a user  A user can block another user if the user doesn't wish to receive any messages or notifications from the blocked user in a 1-to-1 group channel. In a 1-to-N group channel, the user can still receive messages from the blocked user, but this depends on the UI settings of the chat view. In any case, notifications from the blocked user won't be delivered to the 1-to-N group channel. You can choose whether or not the user can view [which users are blocked](https://sendbird.com/docs/chat/platform-api/v3/moderation/listing-blocked-and-blocking-users/list-blocked-and-blocking-users) in the channel UI.  Sendbird application provides two blocking options: include or exclude blocked users when sending invitations, and turn on or off notifications from blocked users. [Explicit and classic block modes](https://sendbird.com/docs/chat/platform-api/v3/deprecated#2-explicit-and-classic-block-modes) have been deprecated and are only supported for customers who started using them before they were deprecated.  - **Include or exclude blocked users when sending invitations**: Determines whether or not to automatically filter out blocked users when a user invites a group of users to a new group channel. By default, blocked users are included when sending invitations. The value of this option can be changed by Sendbird if your Sendbird application isn't integrated with the client app. If you want to change the value, [contact our sales team](https://get.sendbird.com/talk-to-sales.html).      - **Turn on or off notifications from blocked users**: Determines whether or not to receive message notifications from the blocked user in a specific 1-to-N group channel where they are both members. By default, a user doesn't receive notifications from blocked users. The value of this option can be set individually per channel. If you want to use this option, [contact our sales team](https://get.sendbird.com/talk-to-sales.html).  > **Note**: To learn more about other available moderation tools, see [Moderation Overview](https://sendbird.com/docs/chat/platform-api/v3/moderation/moderation-overview#2-actions).  The following tables explain what happens to a user's chat experience when the user blocks another user in a 1-to-1 or 1-to-N group channel. In the case of a 1-to-1 group channel, the block mode is only maintained with the original members. If other than the original members are added, the rules for 1-to-N group channel begin to apply.  [https://sendbird.com/docs/chat/platform-api/v3/moderation/blocking-users/block-users#1-block-users](https://sendbird.com/docs/chat/platform-api/v3/moderation/blocking-users/block-users#1-block-users)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class BlockAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var blockAUserRequest = new BlockAUserRequest(); // BlockAUserRequest |  (optional) 

            try
            {
                // Block a user
                BlockAUserResponse result = apiInstance.BlockAUser(userId, apiToken, blockAUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.BlockAUser: " + e.Message );
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **blockAUserRequest** | [**BlockAUserRequest**](BlockAUserRequest.md)|  | [optional] 

### Return type

[**BlockAUserResponse**](BlockAUserResponse.md)

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


## FreezeAGroupChannel

> SendbirdGroupChannelDetail FreezeAGroupChannel (string channelUrl, string apiToken = null, FreezeAGroupChannelRequest freezeAGroupChannelRequest = null)

Freeze a group channel

## Freeze a group channel  Freezes or unfreezes a group channel.  > **Note**: To learn more about other available moderation tools, see [Moderation Overview](https://sendbird.com/docs/chat/platform-api/v3/moderation/moderation-overview#2-actions).      [https://sendbird.com/docs/chat/platform-api/v3/moderation/freezing-a-channel/freeze-a-group-channel#1-freeze-a-group-channel](https://sendbird.com/docs/chat/platform-api/v3/moderation/freezing-a-channel/freeze-a-group-channel#1-freeze-a-group-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class FreezeAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var freezeAGroupChannelRequest = new FreezeAGroupChannelRequest(); // FreezeAGroupChannelRequest |  (optional) 

            try
            {
                // Freeze a group channel
                SendbirdGroupChannelDetail result = apiInstance.FreezeAGroupChannel(channelUrl, apiToken, freezeAGroupChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.FreezeAGroupChannel: " + e.Message );
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
 **freezeAGroupChannelRequest** | [**FreezeAGroupChannelRequest**](FreezeAGroupChannelRequest.md)|  | [optional] 

### Return type

[**SendbirdGroupChannelDetail**](SendbirdGroupChannelDetail.md)

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


## FreezeAnOpenChannel

> SendbirdOpenChannel FreezeAnOpenChannel (string channelUrl, string apiToken = null, FreezeAnOpenChannelRequest freezeAnOpenChannelRequest = null)

Freeze an open channel

## Freeze an open channel  Freezes or unfreezes an open channel.  > **Note**: To learn more about other available moderation tools, see [Moderation Overview](https://sendbird.com/docs/chat/platform-api/v3/moderation/moderation-overview#2-actions).      [https://sendbird.com/docs/chat/platform-api/v3/moderation/freezing-a-channel/freeze-an-open-channel#1-freeze-an-open-channel](https://sendbird.com/docs/chat/platform-api/v3/moderation/freezing-a-channel/freeze-an-open-channel#1-freeze-an-open-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class FreezeAnOpenChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var freezeAnOpenChannelRequest = new FreezeAnOpenChannelRequest(); // FreezeAnOpenChannelRequest |  (optional) 

            try
            {
                // Freeze an open channel
                SendbirdOpenChannel result = apiInstance.FreezeAnOpenChannel(channelUrl, apiToken, freezeAnOpenChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.FreezeAnOpenChannel: " + e.Message );
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
 **freezeAnOpenChannelRequest** | [**FreezeAnOpenChannelRequest**](FreezeAnOpenChannelRequest.md)|  | [optional] 

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


## ListBlockedUsers

> ListBlockedUsersResponse ListBlockedUsers (string userId, string list = null, string token = null, int? limit = null, string userIds = null, string metadatakey = null, string metadatavaluesIn = null, string apiToken = null)

List blocked users

## List blocked by and blocking users  This action retrieves a list of users who are either blocked by a specific user or a list of users who are blocking a specific user.  [https://sendbird.com/docs/chat/platform-api/v3/moderation/listing-blocked-and-blocking-users/list-blocked-and-blocking-users#1-list-blocked-by-and-blocking-users](https://sendbird.com/docs/chat/platform-api/v3/moderation/listing-blocked-and-blocking-users/list-blocked-and-blocking-users#1-list-blocked-by-and-blocking-users)  `user_id`   Type: string   Description: Specifies the unique ID of the target user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListBlockedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var list = "blocked_by_me";  // string | Specifies whether to retrieve a list of users who are blocked by the specified user or a list of users who are blocking the specified user. Acceptable values are blocked_by_me and blocking_me. The `me` in the values refers to the user specified in the parameter. (Default: blocked_by_me) (optional) 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var userIds = "userIds_example";  // string | Specifies the user IDs of the blocked or blocking users to search for. The value should be a comma-separated string that consists of multiple URL encoded user IDs. (optional) 
            var metadatakey = "metadatakey_example";  // string |  (optional) 
            var metadatavaluesIn = "metadatavaluesIn_example";  // string |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List blocked users
                ListBlockedUsersResponse result = apiInstance.ListBlockedUsers(userId, list, token, limit, userIds, metadatakey, metadatavaluesIn, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.ListBlockedUsers: " + e.Message );
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
 **userId** | **string**| (Required)  | 
 **list** | **string**| Specifies whether to retrieve a list of users who are blocked by the specified user or a list of users who are blocking the specified user. Acceptable values are blocked_by_me and blocking_me. The &#x60;me&#x60; in the values refers to the user specified in the parameter. (Default: blocked_by_me) | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **userIds** | **string**| Specifies the user IDs of the blocked or blocking users to search for. The value should be a comma-separated string that consists of multiple URL encoded user IDs. | [optional] 
 **metadatakey** | **string**|  | [optional] 
 **metadatavaluesIn** | **string**|  | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListBlockedUsersResponse**](ListBlockedUsersResponse.md)

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


## UnblockAUser

> Object UnblockAUser (string userId, string targetId, string apiToken = null)

Unblock a user

## Unblock a user  Unblocks the user.  https://sendbird.com/docs/chat/platform-api/v3/moderation/blocking-users/unblock-a-user#1-unblock-a-user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnblockAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var targetId = "targetId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unblock a user
                Object result = apiInstance.UnblockAUser(userId, targetId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.UnblockAUser: " + e.Message );
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
 **userId** | **string**| (Required)  | 
 **targetId** | **string**| (Required)  | 
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

