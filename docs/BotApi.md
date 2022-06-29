# sendbird_platform_sdk.Api.BotApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBot**](BotApi.md#createbot) | **POST** /v3/bots | Create a bot
[**DeleteBotById**](BotApi.md#deletebotbyid) | **DELETE** /v3/bots/{bot_userid} | Delete a bot
[**JoinChannels**](BotApi.md#joinchannels) | **POST** /v3/bots/{bot_userid}/channels | Join channels
[**LeaveChannels**](BotApi.md#leavechannels) | **DELETE** /v3/bots/{bot_userid}/channels | Leave channels - When leaving all channels
[**LeaveChannelsByUrl**](BotApi.md#leavechannelsbyurl) | **DELETE** /v3/bots/{bot_userid}/channels/{channel_url} | Leave channels - When leaving a channel by its channel URL
[**ListBots**](BotApi.md#listbots) | **GET** /v3/bots | List bots
[**SendBotsMessage**](BotApi.md#sendbotsmessage) | **POST** /v3/bots/{bot_userid}/send | Send a bot&#39;s message
[**UpdateBotById**](BotApi.md#updatebotbyid) | **PUT** /v3/bots/{bot_userid} | Update a bot
[**ViewBotById**](BotApi.md#viewbotbyid) | **GET** /v3/bots/{bot_userid} | View a bot



## CreateBot

> CreateBotResponse CreateBot (string apiToken, CreateBotData createBotData = null)

Create a bot

## Create a bot  Creates a new bot within the application. Creating a bot is similar to creating a normal user, except that a callback URL is specified in order for the bot to receive events.  > __Note__: The bot must [join](#2-join-channels) a group channel first to interact with users. In group channels, you can invite a bot through the [invite as members](https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-invite-as-members) action instead.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-create-a-bot

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CreateBotExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var createBotData = new CreateBotData(); // CreateBotData |  (optional) 

            try
            {
                // Create a bot
                CreateBotResponse result = apiInstance.CreateBot(apiToken, createBotData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.CreateBot: " + e.Message );
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
 **createBotData** | [**CreateBotData**](CreateBotData.md)|  | [optional] 

### Return type

[**CreateBotResponse**](CreateBotResponse.md)

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

> Object DeleteBotById (string apiToken, string botUserid)

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
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 

            try
            {
                // Delete a bot
                Object result = apiInstance.DeleteBotById(apiToken, botUserid);
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
 **apiToken** | **string**|  | 
 **botUserid** | **string**|  | 

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

> JoinChannelsResponse JoinChannels (string apiToken, string botUserid, JoinChannelsData joinChannelsData = null)

Join channels

## Join channels  Makes a bot join one or more channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-join-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

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
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 
            var joinChannelsData = new JoinChannelsData(); // JoinChannelsData |  (optional) 

            try
            {
                // Join channels
                JoinChannelsResponse result = apiInstance.JoinChannels(apiToken, botUserid, joinChannelsData);
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
 **apiToken** | **string**|  | 
 **botUserid** | **string**|  | 
 **joinChannelsData** | [**JoinChannelsData**](JoinChannelsData.md)|  | [optional] 

### Return type

[**JoinChannelsResponse**](JoinChannelsResponse.md)

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


## LeaveChannels

> void LeaveChannels (string apiToken, string botUserid, string channelUrl = null)

Leave channels - When leaving all channels

## Leave channels  Makes a bot leave one or more group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-leave-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 
            var channelUrl = channelUrl_example;  // string |  (optional) 

            try
            {
                // Leave channels - When leaving all channels
                apiInstance.LeaveChannels(apiToken, botUserid, channelUrl);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.LeaveChannels: " + e.Message );
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
 **botUserid** | **string**|  | 
 **channelUrl** | **string**|  | [optional] 

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


## LeaveChannelsByUrl

> Object LeaveChannelsByUrl (string apiToken, string botUserid, string channelUrl)

Leave channels - When leaving a channel by its channel URL

## Leave channels  Makes a bot leave one or more group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-leave-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class LeaveChannelsByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 

            try
            {
                // Leave channels - When leaving a channel by its channel URL
                Object result = apiInstance.LeaveChannelsByUrl(apiToken, botUserid, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.LeaveChannelsByUrl: " + e.Message );
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
 **botUserid** | **string**|  | 
 **channelUrl** | **string**|  | 

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

> ListBotsResponse ListBots (string apiToken, string token = null, int? limit = null)

List bots

## List bots  Retrieves a list of all bots within an application.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-list-bots - -- -- -- -- -- -- -- -- -- -- -- -- -- -

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
            var apiToken = {{API_TOKEN}};  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List bots
                ListBotsResponse result = apiInstance.ListBots(apiToken, token, limit);
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
 **apiToken** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

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


## SendBotsMessage

> SendBirdMessageResponse SendBotsMessage (string apiToken, string botUserid, SendBotSMessageData sendBotSMessageData = null)

Send a bot's message

## Send a bot's message  Sends a bot's message to a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/bot-interface#2-send-a-bot-s-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `bot_userid`      Type: string      Description: Specifies the ID of the bot to send a message.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class SendBotsMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new BotApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 
            var sendBotSMessageData = new SendBotSMessageData(); // SendBotSMessageData |  (optional) 

            try
            {
                // Send a bot's message
                SendBirdMessageResponse result = apiInstance.SendBotsMessage(apiToken, botUserid, sendBotSMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BotApi.SendBotsMessage: " + e.Message );
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
 **botUserid** | **string**|  | 
 **sendBotSMessageData** | [**SendBotSMessageData**](SendBotSMessageData.md)|  | [optional] 

### Return type

[**SendBirdMessageResponse**](SendBirdMessageResponse.md)

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


## UpdateBotById

> UpdateBotByIdResponse UpdateBotById (string apiToken, string botUserid, UpdateBotByIdData updateBotByIdData = null)

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
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 
            var updateBotByIdData = new UpdateBotByIdData(); // UpdateBotByIdData |  (optional) 

            try
            {
                // Update a bot
                UpdateBotByIdResponse result = apiInstance.UpdateBotById(apiToken, botUserid, updateBotByIdData);
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
 **apiToken** | **string**|  | 
 **botUserid** | **string**|  | 
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

> ViewBotByIdResponse ViewBotById (string apiToken, string botUserid)

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
            var apiToken = {{API_TOKEN}};  // string | 
            var botUserid = botUserid_example;  // string | 

            try
            {
                // View a bot
                ViewBotByIdResponse result = apiInstance.ViewBotById(apiToken, botUserid);
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
 **apiToken** | **string**|  | 
 **botUserid** | **string**|  | 

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

