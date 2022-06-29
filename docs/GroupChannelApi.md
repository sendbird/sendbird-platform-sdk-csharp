# sendbird_platform_sdk.Api.GroupChannelApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GcAcceptInvitation**](GroupChannelApi.md#gcacceptinvitation) | **PUT** /v3/group_channels/{channel_url}/accept | Accept an invitation
[**GcCancelTheRegistrationOfOperators**](GroupChannelApi.md#gccanceltheregistrationofoperators) | **DELETE** /v3/group_channels/{channel_url}/operators | Cancel the registration of operators
[**GcCheckIfMemberById**](GroupChannelApi.md#gccheckifmemberbyid) | **GET** /v3/group_channels/{channel_url}/members/{user_id} | Check if member
[**GcCreateChannel**](GroupChannelApi.md#gccreatechannel) | **POST** /v3/group_channels | Create a channel
[**GcDeclineInvitation**](GroupChannelApi.md#gcdeclineinvitation) | **PUT** /v3/group_channels/{channel_url}/decline | Decline an invitation
[**GcDeleteChannelByUrl**](GroupChannelApi.md#gcdeletechannelbyurl) | **DELETE** /v3/group_channels/{channel_url} | Delete a channel
[**GcHideOrArchiveChannel**](GroupChannelApi.md#gchideorarchivechannel) | **PUT** /v3/group_channels/{channel_url}/hide | Hide or archive a channel
[**GcInviteAsMembers**](GroupChannelApi.md#gcinviteasmembers) | **POST** /v3/group_channels/{channel_url}/invite | Invite as members
[**GcJoinChannel**](GroupChannelApi.md#gcjoinchannel) | **PUT** /v3/group_channels/{channel_url}/join | Join a channel
[**GcLeaveChannel**](GroupChannelApi.md#gcleavechannel) | **PUT** /v3/group_channels/{channel_url}/leave | Leave a channel
[**GcListChannels**](GroupChannelApi.md#gclistchannels) | **GET** /v3/group_channels | List channels
[**GcListMembers**](GroupChannelApi.md#gclistmembers) | **GET** /v3/group_channels/{channel_url}/members | List members
[**GcListOperators**](GroupChannelApi.md#gclistoperators) | **GET** /v3/group_channels/{channel_url}/operators | List operators
[**GcRegisterOperators**](GroupChannelApi.md#gcregisteroperators) | **POST** /v3/group_channels/{channel_url}/operators | Register operators
[**GcResetChatHistory**](GroupChannelApi.md#gcresetchathistory) | **PUT** /v3/group_channels/{channel_url}/reset_user_history | Reset chat history
[**GcUnhideOrUnarchiveChannel**](GroupChannelApi.md#gcunhideorunarchivechannel) | **DELETE** /v3/group_channels/{channel_url}/hide | Unhide or unarchive a channel
[**GcUpdateChannelByUrl**](GroupChannelApi.md#gcupdatechannelbyurl) | **PUT** /v3/group_channels/{channel_url} | Update a channel
[**GcViewChannelByUrl**](GroupChannelApi.md#gcviewchannelbyurl) | **GET** /v3/group_channels/{channel_url} | View a channel



## GcAcceptInvitation

> SendBirdGroupChannel GcAcceptInvitation (string apiToken, string channelUrl, GcAcceptInvitationData gcAcceptInvitationData = null)

Accept an invitation

## Accept an invitation  Accepts an invitation from a [private](#4-private-vs-public) group channel for a user to join. Since a user is allowed to join up to 2,000 group channels, the invitation to a user who already belongs to a maximum number of group channels will be canceled automatically.  > __Note__: This action is effective only when the `auto_accept` property of an application is set to false. You can change the value of the property using the [update default channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-default-channel-invitation-preference) action, or [update a user's channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-channel-invitation-preference) action.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-accept-an-invitation - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcAcceptInvitationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcAcceptInvitationData = new GcAcceptInvitationData(); // GcAcceptInvitationData |  (optional) 

            try
            {
                // Accept an invitation
                SendBirdGroupChannel result = apiInstance.GcAcceptInvitation(apiToken, channelUrl, gcAcceptInvitationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcAcceptInvitation: " + e.Message );
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
 **gcAcceptInvitationData** | [**GcAcceptInvitationData**](GcAcceptInvitationData.md)|  | [optional] 

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


## GcCancelTheRegistrationOfOperators

> InlineResponse2001 GcCancelTheRegistrationOfOperators (string apiToken, string channelUrl, List<string> operatorIds, bool? deleteAll = null)

Cancel the registration of operators

## Cancel the registration of operators  Cancels the registration of operators from a group channel but leave them as members.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-cancel-the-registration-of-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to cancel the registration of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcCancelTheRegistrationOfOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var operatorIds = new List<string>(); // List<string> | 
            var deleteAll = true;  // bool? |  (optional) 

            try
            {
                // Cancel the registration of operators
                InlineResponse2001 result = apiInstance.GcCancelTheRegistrationOfOperators(apiToken, channelUrl, operatorIds, deleteAll);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcCancelTheRegistrationOfOperators: " + e.Message );
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
 **operatorIds** | [**List&lt;string&gt;**](string.md)|  | 
 **deleteAll** | **bool?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcCheckIfMemberById

> GcCheckIfMemberByIdResponse GcCheckIfMemberById (string apiToken, string channelUrl, string userId)

Check if member

## Check if member  Checks whether the user is a member of the group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-check-if-member - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcCheckIfMemberByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var userId = userId_example;  // string | 

            try
            {
                // Check if member
                GcCheckIfMemberByIdResponse result = apiInstance.GcCheckIfMemberById(apiToken, channelUrl, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcCheckIfMemberById: " + e.Message );
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
 **userId** | **string**|  | 

### Return type

[**GcCheckIfMemberByIdResponse**](GcCheckIfMemberByIdResponse.md)

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


## GcCreateChannel

> SendBirdGroupChannel GcCreateChannel (string apiToken, GcCreateChannelData gcCreateChannelData = null)

Create a channel

## Create a channel  Creates a new group channel.  > If you are creating a 1-on-1 direct messaging channel for a user, it is recommended that you turn on the `distinct` property. If the property is turned off, a user can create a new channel even if they have had the previous chat between them, and therefore can't see previously sent messages or data in the new channel. On the other hand, if the `distinct` property is turned on, every 1-on-1 conversation between the same two users occurs within the same channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-create-a-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcCreateChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var gcCreateChannelData = new GcCreateChannelData(); // GcCreateChannelData |  (optional) 

            try
            {
                // Create a channel
                SendBirdGroupChannel result = apiInstance.GcCreateChannel(apiToken, gcCreateChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcCreateChannel: " + e.Message );
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
 **gcCreateChannelData** | [**GcCreateChannelData**](GcCreateChannelData.md)|  | [optional] 

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


## GcDeclineInvitation

> InlineResponse2001 GcDeclineInvitation (string apiToken, string channelUrl, GcDeclineInvitationData gcDeclineInvitationData = null)

Decline an invitation

## Decline an invitation  Declines an invitation for a user to not join a [private](#4-private-vs-public) group channel.  > __Note__: This action is effective only when the `auto_accept` property of an application is set to false. You can change the value of the property using the [update default channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-default-channel-invitation-preference) action, or [update a user's channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-channel-invitation-preference) action.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-decline-an-invitation - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcDeclineInvitationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcDeclineInvitationData = new GcDeclineInvitationData(); // GcDeclineInvitationData |  (optional) 

            try
            {
                // Decline an invitation
                InlineResponse2001 result = apiInstance.GcDeclineInvitation(apiToken, channelUrl, gcDeclineInvitationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcDeclineInvitation: " + e.Message );
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
 **gcDeclineInvitationData** | [**GcDeclineInvitationData**](GcDeclineInvitationData.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcDeleteChannelByUrl

> InlineResponse2001 GcDeleteChannelByUrl (string apiToken, string channelUrl)

Delete a channel

## Delete a channel  Deletes a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-delete-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcDeleteChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 

            try
            {
                // Delete a channel
                InlineResponse2001 result = apiInstance.GcDeleteChannelByUrl(apiToken, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcDeleteChannelByUrl: " + e.Message );
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

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcHideOrArchiveChannel

> InlineResponse2001 GcHideOrArchiveChannel (string apiToken, string channelUrl, GcHideOrArchiveChannelData gcHideOrArchiveChannelData = null)

Hide or archive a channel

## Hide or archive a channel  Hides or archives a channel from the channel list of either a specific user or entire channel members. Normally, a hidden channel comes back and shows up in the channel list when a member in the channel sends a new message. This automatically-triggered behavior is intended for users who want to temporarily remove a channel from their list because [leaving the channel](#2-leave-the-channel) would delete all the past messages and stored data.  You can also leave out a channel from the list and archive the channel. The channel doesn't appear even when receiving a new message from other member.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-hide-or-archive-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcHideOrArchiveChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcHideOrArchiveChannelData = new GcHideOrArchiveChannelData(); // GcHideOrArchiveChannelData |  (optional) 

            try
            {
                // Hide or archive a channel
                InlineResponse2001 result = apiInstance.GcHideOrArchiveChannel(apiToken, channelUrl, gcHideOrArchiveChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcHideOrArchiveChannel: " + e.Message );
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
 **gcHideOrArchiveChannelData** | [**GcHideOrArchiveChannelData**](GcHideOrArchiveChannelData.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcInviteAsMembers

> SendBirdGroupChannel GcInviteAsMembers (string apiToken, string channelUrl, GcInviteAsMembersData gcInviteAsMembersData = null)

Invite as members

## Invite as members  Invites one or more users as members into the group channel.  > __Note__: By default, users in your application automatically join a [private](#4-private-vs-public) group channel promptly from an invitation without having to accept it. If you want to give them the option to decide whether to accept or decline an invitation, you should set the value of channel invitation preference to false through the [update default channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-default-channel-invitation-preference) action. Or using the [update a user's channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-channel-invitation-preference) action, you can also allow the option individually by user.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-invite-as-members - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcInviteAsMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcInviteAsMembersData = new GcInviteAsMembersData(); // GcInviteAsMembersData |  (optional) 

            try
            {
                // Invite as members
                SendBirdGroupChannel result = apiInstance.GcInviteAsMembers(apiToken, channelUrl, gcInviteAsMembersData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcInviteAsMembers: " + e.Message );
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
 **gcInviteAsMembersData** | [**GcInviteAsMembersData**](GcInviteAsMembersData.md)|  | [optional] 

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


## GcJoinChannel

> void GcJoinChannel (string apiToken, string channelUrl, GcJoinChannelData gcJoinChannelData = null)

Join a channel

## Join a channel  Allows a user to join a [public](#4-private-vs-public) group channel. Since a user is allowed to join up to 2,000 group channels, a user who already belongs to a maximum number of group channels can't join a new channel.  > __Note__: This action is only permitted for public group channels where the `is_public` property is true.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-join-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcJoinChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcJoinChannelData = new GcJoinChannelData(); // GcJoinChannelData |  (optional) 

            try
            {
                // Join a channel
                apiInstance.GcJoinChannel(apiToken, channelUrl, gcJoinChannelData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcJoinChannel: " + e.Message );
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
 **gcJoinChannelData** | [**GcJoinChannelData**](GcJoinChannelData.md)|  | [optional] 

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


## GcLeaveChannel

> InlineResponse2001 GcLeaveChannel (string apiToken, string channelUrl, GcLeaveChannelData gcLeaveChannelData = null)

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
    public class GcLeaveChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcLeaveChannelData = new GcLeaveChannelData(); // GcLeaveChannelData |  (optional) 

            try
            {
                // Leave a channel
                InlineResponse2001 result = apiInstance.GcLeaveChannel(apiToken, channelUrl, gcLeaveChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcLeaveChannel: " + e.Message );
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
 **gcLeaveChannelData** | [**GcLeaveChannelData**](GcLeaveChannelData.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcListChannels

> GcListChannelsResponse GcListChannels (string apiToken, string token = null, int? limit = null, string distinctMode = null, string publicMode = null, string superMode = null, int? createdAfter = null, int? createdBefore = null, bool? showEmpty = null, bool? showMember = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMetadata = null, bool? showFrozen = null, string order = null, string metadataOrderKey = null, string customTypes = null, string customTypeStartswith = null, string channelUrls = null, string name = null, string nameContains = null, string nameStartswith = null, string membersExactlyIn = null, string membersIncludeIn = null, string queryType = null, string membersNickname = null, string membersNicknameContains = null, string metadataKey = null, string metadataValues = null, string metadataValueStartswith = null, string metacounterKey = null, string metacounterValues = null, string metacounterValueGt = null, string metacounterValueGte = null, string metacounterValueLt = null, string metacounterValueLte = null, bool? includeSortedMetaarrayInLastMessage = null, string customType = null, bool? readReceipt = null, bool? member = null, bool? isDistinct = null, string membersIn = null, string userId = null)

List channels

## List channels  Retrieves a list of group channels in the application.  > __Note__: If you want to get a list of a specific user's group channels, use the [list my group channels](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-list-my-group-channels) action instead.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-list-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcListChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var distinctMode = distinctMode_example;  // string |  (optional) 
            var publicMode = publicMode_example;  // string |  (optional) 
            var superMode = superMode_example;  // string |  (optional) 
            var createdAfter = 56;  // int? |  (optional) 
            var createdBefore = 56;  // int? |  (optional) 
            var showEmpty = true;  // bool? |  (optional) 
            var showMember = true;  // bool? |  (optional) 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var showMetadata = true;  // bool? |  (optional) 
            var showFrozen = true;  // bool? |  (optional) 
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
            var metadataKey = metadataKey_example;  // string |  (optional) 
            var metadataValues = metadataValues_example;  // string |  (optional) 
            var metadataValueStartswith = metadataValueStartswith_example;  // string |  (optional) 
            var metacounterKey = metacounterKey_example;  // string |  (optional) 
            var metacounterValues = metacounterValues_example;  // string |  (optional) 
            var metacounterValueGt = metacounterValueGt_example;  // string |  (optional) 
            var metacounterValueGte = metacounterValueGte_example;  // string |  (optional) 
            var metacounterValueLt = metacounterValueLt_example;  // string |  (optional) 
            var metacounterValueLte = metacounterValueLte_example;  // string |  (optional) 
            var includeSortedMetaarrayInLastMessage = true;  // bool? |  (optional) 
            var customType = customType_example;  // string |  (optional) 
            var readReceipt = true;  // bool? |  (optional) 
            var member = true;  // bool? |  (optional) 
            var isDistinct = true;  // bool? |  (optional) 
            var membersIn = membersIn_example;  // string |  (optional) 
            var userId = userId_example;  // string |  (optional) 

            try
            {
                // List channels
                GcListChannelsResponse result = apiInstance.GcListChannels(apiToken, token, limit, distinctMode, publicMode, superMode, createdAfter, createdBefore, showEmpty, showMember, showDeliveryReceipt, showReadReceipt, showMetadata, showFrozen, order, metadataOrderKey, customTypes, customTypeStartswith, channelUrls, name, nameContains, nameStartswith, membersExactlyIn, membersIncludeIn, queryType, membersNickname, membersNicknameContains, metadataKey, metadataValues, metadataValueStartswith, metacounterKey, metacounterValues, metacounterValueGt, metacounterValueGte, metacounterValueLt, metacounterValueLte, includeSortedMetaarrayInLastMessage, customType, readReceipt, member, isDistinct, membersIn, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcListChannels: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **distinctMode** | **string**|  | [optional] 
 **publicMode** | **string**|  | [optional] 
 **superMode** | **string**|  | [optional] 
 **createdAfter** | **int?**|  | [optional] 
 **createdBefore** | **int?**|  | [optional] 
 **showEmpty** | **bool?**|  | [optional] 
 **showMember** | **bool?**|  | [optional] 
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **showMetadata** | **bool?**|  | [optional] 
 **showFrozen** | **bool?**|  | [optional] 
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
 **metadataKey** | **string**|  | [optional] 
 **metadataValues** | **string**|  | [optional] 
 **metadataValueStartswith** | **string**|  | [optional] 
 **metacounterKey** | **string**|  | [optional] 
 **metacounterValues** | **string**|  | [optional] 
 **metacounterValueGt** | **string**|  | [optional] 
 **metacounterValueGte** | **string**|  | [optional] 
 **metacounterValueLt** | **string**|  | [optional] 
 **metacounterValueLte** | **string**|  | [optional] 
 **includeSortedMetaarrayInLastMessage** | **bool?**|  | [optional] 
 **customType** | **string**|  | [optional] 
 **readReceipt** | **bool?**|  | [optional] 
 **member** | **bool?**|  | [optional] 
 **isDistinct** | **bool?**|  | [optional] 
 **membersIn** | **string**|  | [optional] 
 **userId** | **string**|  | [optional] 

### Return type

[**GcListChannelsResponse**](GcListChannelsResponse.md)

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


## GcListMembers

> GcListMembersResponse GcListMembers (string apiToken, string channelUrl, string token = null, int? limit = null, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, string order = null, string operatorFilter = null, string memberStateFilter = null, string mutedMemberFilter = null, string nicknameStartswith = null)

List members

## List members  Retrieves a list of members of a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-list-members - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of members of.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcListMembersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var order = order_example;  // string |  (optional) 
            var operatorFilter = operatorFilter_example;  // string |  (optional) 
            var memberStateFilter = memberStateFilter_example;  // string |  (optional) 
            var mutedMemberFilter = mutedMemberFilter_example;  // string |  (optional) 
            var nicknameStartswith = nicknameStartswith_example;  // string |  (optional) 

            try
            {
                // List members
                GcListMembersResponse result = apiInstance.GcListMembers(apiToken, channelUrl, token, limit, showDeliveryReceipt, showReadReceipt, order, operatorFilter, memberStateFilter, mutedMemberFilter, nicknameStartswith);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcListMembers: " + e.Message );
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
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **order** | **string**|  | [optional] 
 **operatorFilter** | **string**|  | [optional] 
 **memberStateFilter** | **string**|  | [optional] 
 **mutedMemberFilter** | **string**|  | [optional] 
 **nicknameStartswith** | **string**|  | [optional] 

### Return type

[**GcListMembersResponse**](GcListMembersResponse.md)

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


## GcListOperators

> GcListOperatorsResponse GcListOperators (string apiToken, string channelUrl, string token = null, int? limit = null)

List operators

## List operators  Retrieves a list of operators of a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-list-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcListOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List operators
                GcListOperatorsResponse result = apiInstance.GcListOperators(apiToken, channelUrl, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcListOperators: " + e.Message );
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

[**GcListOperatorsResponse**](GcListOperatorsResponse.md)

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


## GcRegisterOperators

> GcRegisterOperatorsResponse GcRegisterOperators (string apiToken, string channelUrl, GcRegisterOperatorsData gcRegisterOperatorsData = null)

Register operators

## Register operators  Registers one or more operators to a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-register-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcRegisterOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcRegisterOperatorsData = new GcRegisterOperatorsData(); // GcRegisterOperatorsData |  (optional) 

            try
            {
                // Register operators
                GcRegisterOperatorsResponse result = apiInstance.GcRegisterOperators(apiToken, channelUrl, gcRegisterOperatorsData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcRegisterOperators: " + e.Message );
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
 **gcRegisterOperatorsData** | [**GcRegisterOperatorsData**](GcRegisterOperatorsData.md)|  | [optional] 

### Return type

[**GcRegisterOperatorsResponse**](GcRegisterOperatorsResponse.md)

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


## GcResetChatHistory

> GcResetChatHistoryResponse GcResetChatHistory (string apiToken, string channelUrl, GcResetChatHistoryData gcResetChatHistoryData = null)

Reset chat history

## Reset chat history  Resets the properties related to a user's chat history in a group channel, then clears the existing messages in the channel on the user's side only. A user can no longer see the messages in a group channel once this action is called, but those messages are not deleted from the database of the Sendbird system. All other members in the channel can retrieve and see the messages.  This action simply clears the messages for the user by updating the `last_message` and `read_receipt` properties of the [channel](#2-types-of-a-channel-3-resource-representation) resource in addition to other internally managed data such as the number of the user's unread message.  Using the `reset_all` property, you can also reset the properties related to all users' chat history in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-reset-chat-history - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcResetChatHistoryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcResetChatHistoryData = new GcResetChatHistoryData(); // GcResetChatHistoryData |  (optional) 

            try
            {
                // Reset chat history
                GcResetChatHistoryResponse result = apiInstance.GcResetChatHistory(apiToken, channelUrl, gcResetChatHistoryData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcResetChatHistory: " + e.Message );
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
 **gcResetChatHistoryData** | [**GcResetChatHistoryData**](GcResetChatHistoryData.md)|  | [optional] 

### Return type

[**GcResetChatHistoryResponse**](GcResetChatHistoryResponse.md)

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


## GcUnhideOrUnarchiveChannel

> InlineResponse2001 GcUnhideOrUnarchiveChannel (string apiToken, string channelUrl, string userId, bool? shouldUnhideAll = null)

Unhide or unarchive a channel

## Unhide or unarchive a channel  Makes a hidden or archived channel reappear in the channel list of either a specific user or entire channel members.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-unhide-or-unarchive-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to unhide or unarchive.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcUnhideOrUnarchiveChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var userId = userId_example;  // string | 
            var shouldUnhideAll = true;  // bool? |  (optional) 

            try
            {
                // Unhide or unarchive a channel
                InlineResponse2001 result = apiInstance.GcUnhideOrUnarchiveChannel(apiToken, channelUrl, userId, shouldUnhideAll);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcUnhideOrUnarchiveChannel: " + e.Message );
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
 **userId** | **string**|  | 
 **shouldUnhideAll** | **bool?**|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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


## GcUpdateChannelByUrl

> SendBirdGroupChannel GcUpdateChannelByUrl (string apiToken, string channelUrl, GcUpdateChannelByUrlData gcUpdateChannelByUrlData = null)

Update a channel

## Update a channel  Updates information on a group channel.  > __Note__: You can't change the members of the channel here. To do so, see [invite as members](#2-invite-as-members) action below.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-update-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcUpdateChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcUpdateChannelByUrlData = new GcUpdateChannelByUrlData(); // GcUpdateChannelByUrlData |  (optional) 

            try
            {
                // Update a channel
                SendBirdGroupChannel result = apiInstance.GcUpdateChannelByUrl(apiToken, channelUrl, gcUpdateChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcUpdateChannelByUrl: " + e.Message );
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
 **gcUpdateChannelByUrlData** | [**GcUpdateChannelByUrlData**](GcUpdateChannelByUrlData.md)|  | [optional] 

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


## GcViewChannelByUrl

> SendBirdGroupChannel GcViewChannelByUrl (string apiToken, string channelUrl, bool? showDeliveryReceipt = null, bool? showReadReceipt = null, bool? showMember = null, bool? readReceipt = null, bool? member = null)

View a channel

## View a channel  Retrieves information on a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-view-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcViewChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new GroupChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var showDeliveryReceipt = true;  // bool? |  (optional) 
            var showReadReceipt = true;  // bool? |  (optional) 
            var showMember = true;  // bool? |  (optional) 
            var readReceipt = true;  // bool? |  (optional) 
            var member = true;  // bool? |  (optional) 

            try
            {
                // View a channel
                SendBirdGroupChannel result = apiInstance.GcViewChannelByUrl(apiToken, channelUrl, showDeliveryReceipt, showReadReceipt, showMember, readReceipt, member);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupChannelApi.GcViewChannelByUrl: " + e.Message );
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
 **showDeliveryReceipt** | **bool?**|  | [optional] 
 **showReadReceipt** | **bool?**|  | [optional] 
 **showMember** | **bool?**|  | [optional] 
 **readReceipt** | **bool?**|  | [optional] 
 **member** | **bool?**|  | [optional] 

### Return type

[**SendBirdGroupChannel**](SendBirdGroupChannel.md)

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

