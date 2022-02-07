
# sendbird-platform-sdk.Model.UpdateChannelMetacounterData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Metacounter** | **string** | Specifies a &#x60;JSON&#x60; object that stores key-value items. The key must not have a comma (,) and its length is limited to 128 characters. The value must be an integer. This property can have up to 5 items. | 
**Mode** | **string** | Specifies how to calculate the item value of the metacounter. Acceptable values are increase, decrease, and set. If set to increase, increments the item value of the metacounter by the value specified in the metacounter property, while decrease decrements. set sets the item value to the specified value exactly. (Default: set) | [optional] 
**Upsert** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

