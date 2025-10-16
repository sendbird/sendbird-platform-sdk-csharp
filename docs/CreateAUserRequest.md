
# sendbird_platform_sdk.Model.CreateAUserRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DiscoveryKeys** | **List&lt;string&gt;** |  | [optional] 
**IssueAccessToken** | **bool** |  | [optional] 
**Metadata** | **Object** |  | [optional] 
**Nickname** | **string** |  | 
**ProfileFile** | **System.IO.Stream** | Specifies the file of the user&#39;s profile image. An acceptable image is limited to a JPG, JPEG, or PNG file of up to 5 MB. When passing a file, you should send a multipart request. If the profile_file property is specified, the profile_url property is not required. | [optional] 
**ProfileUrl** | **string** |  | [default to ""]
**UserId** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

