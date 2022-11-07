# sendbird_platform_sdk.Api.MessageApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddEmojiCategories**](MessageApi.md#addemojicategories) | **POST** /v3/emoji_categories | Add emoji categories
[**AddEmojis**](MessageApi.md#addemojis) | **POST** /v3/emojis | Add emojis
[**AddExtraDataToMessage**](MessageApi.md#addextradatatomessage) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Add extra data to a message
[**AddReactionToAMessage**](MessageApi.md#addreactiontoamessage) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | Add a reaction to a message
[**DeleteEmojiByKey**](MessageApi.md#deleteemojibykey) | **DELETE** /v3/emojis/{emoji_key} | Delete an emoji
[**DeleteEmojiCategoryById**](MessageApi.md#deleteemojicategorybyid) | **DELETE** /v3/emoji_categories/{emoji_category_id} | Delete an emoji category
[**DeleteMessageById**](MessageApi.md#deletemessagebyid) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id} | Delete a message
[**EnableReactions**](MessageApi.md#enablereactions) | **PUT** /v3/applications/settings/reactions | Enable reactions
[**GcMarkAllMessagesAsDelivered**](MessageApi.md#gcmarkallmessagesasdelivered) | **PUT** /v3/group_channels/{channel_url}/messages/mark_as_delivered | Mark all messages as delivered
[**GcMarkAllMessagesAsRead**](MessageApi.md#gcmarkallmessagesasread) | **PUT** /v3/group_channels/{channel_url}/messages/mark_as_read | Mark all messages as read
[**GcViewNumberOfEachMembersUnreadMessages**](MessageApi.md#gcviewnumberofeachmembersunreadmessages) | **GET** /v3/group_channels/{channel_url}/messages/unread_count | View number of each member&#39;s unread messages
[**GetEmojiByKey**](MessageApi.md#getemojibykey) | **GET** /v3/emojis/{emoji_key} | Get an emoji
[**GetEmojiCategoryById**](MessageApi.md#getemojicategorybyid) | **GET** /v3/emoji_categories/{emoji_category_id} | Get an emoji category
[**ListAllEmojisAndEmojiCategories**](MessageApi.md#listallemojisandemojicategories) | **GET** /v3/emoji_categories | List all emojis and emoji categories
[**ListAnnouncements**](MessageApi.md#listannouncements) | **GET** /v3/announcements | List announcements
[**ListEmojis**](MessageApi.md#listemojis) | **GET** /v3/emojis | List emojis
[**ListMessages**](MessageApi.md#listmessages) | **GET** /v3/{channel_type}/{channel_url}/messages | List messages
[**ListReactionsOfMessage**](MessageApi.md#listreactionsofmessage) | **GET** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | List reactions of a message
[**MigrateMessagesByUrl**](MessageApi.md#migratemessagesbyurl) | **POST** /v3/migration/{target_channel_url} | Migrate messages
[**RemoveExtraDataFromMessage**](MessageApi.md#removeextradatafrommessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Remove extra data from a message
[**RemoveReactionFromAMessage**](MessageApi.md#removereactionfromamessage) | **DELETE** /v3/{channel_type}/{channel_url}/messages/{message_id}/reactions | Remove a reaction from a message
[**SendMessage**](MessageApi.md#sendmessage) | **POST** /v3/{channel_type}/{channel_url}/messages | Send a message
[**TranslateMessageIntoOtherLanguages**](MessageApi.md#translatemessageintootherlanguages) | **POST** /v3/{channel_type}/{channel_url}/messages/{message_id}/translation | Translate a message into other languages
[**UpdateEmojiCategoryUrlById**](MessageApi.md#updateemojicategoryurlbyid) | **PUT** /v3/emoji_categories/{emoji_category_id} | Update an emoji category URL
[**UpdateEmojiUrlByKey**](MessageApi.md#updateemojiurlbykey) | **PUT** /v3/emojis/{emoji_key} | Update an emoji URL
[**UpdateExtraDataInMessage**](MessageApi.md#updateextradatainmessage) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id}/sorted_metaarray | Update extra data in a message
[**UpdateMessageById**](MessageApi.md#updatemessagebyid) | **PUT** /v3/{channel_type}/{channel_url}/messages/{message_id} | Update a message
[**UseDefaultEmojis**](MessageApi.md#usedefaultemojis) | **PUT** /v3/applications/settings/use_default_emoji | Use default emojis
[**ViewMessageById**](MessageApi.md#viewmessagebyid) | **GET** /v3/{channel_type}/{channel_url}/messages/{message_id} | View a message
[**ViewTotalNumberOfMessagesInChannel**](MessageApi.md#viewtotalnumberofmessagesinchannel) | **GET** /v3/{channel_type}/{channel_url}/messages/total_count | View total number of messages in a channel



## AddEmojiCategories

> AddEmojiCategoriesResponse AddEmojiCategories (string apiToken, Object body = null)

Add emoji categories

## Add emoji categories  Adds a list of one or more new emoji categories to the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-add-emoji-categories

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddEmojiCategoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Add emoji categories
                AddEmojiCategoriesResponse result = apiInstance.AddEmojiCategories(apiToken, body);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.AddEmojiCategories: " + e.Message );
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
 **body** | **Object**|  | [optional] 

### Return type

[**AddEmojiCategoriesResponse**](AddEmojiCategoriesResponse.md)

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


## AddEmojis

> AddEmojisResponse AddEmojis (string apiToken, AddEmojisData addEmojisData = null)

Add emojis

## Add emojis  Adds a list of one or more new emojis to the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-add-emojis

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddEmojisExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var addEmojisData = new AddEmojisData(); // AddEmojisData |  (optional) 

            try
            {
                // Add emojis
                AddEmojisResponse result = apiInstance.AddEmojis(apiToken, addEmojisData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.AddEmojis: " + e.Message );
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
 **addEmojisData** | [**AddEmojisData**](AddEmojisData.md)|  | [optional] 

### Return type

[**AddEmojisResponse**](AddEmojisResponse.md)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var addExtraDataToMessageData = new AddExtraDataToMessageData(); // AddExtraDataToMessageData |  (optional) 

            try
            {
                // Add extra data to a message
                AddExtraDataToMessageResponse result = apiInstance.AddExtraDataToMessage(apiToken, channelType, channelUrl, messageId, addExtraDataToMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.AddExtraDataToMessage: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var addReactionToAMessageData = new AddReactionToAMessageData(); // AddReactionToAMessageData |  (optional) 

            try
            {
                // Add a reaction to a message
                AddReactionToAMessageResponse result = apiInstance.AddReactionToAMessage(apiToken, channelType, channelUrl, messageId, addReactionToAMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.AddReactionToAMessage: " + e.Message );
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


## DeleteEmojiByKey

> void DeleteEmojiByKey (string apiToken, string emojiKey)

Delete an emoji

## Delete an emoji  Deletes an emoji from the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-delete-an-emoji - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteEmojiByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiKey = "emojiKey_example";  // string | 

            try
            {
                // Delete an emoji
                apiInstance.DeleteEmojiByKey(apiToken, emojiKey);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.DeleteEmojiByKey: " + e.Message );
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
 **emojiKey** | **string**|  | 

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


## DeleteEmojiCategoryById

> Object DeleteEmojiCategoryById (string apiToken, string emojiCategoryId)

Delete an emoji category

## Delete an emoji category  Deletes an emoji category with the specified ID.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-delete-an-emoji-category - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteEmojiCategoryByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiCategoryId = "emojiCategoryId_example";  // string | 

            try
            {
                // Delete an emoji category
                Object result = apiInstance.DeleteEmojiCategoryById(apiToken, emojiCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.DeleteEmojiCategoryById: " + e.Message );
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
 **emojiCategoryId** | **string**|  | 

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 

            try
            {
                // Delete a message
                Object result = apiInstance.DeleteMessageById(apiToken, channelType, channelUrl, messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.DeleteMessageById: " + e.Message );
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


## EnableReactions

> EnableReactionsResponse EnableReactions (string apiToken, EnableReactionsData enableReactionsData = null)

Enable reactions

## Enable reactions  Turn on or off reactions in a Sendbird application.  > __Note__: This action also allows reactions in UIKit.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-enable-reactions

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class EnableReactionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var enableReactionsData = new EnableReactionsData(); // EnableReactionsData |  (optional) 

            try
            {
                // Enable reactions
                EnableReactionsResponse result = apiInstance.EnableReactions(apiToken, enableReactionsData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.EnableReactions: " + e.Message );
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
 **enableReactionsData** | [**EnableReactionsData**](EnableReactionsData.md)|  | [optional] 

### Return type

[**EnableReactionsResponse**](EnableReactionsResponse.md)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var gcMarkAllMessagesAsDeliveredData = new GcMarkAllMessagesAsDeliveredData(); // GcMarkAllMessagesAsDeliveredData |  (optional) 

            try
            {
                // Mark all messages as delivered
                GcMarkAllMessagesAsDeliveredResponse result = apiInstance.GcMarkAllMessagesAsDelivered(apiToken, channelUrl, gcMarkAllMessagesAsDeliveredData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GcMarkAllMessagesAsDelivered: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var gcMarkAllMessagesAsReadData = new GcMarkAllMessagesAsReadData(); // GcMarkAllMessagesAsReadData |  (optional) 

            try
            {
                // Mark all messages as read
                Object result = apiInstance.GcMarkAllMessagesAsRead(apiToken, channelUrl, gcMarkAllMessagesAsReadData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GcMarkAllMessagesAsRead: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var userIds = "userIds_example";  // string |  (optional) 

            try
            {
                // View number of each member's unread messages
                GcViewNumberOfEachMembersUnreadMessagesResponse result = apiInstance.GcViewNumberOfEachMembersUnreadMessages(apiToken, channelUrl, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GcViewNumberOfEachMembersUnreadMessages: " + e.Message );
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


## GetEmojiByKey

> SendBirdEmoji GetEmojiByKey (string apiToken, string emojiKey)

Get an emoji

## Get an emoji  Retrieves an emoji with the specified key.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-get-an-emoji - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetEmojiByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiKey = "emojiKey_example";  // string | 

            try
            {
                // Get an emoji
                SendBirdEmoji result = apiInstance.GetEmojiByKey(apiToken, emojiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GetEmojiByKey: " + e.Message );
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
 **emojiKey** | **string**|  | 

### Return type

[**SendBirdEmoji**](SendBirdEmoji.md)

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


## GetEmojiCategoryById

> SendBirdEmojiCategory GetEmojiCategoryById (string apiToken, string emojiCategoryId)

Get an emoji category

## Get an emoji category  Retrieves an emoji category with the specified ID, including its emojis.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-get-an-emoji-category - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `emoji_category_id`      Type: int      Description: Specifies the unique ID of the emoji category to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GetEmojiCategoryByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiCategoryId = "emojiCategoryId_example";  // string | 

            try
            {
                // Get an emoji category
                SendBirdEmojiCategory result = apiInstance.GetEmojiCategoryById(apiToken, emojiCategoryId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.GetEmojiCategoryById: " + e.Message );
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
 **emojiCategoryId** | **string**|  | 

### Return type

[**SendBirdEmojiCategory**](SendBirdEmojiCategory.md)

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


## ListAllEmojisAndEmojiCategories

> ListAllEmojisAndEmojiCategoriesResponse ListAllEmojisAndEmojiCategories (string apiToken)

List all emojis and emoji categories

## List all emojis and emoji categories  Retrieves a list of all emoji categories registered to the application, including their emojis.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-list-all-emojis-and-emoji-categories

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListAllEmojisAndEmojiCategoriesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // List all emojis and emoji categories
                ListAllEmojisAndEmojiCategoriesResponse result = apiInstance.ListAllEmojisAndEmojiCategories(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ListAllEmojisAndEmojiCategories: " + e.Message );
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

### Return type

[**ListAllEmojisAndEmojiCategoriesResponse**](ListAllEmojisAndEmojiCategoriesResponse.md)

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


## ListAnnouncements

> ListAnnouncementsResponse ListAnnouncements (string apiToken, string token = null, int? limit = null, string order = null, string status = null, string announcementGroup = null)

List announcements

## List announcements  Retrieves a list of announcements.  https://sendbird.com/docs/chat/v3/platform-api/guides/announcements#2-list-announcements - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListAnnouncementsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var order = "order_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var announcementGroup = "announcementGroup_example";  // string |  (optional) 

            try
            {
                // List announcements
                ListAnnouncementsResponse result = apiInstance.ListAnnouncements(apiToken, token, limit, order, status, announcementGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ListAnnouncements: " + e.Message );
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
 **order** | **string**|  | [optional] 
 **status** | **string**|  | [optional] 
 **announcementGroup** | **string**|  | [optional] 

### Return type

[**ListAnnouncementsResponse**](ListAnnouncementsResponse.md)

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


## ListEmojis

> ListEmojisResponse ListEmojis (string apiToken)

List emojis

## List emojis  Retrieves a list of all emojis registered to the application.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-list-emojis

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListEmojisExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // List emojis
                ListEmojisResponse result = apiInstance.ListEmojis(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ListEmojis: " + e.Message );
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

### Return type

[**ListEmojisResponse**](ListEmojisResponse.md)

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

> ListMessagesResponse ListMessages (string apiToken, string channelType, string channelUrl, string messageTs = null, int? messageId = null, int? prevLimit = null, int? nextLimit = null, bool? include = null, bool? reverse = null, string senderId = null, string senderIds = null, string operatorFilter = null, string customTypes = null, string messageType = null, bool? includingRemoved = null, bool? includeReactions = null, bool? withSortedMetaArray = null, bool? showSubchannelMessagesOnly = null, string userId = null, string customType = null, bool? withMetaArray = null)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageTs = "messageTs_example";  // string |  (optional) 
            var messageId = 56;  // int? |  (optional) 
            var prevLimit = 56;  // int? |  (optional) 
            var nextLimit = 56;  // int? |  (optional) 
            var include = true;  // bool? |  (optional) 
            var reverse = true;  // bool? |  (optional) 
            var senderId = "senderId_example";  // string |  (optional) 
            var senderIds = "senderIds_example";  // string |  (optional) 
            var operatorFilter = "operatorFilter_example";  // string |  (optional) 
            var customTypes = "customTypes_example";  // string |  (optional) 
            var messageType = "messageType_example";  // string |  (optional) 
            var includingRemoved = true;  // bool? |  (optional) 
            var includeReactions = true;  // bool? |  (optional) 
            var withSortedMetaArray = true;  // bool? |  (optional) 
            var showSubchannelMessagesOnly = true;  // bool? |  (optional) 
            var userId = "userId_example";  // string |  (optional) 
            var customType = "customType_example";  // string |  (optional) 
            var withMetaArray = true;  // bool? |  (optional) 

            try
            {
                // List messages
                ListMessagesResponse result = apiInstance.ListMessages(apiToken, channelType, channelUrl, messageTs, messageId, prevLimit, nextLimit, include, reverse, senderId, senderIds, operatorFilter, customTypes, messageType, includingRemoved, includeReactions, withSortedMetaArray, showSubchannelMessagesOnly, userId, customType, withMetaArray);
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
 **apiToken** | **string**|  | 
 **channelType** | **string**|  | 
 **channelUrl** | **string**|  | 
 **messageTs** | **string**|  | [optional] 
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var listUsers = true;  // bool? |  (optional) 

            try
            {
                // List reactions of a message
                ListReactionsOfMessageResponse result = apiInstance.ListReactionsOfMessage(apiToken, channelType, channelUrl, messageId, listUsers);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ListReactionsOfMessage: " + e.Message );
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


## MigrateMessagesByUrl

> void MigrateMessagesByUrl (string apiToken, string targetChannelUrl, Object body = null)

Migrate messages

## Migrate messages  Using our migration API, you can migrate the messages from another system into a Sendbird system's [channel](https://sendbird.com/docs/chat/v3/platform-api/guides/channel-types) which consists of users, messages, and other chat-related data.  > To turn on this feature, [contact our support team](https://dashboard.sendbird.com/settings/contact_us).  There are three things to do in advance before the migration. Follow the instructions below:  1. Register the users of your current chat solution to your Sendbird application. You can migrate the users into the Sendbird system using the [user creation API](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-create-a-user). 2. Create either an [open](https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel) or a [group](https://sendbird.com/docs/chat/v3/platform-api/guides/group-channel#2-create-a-channel) channel to migrate the messages of your chat solution. The Sendbird system doesn't create a channel for your migration automatically. 3. The maximum number of migrated messages per call is 100. To avoid the failure during your migration, you must adjust the number of messages to process at once via the API.  https://sendbird.com/docs/chat/v3/platform-api/guides/migration#2-migrate-messages - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MigrateMessagesByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var targetChannelUrl = "targetChannelUrl_example";  // string | 
            var body = null;  // Object |  (optional) 

            try
            {
                // Migrate messages
                apiInstance.MigrateMessagesByUrl(apiToken, targetChannelUrl, body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.MigrateMessagesByUrl: " + e.Message );
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
 **targetChannelUrl** | **string**|  | 
 **body** | **Object**|  | [optional] 

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var keys = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Remove extra data from a message
                Object result = apiInstance.RemoveExtraDataFromMessage(apiToken, channelType, channelUrl, messageId, keys);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.RemoveExtraDataFromMessage: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var reaction = "reaction_example";  // string |  (optional) 

            try
            {
                // Remove a reaction from a message
                RemoveReactionFromAMessageResponse result = apiInstance.RemoveReactionFromAMessage(apiToken, channelType, channelUrl, messageId, userId, reaction);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.RemoveReactionFromAMessage: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var sendMessageData = new SendMessageData(); // SendMessageData |  (optional) 

            try
            {
                // Send a message
                SendBirdMessageResponse result = apiInstance.SendMessage(apiToken, channelType, channelUrl, sendMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.SendMessage: " + e.Message );
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

> SendBirdMessageResponse TranslateMessageIntoOtherLanguages (string apiToken, string channelType, string channelUrl, string messageId, TranslateMessageIntoOtherLanguagesData translateMessageIntoOtherLanguagesData = null)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var translateMessageIntoOtherLanguagesData = new TranslateMessageIntoOtherLanguagesData(); // TranslateMessageIntoOtherLanguagesData |  (optional) 

            try
            {
                // Translate a message into other languages
                SendBirdMessageResponse result = apiInstance.TranslateMessageIntoOtherLanguages(apiToken, channelType, channelUrl, messageId, translateMessageIntoOtherLanguagesData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.TranslateMessageIntoOtherLanguages: " + e.Message );
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
 **translateMessageIntoOtherLanguagesData** | [**TranslateMessageIntoOtherLanguagesData**](TranslateMessageIntoOtherLanguagesData.md)|  | [optional] 

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


## UpdateEmojiCategoryUrlById

> SendBirdEmojiCategory UpdateEmojiCategoryUrlById (string apiToken, string emojiCategoryId, UpdateEmojiCategoryUrlByIdData updateEmojiCategoryUrlByIdData = null)

Update an emoji category URL

## Update an emoji category URL  Updates the URL of an emoji category with the specified ID.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-update-an-emoji-category-url - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateEmojiCategoryUrlByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiCategoryId = "emojiCategoryId_example";  // string | 
            var updateEmojiCategoryUrlByIdData = new UpdateEmojiCategoryUrlByIdData(); // UpdateEmojiCategoryUrlByIdData |  (optional) 

            try
            {
                // Update an emoji category URL
                SendBirdEmojiCategory result = apiInstance.UpdateEmojiCategoryUrlById(apiToken, emojiCategoryId, updateEmojiCategoryUrlByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateEmojiCategoryUrlById: " + e.Message );
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
 **emojiCategoryId** | **string**|  | 
 **updateEmojiCategoryUrlByIdData** | [**UpdateEmojiCategoryUrlByIdData**](UpdateEmojiCategoryUrlByIdData.md)|  | [optional] 

### Return type

[**SendBirdEmojiCategory**](SendBirdEmojiCategory.md)

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


## UpdateEmojiUrlByKey

> SendBirdEmoji UpdateEmojiUrlByKey (string apiToken, string emojiKey, UpdateEmojiUrlByKeyData updateEmojiUrlByKeyData = null)

Update an emoji URL

## Update an emoji URL  Updates the image URL of an emoji with the specified key.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-update-an-emoji-url - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateEmojiUrlByKeyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var emojiKey = "emojiKey_example";  // string | 
            var updateEmojiUrlByKeyData = new UpdateEmojiUrlByKeyData(); // UpdateEmojiUrlByKeyData |  (optional) 

            try
            {
                // Update an emoji URL
                SendBirdEmoji result = apiInstance.UpdateEmojiUrlByKey(apiToken, emojiKey, updateEmojiUrlByKeyData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateEmojiUrlByKey: " + e.Message );
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
 **emojiKey** | **string**|  | 
 **updateEmojiUrlByKeyData** | [**UpdateEmojiUrlByKeyData**](UpdateEmojiUrlByKeyData.md)|  | [optional] 

### Return type

[**SendBirdEmoji**](SendBirdEmoji.md)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var updateExtraDataInMessageData = new UpdateExtraDataInMessageData(); // UpdateExtraDataInMessageData |  (optional) 

            try
            {
                // Update extra data in a message
                UpdateExtraDataInMessageResponse result = apiInstance.UpdateExtraDataInMessage(apiToken, channelType, channelUrl, messageId, updateExtraDataInMessageData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateExtraDataInMessage: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
            var updateMessageByIdData = new UpdateMessageByIdData(); // UpdateMessageByIdData |  (optional) 

            try
            {
                // Update a message
                SendBirdMessageResponse result = apiInstance.UpdateMessageById(apiToken, channelType, channelUrl, messageId, updateMessageByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UpdateMessageById: " + e.Message );
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


## UseDefaultEmojis

> UseDefaultEmojisResponse UseDefaultEmojis (string apiToken, UseDefaultEmojisData useDefaultEmojisData = null)

Use default emojis

## Use default emojis  Determines whether to use the 7 default emojis initially provided.  https://sendbird.com/docs/chat/v3/platform-api/guides/emojis#2-use-default-emojis

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UseDefaultEmojisExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var useDefaultEmojisData = new UseDefaultEmojisData(); // UseDefaultEmojisData |  (optional) 

            try
            {
                // Use default emojis
                UseDefaultEmojisResponse result = apiInstance.UseDefaultEmojis(apiToken, useDefaultEmojisData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.UseDefaultEmojis: " + e.Message );
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
 **useDefaultEmojisData** | [**UseDefaultEmojisData**](UseDefaultEmojisData.md)|  | [optional] 

### Return type

[**UseDefaultEmojisResponse**](UseDefaultEmojisResponse.md)

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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 
            var messageId = "messageId_example";  // string | 
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
                Debug.Print("Exception when calling MessageApi.ViewMessageById: " + e.Message );
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
            var apiInstance = new MessageApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var channelType = "channelType_example";  // string | 
            var channelUrl = "channelUrl_example";  // string | 

            try
            {
                // View total number of messages in a channel
                ViewTotalNumberOfMessagesInChannelResponse result = apiInstance.ViewTotalNumberOfMessagesInChannel(apiToken, channelType, channelUrl);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling MessageApi.ViewTotalNumberOfMessagesInChannel: " + e.Message );
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

