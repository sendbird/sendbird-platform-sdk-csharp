# sendbird_platform_sdk.Api.UserApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddARegistrationOrDeviceToken**](UserApi.md#addaregistrationordevicetoken) | **POST** /v3/users/{user_id}/push/{token_type} | Add a registration or device token
[**ChooseAPushNotificationContentTemplate**](UserApi.md#chooseapushnotificationcontenttemplate) | **PUT** /v3/users/{user_id}/push/template | Choose a push notification content template
[**CreateAUser**](UserApi.md#createauser) | **POST** /v3/users | Create a user
[**CreateUserToken**](UserApi.md#createusertoken) | **POST** /v3/users/{user_id}/token | Create user token
[**DeleteAUser**](UserApi.md#deleteauser) | **DELETE** /v3/users/{user_id} | Delete a user
[**GetChannelInvitationPreference**](UserApi.md#getchannelinvitationpreference) | **GET** /v3/users/{user_id}/channel_invitation_preference | Get channel invitation preference
[**LeaveMyGroupChannels**](UserApi.md#leavemygroupchannels) | **PUT** /v3/users/{user_id}/my_group_channels/leave | Leave my group channels
[**ListMyGroupChannels**](UserApi.md#listmygroupchannels) | **GET** /v3/users/{user_id}/my_group_channels | List my group channels
[**ListRegistrationOrDeviceTokens**](UserApi.md#listregistrationordevicetokens) | **GET** /v3/users/{user_id}/push/{token_type} | List registration or device tokens
[**ListUsers**](UserApi.md#listusers) | **GET** /v3/users | List users
[**MarkAllMessagesAsRead**](UserApi.md#markallmessagesasread) | **PUT** /v3/users/{user_id}/mark_as_read_all | Mark all messages as read
[**RemoveARegistrationOrDeviceToken**](UserApi.md#removearegistrationordevicetoken) | **DELETE** /v3/users/{user_id}/push/{token_type}/{token} | Remove a registration or device token - When unregistering a specific token
[**RemoveARegistrationOrDeviceTokenFromAnOwner**](UserApi.md#removearegistrationordevicetokenfromanowner) | **DELETE** /v3/push/device_tokens/{token_type}/{token} | Remove a registration or device token from an owner
[**RemoveAllRegistrationOrDeviceToken**](UserApi.md#removeallregistrationordevicetoken) | **DELETE** /v3/users/{user_id}/push | Remove a registration or device token - When unregistering all device tokens
[**ResetPushPreferences**](UserApi.md#resetpushpreferences) | **DELETE** /v3/users/{user_id}/push_preference | Reset push preferences
[**UpdateAUser**](UserApi.md#updateauser) | **PUT** /v3/users/{user_id} | Update a user
[**UpdateChannelInvitationPreference**](UserApi.md#updatechannelinvitationpreference) | **PUT** /v3/users/{user_id}/channel_invitation_preference | Update channel invitation preference
[**UpdateCountPreferenceOfAChannel**](UserApi.md#updatecountpreferenceofachannel) | **PUT** /v3/users/{user_id}/count_preference/{channel_url} | Update count preference of a channel
[**UpdatePushPreferences**](UserApi.md#updatepushpreferences) | **PUT** /v3/users/{user_id}/push_preference | Update push preferences
[**UpdatePushPreferencesForAChannel**](UserApi.md#updatepushpreferencesforachannel) | **PUT** /v3/users/{user_id}/push_preference/{channel_url} | Update push preferences for a channel
[**ViewAUser**](UserApi.md#viewauser) | **GET** /v3/users/{user_id} | View a user
[**ViewCountPreferenceOfAChannel**](UserApi.md#viewcountpreferenceofachannel) | **GET** /v3/users/{user_id}/count_preference/{channel_url} | View count preference of a channel
[**ViewNumberOfChannelsWithUnreadMessages**](UserApi.md#viewnumberofchannelswithunreadmessages) | **GET** /v3/users/{user_id}/unread_channel_count | View number of channels with unread messages
[**ViewNumberOfUnreadMessages**](UserApi.md#viewnumberofunreadmessages) | **GET** /v3/users/{user_id}/unread_message_count | View number of unread messages
[**ViewPushPreferences**](UserApi.md#viewpushpreferences) | **GET** /v3/users/{user_id}/push_preference | View push preferences
[**ViewPushPreferencesForAChannel**](UserApi.md#viewpushpreferencesforachannel) | **GET** /v3/users/{user_id}/push_preference/{channel_url} | View push preferences for a channel
[**ViewWhoOwnsARegistrationOrDeviceToken**](UserApi.md#viewwhoownsaregistrationordevicetoken) | **GET** /v3/push/device_tokens/{token_type}/{token} | View who owns a registration or device token



## AddARegistrationOrDeviceToken

> AddARegistrationOrDeviceTokenResponse AddARegistrationOrDeviceToken (string userId, string tokenType, string apiToken = null, AddARegistrationOrDeviceTokenRequest addARegistrationOrDeviceTokenRequest = null)

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
    public class AddARegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var tokenType = "gcm";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addARegistrationOrDeviceTokenRequest = new AddARegistrationOrDeviceTokenRequest(); // AddARegistrationOrDeviceTokenRequest |  (optional) 

            try
            {
                // Add a registration or device token
                AddARegistrationOrDeviceTokenResponse result = apiInstance.AddARegistrationOrDeviceToken(userId, tokenType, apiToken, addARegistrationOrDeviceTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.AddARegistrationOrDeviceToken: " + e.Message );
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
 **tokenType** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **addARegistrationOrDeviceTokenRequest** | [**AddARegistrationOrDeviceTokenRequest**](AddARegistrationOrDeviceTokenRequest.md)|  | [optional] 

### Return type

[**AddARegistrationOrDeviceTokenResponse**](AddARegistrationOrDeviceTokenResponse.md)

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


## ChooseAPushNotificationContentTemplate

> ChooseAPushNotificationContentTemplateResponse ChooseAPushNotificationContentTemplate (string userId, string apiToken = null, ChooseAPushNotificationContentTemplateRequest chooseAPushNotificationContentTemplateRequest = null)

Choose a push notification content template

## Choose a push notification content template  Users can choose a template to determine how push notifications appear to them. Push notification content templates are pre-formatted forms that can be customized to display your own push notification messages on a user's device. Sendbird provides two types: `default` and `alternative`. Go to **Settings** > **Chat** > **Push notifications** > **Push notification content templates** on [Sendbird Dashboard](https://dashboard.sendbird.com/auth/signin) to customize the templates.  If the `push_message_template` property is specified when [sending a message](https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/send-a-message), the content template customized for the message takes precedence over the user's choice.  > **Note**: Push notifications are only available for group channels.      https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/choose-a-push-notification-content-template#1-choose-a-push-notification-content-template

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ChooseAPushNotificationContentTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var chooseAPushNotificationContentTemplateRequest = new ChooseAPushNotificationContentTemplateRequest(); // ChooseAPushNotificationContentTemplateRequest |  (optional) 

            try
            {
                // Choose a push notification content template
                ChooseAPushNotificationContentTemplateResponse result = apiInstance.ChooseAPushNotificationContentTemplate(userId, apiToken, chooseAPushNotificationContentTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ChooseAPushNotificationContentTemplate: " + e.Message );
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
 **chooseAPushNotificationContentTemplateRequest** | [**ChooseAPushNotificationContentTemplateRequest**](ChooseAPushNotificationContentTemplateRequest.md)|  | [optional] 

### Return type

[**ChooseAPushNotificationContentTemplateResponse**](ChooseAPushNotificationContentTemplateResponse.md)

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


## CreateAUser

> SendbirdUser CreateAUser (string apiToken = null, CreateAUserRequest createAUserRequest = null)

Create a user

## Create a user  You should create a user in your Sendbird application to initiate conversations in channels. A user is identified by its unique user ID, and additionally have a changeable nickname, profile image, and so on. Users are at the core of all conversations. Sendbird applications are made up of users who chat in either Open Channels or Group Channels. Using this API, it is possible to have fine grained control over your users and what those users can do. To learn more about users, see [User overview](https://sendbird.com/docs/chat/platform-api/v3/user/user-overview#2-resource-representation).  https://sendbird.com/docs/chat/platform-api/v3/user/creating-users/create-a-user#1-create-a-user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createAUserRequest = new CreateAUserRequest(); // CreateAUserRequest |  (optional) 

            try
            {
                // Create a user
                SendbirdUser result = apiInstance.CreateAUser(apiToken, createAUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.CreateAUser: " + e.Message );
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
 **createAUserRequest** | [**CreateAUserRequest**](CreateAUserRequest.md)|  | [optional] 

### Return type

[**SendbirdUser**](SendbirdUser.md)

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


## CreateUserToken

> CreateUserTokenResponse CreateUserToken (string userId, string apiToken = null, CreateUserTokenRequest createUserTokenRequest = null)

Create user token

## Create user token  This action issues a session token for user authentication. Session tokens provide an efficient stateless authentication method by not storing the tokens in the Sendbird database, and thus improving the server's performance. See [access token vs. session token](https://sendbird.com/docs/chat/platform-api/v3/user/creating-users/create-a-user#2-access-token-vs-session-token) to learn more about authenticating users.  > **Note**: The endpoint `/users/{user_id}` is deprecated. Use `/users/{user_id}/token` for greater efficiency.      https://sendbird.com/docs/chat/platform-api/v3/user/managing-session-tokens/issue-a-session-token#1-issue-a-session-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateUserTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createUserTokenRequest = new CreateUserTokenRequest(); // CreateUserTokenRequest |  (optional) 

            try
            {
                // Create user token
                CreateUserTokenResponse result = apiInstance.CreateUserToken(userId, apiToken, createUserTokenRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.CreateUserToken: " + e.Message );
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
 **createUserTokenRequest** | [**CreateUserTokenRequest**](CreateUserTokenRequest.md)|  | [optional] 

### Return type

[**CreateUserTokenResponse**](CreateUserTokenResponse.md)

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


## DeleteAUser

> Object DeleteAUser (string userId, string apiToken = null)

Delete a user

## Delete a user  You can delete a user from your Sendbird application using this API.  > **Note**: This API deletes user data and metadata, except for their messages. If you wish to delete user data including their messages, use the [GDPR request](https://sendbird.com/docs/chat/platform-api/v3/privacy/privacy-overview).      [https://sendbird.com/docs/chat/platform-api/v3/user/managing-users/delete-a-user#1-delete-a-user](https://sendbird.com/docs/chat/platform-api/v3/user/managing-users/delete-a-user#1-delete-a-user)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a user
                Object result = apiInstance.DeleteAUser(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.DeleteAUser: " + e.Message );
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


## GetChannelInvitationPreference

> GetChannelInvitationPreferenceResponse GetChannelInvitationPreference (string userId, string apiToken = null)

Get channel invitation preference

## Get channel invitation preference  This action retrieves a user's [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel) invitation preference. Users are subject to both user-specific and application-wide invitation preferences. Of the two, the invitation preference set for a specific user takes precedence over [the default channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/setting-up-channels/get-default-invitation-preference).  [https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/get-channel-invitation-preference#1-get-channel-invitation-preference](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/get-channel-invitation-preference#1-get-channel-invitation-preference)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetChannelInvitationPreferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get channel invitation preference
                GetChannelInvitationPreferenceResponse result = apiInstance.GetChannelInvitationPreference(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.GetChannelInvitationPreference: " + e.Message );
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

### Return type

[**GetChannelInvitationPreferenceResponse**](GetChannelInvitationPreferenceResponse.md)

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


## LeaveMyGroupChannels

> Object LeaveMyGroupChannels (string userId, string apiToken = null, LeaveMyGroupChannelsRequest leaveMyGroupChannelsRequest = null)

Leave my group channels

## Leave my group channels  This action allows a user to leave all group channels or channels with a specific custom type. This API is useful if you want to let a user leave a set of channels at once. To let a user leave only one of their group channels, use the [leave a channel API](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/leave-a-channel) instead.  Since this API can't be called for a deactivated user, ensure that the [<code>leave_all_when_deactivated</code>](https://sendbird.com/docs/chat/platform-api/v3/user/managing-users/update-a-user#2-request-body) property of the user is set to its default value of `true` to let the user leave all joined group channels upon deactivation.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-joined-group-channels/leave-group-channels#1-leave-group-channels  `user_id`   Type: string   Description: Specifies the unique ID of the user to leave all joined group channels.

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var leaveMyGroupChannelsRequest = new LeaveMyGroupChannelsRequest(); // LeaveMyGroupChannelsRequest |  (optional) 

            try
            {
                // Leave my group channels
                Object result = apiInstance.LeaveMyGroupChannels(userId, apiToken, leaveMyGroupChannelsRequest);
                Debug.WriteLine(result);
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **leaveMyGroupChannelsRequest** | [**LeaveMyGroupChannelsRequest**](LeaveMyGroupChannelsRequest.md)|  | [optional] 

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


## ListMyGroupChannels

> ListMyGroupChannelsResponse ListMyGroupChannels (string userId, string apiToken, string token = null, int? limit = null, string distinctMode = null, string publicMode = null, string superMode = null, long? createdAfter = null, long? createdBefore = null, bool? showEmpty = null, bool? showMember = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMetadata = null, bool? showFrozen = null, string order = null, string metadataOrderKey = null, string customTypes = null, string customTypeStartswith = null, string channelUrls = null, string name = null, string nameContains = null, string nameStartswith = null, string membersExactlyIn = null, string membersIncludeIn = null, string queryType = null, string membersNickname = null, string membersNicknameContains = null, string membersNicknameStartswith = null, string searchQuery = null, string searchFields = null, string metadataKey = null, string metadataValues = null, string metadataValueStartswith = null, string metacounterKey = null, string metacounterValues = null, string metacounterValueGt = null, string metacounterValueGte = null, string metacounterValueLt = null, string metacounterValueLte = null, bool? includeSortedMetaarrayInLastMessage = null, string hiddenMode = null, string unreadFilter = null, string memberStateFilter = null)

List my group channels

## List my group channels  This action retrieves a list of [group channels](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel) that a specific user has joined. You can use various query parameters to determine the search scope and select what kind of information you want to receive about the queried channels.  If you're looking to retrieve a list of group channels in a specific application, visit the [list group channels](https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/list-group-channels) page under the Channel section.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-joined-group-channels/list-group-channels-by-user#1-list-group-channels-by-user  `user_id`   Type: string   Description: Specifies the unique ID of the target user.

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string | 
            var token = "token_example";  // string | Specifies a page token that indicates the starting index of a chunk of results. If not specified, the index is set as 0. (optional) 
            var limit = 10;  // int? | Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) (optional) 
            var distinctMode = all;  // string |  (optional) 
            var publicMode = all;  // string |  (optional) 
            var superMode = all;  // string |  (optional) 
            var createdAfter = 1234567890123;  // long? | Restricts the search scope to only retrieve group channels which have been created after the specified time, in Unix milliseconds format. (optional) 
            var createdBefore = 1234567890123;  // long? | Restricts the search scope to only retrieve group channels which have been created before the specified time, in Unix milliseconds format. (optional) 
            var showEmpty = false;  // bool? |  (optional) 
            var showMember = false;  // bool? |  (optional) 
            var showDeliveryReceipt = false;  // bool? |  (optional) 
            var showReadReceipt = false;  // bool? |  (optional) 
            var showMetadata = false;  // bool? |  (optional) 
            var showFrozen = false;  // bool? |  (optional) 
            var order = "chronological";  // string |  (optional) 
            var metadataOrderKey = "metadataOrderKey_example";  // string | Specifies the key of an item in metadata. When a value of the order parameter is set to metadata_value_alphabetical, the results are alphabetically sorted by the value of the item specified by the key. (optional) 
            var customTypes = "customTypes_example";  // string | Specifies a comma-separated string of one or more custom types to filter group channels. URL encoding each type is recommended. If not specified, all channels are returned, regardless of their custom type. (optional) 
            var customTypeStartswith = "customTypeStartswith_example";  // string | Searches for group channels with the custom type which starts with the specified value. URL encoding the value is recommended. (optional) 
            var channelUrls = "channelUrls_example";  // string | Specifies a comma-separated string of one or more group channel URLs to restrict the search scope. URL encoding each channel URL is recommended. (optional) 
            var name = "name_example";  // string | Specifies one or more group channel names. (optional) 
            var nameContains = "nameContains_example";  // string | Searches for group channels whose names contain the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended. (optional) 
            var nameStartswith = "nameStartswith_example";  // string | Searches for group channels whose names start with the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended. (optional) 
            var membersExactlyIn = "membersExactlyIn_example";  // string | Searches for group channels with all the specified users as members. The parameter value should consist of user IDs separated by commas.  Only user IDs that match those of existing users are used for channel search. URL encoding each ID is recommended. (optional) 
            var membersIncludeIn = "membersIncludeIn_example";  // string | Searches for group channels that include one or more users as members among the specified users. The value should consist of user IDs separated by commas or %2C. You can specify up to 60 user IDs.  Only user IDs that match those of existing users are used for channel search. URL encoding each ID is recommended. (optional) 
            var queryType = "queryType_example";  // string | Specifies a logical condition applied to the members_include_in parameter. Acceptable values are either AND or OR. For example, if you specify three members, A, B, and C, in members_include_in, the value of AND returns all channels that include every one of {A. B, C} as members. The value of OR returns channels that include {A}, plus those that include {B}, plus those that include {C}. (Default: AND) (optional) 
            var membersNickname = "membersNickname_example";  // string | Searches for group channels with members whose nicknames match the specified value. URL encoding the value is recommended. (optional) 
            var membersNicknameContains = "membersNicknameContains_example";  // string | Searches for group channels with members whose nicknames contain the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended.  * We recommend using at least three characters for the parameter value for better search efficiency when you design and implement related features. If you would like to allow one or two characters for searching, use members_nickname instead to prevent performance issues. (optional) 
            var membersNicknameStartswith = "membersNicknameStartswith_example";  // string | Searches for group channels with members whose nicknames begin with the specified value. This parameter isn't case-sensitive. URL encoding the value is recommended. (optional) 
            var searchQuery = "searchQuery_example";  // string | Searches for group channels where the specified query string matches the channel name or the nickname of the member. This parameter isn't case-sensitive and should be specified in conjunction with the search_fields parameter below. URL encoding the value is recommended. (optional) 
            var searchFields = "searchFields_example";  // string | Specifies a comma-separated string of one or more search fields to apply to the query, which restricts the results within the specified fields (OR search condition). Acceptable values are channel_name and member_nickname. This is effective only when the search_query parameter above is specified. (Default: channel_name, member_nickname together) (optional) 
            var metadataKey = "metadataKey_example";  // string | Searches for group channels with metadata containing an item with the specified value as its key. To use this parameter, either the metadata_values parameter or the metadata_value_startswith parameter should be specified. (optional) 
            var metadataValues = "metadataValues_example";  // string | Searches for group channels with metadata containing an item with the key specified by the metadata_key parameter, and the value of that item matches one or more values specified by this parameter. The string should be specified with multiple values separated by commas. URL encoding each value is recommended. To use this parameter, the metadata_key parameter should be specified. (optional) 
            var metadataValueStartswith = "metadataValueStartswith_example";  // string | Searches for group channels with metadata containing an item with the key specified by the metadata_key parameter, and the values of that item that start with the specified value of this parameter. URL encoding the value is recommended. To use this parameter, the metadata_key parameter should be specified. (optional) 
            var metacounterKey = "metacounterKey_example";  // string | Searches for group channels with metacounter containing an item with the specified value as its key. To use this parameter, either the metacounter_values parameter or one of the metacounter_value_gt, metacounter_value_gte, metacounter_value_lt, and metacounter_value_lte parameters should be specified. (optional) 
            var metacounterValues = "metacounterValues_example";  // string | Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is equal to one or more values specified by this parameter. The string should be specified with multiple values separated by commas. To use this parameter, the metacounter_key parameter should be specified. (optional) 
            var metacounterValueGt = "metacounterValueGt_example";  // string | Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is greater than the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. (optional) 
            var metacounterValueGte = "metacounterValueGte_example";  // string | Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is greater than or equal to the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. (optional) 
            var metacounterValueLt = "metacounterValueLt_example";  // string | Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is lower than the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. (optional) 
            var metacounterValueLte = "metacounterValueLte_example";  // string | Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is lower than or equal to the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. (optional) 
            var includeSortedMetaarrayInLastMessage = false;  // bool? | Determines whether to include the sorted_metaarray as one of the last_message’s properties in the response. (optional) 
            var hiddenMode = "unhidden_only";  // string | Restricts the search scope to group channels that match a specific hidden_status and operating behavior (optional) 
            var unreadFilter = "all";  // string | Restricts the search scope to only retrieve group channels with one or more unread messages. This filter doesn't support Supergroup channels. Acceptable values are all and unread_message. (Default: all) (optional) 
            var memberStateFilter = "all";  // string |  (optional) 

            try
            {
                // List my group channels
                ListMyGroupChannelsResponse result = apiInstance.ListMyGroupChannels(userId, apiToken, token, limit, distinctMode, publicMode, superMode, createdAfter, createdBefore, showEmpty, showMember, showDeliveryReceipt, showReadReceipt, showMetadata, showFrozen, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, membersNicknameStartswith, searchQuery, searchFields, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, includeSortedMetaarrayInLastMessage, hiddenMode, unreadFilter, memberStateFilter);
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | 
 **token** | **string**| Specifies a page token that indicates the starting index of a chunk of results. If not specified, the index is set as 0. | [optional] 
 **limit** | **int?**| Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) | [optional] 
 **distinctMode** | **string**|  | [optional] 
 **publicMode** | **string**|  | [optional] 
 **superMode** | **string**|  | [optional] 
 **createdAfter** | **long?**| Restricts the search scope to only retrieve group channels which have been created after the specified time, in Unix milliseconds format. | [optional] 
 **createdBefore** | **long?**| Restricts the search scope to only retrieve group channels which have been created before the specified time, in Unix milliseconds format. | [optional] 
 **showEmpty** | **bool?**|  | [optional] 
 **showMember** | **bool?**|  | [optional] 
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **showMetadata** | **bool?**|  | [optional] 
 **showFrozen** | **bool?**|  | [optional] 
 **order** | **string**|  | [optional] 
 **metadataOrderKey** | **string**| Specifies the key of an item in metadata. When a value of the order parameter is set to metadata_value_alphabetical, the results are alphabetically sorted by the value of the item specified by the key. | [optional] 
 **customTypes** | **string**| Specifies a comma-separated string of one or more custom types to filter group channels. URL encoding each type is recommended. If not specified, all channels are returned, regardless of their custom type. | [optional] 
 **customTypeStartswith** | **string**| Searches for group channels with the custom type which starts with the specified value. URL encoding the value is recommended. | [optional] 
 **channelUrls** | **string**| Specifies a comma-separated string of one or more group channel URLs to restrict the search scope. URL encoding each channel URL is recommended. | [optional] 
 **name** | **string**| Specifies one or more group channel names. | [optional] 
 **nameContains** | **string**| Searches for group channels whose names contain the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended. | [optional] 
 **nameStartswith** | **string**| Searches for group channels whose names start with the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended. | [optional] 
 **membersExactlyIn** | **string**| Searches for group channels with all the specified users as members. The parameter value should consist of user IDs separated by commas.  Only user IDs that match those of existing users are used for channel search. URL encoding each ID is recommended. | [optional] 
 **membersIncludeIn** | **string**| Searches for group channels that include one or more users as members among the specified users. The value should consist of user IDs separated by commas or %2C. You can specify up to 60 user IDs.  Only user IDs that match those of existing users are used for channel search. URL encoding each ID is recommended. | [optional] 
 **queryType** | **string**| Specifies a logical condition applied to the members_include_in parameter. Acceptable values are either AND or OR. For example, if you specify three members, A, B, and C, in members_include_in, the value of AND returns all channels that include every one of {A. B, C} as members. The value of OR returns channels that include {A}, plus those that include {B}, plus those that include {C}. (Default: AND) | [optional] 
 **membersNickname** | **string**| Searches for group channels with members whose nicknames match the specified value. URL encoding the value is recommended. | [optional] 
 **membersNicknameContains** | **string**| Searches for group channels with members whose nicknames contain the specified value. Note that this parameter is case-insensitive. URL encoding the value is recommended.  * We recommend using at least three characters for the parameter value for better search efficiency when you design and implement related features. If you would like to allow one or two characters for searching, use members_nickname instead to prevent performance issues. | [optional] 
 **membersNicknameStartswith** | **string**| Searches for group channels with members whose nicknames begin with the specified value. This parameter isn&#39;t case-sensitive. URL encoding the value is recommended. | [optional] 
 **searchQuery** | **string**| Searches for group channels where the specified query string matches the channel name or the nickname of the member. This parameter isn&#39;t case-sensitive and should be specified in conjunction with the search_fields parameter below. URL encoding the value is recommended. | [optional] 
 **searchFields** | **string**| Specifies a comma-separated string of one or more search fields to apply to the query, which restricts the results within the specified fields (OR search condition). Acceptable values are channel_name and member_nickname. This is effective only when the search_query parameter above is specified. (Default: channel_name, member_nickname together) | [optional] 
 **metadataKey** | **string**| Searches for group channels with metadata containing an item with the specified value as its key. To use this parameter, either the metadata_values parameter or the metadata_value_startswith parameter should be specified. | [optional] 
 **metadataValues** | **string**| Searches for group channels with metadata containing an item with the key specified by the metadata_key parameter, and the value of that item matches one or more values specified by this parameter. The string should be specified with multiple values separated by commas. URL encoding each value is recommended. To use this parameter, the metadata_key parameter should be specified. | [optional] 
 **metadataValueStartswith** | **string**| Searches for group channels with metadata containing an item with the key specified by the metadata_key parameter, and the values of that item that start with the specified value of this parameter. URL encoding the value is recommended. To use this parameter, the metadata_key parameter should be specified. | [optional] 
 **metacounterKey** | **string**| Searches for group channels with metacounter containing an item with the specified value as its key. To use this parameter, either the metacounter_values parameter or one of the metacounter_value_gt, metacounter_value_gte, metacounter_value_lt, and metacounter_value_lte parameters should be specified. | [optional] 
 **metacounterValues** | **string**| Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is equal to one or more values specified by this parameter. The string should be specified with multiple values separated by commas. To use this parameter, the metacounter_key parameter should be specified. | [optional] 
 **metacounterValueGt** | **string**| Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is greater than the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. | [optional] 
 **metacounterValueGte** | **string**| Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is greater than or equal to the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. | [optional] 
 **metacounterValueLt** | **string**| Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is lower than the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. | [optional] 
 **metacounterValueLte** | **string**| Searches for group channels with metacounter containing an item with the key specified by the metadata_key parameter, where the value of that item is lower than or equal to the value specified by this parameter. To use this parameter, the metacounter_key parameter should be specified. | [optional] 
 **includeSortedMetaarrayInLastMessage** | **bool?**| Determines whether to include the sorted_metaarray as one of the last_message’s properties in the response. | [optional] 
 **hiddenMode** | **string**| Restricts the search scope to group channels that match a specific hidden_status and operating behavior | [optional] 
 **unreadFilter** | **string**| Restricts the search scope to only retrieve group channels with one or more unread messages. This filter doesn&#39;t support Supergroup channels. Acceptable values are all and unread_message. (Default: all) | [optional] 
 **memberStateFilter** | **string**|  | [optional] 

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

## List registration or device tokens  Retrieves a list of a user's registration or device tokens. You can pass `gcm`, `huawei`, or `apns` for FCM registration token, HMS device token, or APNs device token, respectively, in the `token_type` parameter for the push notification service you are using.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-device-tokens/list-registration-or-device-tokens#1-list-registration-or-device-tokens

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
            var userId = "userId_example";  // string | (Required) 
            var tokenType = "gcm";  // string | (Required) 
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
 **userId** | **string**| (Required)  | 
 **tokenType** | **string**| (Required)  | 
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

> ListUsersResponse ListUsers (string token = null, int? limit = null, string activeMode = null, bool? showBot = null, string userIds = null, string nickname = null, string nicknameStartswith = null, string metadatakey = null, string metadatavaluesIn = null, string apiToken = null)

List users

## List users  You can retrieve a list of users in your Sendbird application using this API. You can generate a customized list using various parameter combinations.  https://sendbird.com/docs/chat/platform-api/v3/user/listing-users/list-users#1-list-users

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
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var activeMode = "activated";  // string | Specifies the activation status of the users in the list. Acceptable values are `activated`, `deactivated`, and `all`. (Default: `activated`) (optional) 
            var showBot = true;  // bool? | Determines whether to include bots in the list. (Default: true) (optional) 
            var userIds = "userIds_example";  // string | Specifies the user IDs. The value should be a comma-separated string that consists of multiple urlencoded user IDs. An example of a urlencoded string is ?user_ids=urlencoded_id_1,urlencoded_id_2. * The maximum number of user IDs in this parameter is 250. If you exceed the maximum number, your request may receive an HTTP 414 error indicating that the request URL is longer than what Sendbird server can interpret. (optional) 
            var nickname = "nickname_example";  // string |  (optional) 
            var nicknameStartswith = "nicknameStartswith_example";  // string |  (optional) 
            var metadatakey = "metadatakey_example";  // string |  (optional) 
            var metadatavaluesIn = "metadatavaluesIn_example";  // string | Searches for blocked users with metadata containing an item with the key specified by the metadatakey parameter above, and the value of that item matches one or more values specified by this parameter. The string should be specified with multiple urlencoded metadata values separated by commas (for example, `?metadatavalues_in=urlencoded_value_1, urlencoded_value_2`). This parameter should be specified in conjunction with the `metadatakey` above. (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List users
                ListUsersResponse result = apiInstance.ListUsers(token, limit, activeMode, showBot, userIds, nickname, nicknameStartswith, metadatakey, metadatavaluesIn, apiToken);
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **activeMode** | **string**| Specifies the activation status of the users in the list. Acceptable values are &#x60;activated&#x60;, &#x60;deactivated&#x60;, and &#x60;all&#x60;. (Default: &#x60;activated&#x60;) | [optional] 
 **showBot** | **bool?**| Determines whether to include bots in the list. (Default: true) | [optional] 
 **userIds** | **string**| Specifies the user IDs. The value should be a comma-separated string that consists of multiple urlencoded user IDs. An example of a urlencoded string is ?user_ids&#x3D;urlencoded_id_1,urlencoded_id_2. * The maximum number of user IDs in this parameter is 250. If you exceed the maximum number, your request may receive an HTTP 414 error indicating that the request URL is longer than what Sendbird server can interpret. | [optional] 
 **nickname** | **string**|  | [optional] 
 **nicknameStartswith** | **string**|  | [optional] 
 **metadatakey** | **string**|  | [optional] 
 **metadatavaluesIn** | **string**| Searches for blocked users with metadata containing an item with the key specified by the metadatakey parameter above, and the value of that item matches one or more values specified by this parameter. The string should be specified with multiple urlencoded metadata values separated by commas (for example, &#x60;?metadatavalues_in&#x3D;urlencoded_value_1, urlencoded_value_2&#x60;). This parameter should be specified in conjunction with the &#x60;metadatakey&#x60; above. | [optional] 
 **apiToken** | **string**|  | [optional] 

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

> Object MarkAllMessagesAsRead (string userId, string apiToken = null, MarkAllMessagesAsReadRequest markAllMessagesAsReadRequest = null)

Mark all messages as read

## Mark all messages as read  This action marks all of a user's unread messages as read in certain group channels. If channels aren't specified, the user's unread messages in all group channels are marked as read.  https://sendbird.com/docs/chat/platform-api/v3/user/marking-messages-as-read/mark-all-of-a-users-messages-as-read#1-mark-all-of-a-user-s-messages-as-read

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var markAllMessagesAsReadRequest = new MarkAllMessagesAsReadRequest(); // MarkAllMessagesAsReadRequest |  (optional) 

            try
            {
                // Mark all messages as read
                Object result = apiInstance.MarkAllMessagesAsRead(userId, apiToken, markAllMessagesAsReadRequest);
                Debug.WriteLine(result);
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **markAllMessagesAsReadRequest** | [**MarkAllMessagesAsReadRequest**](MarkAllMessagesAsReadRequest.md)|  | [optional] 

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


## RemoveARegistrationOrDeviceToken

> RemoveARegistrationOrDeviceTokenResponse RemoveARegistrationOrDeviceToken (string userId, string tokenType, string token, string apiToken = null)

Remove a registration or device token - When unregistering a specific token

## Remove a registration or device token  Removes a user's specific registration or device token or all tokens. You can pass `gcm`, `huawei`, or `apns` for FCM registration token, HMS device token, or APNs device token, respectively, in the `token_type` parameter for the push notification service you are using.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-device-tokens/remove-a-registration-or-device-token#1-remove-a-registration-or-device-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveARegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var tokenType = "gcm";  // string | (Required) 
            var token = "token_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token - When unregistering a specific token
                RemoveARegistrationOrDeviceTokenResponse result = apiInstance.RemoveARegistrationOrDeviceToken(userId, tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveARegistrationOrDeviceToken: " + e.Message );
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
 **tokenType** | **string**| (Required)  | 
 **token** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**RemoveARegistrationOrDeviceTokenResponse**](RemoveARegistrationOrDeviceTokenResponse.md)

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


## RemoveARegistrationOrDeviceTokenFromAnOwner

> List&lt;MarkChannelMessagesAsReadRequest&gt; RemoveARegistrationOrDeviceTokenFromAnOwner (string tokenType, string token, string apiToken = null)

Remove a registration or device token from an owner

## Remove a registration or device token from an owner  Removes a registration or device token from a user who is the owner of the token. You can pass `gcm`, `huawei`, or `apns` for FCM registration token, HMS device token, or APNs device token, respectively, in the `token_type` parameter for the push notification service you are using.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-device-tokens/remove-a-registration-or-device-token-from-an-owner#1-remove-a-registration-or-device-token-from-an-owner

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveARegistrationOrDeviceTokenFromAnOwnerExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var tokenType = "tokenType_example";  // string | (Required) 
            var token = "token_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token from an owner
                List<MarkChannelMessagesAsReadRequest> result = apiInstance.RemoveARegistrationOrDeviceTokenFromAnOwner(tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveARegistrationOrDeviceTokenFromAnOwner: " + e.Message );
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
 **tokenType** | **string**| (Required)  | 
 **token** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**List&lt;MarkChannelMessagesAsReadRequest&gt;**](MarkChannelMessagesAsReadRequest.md)

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


## RemoveAllRegistrationOrDeviceToken

> RemoveAllRegistrationOrDeviceTokenResponse RemoveAllRegistrationOrDeviceToken (string userId, string apiToken = null)

Remove a registration or device token - When unregistering all device tokens

## Remove a registration or device token  Removes a user's specific registration or device token or all tokens. You can pass `gcm`, `huawei`, or `apns` for FCM registration token, HMS device token, or APNs device token, respectively, in the `token_type` parameter for the push notification service you are using.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-device-tokens/remove-a-registration-or-device-token#1-remove-a-registration-or-device-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveAllRegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a registration or device token - When unregistering all device tokens
                RemoveAllRegistrationOrDeviceTokenResponse result = apiInstance.RemoveAllRegistrationOrDeviceToken(userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.RemoveAllRegistrationOrDeviceToken: " + e.Message );
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

### Return type

[**RemoveAllRegistrationOrDeviceTokenResponse**](RemoveAllRegistrationOrDeviceTokenResponse.md)

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

> Object ResetPushPreferences (string userId, string apiToken = null)

Reset push preferences

## Reset push preferences  You can reset a user's notifications preferences. The values are reset to the default as the following.  - The values for the `do_not_disturb` and `snooze_enabled` properties are set to `false`.      - The values of the parameters associated with the time frame are all set to `0`.      - The value for the `timezone` property is set to `UTC`.      - The value for the `push_sound` property is set to `default`.       > **Note**: Push notifications are only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/reset-push-notification-preferences#1-reset-push-notification-preferences](https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/reset-push-notification-preferences#1-reset-push-notification-preferences)

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Reset push preferences
                Object result = apiInstance.ResetPushPreferences(userId, apiToken);
                Debug.WriteLine(result);
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
 **userId** | **string**| (Required)  | 
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


## UpdateAUser

> SendbirdUser UpdateAUser (string userId, string apiToken = null, UpdateAUserRequest updateAUserRequest = null)

Update a user

## Update a user  You can update information about a user using this API. In addition to changing a user's nickname or profile image, you can issue a new access token for the user. The new access token replaces the previous one as the necessary token for authentication.  You can also deactivate or reactivate a user using this API request. If the `leave_all_when_deactivated` is set to `true`, a user leaves all joined group channels and becomes deactivated.  > **Note**: Issuing session tokens through the `/users/{user_id}` endpoint is now deprecated and it&apos;s replaced with [&lt;code&gt;/users/{user_id}/token&lt;/code&gt;](https://sendbird.com/docs/chat/platform-api/v3/user/managing-session-tokens/issue-a-session-token) endpoint for greater efficiency. For those who are currently using the old endpoint, you can start issuing tokens using the new endpoint.      [https://sendbird.com/docs/chat/platform-api/v3/user/managing-users/update-a-user#1-update-a-user](https://sendbird.com/docs/chat/platform-api/v3/user/managing-users/update-a-user#1-update-a-user)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAUserRequest = new UpdateAUserRequest(); // UpdateAUserRequest |  (optional) 

            try
            {
                // Update a user
                SendbirdUser result = apiInstance.UpdateAUser(userId, apiToken, updateAUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdateAUser: " + e.Message );
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
 **updateAUserRequest** | [**UpdateAUserRequest**](UpdateAUserRequest.md)|  | [optional] 

### Return type

[**SendbirdUser**](SendbirdUser.md)

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


## UpdateChannelInvitationPreference

> UpdateChannelInvitationPreferenceResponse UpdateChannelInvitationPreference (string userId, string apiToken = null, UpdateChannelInvitationPreferenceRequest updateChannelInvitationPreferenceRequest = null)

Update channel invitation preference

## Update channel invitation preference  This action updates a user's [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel) invitation preference. Updating the [application's default channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/setting-up-channels/update-default-invitation-preference) won't override existing users' individual channel invitation preferences. The changed preference only affects the users created after the update.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/update-channel-invitation-preference#1-update-channel-invitation-preference

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateChannelInvitationPreferenceRequest = new UpdateChannelInvitationPreferenceRequest(); // UpdateChannelInvitationPreferenceRequest |  (optional) 

            try
            {
                // Update channel invitation preference
                UpdateChannelInvitationPreferenceResponse result = apiInstance.UpdateChannelInvitationPreference(userId, apiToken, updateChannelInvitationPreferenceRequest);
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateChannelInvitationPreferenceRequest** | [**UpdateChannelInvitationPreferenceRequest**](UpdateChannelInvitationPreferenceRequest.md)|  | [optional] 

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


## UpdateCountPreferenceOfAChannel

> UpdateCountPreferenceOfChannelByUrlResponse UpdateCountPreferenceOfAChannel (string userId, string channelUrl, string apiToken = null, UpdateCountPreferenceOfAChannelRequest updateCountPreferenceOfAChannelRequest = null)

Update count preference of a channel

## Update count preference of a channel  This action updates a user's count preference of a specific group channel. The count preference allows a user to either update the number of unread messages or the number of unread mentioned messages, or both in a specific group channel.  If you want to retrieve the total number count of a specific group channel, go to the [get count preference of a channel](https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/get-count-preference-of-a-channel) page.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/update-count-preference-of-a-channel#1-update-count-preference-of-a-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateCountPreferenceOfAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateCountPreferenceOfAChannelRequest = new UpdateCountPreferenceOfAChannelRequest(); // UpdateCountPreferenceOfAChannelRequest |  (optional) 

            try
            {
                // Update count preference of a channel
                UpdateCountPreferenceOfChannelByUrlResponse result = apiInstance.UpdateCountPreferenceOfAChannel(userId, channelUrl, apiToken, updateCountPreferenceOfAChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdateCountPreferenceOfAChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateCountPreferenceOfAChannelRequest** | [**UpdateCountPreferenceOfAChannelRequest**](UpdateCountPreferenceOfAChannelRequest.md)|  | [optional] 

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

> UpdatePushPreferencesResponse UpdatePushPreferences (string userId, string apiToken = null, UpdatePushPreferencesRequest updatePushPreferencesRequest = null)

Update push preferences

## Update push preferences  You can update a user's notifications preferences. A push notification is a message that is immediately delivered to a user's device when the device is either idle or running the client app in the background.  > **Note**: Push notifications are only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/update-push-notification-preferences#1-update-push-notification-preferences](https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/update-push-notification-preferences#1-update-push-notification-preferences)

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
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updatePushPreferencesRequest = new UpdatePushPreferencesRequest(); // UpdatePushPreferencesRequest |  (optional) 

            try
            {
                // Update push preferences
                UpdatePushPreferencesResponse result = apiInstance.UpdatePushPreferences(userId, apiToken, updatePushPreferencesRequest);
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updatePushPreferencesRequest** | [**UpdatePushPreferencesRequest**](UpdatePushPreferencesRequest.md)|  | [optional] 

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


## UpdatePushPreferencesForAChannel

> UpdatePushPreferencesForAChannelResponse UpdatePushPreferencesForAChannel (string userId, string channelUrl, string apiToken = null, UpdatePushPreferencesForAChannelRequest updatePushPreferencesForAChannelRequest = null)

Update push preferences for a channel

## Update push preferences for a channel  You can update a user's notifications preferences for a specific channel. A push notification is a message that is immediately delivered to a user's device when the device is either idle or running the client app in the background.  > **Note**: Push notifications are only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/update-push-notification-preferences-for-a-channel#1-update-push-notification-preferences-for-a-channel](https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/update-push-notification-preferences-for-a-channel#1-update-push-notification-preferences-for-a-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdatePushPreferencesForAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updatePushPreferencesForAChannelRequest = new UpdatePushPreferencesForAChannelRequest(); // UpdatePushPreferencesForAChannelRequest |  (optional) 

            try
            {
                // Update push preferences for a channel
                UpdatePushPreferencesForAChannelResponse result = apiInstance.UpdatePushPreferencesForAChannel(userId, channelUrl, apiToken, updatePushPreferencesForAChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.UpdatePushPreferencesForAChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updatePushPreferencesForAChannelRequest** | [**UpdatePushPreferencesForAChannelRequest**](UpdatePushPreferencesForAChannelRequest.md)|  | [optional] 

### Return type

[**UpdatePushPreferencesForAChannelResponse**](UpdatePushPreferencesForAChannelResponse.md)

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


## ViewAUser

> SendbirdUser ViewAUser (string userId, bool? includeUnreadCount = null, string customTypes = null, string superMode = null, string apiToken = null)

View a user

## View a user  You can retrieve information about a user using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/listing-users/get-a-user#1-get-a-user  `user_id`   Type: string   Description: Specifies the unique ID of the user to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewAUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var includeUnreadCount = true;  // bool? |  (optional) 
            var customTypes = "customTypes_example";  // string |  (optional) 
            var superMode = "all";  // string | Restricts the search scope to retrieve only Supergroup or non-Supergroup channels. Acceptable values are `all`, `super`, and `nonsuper`. This parameter should be specified in conjunction with `include_unread_count` above. (Default: `all`) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a user
                SendbirdUser result = apiInstance.ViewAUser(userId, includeUnreadCount, customTypes, superMode, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewAUser: " + e.Message );
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
 **includeUnreadCount** | **bool?**|  | [optional] 
 **customTypes** | **string**|  | [optional] 
 **superMode** | **string**| Restricts the search scope to retrieve only Supergroup or non-Supergroup channels. Acceptable values are &#x60;all&#x60;, &#x60;super&#x60;, and &#x60;nonsuper&#x60;. This parameter should be specified in conjunction with &#x60;include_unread_count&#x60; above. (Default: &#x60;all&#x60;) | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**SendbirdUser**](SendbirdUser.md)

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


## ViewCountPreferenceOfAChannel

> ViewCountPreferenceOfAChannelResponse ViewCountPreferenceOfAChannel (string userId, string channelUrl, string apiToken = null)

View count preference of a channel

## View count preference of a channel  This action retrieves a user's count preference of a specific group channel. The count preference allows a user to either retrieve the number of unread messages or unread mentioned messages, or both in a specific group channel.  If you want to update the total number count of a specific group channel, visit the [update count preference of a channel](https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/update-count-preference-of-a-channel).  https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/get-count-preference-of-a-channel#1-get-count-preference-of-a-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewCountPreferenceOfAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View count preference of a channel
                ViewCountPreferenceOfAChannelResponse result = apiInstance.ViewCountPreferenceOfAChannel(userId, channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewCountPreferenceOfAChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewCountPreferenceOfAChannelResponse**](ViewCountPreferenceOfAChannelResponse.md)

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

> ViewNumberOfChannelsWithUnreadMessagesResponse ViewNumberOfChannelsWithUnreadMessages (string userId, string customTypes = null, string superMode = null, string apiToken = null)

View number of channels with unread messages

## View number of channels with unread messages  This action retrieves the total number of group channels in which a user has unread messages. You can use various query parameters to determine the search scope of group channels.  https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/get-number-of-channels-with-unread-messages#1-get-number-of-channels-with-unread-messages

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
            var userId = "userId_example";  // string | (Required) 
            var customTypes = "customTypes_example";  // string |  (optional) 
            var superMode = "all";  // string | Restricts the search scope to either Supergroup channels or non-Supergroup channels or both. Acceptable values are all, super, and nonsuper. (Default: all) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View number of channels with unread messages
                ViewNumberOfChannelsWithUnreadMessagesResponse result = apiInstance.ViewNumberOfChannelsWithUnreadMessages(userId, customTypes, superMode, apiToken);
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
 **userId** | **string**| (Required)  | 
 **customTypes** | **string**|  | [optional] 
 **superMode** | **string**| Restricts the search scope to either Supergroup channels or non-Supergroup channels or both. Acceptable values are all, super, and nonsuper. (Default: all) | [optional] 
 **apiToken** | **string**|  | [optional] 

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


## ViewNumberOfUnreadMessages

> ViewNumberOfUnreadMessagesResponse ViewNumberOfUnreadMessages (string userId, string customTypes = null, string superMode = null, string apiToken = null)

View number of unread messages

## View number of unread messages  This action retrieves a user's total number of unread messages in group channels.  > **Note**: The unread count feature is only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/get-number-of-unread-messages#1-get-number-of-unread-messages](https://sendbird.com/docs/chat/platform-api/v3/user/managing-unread-count/get-number-of-unread-messages#1-get-number-of-unread-messages)  `user_id`   Type: string   Description: Specifies the unique ID of a user.

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
            var userId = "userId_example";  // string | (Required) 
            var customTypes = "customTypes_example";  // string | Specifies a comma-separated string of one or more custom types to filter group channels. URL encoding each type is recommended. If not specified, all channels are returned, regardless of their custom type. (optional) 
            var superMode = "superMode_example";  // string | Restricts the search scope to either Supergroup channels or non-Supergroup channels or both. Acceptable values are `all`, `super`, and `nonsuper`. (Default: `all`) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View number of unread messages
                ViewNumberOfUnreadMessagesResponse result = apiInstance.ViewNumberOfUnreadMessages(userId, customTypes, superMode, apiToken);
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
 **userId** | **string**| (Required)  | 
 **customTypes** | **string**| Specifies a comma-separated string of one or more custom types to filter group channels. URL encoding each type is recommended. If not specified, all channels are returned, regardless of their custom type. | [optional] 
 **superMode** | **string**| Restricts the search scope to either Supergroup channels or non-Supergroup channels or both. Acceptable values are &#x60;all&#x60;, &#x60;super&#x60;, and &#x60;nonsuper&#x60;. (Default: &#x60;all&#x60;) | [optional] 
 **apiToken** | **string**|  | [optional] 

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

## View push preferences  You can retrieves a user's notifications preferences. A push notification is a message that is immediately delivered to a user's device when the device is either idle or running the client app in the background.  > **Note**: Push notifications are only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/get-push-notification-preferences#1-get-push-notification-preferences](https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/get-push-notification-preferences#1-get-push-notification-preferences)

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
            var userId = "userId_example";  // string | (Required) 
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
 **userId** | **string**| (Required)  | 
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


## ViewPushPreferencesForAChannel

> ViewPushPreferencesForAChannelResponse ViewPushPreferencesForAChannel (string userId, string channelUrl, string apiToken = null)

View push preferences for a channel

## View push preferences for a channel  You can retrieve a user's notifications preferences for a specific channel. A push notification is a message that is immediately delivered to a user's device when the device is either idle or running the client app in the background. These notifications preferences can be configured.  > **Note**: Push notifications are only available for group channels.      [https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/get-push-notification-preferences-for-a-channel#1-get-push-notification-preferences-for-a-channel](https://sendbird.com/docs/chat/platform-api/v3/user/configuring-notification-preferences/get-push-notification-preferences-for-a-channel#1-get-push-notification-preferences-for-a-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewPushPreferencesForAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var userId = "userId_example";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View push preferences for a channel
                ViewPushPreferencesForAChannelResponse result = apiInstance.ViewPushPreferencesForAChannel(userId, channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewPushPreferencesForAChannel: " + e.Message );
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
 **channelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewPushPreferencesForAChannelResponse**](ViewPushPreferencesForAChannelResponse.md)

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


## ViewWhoOwnsARegistrationOrDeviceToken

> List&lt;MarkChannelMessagesAsReadRequest&gt; ViewWhoOwnsARegistrationOrDeviceToken (string tokenType, string token, string apiToken = null)

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
    public class ViewWhoOwnsARegistrationOrDeviceTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new UserApi(Configuration.Default);
            var tokenType = "tokenType_example";  // string | (Required) 
            var token = "token_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View who owns a registration or device token
                List<MarkChannelMessagesAsReadRequest> result = apiInstance.ViewWhoOwnsARegistrationOrDeviceToken(tokenType, token, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UserApi.ViewWhoOwnsARegistrationOrDeviceToken: " + e.Message );
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
 **tokenType** | **string**| (Required)  | 
 **token** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**List&lt;MarkChannelMessagesAsReadRequest&gt;**](MarkChannelMessagesAsReadRequest.md)

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

