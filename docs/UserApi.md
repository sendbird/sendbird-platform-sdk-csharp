# sendbird_platform_sdk.Api.UserApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddRegistrationOrDeviceToken**](UserApi.md#addregistrationordevicetoken) | **POST** /v3/users/{user_id}/push/{token_type} | Add a registration or device token
[**BanFromChannelsWithCustomChannelTypes**](UserApi.md#banfromchannelswithcustomchanneltypes) | **POST** /v3/users/{user_id}/banned_channel_custom_types | Ban from channels with custom channel types
[**BlockUser**](UserApi.md#blockuser) | **POST** /v3/users/{user_id}/block | Block a user
[**ChoosePushNotificationContentTemplate**](UserApi.md#choosepushnotificationcontenttemplate) | **PUT** /v3/users/{user_id}/push/template | Choose a push notification content template
[**CreateUser**](UserApi.md#createuser) | **POST** /v3/users | Create a user
[**DeleteUserById**](UserApi.md#deleteuserbyid) | **DELETE** /v3/users/{user_id} | Delete a user
[**LeaveMyGroupChannels**](UserApi.md#leavemygroupchannels) | **PUT** /v3/users/{user_id}/my_group_channels/leave | Leave my group channels
[**ListBannedChannels**](UserApi.md#listbannedchannels) | **GET** /v3/users/{user_id}/ban | List banned channels
[**ListBlockedUsers**](UserApi.md#listblockedusers) | **GET** /v3/users/{user_id}/block | List blocked users
[**ListMutedChannels**](UserApi.md#listmutedchannels) | **GET** /v3/users/{user_id}/mute | List muted channels
[**ListMyGroupChannels**](UserApi.md#listmygroupchannels) | **GET** /v3/users/{user_id}/my_group_channels | List my group channels
[**ListRegistrationOrDeviceTokens**](UserApi.md#listregistrationordevicetokens) | **GET** /v3/users/{user_id}/push/{token_type} | List registration or device tokens
[**ListUsers**](UserApi.md#listusers) | **GET** /v3/users | List users
[**MarkAllMessagesAsRead**](UserApi.md#markallmessagesasread) | **PUT** /v3/users/{user_id}/mark_as_read_all | Mark all messages as read
[**MuteInChannelsWithCustomChannelTypes**](UserApi.md#muteinchannelswithcustomchanneltypes) | **POST** /v3/users/{user_id}/muted_channel_custom_types | Mute in channels with custom channel types
[**RegisterAsOperatorToChannelsWithCustomChannelTypes**](UserApi.md#registerasoperatortochannelswithcustomchanneltypes) | **POST** /v3/users/{user_id}/operating_channel_custom_types | Register as an operator to channels with custom channel types
[**RemoveRegistrationOrDeviceToken**](UserApi.md#removeregistrationordevicetoken) | **DELETE** /v3/users/{user_id}/push | Remove a registration or device token - When unregistering all device tokens
[**RemoveRegistrationOrDeviceTokenByToken**](UserApi.md#removeregistrationordevicetokenbytoken) | **DELETE** /v3/users/{user_id}/push/{token_type}/{token} | Remove a registration or device token - When unregistering a specific token
[**RemoveRegistrationOrDeviceTokenFromOwnerByToken**](UserApi.md#removeregistrationordevicetokenfromownerbytoken) | **DELETE** /v3/push/device_tokens/{token_type}/{token} | Remove a registration or device token from an owner
[**ResetPushPreferences**](UserApi.md#resetpushpreferences) | **DELETE** /v3/users/{user_id}/push_preference | Reset push preferences
[**UnblockUserById**](UserApi.md#unblockuserbyid) | **DELETE** /v3/users/{user_id}/block/{target_id} | Unblock a user
[**UpdateChannelInvitationPreference**](UserApi.md#updatechannelinvitationpreference) | **PUT** /v3/users/{user_id}/channel_invitation_preference | Update channel invitation preference
[**UpdateCountPreferenceOfChannelByUrl**](UserApi.md#updatecountpreferenceofchannelbyurl) | **PUT** /v3/users/{user_id}/count_preference/{channel_url} | Update count preference of a channel
[**UpdatePushPreferences**](UserApi.md#updatepushpreferences) | **PUT** /v3/users/{user_id}/push_preference | Update push preferences
[**UpdatePushPreferencesForChannelByUrl**](UserApi.md#updatepushpreferencesforchannelbyurl) | **PUT** /v3/users/{user_id}/push_preference/{channel_url} | Update push preferences for a channel
[**UpdateUserById**](UserApi.md#updateuserbyid) | **PUT** /v3/users/{user_id} | Update a user
[**ViewChannelInvitationPreference**](UserApi.md#viewchannelinvitationpreference) | **GET** /v3/users/{user_id}/channel_invitation_preference | View channel invitation preference
[**ViewCountPreferenceOfChannelByUrl**](UserApi.md#viewcountpreferenceofchannelbyurl) | **GET** /v3/users/{user_id}/count_preference/{channel_url} | View count preference of a channel
[**ViewNumberOfChannelsByJoinStatus**](UserApi.md#viewnumberofchannelsbyjoinstatus) | **GET** /v3/users/{user_id}/group_channel_count | View number of channels by join status
[**ViewNumberOfChannelsWithUnreadMessages**](UserApi.md#viewnumberofchannelswithunreadmessages) | **GET** /v3/users/{user_id}/unread_channel_count | View number of channels with unread messages
[**ViewNumberOfUnreadItems**](UserApi.md#viewnumberofunreaditems) | **GET** /v3/users/{user_id}/unread_item_count | View number of unread items
[**ViewNumberOfUnreadMessages**](UserApi.md#viewnumberofunreadmessages) | **GET** /v3/users/{user_id}/unread_message_count | View number of unread messages
[**ViewPushPreferences**](UserApi.md#viewpushpreferences) | **GET** /v3/users/{user_id}/push_preference | View push preferences
[**ViewPushPreferencesForChannelByUrl**](UserApi.md#viewpushpreferencesforchannelbyurl) | **GET** /v3/users/{user_id}/push_preference/{channel_url} | View push preferences for a channel
[**ViewUserById**](UserApi.md#viewuserbyid) | **GET** /v3/users/{user_id} | View a user
[**ViewWhoOwnsRegistrationOrDeviceTokenByToken**](UserApi.md#viewwhoownsregistrationordevicetokenbytoken) | **GET** /v3/push/device_tokens/{token_type}/{token} | View who owns a registration or device token



## AddRegistrationOrDeviceToken

> AddRegistrationOrDeviceTokenResponse AddRegistrationOrDeviceToken (string userId, string tokenType, string apiToken = null, AddRegistrationOrDeviceTokenData addRegistrationOrDeviceTokenData = null)

Add a registration or device token

## Add a registration or device token  > __Note__: A user can have up to 20 FCM registration tokens, 20 HMS device tokens, and 20 APNs device tokens each. The oldest token will be deleted before a new token is added for a user who already has 20 registration or device tokens. Only the 20 newest tokens will be maintained for users who already have more than 20 of each token type.  To send notification requests to push notification services on behalf of your server, adds a specific user's FCM registration token, HMS device token, or APNs device token to Sendbird server. Depending on which push service you are using, you can pass one of two values in `token_type`: `gcm`, `huawei`, or `apns`.  A FCM registration token and an APNs device token allow identification of each client app instance on each device, and are generated and registered by Android and iOS apps through the corresponding SDKs. Use this method if you need to register a token via your own server.  > __Note__: For more information on the registration token and device token, visit the Google's [FCM](https://firebase.google.com/docs/auth/admin/verify-id-tokens) page, Huawei's [Push kit](https://developer.huawei.com/consumer/en/doc/development/HMSCore-Guides/service-introduction-0000001050040060) and Apple's [APNs](https://developer.apple.com/library/content/documentation/NetworkingInternet/Conceptual/RemoteNotificationsPG/APNSOverview.html) page.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-add-a-registration-or-device-token - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddRegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var tokenType = tokenType_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addRegistrationOrDeviceTokenData = new AddRegistrationOrDeviceTokenData(); // AddRegistrationOrDeviceTokenData |  (optional) 

            try
            {
                // Add a registration or device token
                AddRegistrationOrDeviceTokenResponse result = apiInstance.AddRegistrationOrDeviceToken(userId, tokenType, apiToken, addRegistrationOrDeviceTokenData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.AddRegistrationOrDeviceToken: " + e.Message );
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
 **tokenType** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **addRegistrationOrDeviceTokenData** | [**AddRegistrationOrDeviceTokenData**](AddRegistrationOrDeviceTokenData.md)|  | [optional] 

### Return type

[**AddRegistrationOrDeviceTokenResponse**](AddRegistrationOrDeviceTokenResponse.md)

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


## BanFromChannelsWithCustomChannelTypes

> void BanFromChannelsWithCustomChannelTypes (string userId, string apiToken = null, BanFromChannelsWithCustomChannelTypesData banFromChannelsWithCustomChannelTypesData = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var banFromChannelsWithCustomChannelTypesData = new BanFromChannelsWithCustomChannelTypesData(); // BanFromChannelsWithCustomChannelTypesData |  (optional) 

            try
            {
                // Ban from channels with custom channel types
                apiInstance.BanFromChannelsWithCustomChannelTypes(userId, apiToken, banFromChannelsWithCustomChannelTypesData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.BanFromChannelsWithCustomChannelTypes: " + e.Message );
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
 **banFromChannelsWithCustomChannelTypesData** | [**BanFromChannelsWithCustomChannelTypesData**](BanFromChannelsWithCustomChannelTypesData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BlockUser

> SendBirdUser BlockUser (string userId, string apiToken = null, BlockUserData blockUserData = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var blockUserData = new BlockUserData(); // BlockUserData |  (optional) 

            try
            {
                // Block a user
                SendBirdUser result = apiInstance.BlockUser(userId, apiToken, blockUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.BlockUser: " + e.Message );
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
 **blockUserData** | [**BlockUserData**](BlockUserData.md)|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## ChoosePushNotificationContentTemplate

> ChoosePushNotificationContentTemplateResponse ChoosePushNotificationContentTemplate (string userId, string apiToken = null, Object body = null)

Choose a push notification content template

## Choose a push notification content template  Chooses a push notification content template of a user's own. The push notifications feature is only available for group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-choose-a-push-notification-content-template - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ChoosePushNotificationContentTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var body = ;  // Object |  (optional) 

            try
            {
                // Choose a push notification content template
                ChoosePushNotificationContentTemplateResponse result = apiInstance.ChoosePushNotificationContentTemplate(userId, apiToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ChoosePushNotificationContentTemplate: " + e.Message );
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
 **body** | **Object**|  | [optional] 

### Return type

[**ChoosePushNotificationContentTemplateResponse**](ChoosePushNotificationContentTemplateResponse.md)

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


## CreateUser

> SendBirdUser CreateUser (string apiToken = null, CreateUserData createUserData = null)

Create a user

## Create a user  Creates a new user in the application. A user is identified by its unique user ID, and additionally have a changeable nickname, profile image, and so on.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-create-a-user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createUserData = new CreateUserData(); // CreateUserData |  (optional) 

            try
            {
                // Create a user
                SendBirdUser result = apiInstance.CreateUser(apiToken, createUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.CreateUser: " + e.Message );
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
 **createUserData** | [**CreateUserData**](CreateUserData.md)|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## DeleteUserById

> void DeleteUserById (string userId, string apiToken = null)

Delete a user

## Delete a user  Deletes a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-delete-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a user
                apiInstance.DeleteUserById(userId, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUserById: " + e.Message );
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


## LeaveMyGroupChannels

> void LeaveMyGroupChannels (string userId, string apiToken = null, LeaveMyGroupChannelsData leaveMyGroupChannelsData = null)

Leave my group channels

## Leave my group channels  Makes a user leave all joined group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-leave-my-group-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the user to leave all joined group channels.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveMyGroupChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var leaveMyGroupChannelsData = new LeaveMyGroupChannelsData(); // LeaveMyGroupChannelsData |  (optional) 

            try
            {
                // Leave my group channels
                apiInstance.LeaveMyGroupChannels(userId, apiToken, leaveMyGroupChannelsData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.LeaveMyGroupChannels: " + e.Message );
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
 **leaveMyGroupChannelsData** | [**LeaveMyGroupChannelsData**](LeaveMyGroupChannelsData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListBannedChannels

> ListBannedChannelsResponse ListBannedChannels (string userId, string apiToken = null, string token = null, int? limit = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned channels
                ListBannedChannelsResponse result = apiInstance.ListBannedChannels(userId, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListBannedChannels: " + e.Message );
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

> ListBlockedUsersResponse ListBlockedUsers (string userId, string apiToken = null, string token = null, int? limit = null, string userIds = null, string metadatakey = null, string metadatavaluesIn = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var userIds = userIds_example;  // string |  (optional) 
            var metadatakey = metadatakey_example;  // string |  (optional) 
            var metadatavaluesIn = metadatavaluesIn_example;  // string |  (optional) 

            try
            {
                // List blocked users
                ListBlockedUsersResponse result = apiInstance.ListBlockedUsers(userId, apiToken, token, limit, userIds, metadatakey, metadatavaluesIn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListBlockedUsers: " + e.Message );
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

> ListMutedChannelsResponse ListMutedChannels (string userId, string apiToken = null, string token = null, int? limit = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted channels
                ListMutedChannelsResponse result = apiInstance.ListMutedChannels(userId, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListMutedChannels: " + e.Message );
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


## ListMyGroupChannels

> ListMyGroupChannelsResponse ListMyGroupChannels (string userId, string apiToken = null, string token = null, int? limit = null, string distinctMode = null, string publicMode = null, string superMode = null, string hiddenMode = null, string memberStateFilter = null, string unreadFilter = null, int? createdAfter = null, int? createdBefore = null, bool? showEmpty = null, bool? showFrozen = null, bool? showMember = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, string order = null, string metadataOrderKey = null, string customTypes = null, string customTypeStartswith = null, string channelUrls = null, string name = null, string nameContains = null, string nameStartswith = null, string membersExactlyIn = null, string membersIncludeIn = null, string queryType = null, string membersNickname = null, string membersNicknameContains = null, string searchQuery = null, string searchFields = null, string metadataKey = null, string metadataValues = null, string metadataValueStartswith = null, string metacounterKey = null, string metacounterValues = null, string metacounterValueGt = null, string metacounterValueGte = null, string metacounterValueLt = null, string metacounterValueLte = null, string customType = null)

List my group channels

## List my group channels  Retrieves all group channels that the user has joined. You can create a request based on various query parameters.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-my-group-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the target user.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListMyGroupChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var distinctMode = distinctMode_example;  // string |  (optional) 
            var publicMode = publicMode_example;  // string |  (optional) 
            var superMode = superMode_example;  // string |  (optional) 
            var hiddenMode = hiddenMode_example;  // string |  (optional) 
            var memberStateFilter = memberStateFilter_example;  // string |  (optional) 
            var unreadFilter = unreadFilter_example;  // string |  (optional) 
            var createdAfter = 56;  // int? |  (optional) 
            var createdBefore = 56;  // int? |  (optional) 
            var showEmpty = true;  // bool? |  (optional) 
            var showFrozen = true;  // bool? |  (optional) 
            var showMember = true;  // bool? |  (optional) 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var order = order_example;  // string |  (optional) 
            var metadataOrderKey = metadataOrderKey_example;  // string |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var customTypeStartswith = customTypeStartswith_example;  // string |  (optional) 
            var channelUrls = channelUrls_example;  // string |  (optional) 
            var name = name_example;  // string |  (optional) 
            var nameContains = nameContains_example;  // string |  (optional) 
            var nameStartswith = nameStartswith_example;  // string |  (optional) 
            var membersExactlyIn = membersExactlyIn_example;  // string |  (optional) 
            var membersIncludeIn = membersIncludeIn_example;  // string |  (optional) 
            var queryType = queryType_example;  // string |  (optional) 
            var membersNickname = membersNickname_example;  // string |  (optional) 
            var membersNicknameContains = membersNicknameContains_example;  // string |  (optional) 
            var searchQuery = searchQuery_example;  // string |  (optional) 
            var searchFields = searchFields_example;  // string |  (optional) 
            var metadataKey = metadataKey_example;  // string |  (optional) 
            var metadataValues = metadataValues_example;  // string |  (optional) 
            var metadataValueStartswith = metadataValueStartswith_example;  // string |  (optional) 
            var metacounterKey = metacounterKey_example;  // string |  (optional) 
            var metacounterValues = metacounterValues_example;  // string |  (optional) 
            var metacounterValueGt = metacounterValueGt_example;  // string |  (optional) 
            var metacounterValueGte = metacounterValueGte_example;  // string |  (optional) 
            var metacounterValueLt = metacounterValueLt_example;  // string |  (optional) 
            var metacounterValueLte = metacounterValueLte_example;  // string |  (optional) 
            var customType = customType_example;  // string |  (optional) 

            try
            {
                // List my group channels
                ListMyGroupChannelsResponse result = apiInstance.ListMyGroupChannels(userId, apiToken, token, limit, distinctMode, publicMode, superMode, hiddenMode, memberStateFilter, unreadFilter, createdAfter, createdBefore, showEmpty, showFrozen, showMember, showDeliveryReceipt, showReadReceipt, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, searchQuery, searchFields, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, customType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListMyGroupChannels: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **distinctMode** | **string**|  | [optional] 
 **publicMode** | **string**|  | [optional] 
 **superMode** | **string**|  | [optional] 
 **hiddenMode** | **string**|  | [optional] 
 **memberStateFilter** | **string**|  | [optional] 
 **unreadFilter** | **string**|  | [optional] 
 **createdAfter** | **int?**|  | [optional] 
 **createdBefore** | **int?**|  | [optional] 
 **showEmpty** | **bool?**|  | [optional] 
 **showFrozen** | **bool?**|  | [optional] 
 **showMember** | **bool?**|  | [optional] 
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **order** | **string**|  | [optional] 
 **metadataOrderKey** | **string**|  | [optional] 
 **customTypes** | **string**|  | [optional] 
 **customTypeStartswith** | **string**|  | [optional] 
 **channelUrls** | **string**|  | [optional] 
 **name** | **string**|  | [optional] 
 **nameContains** | **string**|  | [optional] 
 **nameStartswith** | **string**|  | [optional] 
 **membersExactlyIn** | **string**|  | [optional] 
 **membersIncludeIn** | **string**|  | [optional] 
 **queryType** | **string**|  | [optional] 
 **membersNickname** | **string**|  | [optional] 
 **membersNicknameContains** | **string**|  | [optional] 
 **searchQuery** | **string**|  | [optional] 
 **searchFields** | **string**|  | [optional] 
 **metadataKey** | **string**|  | [optional] 
 **metadataValues** | **string**|  | [optional] 
 **metadataValueStartswith** | **string**|  | [optional] 
 **metacounterKey** | **string**|  | [optional] 
 **metacounterValues** | **string**|  | [optional] 
 **metacounterValueGt** | **string**|  | [optional] 
 **metacounterValueGte** | **string**|  | [optional] 
 **metacounterValueLt** | **string**|  | [optional] 
 **metacounterValueLte** | **string**|  | [optional] 
 **customType** | **string**|  | [optional] 

### Return type

[**ListMyGroupChannelsResponse**](ListMyGroupChannelsResponse.md)

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


## ListRegistrationOrDeviceTokens

> ListRegistrationOrDeviceTokensResponse ListRegistrationOrDeviceTokens (string userId, string tokenType, string apiToken = null)

List registration or device tokens

## List registration or device tokens  Retrieves a list of a specific user's FCM registration tokens, HMS device tokens, or APNs device tokens. You can specify either `gcm`, `huawei`, or `apns` in the `token_type` parameter, depending on which push notification service you are using.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-registration-or-device-tokens - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListRegistrationOrDeviceTokensExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var tokenType = tokenType_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List registration or device tokens
                ListRegistrationOrDeviceTokensResponse result = apiInstance.ListRegistrationOrDeviceTokens(userId, tokenType, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListRegistrationOrDeviceTokens: " + e.Message );
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
 **tokenType** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListRegistrationOrDeviceTokensResponse**](ListRegistrationOrDeviceTokensResponse.md)

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


## ListUsers

> ListUsersResponse ListUsers (string apiToken = null, string token = null, int? limit = null, string activeMode = null, bool? showBot = null, string userIds = null, string nickname = null, string nicknameStartswith = null, string metadatakey = null, string metadatavaluesIn = null)

List users

## List users  Retrieves a list of users in your application. You can query the list using various parameters.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var activeMode = activeMode_example;  // string |  (optional) 
            var showBot = true;  // bool? |  (optional) 
            var userIds = userIds_example;  // string |  (optional) 
            var nickname = nickname_example;  // string |  (optional) 
            var nicknameStartswith = nicknameStartswith_example;  // string |  (optional) 
            var metadatakey = metadatakey_example;  // string |  (optional) 
            var metadatavaluesIn = metadatavaluesIn_example;  // string |  (optional) 

            try
            {
                // List users
                ListUsersResponse result = apiInstance.ListUsers(apiToken, token, limit, activeMode, showBot, userIds, nickname, nicknameStartswith, metadatakey, metadatavaluesIn);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ListUsers: " + e.Message );
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
 **activeMode** | **string**|  | [optional] 
 **showBot** | **bool?**|  | [optional] 
 **userIds** | **string**|  | [optional] 
 **nickname** | **string**|  | [optional] 
 **nicknameStartswith** | **string**|  | [optional] 
 **metadatakey** | **string**|  | [optional] 
 **metadatavaluesIn** | **string**|  | [optional] 

### Return type

[**ListUsersResponse**](ListUsersResponse.md)

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


## MarkAllMessagesAsRead

> void MarkAllMessagesAsRead (string userId, string apiToken = null, MarkAllMessagesAsReadData markAllMessagesAsReadData = null)

Mark all messages as read

## Mark all messages as read  Marks all of a user's unread messages as read in the joined group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-mark-all-messages-as-read - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MarkAllMessagesAsReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var markAllMessagesAsReadData = new MarkAllMessagesAsReadData(); // MarkAllMessagesAsReadData |  (optional) 

            try
            {
                // Mark all messages as read
                apiInstance.MarkAllMessagesAsRead(userId, apiToken, markAllMessagesAsReadData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.MarkAllMessagesAsRead: " + e.Message );
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
 **markAllMessagesAsReadData** | [**MarkAllMessagesAsReadData**](MarkAllMessagesAsReadData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## MuteInChannelsWithCustomChannelTypes

> void MuteInChannelsWithCustomChannelTypes (string userId, string apiToken = null, MuteInChannelsWithCustomChannelTypesData muteInChannelsWithCustomChannelTypesData = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var muteInChannelsWithCustomChannelTypesData = new MuteInChannelsWithCustomChannelTypesData(); // MuteInChannelsWithCustomChannelTypesData |  (optional) 

            try
            {
                // Mute in channels with custom channel types
                apiInstance.MuteInChannelsWithCustomChannelTypes(userId, apiToken, muteInChannelsWithCustomChannelTypesData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.MuteInChannelsWithCustomChannelTypes: " + e.Message );
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
 **muteInChannelsWithCustomChannelTypesData** | [**MuteInChannelsWithCustomChannelTypesData**](MuteInChannelsWithCustomChannelTypesData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RegisterAsOperatorToChannelsWithCustomChannelTypes

> void RegisterAsOperatorToChannelsWithCustomChannelTypes (string userId, string apiToken = null, RegisterAsOperatorToChannelsWithCustomChannelTypesData registerAsOperatorToChannelsWithCustomChannelTypesData = null)

Register as an operator to channels with custom channel types

## Register as an operator to channels with custom channel types  Registers a user as an operator to channels with particular custom channel types.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-register-as-an-operator-to-channels-with-custom-channel-types - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RegisterAsOperatorToChannelsWithCustomChannelTypesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var registerAsOperatorToChannelsWithCustomChannelTypesData = new RegisterAsOperatorToChannelsWithCustomChannelTypesData(); // RegisterAsOperatorToChannelsWithCustomChannelTypesData |  (optional) 

            try
            {
                // Register as an operator to channels with custom channel types
                apiInstance.RegisterAsOperatorToChannelsWithCustomChannelTypes(userId, apiToken, registerAsOperatorToChannelsWithCustomChannelTypesData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RegisterAsOperatorToChannelsWithCustomChannelTypes: " + e.Message );
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
 **registerAsOperatorToChannelsWithCustomChannelTypesData** | [**RegisterAsOperatorToChannelsWithCustomChannelTypesData**](RegisterAsOperatorToChannelsWithCustomChannelTypesData.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RemoveRegistrationOrDeviceToken

> RemoveRegistrationOrDeviceTokenResponse RemoveRegistrationOrDeviceToken (string userId, string apiToken = null)

Remove a registration or device token - When unregistering all device tokens

## Remove a registration or device token  Removes a specific user's one or more FCM registration tokens, HMS device tokens, or APNs device tokens.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-remove-a-registration-or-device-token - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveRegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token - When unregistering all device tokens
                RemoveRegistrationOrDeviceTokenResponse result = apiInstance.RemoveRegistrationOrDeviceToken(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveRegistrationOrDeviceToken: " + e.Message );
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

### Return type

[**RemoveRegistrationOrDeviceTokenResponse**](RemoveRegistrationOrDeviceTokenResponse.md)

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


## RemoveRegistrationOrDeviceTokenByToken

> RemoveRegistrationOrDeviceTokenByTokenResponse RemoveRegistrationOrDeviceTokenByToken (string userId, string tokenType, string token, string apiToken = null)

Remove a registration or device token - When unregistering a specific token

## Remove a registration or device token  Removes a specific user's one or more FCM registration tokens, HMS device tokens, or APNs device tokens.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-remove-a-registration-or-device-token - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveRegistrationOrDeviceTokenByTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var tokenType = tokenType_example;  // string | 
            var token = token_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token - When unregistering a specific token
                RemoveRegistrationOrDeviceTokenByTokenResponse result = apiInstance.RemoveRegistrationOrDeviceTokenByToken(userId, tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveRegistrationOrDeviceTokenByToken: " + e.Message );
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
 **tokenType** | **string**|  | 
 **token** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**RemoveRegistrationOrDeviceTokenByTokenResponse**](RemoveRegistrationOrDeviceTokenByTokenResponse.md)

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


## RemoveRegistrationOrDeviceTokenFromOwnerByToken

> RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse RemoveRegistrationOrDeviceTokenFromOwnerByToken (string tokenType, string token, string apiToken = null)

Remove a registration or device token from an owner

## Remove a registration or device token from an owner  Removes a registration or device token from a user who owns it. You can pass one of two values in `token_type`: `gcm`, `huawei`, or `apns`, depending on which push service you are using.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-remove-a-registration-or-device-token-from-an-owner - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveRegistrationOrDeviceTokenFromOwnerByTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var tokenType = tokenType_example;  // string | 
            var token = token_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token from an owner
                RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse result = apiInstance.RemoveRegistrationOrDeviceTokenFromOwnerByToken(tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveRegistrationOrDeviceTokenFromOwnerByToken: " + e.Message );
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
 **tokenType** | **string**|  | 
 **token** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse**](RemoveRegistrationOrDeviceTokenFromOwnerByTokenResponse.md)

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


## ResetPushPreferences

> void ResetPushPreferences (string userId, string apiToken = null)

Reset push preferences

## Reset push preferences  Resets a user's push preferences. After performing this action,   `do_not_disturb` and `snooze_enabled` are set to false.  The values of the parameters associated with the time frame are all set to 0.  `timezone` is reset to `UTC`.  `push_sound` is reset to `default`.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-reset-push-preferences - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ResetPushPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Reset push preferences
                apiInstance.ResetPushPreferences(userId, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ResetPushPreferences: " + e.Message );
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


## UnblockUserById

> void UnblockUserById (string userId, string targetId, string apiToken = null)

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
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var targetId = targetId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unblock a user
                apiInstance.UnblockUserById(userId, targetId, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UnblockUserById: " + e.Message );
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
 **targetId** | **string**|  | 
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


## UpdateChannelInvitationPreference

> UpdateChannelInvitationPreferenceResponse UpdateChannelInvitationPreference (string userId, string apiToken = null, UpdateChannelInvitationPreferenceData updateChannelInvitationPreferenceData = null)

Update channel invitation preference

## Update channel invitation preference  Updates the channel invitation preference for a user's [private](https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#-3-private-vs-public) group channels.  > __Note__: Using the [update default channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-default-channel-invitation-preference) action, you can update the value of channel invitation preference which is globally applied to all users within the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-channel-invitation-preference

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateChannelInvitationPreferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateChannelInvitationPreferenceData = new UpdateChannelInvitationPreferenceData(); // UpdateChannelInvitationPreferenceData |  (optional) 

            try
            {
                // Update channel invitation preference
                UpdateChannelInvitationPreferenceResponse result = apiInstance.UpdateChannelInvitationPreference(userId, apiToken, updateChannelInvitationPreferenceData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdateChannelInvitationPreference: " + e.Message );
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
 **updateChannelInvitationPreferenceData** | [**UpdateChannelInvitationPreferenceData**](UpdateChannelInvitationPreferenceData.md)|  | [optional] 

### Return type

[**UpdateChannelInvitationPreferenceResponse**](UpdateChannelInvitationPreferenceResponse.md)

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


## UpdateCountPreferenceOfChannelByUrl

> UpdateCountPreferenceOfChannelByUrlResponse UpdateCountPreferenceOfChannelByUrl (string userId, string channelUrl, string apiToken = null, UpdateCountPreferenceOfChannelByUrlData updateCountPreferenceOfChannelByUrlData = null)

Update count preference of a channel

## Update count preference of a channel  Updates count preference of a specific group channel of a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-count-preference-of-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateCountPreferenceOfChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateCountPreferenceOfChannelByUrlData = new UpdateCountPreferenceOfChannelByUrlData(); // UpdateCountPreferenceOfChannelByUrlData |  (optional) 

            try
            {
                // Update count preference of a channel
                UpdateCountPreferenceOfChannelByUrlResponse result = apiInstance.UpdateCountPreferenceOfChannelByUrl(userId, channelUrl, apiToken, updateCountPreferenceOfChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdateCountPreferenceOfChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateCountPreferenceOfChannelByUrlData** | [**UpdateCountPreferenceOfChannelByUrlData**](UpdateCountPreferenceOfChannelByUrlData.md)|  | [optional] 

### Return type

[**UpdateCountPreferenceOfChannelByUrlResponse**](UpdateCountPreferenceOfChannelByUrlResponse.md)

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


## UpdatePushPreferences

> UpdatePushPreferencesResponse UpdatePushPreferences (string userId, string apiToken = null, UpdatePushPreferencesData updatePushPreferencesData = null)

Update push preferences

## Update push preferences  Updates a user's push preferences. Through this action, you can set `do_not_disturb` for a user, and update the time frame in which the setting applies.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-push-preferences - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdatePushPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updatePushPreferencesData = new UpdatePushPreferencesData(); // UpdatePushPreferencesData |  (optional) 

            try
            {
                // Update push preferences
                UpdatePushPreferencesResponse result = apiInstance.UpdatePushPreferences(userId, apiToken, updatePushPreferencesData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdatePushPreferences: " + e.Message );
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
 **updatePushPreferencesData** | [**UpdatePushPreferencesData**](UpdatePushPreferencesData.md)|  | [optional] 

### Return type

[**UpdatePushPreferencesResponse**](UpdatePushPreferencesResponse.md)

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


## UpdatePushPreferencesForChannelByUrl

> UpdatePushPreferencesForChannelByUrlResponse UpdatePushPreferencesForChannelByUrl (string userId, string channelUrl, string apiToken = null, UpdatePushPreferencesForChannelByUrlData updatePushPreferencesForChannelByUrlData = null)

Update push preferences for a channel

## Update push preferences for a channel  Updates push preferences for a user's specific group channel. The push notifications feature is only available for group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-push-preferences-for-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdatePushPreferencesForChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updatePushPreferencesForChannelByUrlData = new UpdatePushPreferencesForChannelByUrlData(); // UpdatePushPreferencesForChannelByUrlData |  (optional) 

            try
            {
                // Update push preferences for a channel
                UpdatePushPreferencesForChannelByUrlResponse result = apiInstance.UpdatePushPreferencesForChannelByUrl(userId, channelUrl, apiToken, updatePushPreferencesForChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdatePushPreferencesForChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updatePushPreferencesForChannelByUrlData** | [**UpdatePushPreferencesForChannelByUrlData**](UpdatePushPreferencesForChannelByUrlData.md)|  | [optional] 

### Return type

[**UpdatePushPreferencesForChannelByUrlResponse**](UpdatePushPreferencesForChannelByUrlResponse.md)

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


## UpdateUserById

> SendBirdUser UpdateUserById (string userId, string apiToken = null, UpdateUserByIdData updateUserByIdData = null)

Update a user

## Update a user  Updates information on a user. In addition to changing a user's nickname or profile image, you can issue a new access token for the user. The new access token replaces the previous one as the necessary token for authentication.  You can also deactivate or reactivate a user. If the `leave_all_when_deactivated` is true (which it is by default), a user leaves all joined group channels when deactivated.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateUserByIdData = new UpdateUserByIdData(); // UpdateUserByIdData |  (optional) 

            try
            {
                // Update a user
                SendBirdUser result = apiInstance.UpdateUserById(userId, apiToken, updateUserByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUserById: " + e.Message );
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
 **updateUserByIdData** | [**UpdateUserByIdData**](UpdateUserByIdData.md)|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## ViewChannelInvitationPreference

> ViewChannelInvitationPreferenceResponse ViewChannelInvitationPreference (string userId, string apiToken = null)

View channel invitation preference

## View channel invitation preference  Retrieves channel invitation preference for a user's [private](https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#-3-private-vs-public) group channels.  > __Note__: Using the [view default channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-default-channel-invitation-preference) action, you can retrieve the value of channel invitation preference which is globally applied to all users within the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-channel-invitation-preference

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewChannelInvitationPreferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View channel invitation preference
                ViewChannelInvitationPreferenceResponse result = apiInstance.ViewChannelInvitationPreference(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewChannelInvitationPreference: " + e.Message );
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

### Return type

[**ViewChannelInvitationPreferenceResponse**](ViewChannelInvitationPreferenceResponse.md)

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


## ViewCountPreferenceOfChannelByUrl

> ViewCountPreferenceOfChannelByUrlResponse ViewCountPreferenceOfChannelByUrl (string userId, string channelUrl, string apiToken = null)

View count preference of a channel

## View count preference of a channel  Retrieves count preference of a specific group channel of a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-count-preference-of-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewCountPreferenceOfChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View count preference of a channel
                ViewCountPreferenceOfChannelByUrlResponse result = apiInstance.ViewCountPreferenceOfChannelByUrl(userId, channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewCountPreferenceOfChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewCountPreferenceOfChannelByUrlResponse**](ViewCountPreferenceOfChannelByUrlResponse.md)

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


## ViewNumberOfChannelsByJoinStatus

> ViewNumberOfChannelsByJoinStatusResponse ViewNumberOfChannelsByJoinStatus (string userId, string apiToken = null, string state = null)

View number of channels by join status

## View number of channels by join status  Retrieves the number of a user's group channels by their join status.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-number-of-channels-by-join-status - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the user to retrieve the number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfChannelsByJoinStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var state = state_example;  // string |  (optional) 

            try
            {
                // View number of channels by join status
                ViewNumberOfChannelsByJoinStatusResponse result = apiInstance.ViewNumberOfChannelsByJoinStatus(userId, apiToken, state);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewNumberOfChannelsByJoinStatus: " + e.Message );
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
 **state** | **string**|  | [optional] 

### Return type

[**ViewNumberOfChannelsByJoinStatusResponse**](ViewNumberOfChannelsByJoinStatusResponse.md)

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


## ViewNumberOfChannelsWithUnreadMessages

> ViewNumberOfChannelsWithUnreadMessagesResponse ViewNumberOfChannelsWithUnreadMessages (string userId, string apiToken = null, List<string> customTypes = null, string superMode = null)

View number of channels with unread messages

## View number of channels with unread messages  Retrieves the total number of a user's group channels with unread messages.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-number-of-channels-with-unread-messages - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfChannelsWithUnreadMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var customTypes = new List<string>(); // List<string> |  (optional) 
            var superMode = superMode_example;  // string |  (optional) 

            try
            {
                // View number of channels with unread messages
                ViewNumberOfChannelsWithUnreadMessagesResponse result = apiInstance.ViewNumberOfChannelsWithUnreadMessages(userId, apiToken, customTypes, superMode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewNumberOfChannelsWithUnreadMessages: " + e.Message );
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
 **customTypes** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **superMode** | **string**|  | [optional] 

### Return type

[**ViewNumberOfChannelsWithUnreadMessagesResponse**](ViewNumberOfChannelsWithUnreadMessagesResponse.md)

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


## ViewNumberOfUnreadItems

> ViewNumberOfUnreadItemsResponse ViewNumberOfUnreadItems (string userId, string apiToken = null, string customType = null, string itemKeys = null)

View number of unread items

## View number of unread items  Retrieves a set of total numbers of a user's unread messages, unread mentioned messages, or received invitations in either super or non-super group channels. This action is only available for the group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-number-of-unread-items - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfUnreadItemsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var customType = customType_example;  // string |  (optional) 
            var itemKeys = itemKeys_example;  // string |  (optional) 

            try
            {
                // View number of unread items
                ViewNumberOfUnreadItemsResponse result = apiInstance.ViewNumberOfUnreadItems(userId, apiToken, customType, itemKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewNumberOfUnreadItems: " + e.Message );
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
 **customType** | **string**|  | [optional] 
 **itemKeys** | **string**|  | [optional] 

### Return type

[**ViewNumberOfUnreadItemsResponse**](ViewNumberOfUnreadItemsResponse.md)

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


## ViewNumberOfUnreadMessages

> ViewNumberOfUnreadMessagesResponse ViewNumberOfUnreadMessages (string userId, string apiToken = null, string customTypes = null, string superMode = null)

View number of unread messages

## View number of unread messages  Retrieves the total number of a user's currently unread messages in the group channels. The unread counts feature is only available for the group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-number-of-unread-messages - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the user to retrieve the number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfUnreadMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var superMode = superMode_example;  // string |  (optional) 

            try
            {
                // View number of unread messages
                ViewNumberOfUnreadMessagesResponse result = apiInstance.ViewNumberOfUnreadMessages(userId, apiToken, customTypes, superMode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewNumberOfUnreadMessages: " + e.Message );
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
 **customTypes** | **string**|  | [optional] 
 **superMode** | **string**|  | [optional] 

### Return type

[**ViewNumberOfUnreadMessagesResponse**](ViewNumberOfUnreadMessagesResponse.md)

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


## ViewPushPreferences

> ViewPushPreferencesResponse ViewPushPreferences (string userId, string apiToken = null)

View push preferences

## View push preferences  Retrieves a user's push preferences about whether the user has set `do_not_disturb` to pause notifications for a certain period of time, and the time frame in which the user has applied the setting.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-push-preferences - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewPushPreferencesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View push preferences
                ViewPushPreferencesResponse result = apiInstance.ViewPushPreferences(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewPushPreferences: " + e.Message );
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

### Return type

[**ViewPushPreferencesResponse**](ViewPushPreferencesResponse.md)

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


## ViewPushPreferencesForChannelByUrl

> ViewPushPreferencesForChannelByUrlResponse ViewPushPreferencesForChannelByUrl (string userId, string channelUrl, string apiToken = null)

View push preferences for a channel

## View push preferences for a channel  Retrieves whether a user has turned on notification messages for a specific channel. The push notifications feature is only available for group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-push-preferences-for-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewPushPreferencesForChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View push preferences for a channel
                ViewPushPreferencesForChannelByUrlResponse result = apiInstance.ViewPushPreferencesForChannelByUrl(userId, channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewPushPreferencesForChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewPushPreferencesForChannelByUrlResponse**](ViewPushPreferencesForChannelByUrlResponse.md)

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


## ViewUserById

> SendBirdUser ViewUserById (string userId, string apiToken = null, bool? includeUnreadCount = null, string customTypes = null, string superMode = null)

View a user

## View a user  Retrieves information on a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `user_id`      Type: string      Description: Specifies the unique ID of the user to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = userId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var includeUnreadCount = true;  // bool? |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var superMode = superMode_example;  // string |  (optional) 

            try
            {
                // View a user
                SendBirdUser result = apiInstance.ViewUserById(userId, apiToken, includeUnreadCount, customTypes, superMode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewUserById: " + e.Message );
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
 **includeUnreadCount** | **bool?**|  | [optional] 
 **customTypes** | **string**|  | [optional] 
 **superMode** | **string**|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## ViewWhoOwnsRegistrationOrDeviceTokenByToken

> ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponse ViewWhoOwnsRegistrationOrDeviceTokenByToken (string tokenType, string token, string apiToken = null)

View who owns a registration or device token

## View who owns a registration or device token  Retrieves a user who owns a FCM registration token, HMS device token, or APNs device token. You can pass one of two values in `token_type`: `gcm`, `huawei`, or `apns`, depending on which push service you are using.  https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-who-owns-a-registration-or-device-token - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewWhoOwnsRegistrationOrDeviceTokenByTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var tokenType = tokenType_example;  // string | 
            var token = token_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View who owns a registration or device token
                ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponse result = apiInstance.ViewWhoOwnsRegistrationOrDeviceTokenByToken(tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewWhoOwnsRegistrationOrDeviceTokenByToken: " + e.Message );
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
 **tokenType** | **string**|  | 
 **token** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponse**](ViewWhoOwnsRegistrationOrDeviceTokenByTokenResponse.md)

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

