# sendbird_platform_sdk.Api.GroupChannelApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptAnInvitation**](GroupChannelApi.md#acceptaninvitation) | **PUT** /v3/group_channels/{channel_url}/accept | Accept an invitation
[**CancelTheRegistrationOfOperators**](GroupChannelApi.md#canceltheregistrationofoperators) | **DELETE** /v3/group_channels/{channel_url}/operators | Cancel the registration of operators
[**CheckIfMember**](GroupChannelApi.md#checkifmember) | **GET** /v3/group_channels/{channel_url}/members/{user_id} | Check if member
[**CreateAGroupChannel**](GroupChannelApi.md#createagroupchannel) | **POST** /v3/group_channels | Create a group channel
[**DeleteAGroupChannel**](GroupChannelApi.md#deleteagroupchannel) | **DELETE** /v3/group_channels/{channel_url} | Delete a group channel
[**GetAGroupChannel**](GroupChannelApi.md#getagroupchannel) | **GET** /v3/group_channels/{channel_url} | Get a group channel
[**HideAChannel**](GroupChannelApi.md#hideachannel) | **PUT** /v3/group_channels/{channel_url}/hide | Hide a channel
[**InviteAsMembers**](GroupChannelApi.md#inviteasmembers) | **POST** /v3/group_channels/{channel_url}/invite | Invite as members
[**JoinAChannel**](GroupChannelApi.md#joinachannel) | **PUT** /v3/group_channels/{channel_url}/join | Join a channel
[**LeaveAChannel**](GroupChannelApi.md#leaveachannel) | **PUT** /v3/group_channels/{channel_url}/leave | Leave a channel
[**ListChannels**](GroupChannelApi.md#listchannels) | **GET** /v3/group_channels | List channels
[**ListMembers**](GroupChannelApi.md#listmembers) | **GET** /v3/group_channels/{channel_url}/members | List members
[**ListOperators**](GroupChannelApi.md#listoperators) | **GET** /v3/group_channels/{channel_url}/operators | List operators
[**RegisterOperatorsToAGroupChannel**](GroupChannelApi.md#registeroperatorstoagroupchannel) | **POST** /v3/group_channels/{channel_url}/operators | Register operators to a group channel
[**ResetChatHistory**](GroupChannelApi.md#resetchathistory) | **PUT** /v3/group_channels/{channel_url}/reset_user_history | Reset chat history
[**StartTypingIndicators**](GroupChannelApi.md#starttypingindicators) | **POST** /v3/group_channels/{channel_url}/typing | Start typing indicators
[**StopTypingIndicators**](GroupChannelApi.md#stoptypingindicators) | **DELETE** /v3/group_channels/{channel_url}/typing | Stop typing indicators
[**UnhideAChannel**](GroupChannelApi.md#unhideachannel) | **DELETE** /v3/group_channels/{channel_url}/hide | Unhide a channel
[**UpdateAGroupChannel**](GroupChannelApi.md#updateagroupchannel) | **PUT** /v3/group_channels/{channel_url} | Update a group channel



## AcceptAnInvitation

> SendbirdGroupChannelDetail AcceptAnInvitation (string channelUrl, string apiToken = null, AcceptAnInvitationRequest acceptAnInvitationRequest = null)

Accept an invitation

## Accept an invitation  Accepts an invitation from a group channel for a user to join. A single user may join up to 2,000 group channels, and any invitation to a user who is at capacity will be automatically canceled. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  > **Note**: This action is only available when the `auto_accept` property of an application is set to **false**. You can change the value of the property using the [update default channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/setting-up-channels/update-default-invitation-preference) action, or the [update channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/update-channel-invitation-preference) action.      [https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/accept-an-invitation-channel#1-accept-an-invitation](https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/accept-an-invitation-channel#1-accept-an-invitation)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AcceptAnInvitationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var acceptAnInvitationRequest = new AcceptAnInvitationRequest(); // AcceptAnInvitationRequest |  (optional) 

            try
            {
                // Accept an invitation
                SendbirdGroupChannelDetail result = apiInstance.AcceptAnInvitation(channelUrl, apiToken, acceptAnInvitationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.AcceptAnInvitation: " + e.Message );
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
 **acceptAnInvitationRequest** | [**AcceptAnInvitationRequest**](AcceptAnInvitationRequest.md)|  | [optional] 

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


## CancelTheRegistrationOfOperators

> Object CancelTheRegistrationOfOperators (string channelUrl, string operatorIds, bool? deleteAll = null, string apiToken = null)

Cancel the registration of operators

## Unregister operators from a group channel  You can unregister operators in a group channel but keep them in the channel as members using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/unregister-operators-from-a-group-channel#1-unregister-operators-from-a-group-channel  `channel_url`   Type: string   Description: Specifies the URL of the channel to cancel the registration of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CancelTheRegistrationOfOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var operatorIds = "operatorIds_example";  // string | Specifies an array of one or more operator IDs to unregister from the channel. The operators in this array remain as participants of the channel after losing their operational roles. Urlencoding each operator ID is recommended. An example of a Urlencoded array would be ?operator_ids=urlencoded_id_1,urlencoded_id_2.
            var deleteAll = true;  // bool? |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Cancel the registration of operators
                Object result = apiInstance.CancelTheRegistrationOfOperators(channelUrl, operatorIds, deleteAll, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.CancelTheRegistrationOfOperators: " + e.Message );
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
 **deleteAll** | **bool?**|  | [optional] 
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


## CheckIfMember

> CheckIfMemberResponse CheckIfMember (string channelUrl, string userId, string apiToken = null)

Check if member

## Check if user is a member  Checks if a user is a member of a group channel.  > **Note**: See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.      [https://sendbird.com/docs/chat/platform-api/v3/channel/listing-users/check-if-user-is-a-member#1-check-if-user-is-a-member](https://sendbird.com/docs/chat/platform-api/v3/channel/listing-users/check-if-user-is-a-member#1-check-if-user-is-a-member)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CheckIfMemberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var userId = "userId_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Check if member
                CheckIfMemberResponse result = apiInstance.CheckIfMember(channelUrl, userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.CheckIfMember: " + e.Message );
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
 **userId** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**CheckIfMemberResponse**](CheckIfMemberResponse.md)

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


## CreateAGroupChannel

> SendbirdGroupChannelDetail CreateAGroupChannel (string apiToken = null, CreateAGroupChannelRequest createAGroupChannelRequest = null)

Create a group channel

## Create a group channel  You can create a group channel for 1-to-1 and 1-to-N conversations. By default, group channels are used for conversations between up to 100 members. This number can stretch up to tens of thousands in Supergroup channels. Group channels can either be private and invite only, or public. They support typing indicators, unread count and read receipts, allowing for an interactive chat experience. A user can join up to 2000 group channels, and higher numbers would negatively impact the performance for the end user. The Chat history is turned off by default and its settings can be changed on Sendbird Dashboard by going to Settings > Chat > Channels > Group channels > Chat history. To learn more about group channels, see Channel Overview.  > If you are seeing the error message Maximum \"channel join\" count reached., then consider deleting channels that are no longer used. For situations where an agent connects with many customers such as support, delivery logistics or sales, we recommend using Sendbird Desk.  https://sendbird.com/docs/chat/platform-api/v3/channel/creating-a-channel/create-a-group-channel#1-create-a-group-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createAGroupChannelRequest = new CreateAGroupChannelRequest(); // CreateAGroupChannelRequest |  (optional) 

            try
            {
                // Create a group channel
                SendbirdGroupChannelDetail result = apiInstance.CreateAGroupChannel(apiToken, createAGroupChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.CreateAGroupChannel: " + e.Message );
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
 **createAGroupChannelRequest** | [**CreateAGroupChannelRequest**](CreateAGroupChannelRequest.md)|  | [optional] 

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


## DeleteAGroupChannel

> Object DeleteAGroupChannel (string channelUrl, string apiToken = null)

Delete a group channel

## Delete a group channel  You can delete a group channel or a Supergroup channel using this API. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  [https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/delete-a-group-channel#1-delete-a-group-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/delete-a-group-channel#1-delete-a-group-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a group channel
                Object result = apiInstance.DeleteAGroupChannel(channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.DeleteAGroupChannel: " + e.Message );
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
 **channelUrl** | **string**|  | 
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


## GetAGroupChannel

> GetAGroupChannelResponse GetAGroupChannel (string channelUrl, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMember = null, string memberActiveMode = null, string userId = null, string apiToken = null)

Get a group channel

## Get a group channel  This action retrieves information about a specific [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel). You can use the optional query parameters to determine whether to include delivery receipt, read receipt, or member information in the response.  https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/get-a-group-channel#1-get-a-group-channel  `channel_url`   Type: string   Description: Specifies the URL of the channel to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var showMember = true;  // bool? |  (optional) 
            var memberActiveMode = "all";  // string | Restricts the member list to members who are activated or deactivated in the channel. This parameter is only effective if the parameter show_member is true. Acceptable values are all, activated, and deactivated. (default: all) (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get a group channel
                GetAGroupChannelResponse result = apiInstance.GetAGroupChannel(channelUrl, showDeliveryReceipt, showReadReceipt, showMember, memberActiveMode, userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GetAGroupChannel: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **showMember** | **bool?**|  | [optional] 
 **memberActiveMode** | **string**| Restricts the member list to members who are activated or deactivated in the channel. This parameter is only effective if the parameter show_member is true. Acceptable values are all, activated, and deactivated. (default: all) | [optional] 
 **userId** | **string**|  | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**GetAGroupChannelResponse**](GetAGroupChannelResponse.md)

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


## HideAChannel

> Object HideAChannel (string channelUrl, string apiToken = null, HideAChannelRequest hideAChannelRequest = null)

Hide a channel

## Hide a channel  This action allows you to hide a [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel) from a user's channel list. Hiding a channel gives users the ability to archive channels so that they can focus on channels that need the most attention.  With this API, you can allow users to hide a channel from themselves or from all channel members. You can also determine whether to have the channel remain hidden when a new message is sent to the channel. Note that only group channels can be hidden.  [https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/hide-a-channel#1-hide-a-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/hide-a-channel#1-hide-a-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class HideAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var hideAChannelRequest = new HideAChannelRequest(); // HideAChannelRequest |  (optional) 

            try
            {
                // Hide a channel
                Object result = apiInstance.HideAChannel(channelUrl, apiToken, hideAChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.HideAChannel: " + e.Message );
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
 **hideAChannelRequest** | [**HideAChannelRequest**](HideAChannelRequest.md)|  | [optional] 

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


## InviteAsMembers

> InviteAsMembersResponse InviteAsMembers (string channelUrl, string apiToken = null, InviteAsMembersRequest inviteAsMembersRequest = null)

Invite as members

## Invite as members  Invites one or more users as members to a group channel. Users can join a group channel immediately after receiving an invitation, without having to accept it. To give users an option to accept or decline an invitation, see [update default channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/setting-up-channels/update-default-invitation-preference) or [update channel invitation preference](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/update-channel-invitation-preference). See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  > **Note**: By default, [blocked users](https://sendbird.com/docs/chat/platform-api/v3/moderation/blocking-users/block-users) are included when sending invitations. If you wish to exclude blocked users, [contact our sales team](https://get.sendbird.com/talk-to-sales.html).      [https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/invite-as-members-channel#1-invite-as-members](https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/invite-as-members-channel#1-invite-as-members)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class InviteAsMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var inviteAsMembersRequest = new InviteAsMembersRequest(); // InviteAsMembersRequest |  (optional) 

            try
            {
                // Invite as members
                InviteAsMembersResponse result = apiInstance.InviteAsMembers(channelUrl, apiToken, inviteAsMembersRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.InviteAsMembers: " + e.Message );
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
 **inviteAsMembersRequest** | [**InviteAsMembersRequest**](InviteAsMembersRequest.md)|  | [optional] 

### Return type

[**InviteAsMembersResponse**](InviteAsMembersResponse.md)

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


## JoinAChannel

> SendbirdGroupChannelDetail JoinAChannel (string channelUrl, string apiToken = null, JoinAChannelRequest joinAChannelRequest = null)

Join a channel

## Join a channel  This API allows a user to join a [public](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#4-group-channel-types) group channel. Users can only join public group channels where the `is_public` property is set to `true` using this API. A single user can join up to 2,000 group channels, and a user who reaches the capacity can’t join a new channel. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  [https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/join-a-channel#1-join-a-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/join-a-channel#1-join-a-channel)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class JoinAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var joinAChannelRequest = new JoinAChannelRequest(); // JoinAChannelRequest |  (optional) 

            try
            {
                // Join a channel
                SendbirdGroupChannelDetail result = apiInstance.JoinAChannel(channelUrl, apiToken, joinAChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.JoinAChannel: " + e.Message );
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
 **joinAChannelRequest** | [**JoinAChannelRequest**](JoinAChannelRequest.md)|  | [optional] 

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
| **200** | Join a channel |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LeaveAChannel

> Object LeaveAChannel (string channelUrl, string apiToken = null, LeaveAChannelRequest leaveAChannelRequest = null)

Leave a channel

## Leave a channel  Makes one or more members leave a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-leave-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var leaveAChannelRequest = new LeaveAChannelRequest(); // LeaveAChannelRequest |  (optional) 

            try
            {
                // Leave a channel
                Object result = apiInstance.LeaveAChannel(channelUrl, apiToken, leaveAChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.LeaveAChannel: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **leaveAChannelRequest** | [**LeaveAChannelRequest**](LeaveAChannelRequest.md)|  | [optional] 

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


## ListChannels

> GroupChatListChannelsResponse ListChannels (string apiToken, string token = null, int? limit = null, string distinctMode = null, string publicMode = null, string superMode = null, long? createdAfter = null, long? createdBefore = null, bool? showEmpty = null, bool? showMember = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMetadata = null, bool? showFrozen = null, string order = null, string metadataOrderKey = null, string customTypes = null, string customTypeStartswith = null, string channelUrls = null, string name = null, string nameContains = null, string nameStartswith = null, string membersExactlyIn = null, string membersIncludeIn = null, string queryType = null, string membersNickname = null, string membersNicknameContains = null, string metadataKey = null, string metadataValues = null, string metadataValueStartswith = null, string metacounterKey = null, string metacounterValues = null, string metacounterValueGt = null, string metacounterValueGte = null, string metacounterValueLt = null, string metacounterValueLte = null, bool? includeSortedMetaarrayInLastMessage = null)

List channels

## List group channels  This action retrieves a list of [group channels](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel). You can use various query parameters to determine the search scope and select what kind of information you want to receive about the queried channels.  If you want to retrieve a list of group channels that a specific user has joined, use the [list group channels by user](https://sendbird.com/docs/chat/platform-api/v3/user/managing-joined-group-channels/list-group-channels-by-user) action under the User section.  https://sendbird.com/docs/chat/platform-api/v3/channel/listing-channels-in-an-application/list-group-channels#1-list-group-channels

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
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

            try
            {
                // List channels
                GroupChatListChannelsResponse result = apiInstance.ListChannels(apiToken, token, limit, distinctMode, publicMode, superMode, createdAfter, createdBefore, showEmpty, showMember, showDeliveryReceipt, showReadReceipt, showMetadata, showFrozen, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, includeSortedMetaarrayInLastMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.ListChannels: " + e.Message );
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

### Return type

[**GroupChatListChannelsResponse**](GroupChatListChannelsResponse.md)

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


## ListMembers

> GroupChannelListMembersResponse ListMembers (string channelUrl, string token = null, int? limit = null, string userId = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMemberIsMuted = null, string order = null, string operatorFilter = null, string memberStateFilter = null, string mutedMemberFilter = null, string memberActiveModeFilter = null, string nicknameStartswith = null, bool? includePushPreference = null, string apiToken = null)

List members

## List members  Retrieves a list of members of a group channel.  > **Note**: See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.      [https://sendbird.com/docs/chat/platform-api/v3/channel/listing-users/list-members-of-a-group-channel#1-list-members-of-a-group-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/listing-users/list-members-of-a-group-channel#1-list-members-of-a-group-channel)  `channel_url`   Type: string   Description: Specifies the URL of the channel to retrieve a list of members of.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? | Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) (optional) 
            var userId = "userId_example";  // string | Specifies the unique ID of a user. If `user_id` is provided, the response will include two additional boolean properties about each user in the members list. - `is_blocking_me`: Indicates whether the listed user is blocking the user specified in the user_id parameter. - `is_blocked_by_me`: Indicates whether the listed user is blocked by the user specified in the user_id parameter. (optional) 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var showMemberIsMuted = true;  // bool? |  (optional) 
            var order = "member_nickname_alphabetical";  // string | Specifies the method to sort a list of results. Acceptable values are the following: - `member_nickname_alphabetical` (default): sorts by the member nicknames in alphabetical order. - `operator_then_member_alphabetical`: sorts by the operational role and member nickname in alphabetical order where channel operators are listed before channel members. (optional) 
            var operatorFilter = "all";  // string | Restricts the search scope to only retrieve operators or non-operator members of the channel. Acceptable values are the following: - `all` (default): no filter is applied to the list. - `operator`: only channel operators are retrieved. - `nonoperator`: all channel members, except channel operators, are retrieved. (optional) 
            var memberStateFilter = "all";  // string | Restricts the search scope to retrieve members based on if they have accepted an invitation or if they were invited by a friend. Acceptable values are `invited_only`, `joined_only`, `invited_by_friend`, `invited_by_non_friend`, and `all`. (Default: `all`) (optional) 
            var mutedMemberFilter = "all";  // string | Restricts the search scope to retrieve members who are muted or unmuted in the channel. Acceptable values are `all`, `muted`, and `unmuted`. (Default: `all`) (optional) 
            var memberActiveModeFilter = "activated";  // string | Restricts the search scope to retrieve members who are activated or deactivated in the channel. Acceptable values are `all`, `activated`, and `deactivated`. (default: `activated`) (optional) 
            var nicknameStartswith = "nicknameStartswith_example";  // string | Searches for members whose nicknames start with the specified value. Urlencoding the value is recommended. (optional) 
            var includePushPreference = true;  // bool? | Determines whether to include information about the push preference of each member, such as `push_enabled`, `push_trigger_option`, and `do_not_disturb`. (Default: `false`) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List members
                GroupChannelListMembersResponse result = apiInstance.ListMembers(channelUrl, token, limit, userId, showDeliveryReceipt, showReadReceipt, showMemberIsMuted, order, operatorFilter, memberStateFilter, mutedMemberFilter, memberActiveModeFilter, nicknameStartswith, includePushPreference, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.ListMembers: " + e.Message );
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
 **limit** | **int?**| Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) | [optional] 
 **userId** | **string**| Specifies the unique ID of a user. If &#x60;user_id&#x60; is provided, the response will include two additional boolean properties about each user in the members list. - &#x60;is_blocking_me&#x60;: Indicates whether the listed user is blocking the user specified in the user_id parameter. - &#x60;is_blocked_by_me&#x60;: Indicates whether the listed user is blocked by the user specified in the user_id parameter. | [optional] 
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **showMemberIsMuted** | **bool?**|  | [optional] 
 **order** | **string**| Specifies the method to sort a list of results. Acceptable values are the following: - &#x60;member_nickname_alphabetical&#x60; (default): sorts by the member nicknames in alphabetical order. - &#x60;operator_then_member_alphabetical&#x60;: sorts by the operational role and member nickname in alphabetical order where channel operators are listed before channel members. | [optional] 
 **operatorFilter** | **string**| Restricts the search scope to only retrieve operators or non-operator members of the channel. Acceptable values are the following: - &#x60;all&#x60; (default): no filter is applied to the list. - &#x60;operator&#x60;: only channel operators are retrieved. - &#x60;nonoperator&#x60;: all channel members, except channel operators, are retrieved. | [optional] 
 **memberStateFilter** | **string**| Restricts the search scope to retrieve members based on if they have accepted an invitation or if they were invited by a friend. Acceptable values are &#x60;invited_only&#x60;, &#x60;joined_only&#x60;, &#x60;invited_by_friend&#x60;, &#x60;invited_by_non_friend&#x60;, and &#x60;all&#x60;. (Default: &#x60;all&#x60;) | [optional] 
 **mutedMemberFilter** | **string**| Restricts the search scope to retrieve members who are muted or unmuted in the channel. Acceptable values are &#x60;all&#x60;, &#x60;muted&#x60;, and &#x60;unmuted&#x60;. (Default: &#x60;all&#x60;) | [optional] 
 **memberActiveModeFilter** | **string**| Restricts the search scope to retrieve members who are activated or deactivated in the channel. Acceptable values are &#x60;all&#x60;, &#x60;activated&#x60;, and &#x60;deactivated&#x60;. (default: &#x60;activated&#x60;) | [optional] 
 **nicknameStartswith** | **string**| Searches for members whose nicknames start with the specified value. Urlencoding the value is recommended. | [optional] 
 **includePushPreference** | **bool?**| Determines whether to include information about the push preference of each member, such as &#x60;push_enabled&#x60;, &#x60;push_trigger_option&#x60;, and &#x60;do_not_disturb&#x60;. (Default: &#x60;false&#x60;) | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**GroupChannelListMembersResponse**](GroupChannelListMembersResponse.md)

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


## ListOperators

> ListOperatorsResponse ListOperators (string channelUrl, string token = null, int? limit = null, string apiToken = null)

List operators

## List operators  You can retrieve a list of operators of a group channel using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/list-operators-of-a-group-channel#1-list-operators-of-a-group-channel  `channel_url`   Type: string   Description: Specifies the URL of the channel to retrieve a list of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? | Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List operators
                ListOperatorsResponse result = apiInstance.ListOperators(channelUrl, token, limit, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.ListOperators: " + e.Message );
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
 **limit** | **int?**| Specifies the number of results to return per page. Acceptable values are 1 to 100, inclusive. (Default: 10) | [optional] 
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


## RegisterOperatorsToAGroupChannel

> Object RegisterOperatorsToAGroupChannel (string channelUrl, string apiToken = null, RegisterOperatorsToAGroupChannelRequest registerOperatorsToAGroupChannelRequest = null)

Register operators to a group channel

## Register operators to a group channel  You can register one or more operators to a group channel using this API.  https://sendbird.com/docs/chat/platform-api/v3/user/assigning-a-user-role/register-operators-to-a-group-channel#1-register-operators-to-a-group-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RegisterOperatorsToAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var registerOperatorsToAGroupChannelRequest = new RegisterOperatorsToAGroupChannelRequest(); // RegisterOperatorsToAGroupChannelRequest |  (optional) 

            try
            {
                // Register operators to a group channel
                Object result = apiInstance.RegisterOperatorsToAGroupChannel(channelUrl, apiToken, registerOperatorsToAGroupChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.RegisterOperatorsToAGroupChannel: " + e.Message );
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


## ResetChatHistory

> ResetChatHistoryResponse ResetChatHistory (string channelUrl, string apiToken = null, ResetChatHistoryRequest resetChatHistoryRequest = null)

Reset chat history

## Reset chat history  This action resets the properties related to a specific user's chat history in a [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel), clearing existing messages in a channel from only the specified user's end. Because this action doesn't delete messages from the Sendbird database, other members in the channel can still retrieve and see the messages.  This action clears the messages for the specified user by updating the `last_message` and `read_receipt` properties of the [group channel resource](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#4-list-of-properties-for-group-channels) in addition to other internally managed data such as the count of a user's unread messages.  Using the `reset_all` property, you can also reset the properties related to the chat history of all members in a group channel.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/reset-chat-history#1-reset-chat-history

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ResetChatHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var resetChatHistoryRequest = new ResetChatHistoryRequest(); // ResetChatHistoryRequest |  (optional) 

            try
            {
                // Reset chat history
                ResetChatHistoryResponse result = apiInstance.ResetChatHistory(channelUrl, apiToken, resetChatHistoryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.ResetChatHistory: " + e.Message );
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
 **resetChatHistoryRequest** | [**ResetChatHistoryRequest**](ResetChatHistoryRequest.md)|  | [optional] 

### Return type

[**ResetChatHistoryResponse**](ResetChatHistoryResponse.md)

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


## StartTypingIndicators

> Object StartTypingIndicators (string channelUrl, string apiToken = null, StartTypingIndicatorsRequest startTypingIndicatorsRequest = null)

Start typing indicators

## Start typing indicators  You can start showing a typing indicator using this API. Seeing whether other users are typing can help a more interactive conversation environment by showing real-time engagement of other users.  If you're looking for an easy way to show typing indicators on your app, check out Sendbird UIKit for a ready-to-use UI feature that can be customized to fit your needs.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-typing-indicators/start-typing-indicators#1-start-typing-indicators  `channel_url`   Type: string   Description: Specifies the URL of the channel to set typing indicators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class StartTypingIndicatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var startTypingIndicatorsRequest = new StartTypingIndicatorsRequest(); // StartTypingIndicatorsRequest |  (optional) 

            try
            {
                // Start typing indicators
                Object result = apiInstance.StartTypingIndicators(channelUrl, apiToken, startTypingIndicatorsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.StartTypingIndicators: " + e.Message );
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
 **startTypingIndicatorsRequest** | [**StartTypingIndicatorsRequest**](StartTypingIndicatorsRequest.md)|  | [optional] 

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


## StopTypingIndicators

> Object StopTypingIndicators (string channelUrl, string apiToken = null, StartTypingIndicatorsRequest startTypingIndicatorsRequest = null)

Stop typing indicators

## Stop typing indicators  You can stop showing a typing indicator using this API. To signal that a user is no longer typing, you can let the indicator disappear when the user sends a message or completely deletes the message text.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-typing-indicators/stop-typing-indicators#1-stop-typing-indicators  `channel_url`   Type: string   Description: Specifies the URL of the channel to set typing indicators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class StopTypingIndicatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var startTypingIndicatorsRequest = new StartTypingIndicatorsRequest(); // StartTypingIndicatorsRequest |  (optional) 

            try
            {
                // Stop typing indicators
                Object result = apiInstance.StopTypingIndicators(channelUrl, apiToken, startTypingIndicatorsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.StopTypingIndicators: " + e.Message );
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
 **startTypingIndicatorsRequest** | [**StartTypingIndicatorsRequest**](StartTypingIndicatorsRequest.md)|  | [optional] 

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


## UnhideAChannel

> Object UnhideAChannel (string channelUrl, string userId, bool? shouldUnhideAll = null, string apiToken = null)

Unhide a channel

## Unhide a channel  This action lets a hidden [group channel](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-group-channel) reappear on the channel list of a specific user or every member in the group channel. Hiding or unhiding a channel lets users organize their channel list based on those that require the most attention. Note that only group channels can be hidden or unhidden.  [https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/unhide-a-channel#1-unhide-a-channel](https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/unhide-a-channel#1-unhide-a-channel)  `channel_url`   Type: string   Description: Specifies the URL of the channel to unhide or unarchive.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnhideAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var userId = "userId_example";  // string | (Required) 
            var shouldUnhideAll = true;  // bool? |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unhide a channel
                Object result = apiInstance.UnhideAChannel(channelUrl, userId, shouldUnhideAll, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.UnhideAChannel: " + e.Message );
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
 **userId** | **string**| (Required)  | 
 **shouldUnhideAll** | **bool?**|  | [optional] 
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


## UpdateAGroupChannel

> SendbirdGroupChannelDetail UpdateAGroupChannel (string channelUrl, string apiToken = null, UpdateAGroupChannelRequest updateAGroupChannelRequest = null)

Update a group channel

## Update a group channel  You can update information about a group channel or a Supergroup channel using this API. You can't make any changes to the members of a channel with this API. To change members, see [invite as members](https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/invite-as-members-channel) instead. See [this page](https://sendbird.com/docs/chat/platform-api/v3/channel/channel-overview#2-channel-types-3-open-channel-vs-group-channel-vs-supergroup-channel) to learn more about channel types.  https://sendbird.com/docs/chat/platform-api/v3/channel/managing-a-channel/update-a-group-channel#1-update-a-group-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAGroupChannelRequest = new UpdateAGroupChannelRequest(); // UpdateAGroupChannelRequest |  (optional) 

            try
            {
                // Update a group channel
                SendbirdGroupChannelDetail result = apiInstance.UpdateAGroupChannel(channelUrl, apiToken, updateAGroupChannelRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.UpdateAGroupChannel: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateAGroupChannelRequest** | [**UpdateAGroupChannelRequest**](UpdateAGroupChannelRequest.md)|  | [optional] 

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

