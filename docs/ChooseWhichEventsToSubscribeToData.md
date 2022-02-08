
# sendbird_platform_sdk.Model.ChooseWhichEventsToSubscribeToData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Determines whether webhooks are turned on in your Sendbird application or not. (Default: false) | 
**Url** | **string** | Specifies the URL of your webhook server to receive payloads for events. | 
**IncludeMembers** | **bool** | Determines whether to include the information on the members of group channels in payloads. (Default: false) | [optional] 
**EnabledEvents** | **List&lt;string&gt;** | Specifies an array of one or more [events](#2-webhook-events) for your webhook server to subscribe to. If set to an asterisk () only, the server will subscribe to all supported events. If set to an empty array, the server will unsubscribe from all (which indicates turning off webhooks). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

