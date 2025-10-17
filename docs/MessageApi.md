# sendbird_platform_sdk.Api.MessageApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExtraDataToAMessage**](MessageApi.md#addextradatatoamessage) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Add extra data to a message
[**DeleteAMessage**](MessageApi.md#deleteamessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id} | Delete a message
[**GetAMessage**](MessageApi.md#getamessage) | **GET** /v3/{channel_type}/{channel_url}/messages/{message_id} | Get a message
[**GetTotalNumberOfMessagesInAChannel**](MessageApi.md#gettotalnumberofmessagesinachannel) | **GET** /v3/{channel_type}/{channel_url}/messages/total_count | Get total number of messages in a channel
[**ListMessages**](MessageApi.md#listmessages) | **GET** /v3/{channel_type}/{channel_url}/messages | List messages
[**MarkChannelMessagesAsRead**](MessageApi.md#markchannelmessagesasread) | **PUT** /v3/group_channels/{channel_url}/messages/mark_as_read | Mark all messages as read
[**MigrateMessages**](MessageApi.md#migratemessages) | **POST** /v3/migration/{target_channel_url} | Migrate messages
[**RemoveExtraDataFromAMessage**](MessageApi.md#removeextradatafromamessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Remove extra data from a message
[**SendAMessage**](MessageApi.md#sendamessage) | **POST** /v3/{channel_type}/{channel_url}/messages | Send a message
[**UpdateAMessage**](MessageApi.md#updateamessage) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id} | Update a message
[**UpdateExtraDataInAMessage**](MessageApi.md#updateextradatainamessage) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Update extra data in a message



## AddExtraDataToAMessage

> AddExtraDataToAMessageResponse AddExtraDataToAMessage (string channelType, string channelUrl, long messageId, string apiToken = null, AddExtraDataToAMessageRequest addExtraDataToAMessageRequest = null)

Add extra data to a message

## Add extra data to a message  Adds one or more key-values items which store additional information for a message.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/message-add-metadata#1-add-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddExtraDataToAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addExtraDataToAMessageRequest = new AddExtraDataToAMessageRequest(); // AddExtraDataToAMessageRequest |  (optional) 

            try
            {
                // Add extra data to a message
                AddExtraDataToAMessageResponse result = apiInstance.AddExtraDataToAMessage(channelType, channelUrl, messageId, apiToken, addExtraDataToAMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.AddExtraDataToAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **addExtraDataToAMessageRequest** | [**AddExtraDataToAMessageRequest**](AddExtraDataToAMessageRequest.md)|  | [optional] 

### Return type

[**AddExtraDataToAMessageResponse**](AddExtraDataToAMessageResponse.md)

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


## DeleteAMessage

> Object DeleteAMessage (string channelType, string channelUrl, long messageId, string apiToken = null)

Delete a message

## Delete a message  Deletes a message from a channel.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/delete-a-message#1-delete-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a message
                Object result = apiInstance.DeleteAMessage(channelType, channelUrl, messageId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.DeleteAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
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


## GetAMessage

> SendbirdMessageResponse GetAMessage (string channelType, string channelUrl, long messageId, bool? includeReactions = null, bool? includeThreadInfo = null, bool? includeParentMessageInfo = null, bool? includePollDetails = null, bool? withSortedMetaArray = null, string apiToken = null)

Get a message

## Get a message  Retrieves information on a specific message.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/get-a-message#1-get-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.  `message_id`      Type: long      Description: Specifies the unique ID of the message to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var includeReactions = true;  // bool? |  (optional) 
            var includeThreadInfo = true;  // bool? |  (optional) 
            var includeParentMessageInfo = true;  // bool? |  (optional) 
            var includePollDetails = true;  // bool? | Determines whether to include all properties of a poll resource with a full list of options in the results. If set to false, a selection of poll resource properties consisting of id, title, close_at, created_at, updated_at, status, and message_id are returned. (Default: false) * To use this property, the polls feature should be turned on in Settings > Chat > Features on Sendbird Dashboard. (optional) 
            var withSortedMetaArray = true;  // bool? |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get a message
                SendbirdMessageResponse result = apiInstance.GetAMessage(channelType, channelUrl, messageId, includeReactions, includeThreadInfo, includeParentMessageInfo, includePollDetails, withSortedMetaArray, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GetAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
 **includeReactions** | **bool?**|  | [optional] 
 **includeThreadInfo** | **bool?**|  | [optional] 
 **includeParentMessageInfo** | **bool?**|  | [optional] 
 **includePollDetails** | **bool?**| Determines whether to include all properties of a poll resource with a full list of options in the results. If set to false, a selection of poll resource properties consisting of id, title, close_at, created_at, updated_at, status, and message_id are returned. (Default: false) * To use this property, the polls feature should be turned on in Settings &gt; Chat &gt; Features on Sendbird Dashboard. | [optional] 
 **withSortedMetaArray** | **bool?**|  | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**SendbirdMessageResponse**](SendbirdMessageResponse.md)

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


## GetTotalNumberOfMessagesInAChannel

> GetTotalNumberOfMessagesInAChannelResponse GetTotalNumberOfMessagesInAChannel (string channelType, string channelUrl, string apiToken = null)

Get total number of messages in a channel

## Get total number of messages in a channel  Retrieves the total number of messages in a specific channel.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/get-total-number-of-messages-in-a-channel#1-get-total-number-of-messages-in-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetTotalNumberOfMessagesInAChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Get total number of messages in a channel
                GetTotalNumberOfMessagesInAChannelResponse result = apiInstance.GetTotalNumberOfMessagesInAChannel(channelType, channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GetTotalNumberOfMessagesInAChannel: " + e.Message );
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

### Return type

[**GetTotalNumberOfMessagesInAChannelResponse**](GetTotalNumberOfMessagesInAChannelResponse.md)

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


## ListMessages

> ListMessagesResponse ListMessages (string channelType, string channelUrl, long messageTs, long messageId, int? prevLimit = null, int? nextLimit = null, bool? include = null, bool? reverse = null, string senderId = null, string senderIds = null, string operatorFilter = null, string customTypes = null, string messageType = null, bool? includingRemoved = null, bool? includeReactions = null, string includeReplyType = null, bool? includeParentMessageInfo = null, bool? includeThreadInfo = null, bool? includePollDetails = null, bool? withSortedMetaArray = null, bool? showSubchannelMessagesOnly = null, string userId = null, string apiToken = null)

List messages

## List messages  You can retrieve a list of past messages of a specific channel with this API.  By default, this action returns a list of messages in the order they were created. Replies in threaded messages are also listed in the chronological order of their creation like other messages, not grouped with their parent messages.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/list-messages#1-list-messages  `channel_type`   Type: string   Description: Specifies the type of the channel. Either open_channels or group_channels.   `channel_url`   Type: string   Description: Specifies the URL of the channel to retrieve a list of past messages.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageTs = 789L;  // long | Specifies the timestamp to be the reference point of the query in Unix milliseconds. Either this or the message_id parameter below should be specified in your query URL to retrieve a list. It fetches messages that were sent prior to and after the specified message_ts and the default value for both prev_limit and next_limit is 15.
            var messageId = 789L;  // long | Specifies the unique ID of the message to be the reference point of the query. Either this or the message_ts parameter above should be specified in your query URL to retrieve a list. It fetches messages that were sent prior to and after the specified message_id and the default value for both prev_limit and next_limit is 15.
            var prevLimit = 56;  // int? | Specifies the number of previously sent messages to retrieve before message_ts. For example, if message_ts=1484202848298, then prev_limit=50 returns 50 messages sent by 1484202848297 (message_ts - 1). Acceptable values range from 0 to 200. (Default: 15) (optional) 
            var nextLimit = 56;  // int? | Specifies the number of sent messages to retrieve after message_ts. For example, if message_ts=1484202848298, then next_limit=50 returns 50 messages sent from 1484202848299 (message_ts + 1). Acceptable values range from 0 to 200. (Default: 15) (optional) 
            var include = true;  // bool? | Determines whether to include messages sent exactly on the specified message_ts in the results. (Default: true) (optional) 
            var reverse = true;  // bool? | Determines whether to sort the results in reverse chronological order. If set to true, messages appear in reverse chronological order where the newest comes first and the oldest last. (Default: false) (optional) 
            var senderId = "senderId_example";  // string | Restricts the search scope to only retrieve messages sent by the user with the specified ID. (optional) 
            var senderIds = "senderIds_example";  // string | Restricts the search scope to only retrieve messages sent by one or more users with the specified IDs listed in a comma-separated string. (optional) 
            var operatorFilter = "all";  // string |  (optional) 
            var customTypes = "customTypes_example";  // string | Specifies a comma-separated string of one or more custom message types to retrieve. The value set to this parameter can serve as a filter as follows: - A string of specific custom types: Messages with the corresponding custom types are returned. - Empty like &custom_types=&...: Messages whose custom_type property is empty or has a value of null are returned. - An asterisk (\\*) (default): All messages are returned regardless of their custom_type. (optional) 
            var messageType = "MESG";  // string |  (optional) 
            var includingRemoved = true;  // bool? |  (optional) 
            var includeReactions = true;  // bool? |  (optional) 
            var includeReplyType = "NONE";  // string | One of following values: NONE, ALL, ONLY_REPLY_TO_CHANNEL (optional) 
            var includeParentMessageInfo = true;  // bool? |  (optional) 
            var includeThreadInfo = true;  // bool? |  (optional) 
            var includePollDetails = true;  // bool? | Determines whether to include all properties of a poll resource with a full list of options in the results. If set to false, a selection of poll resource properties consisting of id, title, close_at, created_at, updated_at, status, and message_id are returned. (Default: false) * To use this property, the polls feature should be turned on in Settings > Chat > Features on Sendbird Dashboard. (optional) 
            var withSortedMetaArray = true;  // bool? | Determines whether to include the sorted_metaarray property in the response. (Default: false) (optional) 
            var showSubchannelMessagesOnly = true;  // bool? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List messages
                ListMessagesResponse result = apiInstance.ListMessages(channelType, channelUrl, messageTs, messageId, prevLimit, nextLimit, include, reverse, senderId, senderIds, operatorFilter, customTypes, messageType, includingRemoved, includeReactions, includeReplyType, includeParentMessageInfo, includeThreadInfo, includePollDetails, withSortedMetaArray, showSubchannelMessagesOnly, userId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ListMessages: " + e.Message );
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
 **messageTs** | **long**| Specifies the timestamp to be the reference point of the query in Unix milliseconds. Either this or the message_id parameter below should be specified in your query URL to retrieve a list. It fetches messages that were sent prior to and after the specified message_ts and the default value for both prev_limit and next_limit is 15. | 
 **messageId** | **long**| Specifies the unique ID of the message to be the reference point of the query. Either this or the message_ts parameter above should be specified in your query URL to retrieve a list. It fetches messages that were sent prior to and after the specified message_id and the default value for both prev_limit and next_limit is 15. | 
 **prevLimit** | **int?**| Specifies the number of previously sent messages to retrieve before message_ts. For example, if message_ts&#x3D;1484202848298, then prev_limit&#x3D;50 returns 50 messages sent by 1484202848297 (message_ts - 1). Acceptable values range from 0 to 200. (Default: 15) | [optional] 
 **nextLimit** | **int?**| Specifies the number of sent messages to retrieve after message_ts. For example, if message_ts&#x3D;1484202848298, then next_limit&#x3D;50 returns 50 messages sent from 1484202848299 (message_ts + 1). Acceptable values range from 0 to 200. (Default: 15) | [optional] 
 **include** | **bool?**| Determines whether to include messages sent exactly on the specified message_ts in the results. (Default: true) | [optional] 
 **reverse** | **bool?**| Determines whether to sort the results in reverse chronological order. If set to true, messages appear in reverse chronological order where the newest comes first and the oldest last. (Default: false) | [optional] 
 **senderId** | **string**| Restricts the search scope to only retrieve messages sent by the user with the specified ID. | [optional] 
 **senderIds** | **string**| Restricts the search scope to only retrieve messages sent by one or more users with the specified IDs listed in a comma-separated string. | [optional] 
 **operatorFilter** | **string**|  | [optional] 
 **customTypes** | **string**| Specifies a comma-separated string of one or more custom message types to retrieve. The value set to this parameter can serve as a filter as follows: - A string of specific custom types: Messages with the corresponding custom types are returned. - Empty like &amp;custom_types&#x3D;&amp;...: Messages whose custom_type property is empty or has a value of null are returned. - An asterisk (\\*) (default): All messages are returned regardless of their custom_type. | [optional] 
 **messageType** | **string**|  | [optional] 
 **includingRemoved** | **bool?**|  | [optional] 
 **includeReactions** | **bool?**|  | [optional] 
 **includeReplyType** | **string**| One of following values: NONE, ALL, ONLY_REPLY_TO_CHANNEL | [optional] 
 **includeParentMessageInfo** | **bool?**|  | [optional] 
 **includeThreadInfo** | **bool?**|  | [optional] 
 **includePollDetails** | **bool?**| Determines whether to include all properties of a poll resource with a full list of options in the results. If set to false, a selection of poll resource properties consisting of id, title, close_at, created_at, updated_at, status, and message_id are returned. (Default: false) * To use this property, the polls feature should be turned on in Settings &gt; Chat &gt; Features on Sendbird Dashboard. | [optional] 
 **withSortedMetaArray** | **bool?**| Determines whether to include the sorted_metaarray property in the response. (Default: false) | [optional] 
 **showSubchannelMessagesOnly** | **bool?**|  | [optional] 
 **userId** | **string**|  | [optional] 
 **apiToken** | **string**|  | [optional] 

### Return type

[**ListMessagesResponse**](ListMessagesResponse.md)

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


## MarkChannelMessagesAsRead

> Object MarkChannelMessagesAsRead (string channelUrl, string apiToken = null, MarkChannelMessagesAsReadRequest markChannelMessagesAsReadRequest = null)

Mark all messages as read

## Mark all messages as read  Marks all messages in a group channel as read for a specific user. This action is only applicable for users in a group channel.  https://sendbird.com/docs/chat/platform-api/v3/message/read-receipts/mark-all-messages-as-read-message#1-mark-all-messages-as-read

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MarkChannelMessagesAsReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var markChannelMessagesAsReadRequest = new MarkChannelMessagesAsReadRequest(); // MarkChannelMessagesAsReadRequest |  (optional) 

            try
            {
                // Mark all messages as read
                Object result = apiInstance.MarkChannelMessagesAsRead(channelUrl, apiToken, markChannelMessagesAsReadRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.MarkChannelMessagesAsRead: " + e.Message );
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
 **markChannelMessagesAsReadRequest** | [**MarkChannelMessagesAsReadRequest**](MarkChannelMessagesAsReadRequest.md)|  | [optional] 

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


## MigrateMessages

> Object MigrateMessages (string targetChannelUrl, string apiToken = null, MigrateMessagesRequest migrateMessagesRequest = null)

Migrate messages

## Migrate messages  Using our migration API, you can migrate the messages from another system into a Sendbird system's [channel](https://sendbird.com/docs/chat/v3/platform-api/guides/channel-types) which consists of users, messages, and other chat-related data.  > To turn on this feature, [contact our support team](https://dashboard.sendbird.com/settings/contact_us).      There are three things to do in advance before the migration. Follow the instructions below:  1. Register the users of your current chat solution to your Sendbird application. You can migrate the users into the Sendbird system using the [user creation API](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-create-a-user).      2. Create either an [open](https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel) or a [group](https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-create-a-channel) channel to migrate the messages of your chat solution. The Sendbird system doesn't create a channel for your migration automatically.      3. The maximum number of migrated messages per call is 100. To avoid the failure during your migration, you must adjust the number of messages to process at once via the API.       https://sendbird.com/docs/chat/platform-api/v3/message/migration/migrate-messages#1-migrate-messages

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MigrateMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var targetChannelUrl = "targetChannelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var migrateMessagesRequest = new MigrateMessagesRequest(); // MigrateMessagesRequest |  (optional) 

            try
            {
                // Migrate messages
                Object result = apiInstance.MigrateMessages(targetChannelUrl, apiToken, migrateMessagesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.MigrateMessages: " + e.Message );
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
 **targetChannelUrl** | **string**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **migrateMessagesRequest** | [**MigrateMessagesRequest**](MigrateMessagesRequest.md)|  | [optional] 

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


## RemoveExtraDataFromAMessage

> Object RemoveExtraDataFromAMessage (string channelType, string channelUrl, long messageId, string keys = null, string apiToken = null)

Remove extra data from a message

## Remove extra data from a message  Removes specific items from a message by their keys.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/message-remove-metadata#1-remove-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveExtraDataFromAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var keys = "keys_example";  // string |  (optional) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove extra data from a message
                Object result = apiInstance.RemoveExtraDataFromAMessage(channelType, channelUrl, messageId, keys, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.RemoveExtraDataFromAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
 **keys** | **string**|  | [optional] 
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


## SendAMessage

> SendbirdMessageResponse SendAMessage (string channelType, string channelUrl, string apiToken = null, SendAMessageRequest sendAMessageRequest = null)

Send a message

## Send a message  You can use this action to send a text message, a file message, or an admin message to a specific channel. Sendbird Chat SDKs and the platform API allows you to upload any type of files in messages to the Sendbird server. See [Message Overview](https://sendbird.com/docs/chat/platform-api/v3/message/message-overview) for more information on each message type. Messages are sent between client devices running the Sendbird Chat SDK or UIKit as well as programmatically from businesses to their customers. For instance, a delivery app can automatically send a message like \"Arriving in one minute!\" on behalf of a delivery driver.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/send-a-message#1-send-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class SendAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var sendAMessageRequest = new SendAMessageRequest(); // SendAMessageRequest |  (optional) 

            try
            {
                // Send a message
                SendbirdMessageResponse result = apiInstance.SendAMessage(channelType, channelUrl, apiToken, sendAMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.SendAMessage: " + e.Message );
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
 **sendAMessageRequest** | [**SendAMessageRequest**](SendAMessageRequest.md)|  | [optional] 

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


## UpdateAMessage

> SendbirdMessageResponse UpdateAMessage (string channelType, string channelUrl, long messageId, string apiToken = null, UpdateAMessageRequest updateAMessageRequest = null)

Update a message

## Update a message  Updates specific information on a message.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/update-a-message#1-update-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateAMessageRequest = new UpdateAMessageRequest(); // UpdateAMessageRequest |  (optional) 

            try
            {
                // Update a message
                SendbirdMessageResponse result = apiInstance.UpdateAMessage(channelType, channelUrl, messageId, apiToken, updateAMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateAMessageRequest** | [**UpdateAMessageRequest**](UpdateAMessageRequest.md)|  | [optional] 

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


## UpdateExtraDataInAMessage

> UpdateExtraDataInAMessageResponse UpdateExtraDataInAMessage (string channelType, string channelUrl, long messageId, string apiToken = null, UpdateExtraDataInAMessageRequest updateExtraDataInAMessageRequest = null)

Update extra data in a message

## Update extra data in a message  Updates the values of specific items by their keys.  https://sendbird.com/docs/chat/platform-api/v3/message/messaging-basics/message-update-metadata#1-update-metadata - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateExtraDataInAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var channelType = "open_channels";  // string | (Required) 
            var channelUrl = "channelUrl_example";  // string | (Required) 
            var messageId = 789L;  // long | (Required) 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateExtraDataInAMessageRequest = new UpdateExtraDataInAMessageRequest(); // UpdateExtraDataInAMessageRequest |  (optional) 

            try
            {
                // Update extra data in a message
                UpdateExtraDataInAMessageResponse result = apiInstance.UpdateExtraDataInAMessage(channelType, channelUrl, messageId, apiToken, updateExtraDataInAMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateExtraDataInAMessage: " + e.Message );
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
 **messageId** | **long**| (Required)  | 
 **apiToken** | **string**|  | [optional] 
 **updateExtraDataInAMessageRequest** | [**UpdateExtraDataInAMessageRequest**](UpdateExtraDataInAMessageRequest.md)|  | [optional] 

### Return type

[**UpdateExtraDataInAMessageResponse**](UpdateExtraDataInAMessageResponse.md)

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

