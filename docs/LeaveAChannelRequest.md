
# sendbird_platform_sdk.Model.LeaveAChannelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserIds** | **List&lt;string&gt;** | Specifies an array of one or more IDs of the users to leave the channel. | 
**ShouldLeaveAll** | **bool** | Determines whether to make all members leave the channel. (Default: false) | [optional] 
**ShouldRemoveOperatorStatus** | **bool** | Determines whether to remove a user from the channel&#39;s operator list if the user who is leaving the channel is an operator. (Default: false) | [optional] 
**Reason** | **string** | Specifies the reason for leaving a channel. Acceptable values are admin_removed, admin_deleted, admin_deactivated, left_by_own_choice, and channel_operator_removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

