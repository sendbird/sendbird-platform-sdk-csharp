
# sendbird-platform-sdk.Model.ReportMessageByIdData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelType** | **string** | Specifies the type of the channel. Either open_channels or group_channels. | [optional] 
**ChannelUrl** | **string** | Specifies the URL of the channel where the message to report is in. | [optional] 
**MessageId** | **string** | Specifies the unique ID of the message to report. | [optional] 
**ReportCategory** | **string** | Specifies the category which indicates the reason for reporting. Acceptable values are suspicious, harassing, inappropriate, and spam. | 
**OffendingUserId** | **string** | Specifies the unique ID of the user who has sent the message to report. | 
**ReportingUserId** | **string** | Specifies the unique ID of the user who reports the message. | [optional] 
**ReportDescription** | **string** | Specifies additional information to be included in the report. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

