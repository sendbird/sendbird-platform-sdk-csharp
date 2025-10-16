
# sendbird_platform_sdk.Model.SendAMessageRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageType** | **string** |  | 
**UserId** | **string** |  | 
**Message** | **string** | Specifies the content of the message. * This property is required when message_type is MESG or ADMM. | [optional] 
**PushMessageTemplate** | [**SendAMessageRequestPushMessageTemplate**](SendAMessageRequestPushMessageTemplate.md) |  | [optional] 
**PollId** | **int** | Specifies the ID of the poll to be associated with the message. * This property is only available for group channels and message_type is MESG. | [optional] 
**Files** | [**SendbirdFile**](SendbirdFile.md) |  | [optional] 
**RequireAuth** | **bool** | Determines whether to require an authentication key to verify if the file is being properly accessed. Only the user who uploaded the file or users who are in the channel where the file was uploaded should have access. The authentication key managed internally by the Sendbird system is generated every time a user logs in to the Sendbird server and is valid for three days starting from the last login. If set to false, Sendbird tries to access a file without any key. To access encrypted files, such as the files in the Sendbird server which are by default encrypted, the property must be set to true. (Default: false) The require_auth parameter only works if the file or URL is managed by Sendbird, which means that when you upload files using multipart format or provide URLs that point to the files hosted on the Sendbird server. However, if the file is hosted on a server or service that is not managed by Sendbird, access control and authentication for the file should be handled by the respective server or service hosting the file. | [optional] 
**Thumbnail1** | **string** | Specifies the URL of the thumbnail of the file. * This property is available when message_type is FILE. | [optional] 
**Thumbnail2** | **string** | Specifies the URL of the thumbnail of the file. * This property is available when message_type is FILE. | [optional] 
**Thumbnail3** | **string** | Specifies the URL of the thumbnail of the file. * This property is available when message_type is FILE. | [optional] 
**Thumbnails** | **List&lt;string&gt;** | Specifies the URL of the thumbnail of the file. * This property is available when message_type is FILE. | [optional] 
**ApnsBundleId** | **string** |  | [optional] 
**AppleCriticalAlertOptions** | **Object** |  | [optional] 
**CreatedAt** | **long** |  | [optional] 
**CustomType** | **string** |  | [optional] 
**Data** | **string** |  | [optional] 
**DedupId** | **string** |  | [optional] 
**IncludePollDetails** | **bool** |  | [optional] 
**IsSilent** | **bool** |  | [optional] 
**MarkAsRead** | **bool** |  | [optional] 
**MentionType** | **string** |  | [optional] 
**MentionedUserIds** | **List&lt;string&gt;** |  | [optional] 
**SendPush** | **bool** |  | [optional] 
**SortedMetaarray** | [**List&lt;SendbirdSortedMetaarrayInner&gt;**](SendbirdSortedMetaarrayInner.md) |  | [optional] 
**Sound** | **string** |  | [optional] 
**Volume** | **decimal** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

