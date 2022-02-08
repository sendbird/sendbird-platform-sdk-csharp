
# sendbird_platform_sdk.Model.SendBotSMessageData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Message** | **string** | Specifies the content of the message sent by the bot. | 
**ChannelUrl** | **string** | Specifies the URL of the channel where the message is sent to. | 
**CustomType** | **string** | Specifies a custom message type which is used for message grouping. The length is limited to 128 characters. | [optional] 
**Data** | **string** | Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string. | [optional] 
**SendPush** | **bool** | Determines whether to send a push notification for the message to the members of the channel (Default: true) | [optional] 
**Mentioned** | **List&lt;int&gt;** | Specifies an array of one or more IDs of the users who get a notification for the message. | [optional] 
**MarkAsRead** | **bool** | Determines whether to mark the message as read for the bot. If set to false, the bot&#39;s unread_count and read_receipt remain unchanged after the message is sent. (Default: true) | [optional] 
**DedupId** | **string** | Specifies the unique ID for the message to prevent the same message data from getting sent to the channel. | [optional] 
**CreatedAt** | **int** | Specifies the time that the message was sent, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

