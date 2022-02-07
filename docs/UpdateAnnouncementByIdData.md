
# sendbird-platform-sdk.Model.UpdateAnnouncementByIdData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UniqueId** | **string** | Specifies the unique ID of the announcement to update. | 
**Action** | **string** | Specifies an action to take on the announcement. If this property is updated, other specified properties in the request are not effective. Acceptable values are limited to remove, pause, resume, and cancel. The [Announcement actions](#2-update-an-announcement-3-how-to-change-announcement-status) table explains each action in detail. | [optional] 
**AnnouncementGroup** | **string** | Specifies the name of an announcement group to retrieve. If not specified, all announcements are returned, regardless of their group. | [optional] 
**CreateChannel** | **bool** | Determines whether to create a new channel if there is no existing channel that matches with the target options including target_at and target_list. | [optional] 
**CreateChannelOptionsName** | **string** | Specifies the name of the channel. (Default: Group Channel) | [optional] 
**CreateChannelOptionsCoverUrl** | **string** | Specifies the URL of the cover image. | [optional] 
**CreateChannelOptionsCustomType** | **string** | Specifies the custom channel type. | [optional] 
**CreateChannelOptionsData** | **string** | Specifies additional channel information such as a long description of the channel or &#x60;JSON&#x60; formatted string. | [optional] 
**CreateChannelOptionsDistinct** | **string** | Determines whether to create a [distinct](/docs/chat/v3/platform-api/guides/channel-types#2-group-channel) channel. (Default: true) | [optional] 
**MessageUserId** | **string** | Specifies the unique ID of the announcement sender. | [optional] 
**MessageContent** | **string** | Specifies the content of the message. | [optional] 
**MessageData** | **string** | Specifies additional message information such as custom font size, font type or &#x60;JSON&#x60; formatted string. | [optional] 
**EnablePush** | **bool** | Determines whether to turn on push notification for the announcement. If set to true, push notifications will be sent for announcements. | [optional] 
**ScheduledAt** | **int** | Specifies the time to start the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format. (Default: current timestamp) | [optional] 
**EndAt** | **int** | Specifies the time to permanently end the announcement, in [Unix milliseconds](/docs/chat/v3/platform-api/guides/miscellaneous#2-timestamps) format, even if the announcement is not sent to all its targets. | [optional] 
**CeaseAt** | **string** | Specifies the time to temporarily put the announcement on hold in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the resume_at below. | [optional] 
**ResumeAt** | **string** | Specifies the time to automatically resume the on-hold announcement in UTC. The string is represented in HHMM format. This property should be specified in conjunction with the cease_at above. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

