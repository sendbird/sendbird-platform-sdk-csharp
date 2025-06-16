# sendbird_platform_sdk.Api.BotApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateABot**](BotApi.md#createabot) | **POST** /v3/bots | Create a bot
[**JoinChannels**](BotApi.md#joinchannels) | **POST** /v3/bots/{bot_userid}/channels | Join channels
[**LeaveAGroupChannel**](BotApi.md#leaveagroupchannel) | **DELETE** /v3/bots/{bot_userid}/channels/{channel_url} | Leave channels - When leaving a specific channel
[**LeaveGroupChannels**](BotApi.md#leavegroupchannels) | **DELETE** /v3/bots/{bot_userid}/channels | Leave channels - When leaving all channels
[**ListBots**](BotApi.md#listbots) | **GET** /v3/bots | List bots
[**SendABotMessage**](BotApi.md#sendabotmessage) | **POST** /v3/bots/{bot_userid}/send | Send a bot&#39;s message



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

> SendbirdMessageResponse SendABotMessage (string botUserid, string apiToken = null, SendABotMessageRequest sendABotMessageRequest = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var sendABotMessageRequest = new SendABotMessageRequest(); // SendABotMessageRequest |  (optional) 

            try
            {
                // Send a bot's message
                SendbirdMessageResponse result = apiInstance.SendABotMessage(botUserid, apiToken, sendABotMessageRequest);
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
 **apiToken** | **string**|  | [optional] 
 **sendABotMessageRequest** | [**SendABotMessageRequest**](SendABotMessageRequest.md)|  | [optional] 

### Return type

[**SendbirdMessageResponse**](SendbirdMessageResponse.md)

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

