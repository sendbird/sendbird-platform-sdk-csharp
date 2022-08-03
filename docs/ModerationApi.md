# sendbird_platform_sdk.Api.ModerationApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BanFromChannelsWithCustomChannelTypes**](ModerationApi.md#banfromchannelswithcustomchanneltypes) | **POST** /v3/users/{user_id}/banned_channel_custom_types | Ban from channels with custom channel types
[**BlockUser**](ModerationApi.md#blockuser) | **POST** /v3/users/{user_id}/block | Block a user
[**GcBanUser**](ModerationApi.md#gcbanuser) | **POST** /v3/group_channels/{channel_url}/ban | Ban a user
[**GcFreezeChannel**](ModerationApi.md#gcfreezechannel) | **PUT** /v3/group_channels/{channel_url}/freeze | Freeze a channel
[**GcListBannedUsers**](ModerationApi.md#gclistbannedusers) | **GET** /v3/group_channels/{channel_url}/ban | List banned users
[**GcListMutedUsers**](ModerationApi.md#gclistmutedusers) | **GET** /v3/group_channels/{channel_url}/mute | List muted users
[**GcMuteUser**](ModerationApi.md#gcmuteuser) | **POST** /v3/group_channels/{channel_url}/mute | Mute a user
[**GcUnbanUserById**](ModerationApi.md#gcunbanuserbyid) | **DELETE** /v3/group_channels/{channel_url}/ban/{banned_user_id} | Unban a user
[**GcUnmuteUserById**](ModerationApi.md#gcunmuteuserbyid) | **DELETE** /v3/group_channels/{channel_url}/mute/{muted_user_id} | Unmute a user
[**GcUpdateBanById**](ModerationApi.md#gcupdatebanbyid) | **PUT** /v3/group_channels/{channel_url}/ban/{banned_user_id} | Update a ban
[**GcViewBanById**](ModerationApi.md#gcviewbanbyid) | **GET** /v3/group_channels/{channel_url}/ban/{banned_user_id} | View a ban
[**GcViewMuteById**](ModerationApi.md#gcviewmutebyid) | **GET** /v3/group_channels/{channel_url}/mute/{muted_user_id} | View a mute
[**ListBannedChannels**](ModerationApi.md#listbannedchannels) | **GET** /v3/users/{user_id}/ban | List banned channels
[**ListBlockedUsers**](ModerationApi.md#listblockedusers) | **GET** /v3/users/{user_id}/block | List blocked users
[**ListMutedChannels**](ModerationApi.md#listmutedchannels) | **GET** /v3/users/{user_id}/mute | List muted channels
[**MuteInChannelsWithCustomChannelTypes**](ModerationApi.md#muteinchannelswithcustomchanneltypes) | **POST** /v3/users/{user_id}/muted_channel_custom_types | Mute in channels with custom channel types
[**OcBanUser**](ModerationApi.md#ocbanuser) | **POST** /v3/open_channels/{channel_url}/ban | Ban a user
[**OcFreezeChannel**](ModerationApi.md#ocfreezechannel) | **PUT** /v3/open_channels/{channel_url}/freeze | Freeze a channel
[**OcListBannedUsers**](ModerationApi.md#oclistbannedusers) | **GET** /v3/open_channels/{channel_url}/ban | List banned users
[**OcListMutedUsers**](ModerationApi.md#oclistmutedusers) | **GET** /v3/open_channels/{channel_url}/mute | List muted users
[**OcMuteUser**](ModerationApi.md#ocmuteuser) | **POST** /v3/open_channels/{channel_url}/mute | Mute a user
[**OcUnbanUserById**](ModerationApi.md#ocunbanuserbyid) | **DELETE** /v3/open_channels/{channel_url}/ban/{banned_user_id} | Unban a user
[**OcUnmuteUserById**](ModerationApi.md#ocunmuteuserbyid) | **DELETE** /v3/open_channels/{channel_url}/mute/{muted_user_id} | Unmute a user
[**OcUpdateBanById**](ModerationApi.md#ocupdatebanbyid) | **PUT** /v3/open_channels/{channel_url}/ban/{banned_user_id} | Update a ban
[**OcViewBanById**](ModerationApi.md#ocviewbanbyid) | **GET** /v3/open_channels/{channel_url}/ban/{banned_user_id} | View a ban
[**OcViewMuteById**](ModerationApi.md#ocviewmutebyid) | **GET** /v3/open_channels/{channel_url}/mute/{muted_user_id} | View a mute
[**UnblockUserById**](ModerationApi.md#unblockuserbyid) | **DELETE** /v3/users/{user_id}/block/{target_id} | Unblock a user



## BanFromChannelsWithCustomChannelTypes

> Object BanFromChannelsWithCustomChannelTypes (string apiToken, string userId, BanFromChannelsWithCustomChannelTypesData banFromChannelsWithCustomChannelTypesData = null)

Ban from channels with custom channel types

## Ban from channels with custom channel types  Bans a user from channels with particular custom channel types.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-ban-from-channels-with-custom-channel-types - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class BanFromChannelsWithCustomChannelTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var banFromChannelsWithCustomChannelTypesData = new BanFromChannelsWithCustomChannelTypesData(); // BanFromChannelsWithCustomChannelTypesData |  (optional) 

            try
            {
                // Ban from channels with custom channel types
                Object result = apiInstance.BanFromChannelsWithCustomChannelTypes(apiToken, userId, banFromChannelsWithCustomChannelTypesData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.BanFromChannelsWithCustomChannelTypes: " + e.Message );
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
 **banFromChannelsWithCustomChannelTypesData** | [**BanFromChannelsWithCustomChannelTypesData**](BanFromChannelsWithCustomChannelTypesData.md)|  | [optional] 

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


## BlockUser

> BlockUserResponse BlockUser (string apiToken, string userId, BlockUserData blockUserData = null)

Block a user

## Block a user  Allows a user to block another user. A user doesn't receive messages from someone they have blocked anymore. Also, blocking someone doesn't alert them that they have been blocked. Blocked users still can send messages as normal in the channel: however, they can't receive any messages from the users who have blocked them.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-block-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class BlockUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var blockUserData = new BlockUserData(); // BlockUserData |  (optional) 

            try
            {
                // Block a user
                BlockUserResponse result = apiInstance.BlockUser(apiToken, userId, blockUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.BlockUser: " + e.Message );
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
 **blockUserData** | [**BlockUserData**](BlockUserData.md)|  | [optional] 

### Return type

[**BlockUserResponse**](BlockUserResponse.md)

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


## GcBanUser

> GcBanUserResponse GcBanUser (string apiToken, string channelUrl, GcBanUserData gcBanUserData = null)

Ban a user

## Ban a user  Bans a user from a group channel. A banned user is immediately expelled from a channel and allowed to join the channel again after a set time period.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-ban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcBanUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var gcBanUserData = new GcBanUserData(); // GcBanUserData |  (optional) 

            try
            {
                // Ban a user
                GcBanUserResponse result = apiInstance.GcBanUser(apiToken, channelUrl, gcBanUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcBanUser: " + e.Message );
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
 **gcBanUserData** | [**GcBanUserData**](GcBanUserData.md)|  | [optional] 

### Return type

[**GcBanUserResponse**](GcBanUserResponse.md)

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


## GcFreezeChannel

> SendBirdGroupChannel GcFreezeChannel (string apiToken, string channelUrl, GcFreezeChannelData gcFreezeChannelData = null)

Freeze a channel

## Freeze a channel  Freezes or unfreezes a group channel.  > __Note__: Only users designated as channel operators are allowed to talk when a channel is frozen.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-freeze-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcFreezeChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var gcFreezeChannelData = new GcFreezeChannelData(); // GcFreezeChannelData |  (optional) 

            try
            {
                // Freeze a channel
                SendBirdGroupChannel result = apiInstance.GcFreezeChannel(apiToken, channelUrl, gcFreezeChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcFreezeChannel: " + e.Message );
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
 **gcFreezeChannelData** | [**GcFreezeChannelData**](GcFreezeChannelData.md)|  | [optional] 

### Return type

[**SendBirdGroupChannel**](SendBirdGroupChannel.md)

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


## GcListBannedUsers

> GcListBannedUsersResponse GcListBannedUsers (string apiToken, string channelUrl, string token = null, int? limit = null)

List banned users

## List banned users  Retrieves a list of the banned users from a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-list-banned-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel where to retrieve a list of banned users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcListBannedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned users
                GcListBannedUsersResponse result = apiInstance.GcListBannedUsers(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcListBannedUsers: " + e.Message );
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

[**GcListBannedUsersResponse**](GcListBannedUsersResponse.md)

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


## GcListMutedUsers

> GcListMutedUsersResponse GcListMutedUsers (string apiToken, string channelUrl, string token = null, int? limit = null)

List muted users

## List muted users  Retrieves a list of the muted users in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-list-muted-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of muted users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcListMutedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted users
                GcListMutedUsersResponse result = apiInstance.GcListMutedUsers(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcListMutedUsers: " + e.Message );
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

[**GcListMutedUsersResponse**](GcListMutedUsersResponse.md)

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


## GcMuteUser

> SendBirdGroupChannel GcMuteUser (string apiToken, string channelUrl, GcMuteUserData gcMuteUserData = null)

Mute a user

## Mute a user  Mutes a user in a group channel. A muted user remains in the channel and is allowed to view the messages, but can't send any messages until unmuted.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-mute-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcMuteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var gcMuteUserData = new GcMuteUserData(); // GcMuteUserData |  (optional) 

            try
            {
                // Mute a user
                SendBirdGroupChannel result = apiInstance.GcMuteUser(apiToken, channelUrl, gcMuteUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcMuteUser: " + e.Message );
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
 **gcMuteUserData** | [**GcMuteUserData**](GcMuteUserData.md)|  | [optional] 

### Return type

[**SendBirdGroupChannel**](SendBirdGroupChannel.md)

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


## GcUnbanUserById

> OcDeleteChannelByUrl200Response GcUnbanUserById (string apiToken, string channelUrl, string bannedUserId)

Unban a user

## Unban a user  Unbans a user from a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-unban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcUnbanUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 

            try
            {
                // Unban a user
                OcDeleteChannelByUrl200Response result = apiInstance.GcUnbanUserById(apiToken, channelUrl, bannedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcUnbanUserById: " + e.Message );
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
 **bannedUserId** | **string**|  | 

### Return type

[**OcDeleteChannelByUrl200Response**](OcDeleteChannelByUrl200Response.md)

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


## GcUnmuteUserById

> OcDeleteChannelByUrl200Response GcUnmuteUserById (string apiToken, string channelUrl, string mutedUserId)

Unmute a user

## Unmute a user  Unmutes a user within a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-unmute-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcUnmuteUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var mutedUserId = "mutedUserId_example";  // string | 

            try
            {
                // Unmute a user
                OcDeleteChannelByUrl200Response result = apiInstance.GcUnmuteUserById(apiToken, channelUrl, mutedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcUnmuteUserById: " + e.Message );
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
 **mutedUserId** | **string**|  | 

### Return type

[**OcDeleteChannelByUrl200Response**](OcDeleteChannelByUrl200Response.md)

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


## GcUpdateBanById

> GcUpdateBanByIdResponse GcUpdateBanById (string apiToken, string channelUrl, string bannedUserId, GcUpdateBanByIdData gcUpdateBanByIdData = null)

Update a ban

## Update a ban  Updates details of a ban imposed on a user. You can change the length of the ban with this action, and also provide an updated description.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-update-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcUpdateBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 
            var gcUpdateBanByIdData = new GcUpdateBanByIdData(); // GcUpdateBanByIdData |  (optional) 

            try
            {
                // Update a ban
                GcUpdateBanByIdResponse result = apiInstance.GcUpdateBanById(apiToken, channelUrl, bannedUserId, gcUpdateBanByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcUpdateBanById: " + e.Message );
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
 **bannedUserId** | **string**|  | 
 **gcUpdateBanByIdData** | [**GcUpdateBanByIdData**](GcUpdateBanByIdData.md)|  | [optional] 

### Return type

[**GcUpdateBanByIdResponse**](GcUpdateBanByIdResponse.md)

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


## GcViewBanById

> GcViewBanByIdResponse GcViewBanById (string apiToken, string channelUrl, string bannedUserId)

View a ban

## View a ban  Retrieves details of a ban imposed on a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-view-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcViewBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 

            try
            {
                // View a ban
                GcViewBanByIdResponse result = apiInstance.GcViewBanById(apiToken, channelUrl, bannedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcViewBanById: " + e.Message );
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
 **bannedUserId** | **string**|  | 

### Return type

[**GcViewBanByIdResponse**](GcViewBanByIdResponse.md)

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


## GcViewMuteById

> GcViewMuteByIdResponse GcViewMuteById (string apiToken, string channelUrl, string mutedUserId)

View a mute

## View a mute  Checks if a user is muted in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-view-a-mute - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcViewMuteByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var mutedUserId = "mutedUserId_example";  // string | 

            try
            {
                // View a mute
                GcViewMuteByIdResponse result = apiInstance.GcViewMuteById(apiToken, channelUrl, mutedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.GcViewMuteById: " + e.Message );
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
 **mutedUserId** | **string**|  | 

### Return type

[**GcViewMuteByIdResponse**](GcViewMuteByIdResponse.md)

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


## ListBannedChannels

> ListBannedChannelsResponse ListBannedChannels (string apiToken, string userId, string token = null, int? limit = null)

List banned channels

## List banned channels  Retrieves a list of open and group channels with additional information where a user is banned.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-banned-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the target user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListBannedChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned channels
                ListBannedChannelsResponse result = apiInstance.ListBannedChannels(apiToken, userId, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.ListBannedChannels: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**ListBannedChannelsResponse**](ListBannedChannelsResponse.md)

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


## ListBlockedUsers

> ListBlockedUsersResponse ListBlockedUsers (string apiToken, string userId, string token = null, int? limit = null, string userIds = null, string metadatakey = null, string metadatavaluesIn = null)

List blocked users

## List blocked users  Retrieves a list of other users that a user has blocked.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-blocked-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the target user.

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
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var userIds = "userIds_example";  // string |  (optional) 
            var metadatakey = "metadatakey_example";  // string |  (optional) 
            var metadatavaluesIn = "metadatavaluesIn_example";  // string |  (optional) 

            try
            {
                // List blocked users
                ListBlockedUsersResponse result = apiInstance.ListBlockedUsers(apiToken, userId, token, limit, userIds, metadatakey, metadatavaluesIn);
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
 **apiToken** | **string**|  | 
 **userId** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **userIds** | **string**|  | [optional] 
 **metadatakey** | **string**|  | [optional] 
 **metadatavaluesIn** | **string**|  | [optional] 

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


## ListMutedChannels

> ListMutedChannelsResponse ListMutedChannels (string apiToken, string userId, string token = null, int? limit = null)

List muted channels

## List muted channels  Retrieves a list of open and group channels with additional information where a user is muted.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-muted-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the target user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListMutedChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted channels
                ListMutedChannelsResponse result = apiInstance.ListMutedChannels(apiToken, userId, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.ListMutedChannels: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**ListMutedChannelsResponse**](ListMutedChannelsResponse.md)

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


## MuteInChannelsWithCustomChannelTypes

> Object MuteInChannelsWithCustomChannelTypes (string apiToken, string userId, MuteInChannelsWithCustomChannelTypesData muteInChannelsWithCustomChannelTypesData = null)

Mute in channels with custom channel types

## Mute in channels with custom channel types  Mutes a user in channels with particular custom channel types.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-mute-in-channels-with-custom-channel-types - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MuteInChannelsWithCustomChannelTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var muteInChannelsWithCustomChannelTypesData = new MuteInChannelsWithCustomChannelTypesData(); // MuteInChannelsWithCustomChannelTypesData |  (optional) 

            try
            {
                // Mute in channels with custom channel types
                Object result = apiInstance.MuteInChannelsWithCustomChannelTypes(apiToken, userId, muteInChannelsWithCustomChannelTypesData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.MuteInChannelsWithCustomChannelTypes: " + e.Message );
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
 **muteInChannelsWithCustomChannelTypesData** | [**MuteInChannelsWithCustomChannelTypesData**](MuteInChannelsWithCustomChannelTypesData.md)|  | [optional] 

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


## OcBanUser

> OcBanUserResponse OcBanUser (string apiToken, string channelUrl, OcBanUserData ocBanUserData = null)

Ban a user

## Ban a user  Bans a user from an open channel. A banned user is immediately expelled from a channel and allowed to participate in the channel again after a set time period.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-ban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcBanUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var ocBanUserData = new OcBanUserData(); // OcBanUserData |  (optional) 

            try
            {
                // Ban a user
                OcBanUserResponse result = apiInstance.OcBanUser(apiToken, channelUrl, ocBanUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcBanUser: " + e.Message );
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
 **ocBanUserData** | [**OcBanUserData**](OcBanUserData.md)|  | [optional] 

### Return type

[**OcBanUserResponse**](OcBanUserResponse.md)

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


## OcFreezeChannel

> SendBirdOpenChannel OcFreezeChannel (string apiToken, string channelUrl, OcFreezeChannelData ocFreezeChannelData = null)

Freeze a channel

## Freeze a channel  Freezes or unfreezes an open channel.  > __Note__: Only users designated as channel operators are allowed to talk when a channel is frozen.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-freeze-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcFreezeChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var ocFreezeChannelData = new OcFreezeChannelData(); // OcFreezeChannelData |  (optional) 

            try
            {
                // Freeze a channel
                SendBirdOpenChannel result = apiInstance.OcFreezeChannel(apiToken, channelUrl, ocFreezeChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcFreezeChannel: " + e.Message );
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
 **ocFreezeChannelData** | [**OcFreezeChannelData**](OcFreezeChannelData.md)|  | [optional] 

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


## OcListBannedUsers

> OcListBannedUsersResponse OcListBannedUsers (string apiToken, string channelUrl, string token = null, int? limit = null)

List banned users

## List banned users  Retrieves a list of banned users from a specific open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-banned-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel where to retrieve a list of banned users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListBannedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned users
                OcListBannedUsersResponse result = apiInstance.OcListBannedUsers(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcListBannedUsers: " + e.Message );
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

[**OcListBannedUsersResponse**](OcListBannedUsersResponse.md)

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


## OcListMutedUsers

> OcListMutedUsersResponse OcListMutedUsers (string apiToken, string channelUrl, string token = null, int? limit = null)

List muted users

## List muted users  Retrieves a list of muted users in the channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-muted-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of muted users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListMutedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted users
                OcListMutedUsersResponse result = apiInstance.OcListMutedUsers(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcListMutedUsers: " + e.Message );
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

[**OcListMutedUsersResponse**](OcListMutedUsersResponse.md)

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


## OcMuteUser

> SendBirdOpenChannel OcMuteUser (string apiToken, string channelUrl, OcMuteUserData ocMuteUserData = null)

Mute a user

## Mute a user  Mutes a user in the channel. A muted user remains in the channel and is allowed to view the messages, but can't send any messages until unmuted.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-mute-a-user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcMuteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var ocMuteUserData = new OcMuteUserData(); // OcMuteUserData |  (optional) 

            try
            {
                // Mute a user
                SendBirdOpenChannel result = apiInstance.OcMuteUser(apiToken, channelUrl, ocMuteUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcMuteUser: " + e.Message );
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
 **ocMuteUserData** | [**OcMuteUserData**](OcMuteUserData.md)|  | [optional] 

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


## OcUnbanUserById

> OcDeleteChannelByUrl200Response OcUnbanUserById (string apiToken, string channelUrl, string bannedUserId)

Unban a user

## Unban a user  Unbans a user from an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-unban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUnbanUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 

            try
            {
                // Unban a user
                OcDeleteChannelByUrl200Response result = apiInstance.OcUnbanUserById(apiToken, channelUrl, bannedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcUnbanUserById: " + e.Message );
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
 **bannedUserId** | **string**|  | 

### Return type

[**OcDeleteChannelByUrl200Response**](OcDeleteChannelByUrl200Response.md)

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


## OcUnmuteUserById

> OcDeleteChannelByUrl200Response OcUnmuteUserById (string apiToken, string channelUrl, string mutedUserId)

Unmute a user

## Unmute a user  Unmutes a user from an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-unmute-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUnmuteUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var mutedUserId = "mutedUserId_example";  // string | 

            try
            {
                // Unmute a user
                OcDeleteChannelByUrl200Response result = apiInstance.OcUnmuteUserById(apiToken, channelUrl, mutedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcUnmuteUserById: " + e.Message );
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
 **mutedUserId** | **string**|  | 

### Return type

[**OcDeleteChannelByUrl200Response**](OcDeleteChannelByUrl200Response.md)

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


## OcUpdateBanById

> OcUpdateBanByIdResponse OcUpdateBanById (string apiToken, string channelUrl, string bannedUserId, OcUpdateBanByIdData ocUpdateBanByIdData = null)

Update a ban

## Update a ban  Updates details of a ban imposed on a user. You can change the length of a ban with this action, and also provide an updated description.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-update-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUpdateBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 
            var ocUpdateBanByIdData = new OcUpdateBanByIdData(); // OcUpdateBanByIdData |  (optional) 

            try
            {
                // Update a ban
                OcUpdateBanByIdResponse result = apiInstance.OcUpdateBanById(apiToken, channelUrl, bannedUserId, ocUpdateBanByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcUpdateBanById: " + e.Message );
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
 **bannedUserId** | **string**|  | 
 **ocUpdateBanByIdData** | [**OcUpdateBanByIdData**](OcUpdateBanByIdData.md)|  | [optional] 

### Return type

[**OcUpdateBanByIdResponse**](OcUpdateBanByIdResponse.md)

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


## OcViewBanById

> OcViewBanByIdResponse OcViewBanById (string apiToken, string channelUrl, string bannedUserId)

View a ban

## View a ban  Retrieves details of a ban imposed on a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var bannedUserId = "bannedUserId_example";  // string | 

            try
            {
                // View a ban
                OcViewBanByIdResponse result = apiInstance.OcViewBanById(apiToken, channelUrl, bannedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcViewBanById: " + e.Message );
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
 **bannedUserId** | **string**|  | 

### Return type

[**OcViewBanByIdResponse**](OcViewBanByIdResponse.md)

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


## OcViewMuteById

> OcViewMuteByIdResponse OcViewMuteById (string apiToken, string channelUrl, string mutedUserId)

View a mute

## View a mute  Checks if a user is muted in an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-mute - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewMuteByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var mutedUserId = "mutedUserId_example";  // string | 

            try
            {
                // View a mute
                OcViewMuteByIdResponse result = apiInstance.OcViewMuteById(apiToken, channelUrl, mutedUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.OcViewMuteById: " + e.Message );
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
 **mutedUserId** | **string**|  | 

### Return type

[**OcViewMuteByIdResponse**](OcViewMuteByIdResponse.md)

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


## UnblockUserById

> Object UnblockUserById (string apiToken, string userId, string targetId)

Unblock a user

## Unblock a user  Unblocks the user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-unblock-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnblockUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ModerationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var userId = "userId_example";  // string | 
            var targetId = "targetId_example";  // string | 

            try
            {
                // Unblock a user
                Object result = apiInstance.UnblockUserById(apiToken, userId, targetId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ModerationApi.UnblockUserById: " + e.Message );
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
 **targetId** | **string**|  | 

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

