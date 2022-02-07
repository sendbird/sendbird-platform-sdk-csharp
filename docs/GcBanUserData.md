
# sendbird-platform-sdk.Model.GcBanUserData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelUrl** | **string** | Specifies the URL of the channel where to ban a user. | 
**UserId** | **string** | Specifies the unique ID of the user to ban. | 
**AgentId** | **string** | Specifies the ID of the agent (operator) who bans the user. | 
**Seconds** | **int** | Specifies the ban duration. If set to -1, the user will be banned permanently (10 years, technically). (Default: -1) | 
**Description** | **string** | Specifies a reason for the banning. The length is limited to 250 characters. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

