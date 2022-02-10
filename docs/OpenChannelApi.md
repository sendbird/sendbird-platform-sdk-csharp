# sendbird_platform_sdk.Api.OpenChannelApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OcBanUser**](OpenChannelApi.md#ocbanuser) | **POST** /v3/open_channels/{channel_url}/ban | Ban a user
[**OcCancelTheRegistrationOfOperators**](OpenChannelApi.md#occanceltheregistrationofoperators) | **DELETE** /v3/open_channels/{channel_url}/operators | Cancel the registration of operators
[**OcCreateChannel**](OpenChannelApi.md#occreatechannel) | **POST** /v3/open_channels | Create a channel
[**OcDeleteChannelByUrl**](OpenChannelApi.md#ocdeletechannelbyurl) | **DELETE** /v3/open_channels/{channel_url} | Delete a channel
[**OcFreezeChannel**](OpenChannelApi.md#ocfreezechannel) | **PUT** /v3/open_channels/{channel_url}/freeze | Freeze a channel
[**OcListBannedUsers**](OpenChannelApi.md#oclistbannedusers) | **GET** /v3/open_channels/{channel_url}/ban | List banned users
[**OcListChannels**](OpenChannelApi.md#oclistchannels) | **GET** /v3/open_channels | List channels
[**OcListMutedUsers**](OpenChannelApi.md#oclistmutedusers) | **GET** /v3/open_channels/{channel_url}/mute | List muted users
[**OcListOperators**](OpenChannelApi.md#oclistoperators) | **GET** /v3/open_channels/{channel_url}/operators | List operators
[**OcListParticipants**](OpenChannelApi.md#oclistparticipants) | **GET** /v3/open_channels/{channel_url}/participants | List participants
[**OcMuteUser**](OpenChannelApi.md#ocmuteuser) | **POST** /v3/open_channels/{channel_url}/mute | Mute a user
[**OcRegisterOperators**](OpenChannelApi.md#ocregisteroperators) | **POST** /v3/open_channels/{channel_url}/operators | Register operators
[**OcUnbanUserById**](OpenChannelApi.md#ocunbanuserbyid) | **DELETE** /v3/open_channels/{channel_url}/ban/{banned_user_id} | Unban a user
[**OcUnmuteUserById**](OpenChannelApi.md#ocunmuteuserbyid) | **DELETE** /v3/open_channels/{channel_url}/mute/{muted_user_id} | Unmute a user
[**OcUpdateBanById**](OpenChannelApi.md#ocupdatebanbyid) | **PUT** /v3/open_channels/{channel_url}/ban/{banned_user_id} | Update a ban
[**OcUpdateChannelByUrl**](OpenChannelApi.md#ocupdatechannelbyurl) | **PUT** /v3/open_channels/{channel_url} | Update a channel
[**OcViewBanById**](OpenChannelApi.md#ocviewbanbyid) | **GET** /v3/open_channels/{channel_url}/ban/{banned_user_id} | View a ban
[**OcViewChannelByUrl**](OpenChannelApi.md#ocviewchannelbyurl) | **GET** /v3/open_channels/{channel_url} | View a channel
[**OcViewMuteById**](OpenChannelApi.md#ocviewmutebyid) | **GET** /v3/open_channels/{channel_url}/mute/{muted_user_id} | View a mute



## OcBanUser

> OcBanUserResponse OcBanUser (string channelUrl, string apiToken = null, OcBanUserData ocBanUserData = null)

Ban a user

## Ban a user  Bans a user from an open channel. A banned user is immediately expelled from a channel and allowed to participate in the channel again after a set time period.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-ban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcBanUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocBanUserData = new OcBanUserData(); // OcBanUserData |  (optional) 

            try
            {
                // Ban a user
                OcBanUserResponse result = apiInstance.OcBanUser(channelUrl, apiToken, ocBanUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcBanUser: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocBanUserData** | [**OcBanUserData**](OcBanUserData.md)|  | [optional] 

### Return type

[**OcBanUserResponse**](OcBanUserResponse.md)

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


## OcCancelTheRegistrationOfOperators

> void OcCancelTheRegistrationOfOperators (string channelUrl, List<string> operatorIds, string apiToken = null, bool? deleteAll = null)

Cancel the registration of operators

## Cancel the registration of operators  Cancels the registration of operators from an open channel but leave them as participants.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-cancel-the-registration-of-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to cancel the registration of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcCancelTheRegistrationOfOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var operatorIds = new List<string>(); // List<string> | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var deleteAll = true;  // bool? |  (optional) 

            try
            {
                // Cancel the registration of operators
                apiInstance.OcCancelTheRegistrationOfOperators(channelUrl, operatorIds, apiToken, deleteAll);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcCancelTheRegistrationOfOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **operatorIds** | [**List&lt;string&gt;**](string.md)|  | 
 **apiToken** | **string**|  | [optional] 
 **deleteAll** | **bool?**|  | [optional] 

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


## OcCreateChannel

> SendBirdOpenChannel OcCreateChannel (string apiToken = null, OcCreateChannelData ocCreateChannelData = null)

Create a channel

## Create a channel  Creates an open channel.  >__Note__: Classic open channels created before the deprecation date of March 2021 will maintain their original form and functions. However, new applications created after December 15, 2020, will be able to create dynamic partitioning open channels only.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-create-a-channel

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcCreateChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocCreateChannelData = new OcCreateChannelData(); // OcCreateChannelData |  (optional) 

            try
            {
                // Create a channel
                SendBirdOpenChannel result = apiInstance.OcCreateChannel(apiToken, ocCreateChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcCreateChannel: " + e.Message );
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
 **apiToken** | **string**|  | [optional] 
 **ocCreateChannelData** | [**OcCreateChannelData**](OcCreateChannelData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcDeleteChannelByUrl

> void OcDeleteChannelByUrl (string channelUrl, string apiToken = null)

Delete a channel

## Delete a channel  Deletes an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-delete-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcDeleteChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete a channel
                apiInstance.OcDeleteChannelByUrl(channelUrl, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcDeleteChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## OcFreezeChannel

> SendBirdOpenChannel OcFreezeChannel (string channelUrl, string apiToken = null, OcFreezeChannelData ocFreezeChannelData = null)

Freeze a channel

## Freeze a channel  Freezes or unfreezes an open channel.  > __Note__: Only users designated as channel operators are allowed to talk when a channel is frozen.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-freeze-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcFreezeChannelExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocFreezeChannelData = new OcFreezeChannelData(); // OcFreezeChannelData |  (optional) 

            try
            {
                // Freeze a channel
                SendBirdOpenChannel result = apiInstance.OcFreezeChannel(channelUrl, apiToken, ocFreezeChannelData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcFreezeChannel: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocFreezeChannelData** | [**OcFreezeChannelData**](OcFreezeChannelData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcListBannedUsers

> OcListBannedUsersResponse OcListBannedUsers (string channelUrl, string apiToken = null, string token = null, int? limit = null)

List banned users

## List banned users  Retrieves a list of banned users from a specific open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-banned-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel where to retrieve a list of banned users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListBannedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned users
                OcListBannedUsersResponse result = apiInstance.OcListBannedUsers(channelUrl, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListBannedUsers: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListBannedUsersResponse**](OcListBannedUsersResponse.md)

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


## OcListChannels

> OcListChannelsResponse OcListChannels (string apiToken = null, string token = null, int? limit = null, string customTypes = null, string nameContains = null, string urlContains = null, bool? showFrozen = null, bool? showMetadata = null, string customType = null)

List channels

## List channels  Retrieves a list of open channels. You can query the list using various parameters.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-channels - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListChannelsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 
            var customTypes = customTypes_example;  // string |  (optional) 
            var nameContains = nameContains_example;  // string |  (optional) 
            var urlContains = urlContains_example;  // string |  (optional) 
            var showFrozen = true;  // bool? |  (optional) 
            var showMetadata = true;  // bool? |  (optional) 
            var customType = customType_example;  // string |  (optional) 

            try
            {
                // List channels
                OcListChannelsResponse result = apiInstance.OcListChannels(apiToken, token, limit, customTypes, nameContains, urlContains, showFrozen, showMetadata, customType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListChannels: " + e.Message );
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
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 
 **customTypes** | **string**|  | [optional] 
 **nameContains** | **string**|  | [optional] 
 **urlContains** | **string**|  | [optional] 
 **showFrozen** | **bool?**|  | [optional] 
 **showMetadata** | **bool?**|  | [optional] 
 **customType** | **string**|  | [optional] 

### Return type

[**OcListChannelsResponse**](OcListChannelsResponse.md)

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


## OcListMutedUsers

> OcListMutedUsersResponse OcListMutedUsers (string channelUrl, string apiToken = null, string token = null, int? limit = null)

List muted users

## List muted users  Retrieves a list of muted users in the channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-muted-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of muted users.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListMutedUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted users
                OcListMutedUsersResponse result = apiInstance.OcListMutedUsers(channelUrl, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListMutedUsers: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListMutedUsersResponse**](OcListMutedUsersResponse.md)

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


## OcListOperators

> OcListOperatorsResponse OcListOperators (string channelUrl, string apiToken = null, string token = null, int? limit = null)

List operators

## List operators  Retrieves a list of operators of an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of operators.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List operators
                OcListOperatorsResponse result = apiInstance.OcListOperators(channelUrl, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListOperatorsResponse**](OcListOperatorsResponse.md)

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


## OcListParticipants

> OcListParticipantsResponse OcListParticipants (string channelUrl, string apiToken = null, string token = null, int? limit = null)

List participants

## List participants  Retrieves a list of the participants of an open channel. A participant refers to a user who has entered the open channel and is currently online.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-list-participants - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `channel_url`      Type: string      Description: Specifies the URL of the channel to retrieve a list of participants in.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcListParticipantsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List participants
                OcListParticipantsResponse result = apiInstance.OcListParticipants(channelUrl, apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcListParticipants: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**OcListParticipantsResponse**](OcListParticipantsResponse.md)

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


## OcMuteUser

> SendBirdOpenChannel OcMuteUser (string channelUrl, string apiToken = null, OcMuteUserData ocMuteUserData = null)

Mute a user

## Mute a user  Mutes a user in the channel. A muted user remains in the channel and is allowed to view the messages, but can't send any messages until unmuted.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-mute-a-user

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcMuteUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocMuteUserData = new OcMuteUserData(); // OcMuteUserData |  (optional) 

            try
            {
                // Mute a user
                SendBirdOpenChannel result = apiInstance.OcMuteUser(channelUrl, apiToken, ocMuteUserData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcMuteUser: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocMuteUserData** | [**OcMuteUserData**](OcMuteUserData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcRegisterOperators

> void OcRegisterOperators (string channelUrl, string apiToken = null, OcRegisterOperatorsData ocRegisterOperatorsData = null)

Register operators

## Register operators  Registers one or more operators to an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-register-operators - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcRegisterOperatorsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocRegisterOperatorsData = new OcRegisterOperatorsData(); // OcRegisterOperatorsData |  (optional) 

            try
            {
                // Register operators
                apiInstance.OcRegisterOperators(channelUrl, apiToken, ocRegisterOperatorsData);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcRegisterOperators: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocRegisterOperatorsData** | [**OcRegisterOperatorsData**](OcRegisterOperatorsData.md)|  | [optional] 

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


## OcUnbanUserById

> void OcUnbanUserById (string channelUrl, string bannedUserId, string apiToken = null)

Unban a user

## Unban a user  Unbans a user from an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-unban-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUnbanUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var bannedUserId = bannedUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unban a user
                apiInstance.OcUnbanUserById(channelUrl, bannedUserId, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcUnbanUserById: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **bannedUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## OcUnmuteUserById

> void OcUnmuteUserById (string channelUrl, string mutedUserId, string apiToken = null)

Unmute a user

## Unmute a user  Unmutes a user from an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-unmute-a-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUnmuteUserByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var mutedUserId = mutedUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Unmute a user
                apiInstance.OcUnmuteUserById(channelUrl, mutedUserId, apiToken);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcUnmuteUserById: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **mutedUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

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


## OcUpdateBanById

> SendBirdUser OcUpdateBanById (string channelUrl, string bannedUserId, string apiToken = null, OcUpdateBanByIdData ocUpdateBanByIdData = null)

Update a ban

## Update a ban  Updates details of a ban imposed on a user. You can change the length of a ban with this action, and also provide an updated description.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-update-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUpdateBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var bannedUserId = bannedUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocUpdateBanByIdData = new OcUpdateBanByIdData(); // OcUpdateBanByIdData |  (optional) 

            try
            {
                // Update a ban
                SendBirdUser result = apiInstance.OcUpdateBanById(channelUrl, bannedUserId, apiToken, ocUpdateBanByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcUpdateBanById: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **bannedUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocUpdateBanByIdData** | [**OcUpdateBanByIdData**](OcUpdateBanByIdData.md)|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## OcUpdateChannelByUrl

> SendBirdOpenChannel OcUpdateChannelByUrl (string channelUrl, string apiToken = null, OcUpdateChannelByUrlData ocUpdateChannelByUrlData = null)

Update a channel

## Update a channel  Updates information on an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-update-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcUpdateChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var ocUpdateChannelByUrlData = new OcUpdateChannelByUrlData(); // OcUpdateChannelByUrlData |  (optional) 

            try
            {
                // Update a channel
                SendBirdOpenChannel result = apiInstance.OcUpdateChannelByUrl(channelUrl, apiToken, ocUpdateChannelByUrlData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcUpdateChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **ocUpdateChannelByUrlData** | [**OcUpdateChannelByUrlData**](OcUpdateChannelByUrlData.md)|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcViewBanById

> SendBirdUser OcViewBanById (string channelUrl, string bannedUserId, string apiToken = null)

View a ban

## View a ban  Retrieves details of a ban imposed on a user.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-ban - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewBanByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var bannedUserId = bannedUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a ban
                SendBirdUser result = apiInstance.OcViewBanById(channelUrl, bannedUserId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcViewBanById: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **bannedUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**SendBirdUser**](SendBirdUser.md)

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


## OcViewChannelByUrl

> SendBirdOpenChannel OcViewChannelByUrl (string channelUrl, string apiToken = null)

View a channel

## View a channel  Retrieves information on a specific open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-channel - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewChannelByUrlExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a channel
                SendBirdOpenChannel result = apiInstance.OcViewChannelByUrl(channelUrl, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcViewChannelByUrl: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**SendBirdOpenChannel**](SendBirdOpenChannel.md)

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


## OcViewMuteById

> OcViewMuteByIdResponse OcViewMuteById (string channelUrl, string mutedUserId, string apiToken = null)

View a mute

## View a mute  Checks if a user is muted in an open channel.  https://sendbird.com/docs/chat/v3/platform-api/guides/open-channel#2-view-a-mute - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class OcViewMuteByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new OpenChannelApi(Configuration.Default);
            var channelUrl = channelUrl_example;  // string | 
            var mutedUserId = mutedUserId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a mute
                OcViewMuteByIdResponse result = apiInstance.OcViewMuteById(channelUrl, mutedUserId, apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OpenChannelApi.OcViewMuteById: " + e.Message );
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
 **channelUrl** | **string**|  | 
 **mutedUserId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**OcViewMuteByIdResponse**](OcViewMuteByIdResponse.md)

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

