# sendbird_platform_sdk.Api.MessagesApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExtraDataToMessage**](MessagesApi.md#addextradatatomessage) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Add extra data to a message
[**AddReactionToAMessage**](MessagesApi.md#addreactiontoamessage) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | Add a reaction to a message
[**DeleteMessageById**](MessagesApi.md#deletemessagebyid) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id} | Delete a message
[**GcMarkAllMessagesAsDelivered**](MessagesApi.md#gcmarkallmessagesasdelivered) | **PUT** /v3/group_channels/{channel_url}/messages/mark_as_delivered | Mark all messages as delivered
[**GcMarkAllMessagesAsRead**](MessagesApi.md#gcmarkallmessagesasread) | **PUT** /v3/group_channels/{channel_url}/messages/mark_as_read | Mark all messages as read
[**GcViewNumberOfEachMembersUnreadMessages**](MessagesApi.md#gcviewnumberofeachmembersunreadmessages) | **GET** /v3/group_channels/{channel_url}/messages/unread_count | View number of each member&#39;s unread messages
[**ListMessages**](MessagesApi.md#listmessages) | **GET** /v3/{channel_type}/{channel_url}/messages | List messages
[**ListReactionsOfMessage**](MessagesApi.md#listreactionsofmessage) | **GET** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | List reactions of a message
[**RemoveExtraDataFromMessage**](MessagesApi.md#removeextradatafrommessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Remove extra data from a message
[**RemoveReactionFromAMessage**](MessagesApi.md#removereactionfromamessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | Remove a reaction from a message
[**SendMessage**](MessagesApi.md#sendmessage) | **POST** /v3/{channel_type}/{channel_url}/messages | Send a message
[**TranslateMessageIntoOtherLanguages**](MessagesApi.md#translatemessageintootherlanguages) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/translation | Translate a message into other languages
[**UpdateExtraDataInMessage**](MessagesApi.md#updateextradatainmessage) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Update extra data in a message
[**UpdateMessageById**](MessagesApi.md#updatemessagebyid) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id} | Update a message
[**ViewMessageById**](MessagesApi.md#viewmessagebyid) | **GET** /v3/{channel_type}/{channel_url}/messages/{message_id} | View a message
[**ViewTotalNumberOfMessagesInChannel**](MessagesApi.md#viewtotalnumberofmessagesinchannel) | **GET** /v3/{channel_type}/{channel_url}/messages/total_count | View total number of messages in a channel



## AddExtraDataToMessage

> AddExtraDataToMessageResponse AddExtraDataToMessage (string apiToken, string channelType, string channelUrl, string messageId, AddExtraDataToMessageData addExtraDataToMessageData = null)

Add extra data to a message

## Add extra data to a message  Adds one or more key-values items which store additional information for a message.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-add-extra-data-to-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddExtraDataToMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var addExtraDataToMessageData = new AddExtraDataToMessageData(); // AddExtraDataToMessageData |  (optional) 

            try
            {
                // Add extra data to a message
                AddExtraDataToMessageResponse result = apiInstance.AddExtraDataToMessage(apiToken, channelType, channelUrl, messageId, addExtraDataToMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.AddExtraDataToMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **addExtraDataToMessageData** | [**AddExtraDataToMessageData**](AddExtraDataToMessageData.md)|  | [optional] 

### Return type

[**AddExtraDataToMessageResponse**](AddExtraDataToMessageResponse.md)

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


## AddReactionToAMessage

> AddReactionToAMessageResponse AddReactionToAMessage (string apiToken, string channelType, string channelUrl, string messageId, AddReactionToAMessageData addReactionToAMessageData = null)

Add a reaction to a message

## Add a reaction to a message  Adds a specific reaction to a message.  > __Note__: Currently, this action is only available in group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-add-a-reaction-to-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddReactionToAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var addReactionToAMessageData = new AddReactionToAMessageData(); // AddReactionToAMessageData |  (optional) 

            try
            {
                // Add a reaction to a message
                AddReactionToAMessageResponse result = apiInstance.AddReactionToAMessage(apiToken, channelType, channelUrl, messageId, addReactionToAMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.AddReactionToAMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **addReactionToAMessageData** | [**AddReactionToAMessageData**](AddReactionToAMessageData.md)|  | [optional] 

### Return type

[**AddReactionToAMessageResponse**](AddReactionToAMessageResponse.md)

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


## DeleteMessageById

> Object DeleteMessageById (string apiToken, string channelType, string channelUrl, string messageId)

Delete a message

## Delete a message  Deletes a message from a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-delete-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 

            try
            {
                // Delete a message
                Object result = apiInstance.DeleteMessageById(apiToken, channelType, channelUrl, messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.DeleteMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 

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


## GcMarkAllMessagesAsDelivered

> GcMarkAllMessagesAsDeliveredResponse GcMarkAllMessagesAsDelivered (string apiToken, string channelUrl, GcMarkAllMessagesAsDeliveredData gcMarkAllMessagesAsDeliveredData = null)

Mark all messages as delivered

## Mark all messages as delivered  Marks all messages in a group channel as delivered for a given user. This action is only applicable for users in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-mark-all-messages-as-delivered - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcMarkAllMessagesAsDeliveredExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcMarkAllMessagesAsDeliveredData = new GcMarkAllMessagesAsDeliveredData(); // GcMarkAllMessagesAsDeliveredData |  (optional) 

            try
            {
                // Mark all messages as delivered
                GcMarkAllMessagesAsDeliveredResponse result = apiInstance.GcMarkAllMessagesAsDelivered(apiToken, channelUrl, gcMarkAllMessagesAsDeliveredData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.GcMarkAllMessagesAsDelivered: " + e.Message );
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
 **gcMarkAllMessagesAsDeliveredData** | [**GcMarkAllMessagesAsDeliveredData**](GcMarkAllMessagesAsDeliveredData.md)|  | [optional] 

### Return type

[**GcMarkAllMessagesAsDeliveredResponse**](GcMarkAllMessagesAsDeliveredResponse.md)

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


## GcMarkAllMessagesAsRead

> Object GcMarkAllMessagesAsRead (string apiToken, string channelUrl, GcMarkAllMessagesAsReadData gcMarkAllMessagesAsReadData = null)

Mark all messages as read

## Mark all messages as read  Marks all messages in a group channel as read for a given user. This action is only applicable for users in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-mark-all-messages-as-read - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcMarkAllMessagesAsReadExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var gcMarkAllMessagesAsReadData = new GcMarkAllMessagesAsReadData(); // GcMarkAllMessagesAsReadData |  (optional) 

            try
            {
                // Mark all messages as read
                Object result = apiInstance.GcMarkAllMessagesAsRead(apiToken, channelUrl, gcMarkAllMessagesAsReadData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.GcMarkAllMessagesAsRead: " + e.Message );
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
 **gcMarkAllMessagesAsReadData** | [**GcMarkAllMessagesAsReadData**](GcMarkAllMessagesAsReadData.md)|  | [optional] 

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


## GcViewNumberOfEachMembersUnreadMessages

> GcViewNumberOfEachMembersUnreadMessagesResponse GcViewNumberOfEachMembersUnreadMessages (string apiToken, string channelUrl, string userIds = null)

View number of each member's unread messages

## View number of each member's unread messages  Retrieves the total number of each member's unread messages in a group channel. This action is only applicable for users in a group channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-view-number-of-each-member-s-unread-messages - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GcViewNumberOfEachMembersUnreadMessagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var userIds = userIds_example;  // string |  (optional) 

            try
            {
                // View number of each member's unread messages
                GcViewNumberOfEachMembersUnreadMessagesResponse result = apiInstance.GcViewNumberOfEachMembersUnreadMessages(apiToken, channelUrl, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.GcViewNumberOfEachMembersUnreadMessages: " + e.Message );
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
 **userIds** | **string**|  | [optional] 

### Return type

[**GcViewNumberOfEachMembersUnreadMessagesResponse**](GcViewNumberOfEachMembersUnreadMessagesResponse.md)

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

> ListMessagesResponse ListMessages (string apiToken, string channelType, string channelUrl, int? messageTs = null, int? messageId = null, int? prevLimit = null, int? nextLimit = null, bool? include = null, bool? reverse = null, string senderId = null, string senderIds = null, string operatorFilter = null, string customTypes = null, string messageType = null, bool? includingRemoved = null, bool? includeReactions = null, bool? withSortedMetaArray = null, bool? showSubchannelMessagesOnly = null, string userId = null, string customType = null, bool? withMetaArray = null)

List messages

## List messages  Retrieves a list of past messages of a channel.  > This message retrieval is one of Sendbird's [premium features](https://sendbird.com/docs/chat/v3/platform-api/guides/application#-3-sendbird-s-premium-features). Contact our [sales team](https://get.sendbird.com/talk-to-sales.html) for further assistance.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-list-messages - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of past messages.

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
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageTs = 56;  // int? |  (optional) 
            var messageId = 56;  // int? |  (optional) 
            var prevLimit = 56;  // int? |  (optional) 
            var nextLimit = 56;  // int? |  (optional) 
            var include = true;  // bool? |  (optional) 
            var reverse = true;  // bool? |  (optional) 
            var senderId = senderId_example;  // string |  (optional) 
            var senderIds = senderIds_example;  // string |  (optional) 
            var operatorFilter = operatorFilter_example;  // string |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var messageType = messageType_example;  // string |  (optional) 
            var includingRemoved = true;  // bool? |  (optional) 
            var includeReactions = true;  // bool? |  (optional) 
            var withSortedMetaArray = true;  // bool? |  (optional) 
            var showSubchannelMessagesOnly = true;  // bool? |  (optional) 
            var userId = userId_example;  // string |  (optional) 
            var customType = customType_example;  // string |  (optional) 
            var withMetaArray = true;  // bool? |  (optional) 

            try
            {
                // List messages
                ListMessagesResponse result = apiInstance.ListMessages(apiToken, channelType, channelUrl, messageTs, messageId, prevLimit, nextLimit, include, reverse, senderId, senderIds, operatorFilter, customTypes, messageType, includingRemoved, includeReactions, withSortedMetaArray, showSubchannelMessagesOnly, userId, customType, withMetaArray);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.ListMessages: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageTs** | **int?**|  | [optional] 
 **messageId** | **int?**|  | [optional] 
 **prevLimit** | **int?**|  | [optional] 
 **nextLimit** | **int?**|  | [optional] 
 **include** | **bool?**|  | [optional] 
 **reverse** | **bool?**|  | [optional] 
 **senderId** | **string**|  | [optional] 
 **senderIds** | **string**|  | [optional] 
 **operatorFilter** | **string**|  | [optional] 
 **customTypes** | **string**|  | [optional] 
 **messageType** | **string**|  | [optional] 
 **includingRemoved** | **bool?**|  | [optional] 
 **includeReactions** | **bool?**|  | [optional] 
 **withSortedMetaArray** | **bool?**|  | [optional] 
 **showSubchannelMessagesOnly** | **bool?**|  | [optional] 
 **userId** | **string**|  | [optional] 
 **customType** | **string**|  | [optional] 
 **withMetaArray** | **bool?**|  | [optional] 

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


## ListReactionsOfMessage

> ListReactionsOfMessageResponse ListReactionsOfMessage (string apiToken, string channelType, string channelUrl, string messageId, bool? listUsers = null)

List reactions of a message

## List reactions of a message  Retrieves a list of reactions made to a message.  > __Note__: Currently, this action is only available in group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-list-reactions-of-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.  `message_id`      Type: long      Description: Specifies the unique ID of the message to add a reaction to.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListReactionsOfMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var listUsers = true;  // bool? |  (optional) 

            try
            {
                // List reactions of a message
                ListReactionsOfMessageResponse result = apiInstance.ListReactionsOfMessage(apiToken, channelType, channelUrl, messageId, listUsers);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.ListReactionsOfMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **listUsers** | **bool?**|  | [optional] 

### Return type

[**ListReactionsOfMessageResponse**](ListReactionsOfMessageResponse.md)

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


## RemoveExtraDataFromMessage

> Object RemoveExtraDataFromMessage (string apiToken, string channelType, string channelUrl, string messageId, List<string> keys = null)

Remove extra data from a message

## Remove extra data from a message  Removes specific items from a message by their keys.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-remove-extra-data-from-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveExtraDataFromMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Remove extra data from a message
                Object result = apiInstance.RemoveExtraDataFromMessage(apiToken, channelType, channelUrl, messageId, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.RemoveExtraDataFromMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **keys** | [**List&lt;string&gt;**](string.md)|  | [optional] 

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


## RemoveReactionFromAMessage

> RemoveReactionFromAMessageResponse RemoveReactionFromAMessage (string apiToken, string channelType, string channelUrl, string messageId, string userId = null, string reaction = null)

Remove a reaction from a message

## Remove a reaction from a message  Removes a specific reaction from a message.  > __Note__: Currently, this action is only available in group channels.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-remove-a-reaction-from-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemoveReactionFromAMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var userId = userId_example;  // string |  (optional) 
            var reaction = reaction_example;  // string |  (optional) 

            try
            {
                // Remove a reaction from a message
                RemoveReactionFromAMessageResponse result = apiInstance.RemoveReactionFromAMessage(apiToken, channelType, channelUrl, messageId, userId, reaction);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.RemoveReactionFromAMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **userId** | **string**|  | [optional] 
 **reaction** | **string**|  | [optional] 

### Return type

[**RemoveReactionFromAMessageResponse**](RemoveReactionFromAMessageResponse.md)

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


## SendMessage

> SendBirdMessageResponse SendMessage (string apiToken, string channelType, string channelUrl, SendMessageData sendMessageData = null)

Send a message

## Send a message  Sends a message to a channel. You can send a text message, a file message, and an admin message.  >__Note__: With Sendbird Chat SDKs and the platform API, any type of files in messages can be uploaded to Sendbird server.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-send-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class SendMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var sendMessageData = new SendMessageData(); // SendMessageData |  (optional) 

            try
            {
                // Send a message
                SendBirdMessageResponse result = apiInstance.SendMessage(apiToken, channelType, channelUrl, sendMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.SendMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **sendMessageData** | [**SendMessageData**](SendMessageData.md)|  | [optional] 

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


## TranslateMessageIntoOtherLanguages

> SendBirdMessageResponse TranslateMessageIntoOtherLanguages (string apiToken, string channelType, string channelUrl, string messageId, Object body = null)

Translate a message into other languages

## Translate a message into other languages  Translates a message into specific languages. Only text messages of which type is MESG can be translated into other languages.  > __Note__: Message translation is powered by [Google Cloud Translation API recognition engine](https://cloud.google.com/translate/). Find language codes supported by the engine in the [Miscellaneous](https://sendbird.com/docs/chat/v3/platform-api/guides/Miscellaneous) page or visit the [Language Support](https://cloud.google.com/translate/docs/languages) for Google Cloud Translation.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-translate-a-message-into-other-languages - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class TranslateMessageIntoOtherLanguagesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                // Translate a message into other languages
                SendBirdMessageResponse result = apiInstance.TranslateMessageIntoOtherLanguages(apiToken, channelType, channelUrl, messageId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.TranslateMessageIntoOtherLanguages: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **body** | **Object**|  | [optional] 

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


## UpdateExtraDataInMessage

> UpdateExtraDataInMessageResponse UpdateExtraDataInMessage (string apiToken, string channelType, string channelUrl, string messageId, UpdateExtraDataInMessageData updateExtraDataInMessageData = null)

Update extra data in a message

## Update extra data in a message  Updates the values of specific items by their keys.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-update-extra-data-in-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateExtraDataInMessageExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var updateExtraDataInMessageData = new UpdateExtraDataInMessageData(); // UpdateExtraDataInMessageData |  (optional) 

            try
            {
                // Update extra data in a message
                UpdateExtraDataInMessageResponse result = apiInstance.UpdateExtraDataInMessage(apiToken, channelType, channelUrl, messageId, updateExtraDataInMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.UpdateExtraDataInMessage: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **updateExtraDataInMessageData** | [**UpdateExtraDataInMessageData**](UpdateExtraDataInMessageData.md)|  | [optional] 

### Return type

[**UpdateExtraDataInMessageResponse**](UpdateExtraDataInMessageResponse.md)

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


## UpdateMessageById

> SendBirdMessageResponse UpdateMessageById (string apiToken, string channelType, string channelUrl, string messageId, UpdateMessageByIdData updateMessageByIdData = null)

Update a message

## Update a message  Updates information on a message in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-update-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var updateMessageByIdData = new UpdateMessageByIdData(); // UpdateMessageByIdData |  (optional) 

            try
            {
                // Update a message
                SendBirdMessageResponse result = apiInstance.UpdateMessageById(apiToken, channelType, channelUrl, messageId, updateMessageByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.UpdateMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **updateMessageByIdData** | [**UpdateMessageByIdData**](UpdateMessageByIdData.md)|  | [optional] 

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


## ViewMessageById

> SendBirdMessageResponse ViewMessageById (string apiToken, string channelType, string channelUrl, string messageId, bool? withSortedMetaArray = null, bool? withMetaArray = null)

View a message

## View a message  Retrieves information on a message.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-view-a-message - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_type`      Type: string      Description: Specifies the type of the channel. Either open_channels or group_channels.  `channel_url`      Type: string      Description: Specifies the URL of the target channel.  `message_id`      Type: long      Description: Specifies the unique ID of the message to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewMessageByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 
            var messageId = messageId_example;  // string | 
            var withSortedMetaArray = true;  // bool? |  (optional) 
            var withMetaArray = true;  // bool? |  (optional) 

            try
            {
                // View a message
                SendBirdMessageResponse result = apiInstance.ViewMessageById(apiToken, channelType, channelUrl, messageId, withSortedMetaArray, withMetaArray);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.ViewMessageById: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageId** | **string**|  | 
 **withSortedMetaArray** | **bool?**|  | [optional] 
 **withMetaArray** | **bool?**|  | [optional] 

### Return type

[**SendBirdMessageResponse**](SendBirdMessageResponse.md)

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


## ViewTotalNumberOfMessagesInChannel

> ViewTotalNumberOfMessagesInChannelResponse ViewTotalNumberOfMessagesInChannel (string apiToken, string channelType, string channelUrl)

View total number of messages in a channel

## View total number of messages in a channel  Retrieves the total number of messages in a channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/messages#2-view-total-number-of-messages-in-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewTotalNumberOfMessagesInChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessagesApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = channelType_example;  // string | 
            var channelUrl = channelUrl_example;  // string | 

            try
            {
                // View total number of messages in a channel
                ViewTotalNumberOfMessagesInChannelResponse result = apiInstance.ViewTotalNumberOfMessagesInChannel(apiToken, channelType, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessagesApi.ViewTotalNumberOfMessagesInChannel: " + e.Message );
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
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 

### Return type

[**ViewTotalNumberOfMessagesInChannelResponse**](ViewTotalNumberOfMessagesInChannelResponse.md)

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

