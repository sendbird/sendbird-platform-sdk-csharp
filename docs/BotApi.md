# sendbird_platform_sdk.Api.BotApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateABot**](BotApi.md#createabot) | **POST** /v3/bots | Create a bot
[**DeleteBotById**](BotApi.md#deletebotbyid) | **DELETE** /v3/bots/{bot_userid} | Delete a bot
[**JoinChannels**](BotApi.md#joinchannels) | **POST** /v3/bots/{bot_userid}/channels | Join channels
[**LeaveAGroupChannel**](BotApi.md#leaveagroupchannel) | **DELETE** /v3/bots/{bot_userid}/channels/{channel_url} | Leave channels - When leaving a specific channel
[**LeaveGroupChannels**](BotApi.md#leavegroupchannels) | **DELETE** /v3/bots/{bot_userid}/channels | Leave channels - When leaving all channels
[**ListBots**](BotApi.md#listbots) | **GET** /v3/bots | List bots
[**SendABotMessage**](BotApi.md#sendabotmessage) | **POST** /v3/bots/{bot_userid}/send | Send a bot&#39;s message
[**UpdateBotById**](BotApi.md#updatebotbyid) | **PUT** /v3/bots/{bot_userid} | Update a bot
[**ViewBotById**](BotApi.md#viewbotbyid) | **GET** /v3/bots/{bot_userid} | View a bot



## CreateABot

> CreateABotResponse CreateABot (string apiToken = null, CreateABotRequest createABotRequest = null)

Create a bot

## Create a bot  Creates a new bot within an application. Creating a bot is similar to creating a normal user, except a callback URL should be specified for a bot to receive events.  > **Note**: The bot must first [join a group channel](https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/join-channels) to interact with users. In group channels, you can also invite a bot through the [invite as members](https://sendbird.com/docs/chat/platform-api/v3/channel/inviting-a-user/invite-as-members-channel) action.      [https://sendbird.com/docs/chat/platform-api/v3/bot/creating-a-bot/create-a-bot#1-create-a-bot](https://sendbird.com/docs/chat/platform-api/v3/bot/creating-a-bot/create-a-bot#1-create-a-bot)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateABotExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var createABotRequest = new CreateABotRequest(); // CreateABotRequest |  (optional) 

            try
            {
                // Create a bot
                CreateABotResponse result = apiInstance.CreateABot(apiToken, createABotRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.CreateABot: " + e.Message );
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
 **createABotRequest** | [**CreateABotRequest**](CreateABotRequest.md)|  | [optional] 

### Return type

[**CreateABotResponse**](CreateABotResponse.md)

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


## DeleteBotById

> Object DeleteBotById (string botUserid, string apiToken = null)

Delete a bot

## Delete a bot  Deletes a bot from an application.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-delete-a-bot - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteBotByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a bot
                Object result = apiInstance.DeleteBotById(botUserid, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.DeleteBotById: " + e.Message );
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
 **botUserid** | **string**|  | 
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


## JoinChannels

> SendbirdGroupChannelDetail JoinChannels (string botUserid, string apiToken = null, JoinChannelsRequest joinChannelsRequest = null)

Join channels

## Join channels  Makes a bot join one or more group channels.  [https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/join-channels#1-join-channels](https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/join-channels#1-join-channels)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class JoinChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var joinChannelsRequest = new JoinChannelsRequest(); // JoinChannelsRequest |  (optional) 

            try
            {
                // Join channels
                SendbirdGroupChannelDetail result = apiInstance.JoinChannels(botUserid, apiToken, joinChannelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.JoinChannels: " + e.Message );
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
 **botUserid** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **joinChannelsRequest** | [**JoinChannelsRequest**](JoinChannelsRequest.md)|  | [optional] 

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


## LeaveAGroupChannel

> Object LeaveAGroupChannel (string channelUrl, string botUserid, string apiToken = null)

Leave channels - When leaving a specific channel

## Leave channels  Makes a bot leave a specific channel  [https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/leave-channels#1-leave-channels](https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/leave-channels#1-leave-channels)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveAGroupChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | 
            var botUserid = "botUserid_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Leave channels - When leaving a specific channel
                Object result = apiInstance.LeaveAGroupChannel(channelUrl, botUserid, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.LeaveAGroupChannel: " + e.Message );
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
 **botUserid** | **string**| (Required)  | 
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


## LeaveGroupChannels

> Object LeaveGroupChannels (string botUserid, string apiToken = null)

Leave channels - When leaving all channels

## Leave channels  Makes a bot leave all group channels.  [https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/leave-channels#1-leave-channels](https://sendbird.com/docs/chat/platform-api/v3/bot/managing-a-bot/leave-channels#1-leave-channels)

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveGroupChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Leave channels - When leaving all channels
                Object result = apiInstance.LeaveGroupChannels(botUserid, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.LeaveGroupChannels: " + e.Message );
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
 **botUserid** | **string**| (Required)  | 
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


## ListBots

> ListBotsResponse ListBots (string token = null, int? limit = null, string apiToken = null)

List bots

## List bots  Retrieves a list of all bots within an application.  https://sendbird.com/docs/chat/platform-api/v3/bot/listing-bots/list-bots#1-list-bots

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListBotsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List bots
                ListBotsResponse result = apiInstance.ListBots(token, limit, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.ListBots: " + e.Message );
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
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListBotsResponse**](ListBotsResponse.md)

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


## SendABotMessage

> SendABotMessageResponse SendABotMessage (string botUserid, string messageType, string channelUrl, string apiToken = null, string message = null, List<string> mentioned = null, SendbirdExtendedMessagePayload extendedMessagePayload = null, System.IO.Stream file = null, bool? requireAuth = null, string mentionType = null, List<string> mentionedUserIds = null, bool? isSilent = null, List<SendbirdSortedMetaarrayInner> sortedMetaarray = null, string apnsBundleId = null, Object appleCriticalAlertOptions = null, string sound = null, decimal? volume = null, long? createdAt = null, string customType = null, string data = null, string dedupId = null, bool? markAsRead = null, bool? sendPush = null)

Send a bot's message

## Send a bot message  Sends a bot message to a group channel.  [https://sendbird.com/docs/chat/platform-api/v3/bot/sending-a-bot-message/send-a-bot-message#1-send-a-bot-message](https://sendbird.com/docs/chat/platform-api/v3/bot/sending-a-bot-message/send-a-bot-message#1-send-a-bot-message)  `bot_userid`   Type: string   Description: Specifies the ID of the bot to send a message.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class SendABotMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | (Required) 
            var messageType = "MESG";  // string | Specifies the type of message to send. MESG for text message, FILE for file message.
            var channelUrl = "channelUrl_example";  // string | Specifies the URL of the channel to send the message to.
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var message = "message_example";  // string | Specifies the content of the message. * This property is required when message_type is MESG. (optional) 
            var mentioned = new List<string>(); // List<string> | * This property is available when message_type is MESG. (optional) 
            var extendedMessagePayload = new SendbirdExtendedMessagePayload(); // SendbirdExtendedMessagePayload |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | When sending a single file with a message, specifies the data of the file to upload to the Sendbird server in raw binary format. When sending a request containing a file, change the value of the content-type header to multipart/form-data;boundary={your_unique_boundary_string} in the request. * This property is required when message_type is FILE. * This doesn't allow a converted base64-encoded string from a file as its value. (optional) 
            var requireAuth = true;  // bool? | Determines whether to require an authentication key to verify if the file is being properly accessed. Only the user who uploaded the file or users who are in the channel where the file was uploaded should have access. The authentication key managed internally by the Sendbird system is generated every time a user logs in to the Sendbird server and is valid for three days starting from the last login. If set to false, Sendbird tries to access a file without any key. To access encrypted files, such as the files in the Sendbird server which are by default encrypted, the property must be set to true. (Default: false) The require_auth parameter only works if the file or URL is managed by Sendbird, which means that when you upload files using multipart format or provide URLs that point to the files hosted on the Sendbird server. However, if the file is hosted on a server or service that is not managed by Sendbird, access control and authentication for the file should be handled by the respective server or service hosting the file. * This property is available when message_type is FILE. (optional) 
            var mentionType = "users";  // string | * This property is available when message_type is FILE. (optional) 
            var mentionedUserIds = new List<string>(); // List<string> | * This property is available when message_type is FILE. (optional) 
            var isSilent = true;  // bool? | * This property is available when message_type is FILE. (optional) 
            var sortedMetaarray = new List<SendbirdSortedMetaarrayInner>(); // List<SendbirdSortedMetaarrayInner> |  (optional) 
            var apnsBundleId = "apnsBundleId_example";  // string | * This property is available when message_type is FILE. (optional) 
            var appleCriticalAlertOptions = new Object(); // Object | * This property is available when message_type is FILE. (optional) 
            var sound = "sound_example";  // string | * This property is available when message_type is FILE. (optional) 
            var volume = 8.14D;  // decimal? | * This property is available when message_type is FILE. (optional) 
            var createdAt = 789L;  // long? |  (optional) 
            var customType = "customType_example";  // string |  (optional) 
            var data = "data_example";  // string |  (optional) 
            var dedupId = "dedupId_example";  // string |  (optional) 
            var markAsRead = true;  // bool? |  (optional) 
            var sendPush = true;  // bool? |  (optional) 

            try
            {
                // Send a bot's message
                SendABotMessageResponse result = apiInstance.SendABotMessage(botUserid, messageType, channelUrl, apiToken, message, mentioned, extendedMessagePayload, file, requireAuth, mentionType, mentionedUserIds, isSilent, sortedMetaarray, apnsBundleId, appleCriticalAlertOptions, sound, volume, createdAt, customType, data, dedupId, markAsRead, sendPush);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.SendABotMessage: " + e.Message );
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
 **botUserid** | **string**| (Required)  | 
 **messageType** | **string**| Specifies the type of message to send. MESG for text message, FILE for file message. | 
 **channelUrl** | **string**| Specifies the URL of the channel to send the message to. | 
 **apiToken** | **string**|  | [optional] 
 **message** | **string**| Specifies the content of the message. * This property is required when message_type is MESG. | [optional] 
 **mentioned** | [**List&lt;string&gt;**](string.md)| * This property is available when message_type is MESG. | [optional] 
 **extendedMessagePayload** | [**SendbirdExtendedMessagePayload**](SendbirdExtendedMessagePayload.md)|  | [optional] 
 **file** | **System.IO.Stream**| When sending a single file with a message, specifies the data of the file to upload to the Sendbird server in raw binary format. When sending a request containing a file, change the value of the content-type header to multipart/form-data;boundary&#x3D;{your_unique_boundary_string} in the request. * This property is required when message_type is FILE. * This doesn&#39;t allow a converted base64-encoded string from a file as its value. | [optional] 
 **requireAuth** | **bool?**| Determines whether to require an authentication key to verify if the file is being properly accessed. Only the user who uploaded the file or users who are in the channel where the file was uploaded should have access. The authentication key managed internally by the Sendbird system is generated every time a user logs in to the Sendbird server and is valid for three days starting from the last login. If set to false, Sendbird tries to access a file without any key. To access encrypted files, such as the files in the Sendbird server which are by default encrypted, the property must be set to true. (Default: false) The require_auth parameter only works if the file or URL is managed by Sendbird, which means that when you upload files using multipart format or provide URLs that point to the files hosted on the Sendbird server. However, if the file is hosted on a server or service that is not managed by Sendbird, access control and authentication for the file should be handled by the respective server or service hosting the file. * This property is available when message_type is FILE. | [optional] 
 **mentionType** | **string**| * This property is available when message_type is FILE. | [optional] 
 **mentionedUserIds** | [**List&lt;string&gt;**](string.md)| * This property is available when message_type is FILE. | [optional] 
 **isSilent** | **bool?**| * This property is available when message_type is FILE. | [optional] 
 **sortedMetaarray** | [**List&lt;SendbirdSortedMetaarrayInner&gt;**](SendbirdSortedMetaarrayInner.md)|  | [optional] 
 **apnsBundleId** | **string**| * This property is available when message_type is FILE. | [optional] 
 **appleCriticalAlertOptions** | [**Object**](Object.md)| * This property is available when message_type is FILE. | [optional] 
 **sound** | **string**| * This property is available when message_type is FILE. | [optional] 
 **volume** | **decimal?**| * This property is available when message_type is FILE. | [optional] 
 **createdAt** | **long?**|  | [optional] 
 **customType** | **string**|  | [optional] 
 **data** | **string**|  | [optional] 
 **dedupId** | **string**|  | [optional] 
 **markAsRead** | **bool?**|  | [optional] 
 **sendPush** | **bool?**|  | [optional] 

### Return type

[**SendABotMessageResponse**](SendABotMessageResponse.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpdateBotById

> UpdateBotByIdResponse UpdateBotById (string botUserid, string apiToken = null, UpdateBotByIdData updateBotByIdData = null)

Update a bot

## Update a bot  Updates information on a bot.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-update-a-bot - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateBotByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateBotByIdData = new UpdateBotByIdData(); // UpdateBotByIdData |  (optional) 

            try
            {
                // Update a bot
                UpdateBotByIdResponse result = apiInstance.UpdateBotById(botUserid, apiToken, updateBotByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.UpdateBotById: " + e.Message );
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
 **botUserid** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateBotByIdData** | [**UpdateBotByIdData**](UpdateBotByIdData.md)|  | [optional] 

### Return type

[**UpdateBotByIdResponse**](UpdateBotByIdResponse.md)

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


## ViewBotById

> ViewBotByIdResponse ViewBotById (string botUserid, string apiToken = null)

View a bot

## View a bot  Retrieves information on a bot.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-view-a-bot - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewBotByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var botUserid = "botUserid_example";  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a bot
                ViewBotByIdResponse result = apiInstance.ViewBotById(botUserid, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.ViewBotById: " + e.Message );
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
 **botUserid** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ViewBotByIdResponse**](ViewBotByIdResponse.md)

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

