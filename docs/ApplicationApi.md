# sendbird_platform_sdk.Api.ApplicationApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddApnsPushConfiguration**](ApplicationApi.md#addapnspushconfiguration) | **POST** /v3/applications/push/apns | Add an APNs push configuration
[**AddFcmPushConfiguration**](ApplicationApi.md#addfcmpushconfiguration) | **POST** /v3/applications/push/fcm | Add a FCM push configuration
[**AddHmsPushConfiguration**](ApplicationApi.md#addhmspushconfiguration) | **POST** /v3/applications/push/hms | Add an HMS push configuration
[**AddIpToWhitelist**](ApplicationApi.md#addiptowhitelist) | **PUT** /v3/applications/settings/ip_whitelist | Add an IP to a whitelist
[**BanUsersInChannelsWithCustomChannelType**](ApplicationApi.md#banusersinchannelswithcustomchanneltype) | **POST** /v3/applications/settings_by_channel_custom_type/{custom_type}/ban | Ban users in channels with a custom channel type
[**DeleteAllowedIpsFromWhitelist**](ApplicationApi.md#deleteallowedipsfromwhitelist) | **DELETE** /v3/applications/settings/ip_whitelist | Delete allowed IPs from a whitelist
[**DeleteApnsCertificateById**](ApplicationApi.md#deleteapnscertificatebyid) | **DELETE** /v3/applications/push/apns/cert/{provider_id} | Delete an APNs certificate
[**GenerateSecondaryApiToken**](ApplicationApi.md#generatesecondaryapitoken) | **POST** /v3/applications/api_tokens | Generate a secondary API token
[**ListBannedUsersInChannelsWithCustomChannelType**](ApplicationApi.md#listbannedusersinchannelswithcustomchanneltype) | **GET** /v3/applications/settings_by_channel_custom_type/{custom_type}/ban | List banned users in channels with a custom channel type
[**ListMutedUsersInChannelsWithCustomChannelType**](ApplicationApi.md#listmutedusersinchannelswithcustomchanneltype) | **GET** /v3/applications/settings_by_channel_custom_type/{custom_type}/mute | List muted users in channels with a custom channel type
[**ListPushConfigurations**](ApplicationApi.md#listpushconfigurations) | **GET** /v3/applications/push/{push_type} | List push configurations
[**ListPushNotificationContentTemplates**](ApplicationApi.md#listpushnotificationcontenttemplates) | **GET** /v3/applications/push/message_templates | List push notification content templates
[**ListSecondaryApiTokens**](ApplicationApi.md#listsecondaryapitokens) | **GET** /v3/applications/api_tokens | List secondary API tokens
[**MuteUsersInChannelsWithCustomChannelType**](ApplicationApi.md#muteusersinchannelswithcustomchanneltype) | **POST** /v3/applications/settings_by_channel_custom_type/{custom_type}/mute | Mute users in channels with a custom channel type
[**RemovePushConfigurationById**](ApplicationApi.md#removepushconfigurationbyid) | **DELETE** /v3/applications/push/{push_type}/{provider_id} | Remove a push configuration
[**RetrieveIpWhitelist**](ApplicationApi.md#retrieveipwhitelist) | **GET** /v3/applications/settings/ip_whitelist | Retrieve an IP whitelist
[**RevokeSecondaryApiTokenByToken**](ApplicationApi.md#revokesecondaryapitokenbytoken) | **DELETE** /v3/applications/api_tokens/{api_token} | Revoke a secondary API token
[**SetDomainFilter**](ApplicationApi.md#setdomainfilter) | **PUT** /v3/applications/settings_global/{custom_type} | Message moderation
[**UnbanUsersInChannelsWithCustomChannelType**](ApplicationApi.md#unbanusersinchannelswithcustomchanneltype) | **DELETE** /v3/applications/settings_by_channel_custom_type/{custom_type}/ban | Unban users in channels with a custom channel type
[**UnmuteUsersInChannelsWithCustomChannelType**](ApplicationApi.md#unmuteusersinchannelswithcustomchanneltype) | **DELETE** /v3/applications/settings_by_channel_custom_type/{custom_type}/mute | Unmute users in channels with a custom channel type
[**UpdateApnsPushConfigurationById**](ApplicationApi.md#updateapnspushconfigurationbyid) | **PUT** /v3/applications/push/apns/{provider_id} | Update an APNs push configuration
[**UpdateDefaultChannelInvitationPreference**](ApplicationApi.md#updatedefaultchannelinvitationpreference) | **PUT** /v3/applications/default_channel_invitation_preference | Update default channel invitation preference
[**UpdateFcmPushConfigurationById**](ApplicationApi.md#updatefcmpushconfigurationbyid) | **PUT** /v3/applications/push/fcm/{provider_id} | Update a FCM push configuration
[**UpdateHmsPushConfigurationById**](ApplicationApi.md#updatehmspushconfigurationbyid) | **PUT** /v3/applications/push/hms/{provider_id} | Update an HMS push configuration
[**UpdatePushNotificationContentTemplate**](ApplicationApi.md#updatepushnotificationcontenttemplate) | **PUT** /v3/applications/push/message_templates/{template_name} | Update a push notification content template
[**ViewDefaultChannelInvitationPreference**](ApplicationApi.md#viewdefaultchannelinvitationpreference) | **GET** /v3/applications/default_channel_invitation_preference | View default channel invitation preference
[**ViewPushConfigurationById**](ApplicationApi.md#viewpushconfigurationbyid) | **GET** /v3/applications/push/{push_type}/{provider_id} | View a push configuration
[**ViewPushNotificationContentTemplate**](ApplicationApi.md#viewpushnotificationcontenttemplate) | **GET** /v3/applications/push/message_templates/{template_name} | View a push notification content template
[**ViewSecondaryApiTokenByToken**](ApplicationApi.md#viewsecondaryapitokenbytoken) | **GET** /v3/applications/api_tokens/{api_token} | View a secondary API token



## AddApnsPushConfiguration

> AddApnsPushConfigurationResponse AddApnsPushConfiguration (string apiToken, AddApnsPushConfigurationData addApnsPushConfigurationData = null)

Add an APNs push configuration

## Add an APNs push configuration  Registers an APNs (Apple Push Notification service) push configuration for your client app. To send push notifications to iOS devices, your should first register the APNs push configuration. You can also register the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  > __Note__: To upload a [.p12](https://sendbird.com/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) certificate file to Sendbird server, you should send a [Multipart request](https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api#2-headers-3-multipart-requests).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-add-an-apns-push-configuration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddApnsPushConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var addApnsPushConfigurationData = new AddApnsPushConfigurationData(); // AddApnsPushConfigurationData |  (optional) 

            try
            {
                // Add an APNs push configuration
                AddApnsPushConfigurationResponse result = apiInstance.AddApnsPushConfiguration(apiToken, addApnsPushConfigurationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddApnsPushConfiguration: " + e.Message );
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
 **apiToken** | **string**|  | 
 **addApnsPushConfigurationData** | [**AddApnsPushConfigurationData**](AddApnsPushConfigurationData.md)|  | [optional] 

### Return type

[**AddApnsPushConfigurationResponse**](AddApnsPushConfigurationResponse.md)

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


## AddFcmPushConfiguration

> AddFcmPushConfigurationResponse AddFcmPushConfiguration (string apiToken, AddFcmPushConfigurationData addFcmPushConfigurationData = null)

Add a FCM push configuration

## Add a FCM push configuration  Registers a FCM (Firebase Cloud Messaging) push configuration for your client app. To send push notifications to Android devices, you should first register the FCM push configuration. You can also register the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-add-a-fcm-push-configuration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddFcmPushConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var addFcmPushConfigurationData = new AddFcmPushConfigurationData(); // AddFcmPushConfigurationData |  (optional) 

            try
            {
                // Add a FCM push configuration
                AddFcmPushConfigurationResponse result = apiInstance.AddFcmPushConfiguration(apiToken, addFcmPushConfigurationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddFcmPushConfiguration: " + e.Message );
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
 **apiToken** | **string**|  | 
 **addFcmPushConfigurationData** | [**AddFcmPushConfigurationData**](AddFcmPushConfigurationData.md)|  | [optional] 

### Return type

[**AddFcmPushConfigurationResponse**](AddFcmPushConfigurationResponse.md)

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


## AddHmsPushConfiguration

> AddHmsPushConfigurationResponse AddHmsPushConfiguration (string apiToken, AddHmsPushConfigurationData addHmsPushConfigurationData = null)

Add an HMS push configuration

## Add an HMS push configuration  Registers an HMS (Huawei Mobile Services) push configuration for your client app. To send push notifications to Android devices for HMS, you should first register the HMS push configuration. You can also register the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-add-an-hms-push-configuration

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddHmsPushConfigurationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var addHmsPushConfigurationData = new AddHmsPushConfigurationData(); // AddHmsPushConfigurationData |  (optional) 

            try
            {
                // Add an HMS push configuration
                AddHmsPushConfigurationResponse result = apiInstance.AddHmsPushConfiguration(apiToken, addHmsPushConfigurationData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddHmsPushConfiguration: " + e.Message );
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
 **apiToken** | **string**|  | 
 **addHmsPushConfigurationData** | [**AddHmsPushConfigurationData**](AddHmsPushConfigurationData.md)|  | [optional] 

### Return type

[**AddHmsPushConfigurationResponse**](AddHmsPushConfigurationResponse.md)

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


## AddIpToWhitelist

> AddIpToWhitelistResponse AddIpToWhitelist (string apiToken, AddIpToWhitelistData addIpToWhitelistData = null)

Add an IP to a whitelist

## Add an IP to a whitelist  Adds IP addresses and ranges to your Sendbird application settings. Both currently added and any previously added IPs are granted API access. You can configure the IP whitelist under Settings > Security > Allowed IPs in the [Sendbird Dashboard](https://dashboard.sendbird.com).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-add-an-ip-to-a-whitelist

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class AddIpToWhitelistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var addIpToWhitelistData = new AddIpToWhitelistData(); // AddIpToWhitelistData |  (optional) 

            try
            {
                // Add an IP to a whitelist
                AddIpToWhitelistResponse result = apiInstance.AddIpToWhitelist(apiToken, addIpToWhitelistData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.AddIpToWhitelist: " + e.Message );
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
 **apiToken** | **string**|  | 
 **addIpToWhitelistData** | [**AddIpToWhitelistData**](AddIpToWhitelistData.md)|  | [optional] 

### Return type

[**AddIpToWhitelistResponse**](AddIpToWhitelistResponse.md)

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


## BanUsersInChannelsWithCustomChannelType

> Object BanUsersInChannelsWithCustomChannelType (string apiToken, string customType, BanUsersInChannelsWithCustomChannelTypeData banUsersInChannelsWithCustomChannelTypeData = null)

Ban users in channels with a custom channel type

## Ban specified users in channels with a custom channel type at once.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class BanUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var banUsersInChannelsWithCustomChannelTypeData = new BanUsersInChannelsWithCustomChannelTypeData(); // BanUsersInChannelsWithCustomChannelTypeData |  (optional) 

            try
            {
                // Ban users in channels with a custom channel type
                Object result = apiInstance.BanUsersInChannelsWithCustomChannelType(apiToken, customType, banUsersInChannelsWithCustomChannelTypeData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.BanUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **banUsersInChannelsWithCustomChannelTypeData** | [**BanUsersInChannelsWithCustomChannelTypeData**](BanUsersInChannelsWithCustomChannelTypeData.md)|  | [optional] 

### Return type

**Object**

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


## DeleteAllowedIpsFromWhitelist

> DeleteAllowedIpsFromWhitelistResponse DeleteAllowedIpsFromWhitelist (string apiToken, List<string> ipWhitelistAddresses)

Delete allowed IPs from a whitelist

## Delete allowed IPs from a whitelist  Deletes allowed IPs from the whitelist by specifying their IP addresses or ranges. You can configure the IP whitelist under Settings > Security > Allowed IPs in the [Sendbird Dashboard](https://dashboard.sendbird.com).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-delete-allowed-ips-from-a-whitelist

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteAllowedIpsFromWhitelistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var ipWhitelistAddresses = new List<string>(); // List<string> | 

            try
            {
                // Delete allowed IPs from a whitelist
                DeleteAllowedIpsFromWhitelistResponse result = apiInstance.DeleteAllowedIpsFromWhitelist(apiToken, ipWhitelistAddresses);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteAllowedIpsFromWhitelist: " + e.Message );
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
 **apiToken** | **string**|  | 
 **ipWhitelistAddresses** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

[**DeleteAllowedIpsFromWhitelistResponse**](DeleteAllowedIpsFromWhitelistResponse.md)

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


## DeleteApnsCertificateById

> DeleteApnsCertificateByIdResponse DeleteApnsCertificateById (string apiToken, string providerId)

Delete an APNs certificate

## Delete an APNs certificate  Deletes a specific APNs certificate.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-delete-an-apns-certificate - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class DeleteApnsCertificateByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var providerId = providerId_example;  // string | 

            try
            {
                // Delete an APNs certificate
                DeleteApnsCertificateByIdResponse result = apiInstance.DeleteApnsCertificateById(apiToken, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.DeleteApnsCertificateById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **providerId** | **string**|  | 

### Return type

[**DeleteApnsCertificateByIdResponse**](DeleteApnsCertificateByIdResponse.md)

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


## GenerateSecondaryApiToken

> GenerateSecondaryApiTokenResponse GenerateSecondaryApiToken (string apiToken, GenerateSecondaryApiTokenData generateSecondaryApiTokenData = null)

Generate a secondary API token

## Generate a secondary API token  Generates a new secondary API token.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-generate-a-secondary-api-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class GenerateSecondaryApiTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var generateSecondaryApiTokenData = new GenerateSecondaryApiTokenData(); // GenerateSecondaryApiTokenData |  (optional) 

            try
            {
                // Generate a secondary API token
                GenerateSecondaryApiTokenResponse result = apiInstance.GenerateSecondaryApiToken(apiToken, generateSecondaryApiTokenData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.GenerateSecondaryApiToken: " + e.Message );
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
 **apiToken** | **string**|  | 
 **generateSecondaryApiTokenData** | [**GenerateSecondaryApiTokenData**](GenerateSecondaryApiTokenData.md)|  | [optional] 

### Return type

[**GenerateSecondaryApiTokenResponse**](GenerateSecondaryApiTokenResponse.md)

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


## ListBannedUsersInChannelsWithCustomChannelType

> CustomTypeListBannedUsersResponse ListBannedUsersInChannelsWithCustomChannelType (string apiToken, string customType, string token = null, int? limit = null)

List banned users in channels with a custom channel type

## Retrieves a list of users banned from channels with the specified custom channel type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListBannedUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List banned users in channels with a custom channel type
                CustomTypeListBannedUsersResponse result = apiInstance.ListBannedUsersInChannelsWithCustomChannelType(apiToken, customType, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListBannedUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**CustomTypeListBannedUsersResponse**](CustomTypeListBannedUsersResponse.md)

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


## ListMutedUsersInChannelsWithCustomChannelType

> InlineResponse200 ListMutedUsersInChannelsWithCustomChannelType (string apiToken, string customType, string token = null, int? limit = null)

List muted users in channels with a custom channel type

## Retrieves a list of the muted users in channels with a custom channel type.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListMutedUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List muted users in channels with a custom channel type
                InlineResponse200 result = apiInstance.ListMutedUsersInChannelsWithCustomChannelType(apiToken, customType, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListMutedUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

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


## ListPushConfigurations

> ListPushConfigurationsResponse ListPushConfigurations (string apiToken, string pushType)

List push configurations

## List push configurations  Retrieves a list of an application's registered push configurations.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-list-push-configurations - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListPushConfigurationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var pushType = pushType_example;  // string | 

            try
            {
                // List push configurations
                ListPushConfigurationsResponse result = apiInstance.ListPushConfigurations(apiToken, pushType);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListPushConfigurations: " + e.Message );
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
 **apiToken** | **string**|  | 
 **pushType** | **string**|  | 

### Return type

[**ListPushConfigurationsResponse**](ListPushConfigurationsResponse.md)

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


## ListPushNotificationContentTemplates

> ListPushNotificationContentTemplatesResponse ListPushNotificationContentTemplates (string apiToken)

List push notification content templates

## List push notification content templates  Retrieves a list of push notification content templates of an application.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-list-push-notification-content-templates

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListPushNotificationContentTemplatesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // List push notification content templates
                ListPushNotificationContentTemplatesResponse result = apiInstance.ListPushNotificationContentTemplates(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListPushNotificationContentTemplates: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**ListPushNotificationContentTemplatesResponse**](ListPushNotificationContentTemplatesResponse.md)

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


## ListSecondaryApiTokens

> ListSecondaryApiTokensResponse ListSecondaryApiTokens (string apiToken)

List secondary API tokens

## List secondary API tokens  Retrieves a list of secondary API tokens.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-list-secondary-api-tokens

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListSecondaryApiTokensExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // List secondary API tokens
                ListSecondaryApiTokensResponse result = apiInstance.ListSecondaryApiTokens(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ListSecondaryApiTokens: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**ListSecondaryApiTokensResponse**](ListSecondaryApiTokensResponse.md)

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


## MuteUsersInChannelsWithCustomChannelType

> Object MuteUsersInChannelsWithCustomChannelType (string apiToken, string customType, MuteUsersInChannelsWithCustomChannelTypeData muteUsersInChannelsWithCustomChannelTypeData = null)

Mute users in channels with a custom channel type

## Mutes specified users in channels with a custom channel type at once.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class MuteUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var muteUsersInChannelsWithCustomChannelTypeData = new MuteUsersInChannelsWithCustomChannelTypeData(); // MuteUsersInChannelsWithCustomChannelTypeData |  (optional) 

            try
            {
                // Mute users in channels with a custom channel type
                Object result = apiInstance.MuteUsersInChannelsWithCustomChannelType(apiToken, customType, muteUsersInChannelsWithCustomChannelTypeData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.MuteUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **muteUsersInChannelsWithCustomChannelTypeData** | [**MuteUsersInChannelsWithCustomChannelTypeData**](MuteUsersInChannelsWithCustomChannelTypeData.md)|  | [optional] 

### Return type

**Object**

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


## RemovePushConfigurationById

> RemovePushConfigurationByIdResponse RemovePushConfigurationById (string apiToken, string pushType, string providerId)

Remove a push configuration

## Remove a push configuration  Removes a specific push configuration from an application. The type of a push configuration is either `fcm`, `huawei`, or `apns`.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-remove-a-push-configuration - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RemovePushConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var pushType = pushType_example;  // string | 
            var providerId = providerId_example;  // string | 

            try
            {
                // Remove a push configuration
                RemovePushConfigurationByIdResponse result = apiInstance.RemovePushConfigurationById(apiToken, pushType, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.RemovePushConfigurationById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **pushType** | **string**|  | 
 **providerId** | **string**|  | 

### Return type

[**RemovePushConfigurationByIdResponse**](RemovePushConfigurationByIdResponse.md)

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


## RetrieveIpWhitelist

> RetrieveIpWhitelistResponse RetrieveIpWhitelist (string apiToken)

Retrieve an IP whitelist

## Retrieve an IP whitelist  Retrieves a list of all the IP ranges and addresses that have access to your Sendbird application. This list is called an IP whitelist and its addresses are granted API access when the IP whitelist API enables [CIDR](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing) notations.  If you specify which IP addresses or ranges to include in the whitelist, any unlisted foreign IP addresses will be denied access. If you don't specify any IP address or range to include in the whitelist, all IP addresses will be granted API access. You can configure the IP whitelist under Settings > Security > Allowed IPs in the [Sendbird Dashboard](https://dashboard.sendbird.com).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-retrieve-an-ip-whitelist

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RetrieveIpWhitelistExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // Retrieve an IP whitelist
                RetrieveIpWhitelistResponse result = apiInstance.RetrieveIpWhitelist(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.RetrieveIpWhitelist: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**RetrieveIpWhitelistResponse**](RetrieveIpWhitelistResponse.md)

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


## RevokeSecondaryApiTokenByToken

> RevokeSecondaryApiTokenByTokenResponse RevokeSecondaryApiTokenByToken (string apiToken, string apiToken2)

Revoke a secondary API token

## Revoke a secondary API token  Revokes a secondary API token.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-revoke-a-secondary-api-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RevokeSecondaryApiTokenByTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var apiToken2 = apiToken_example;  // string | 

            try
            {
                // Revoke a secondary API token
                RevokeSecondaryApiTokenByTokenResponse result = apiInstance.RevokeSecondaryApiTokenByToken(apiToken, apiToken2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.RevokeSecondaryApiTokenByToken: " + e.Message );
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
 **apiToken** | **string**|  | 
 **apiToken2** | **string**|  | 

### Return type

[**RevokeSecondaryApiTokenByTokenResponse**](RevokeSecondaryApiTokenByTokenResponse.md)

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


## SetDomainFilter

> SendBirdChannelResponse SetDomainFilter (string apiToken, string customType, SetDomainFilterData setDomainFilterData = null)

Message moderation

## 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class SetDomainFilterExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var setDomainFilterData = new SetDomainFilterData(); // SetDomainFilterData |  (optional) 

            try
            {
                // Message moderation
                SendBirdChannelResponse result = apiInstance.SetDomainFilter(apiToken, customType, setDomainFilterData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.SetDomainFilter: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **setDomainFilterData** | [**SetDomainFilterData**](SetDomainFilterData.md)|  | [optional] 

### Return type

[**SendBirdChannelResponse**](SendBirdChannelResponse.md)

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


## UnbanUsersInChannelsWithCustomChannelType

> Object UnbanUsersInChannelsWithCustomChannelType (string apiToken, string customType, List<string> userIds)

Unban users in channels with a custom channel type

## Unban specified users in channels with a custom channel type at once.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnbanUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var userIds = new List<string>(); // List<string> | 

            try
            {
                // Unban users in channels with a custom channel type
                Object result = apiInstance.UnbanUsersInChannelsWithCustomChannelType(apiToken, customType, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UnbanUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **userIds** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

**Object**

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


## UnmuteUsersInChannelsWithCustomChannelType

> Object UnmuteUsersInChannelsWithCustomChannelType (string apiToken, string customType, List<string> userIds)

Unmute users in channels with a custom channel type

## Unmute specified users in channels with a custom channel type at once.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UnmuteUsersInChannelsWithCustomChannelTypeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var customType = customType_example;  // string | 
            var userIds = new List<string>(); // List<string> | 

            try
            {
                // Unmute users in channels with a custom channel type
                Object result = apiInstance.UnmuteUsersInChannelsWithCustomChannelType(apiToken, customType, userIds);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UnmuteUsersInChannelsWithCustomChannelType: " + e.Message );
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
 **apiToken** | **string**|  | 
 **customType** | **string**|  | 
 **userIds** | [**List&lt;string&gt;**](string.md)|  | 

### Return type

**Object**

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


## UpdateApnsPushConfigurationById

> UpdateApnsPushConfigurationByIdResponse UpdateApnsPushConfigurationById (string apiToken, string providerId, UpdateApnsPushConfigurationByIdData updateApnsPushConfigurationByIdData = null)

Update an APNs push configuration

## Update an APNs push configuration  Updates a specific APNs (Apple Push Notification service) push configuration for your client app. You can also register the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  > __Note__: If your HTTP request body contains a [.p12](https://sendbird.com/docs/chat/v3/ios/guides/push-notifications#2-step-3-export-a-p12-file-and-upload-to-sendbird-dashboard) certificate file to upload to Sendbird server, you should send a [Multipart request](https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api#2-headers-3-multipart-requests) .  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-an-apns-push-configuration - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateApnsPushConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var providerId = providerId_example;  // string | 
            var updateApnsPushConfigurationByIdData = new UpdateApnsPushConfigurationByIdData(); // UpdateApnsPushConfigurationByIdData |  (optional) 

            try
            {
                // Update an APNs push configuration
                UpdateApnsPushConfigurationByIdResponse result = apiInstance.UpdateApnsPushConfigurationById(apiToken, providerId, updateApnsPushConfigurationByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateApnsPushConfigurationById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **providerId** | **string**|  | 
 **updateApnsPushConfigurationByIdData** | [**UpdateApnsPushConfigurationByIdData**](UpdateApnsPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**UpdateApnsPushConfigurationByIdResponse**](UpdateApnsPushConfigurationByIdResponse.md)

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


## UpdateDefaultChannelInvitationPreference

> UpdateDefaultChannelInvitationPreferenceResponse UpdateDefaultChannelInvitationPreference (string apiToken, UpdateDefaultChannelInvitationPreferenceData updateDefaultChannelInvitationPreferenceData = null)

Update default channel invitation preference

## Update default channel invitation preference  Updates the default channel invitation preference of an application.  > __Note__: Using the [update channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-update-channel-invitation-preference) action, you can update the value of a specific user's channel invitation preference, which can be set individually by user.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-default-channel-invitation-preference

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateDefaultChannelInvitationPreferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var updateDefaultChannelInvitationPreferenceData = new UpdateDefaultChannelInvitationPreferenceData(); // UpdateDefaultChannelInvitationPreferenceData |  (optional) 

            try
            {
                // Update default channel invitation preference
                UpdateDefaultChannelInvitationPreferenceResponse result = apiInstance.UpdateDefaultChannelInvitationPreference(apiToken, updateDefaultChannelInvitationPreferenceData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateDefaultChannelInvitationPreference: " + e.Message );
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
 **apiToken** | **string**|  | 
 **updateDefaultChannelInvitationPreferenceData** | [**UpdateDefaultChannelInvitationPreferenceData**](UpdateDefaultChannelInvitationPreferenceData.md)|  | [optional] 

### Return type

[**UpdateDefaultChannelInvitationPreferenceResponse**](UpdateDefaultChannelInvitationPreferenceResponse.md)

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


## UpdateFcmPushConfigurationById

> UpdateFcmPushConfigurationByIdResponse UpdateFcmPushConfigurationById (string apiToken, string providerId, UpdateFcmPushConfigurationByIdData updateFcmPushConfigurationByIdData = null)

Update a FCM push configuration

## Update a FCM push configuration  Updates a specific FCM (Firebase Cloud Messaging) push configuration for your client app. You can also update the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-a-fcm-push-configuration - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateFcmPushConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var providerId = providerId_example;  // string | 
            var updateFcmPushConfigurationByIdData = new UpdateFcmPushConfigurationByIdData(); // UpdateFcmPushConfigurationByIdData |  (optional) 

            try
            {
                // Update a FCM push configuration
                UpdateFcmPushConfigurationByIdResponse result = apiInstance.UpdateFcmPushConfigurationById(apiToken, providerId, updateFcmPushConfigurationByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateFcmPushConfigurationById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **providerId** | **string**|  | 
 **updateFcmPushConfigurationByIdData** | [**UpdateFcmPushConfigurationByIdData**](UpdateFcmPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**UpdateFcmPushConfigurationByIdResponse**](UpdateFcmPushConfigurationByIdResponse.md)

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


## UpdateHmsPushConfigurationById

> UpdateHmsPushConfigurationByIdResponse UpdateHmsPushConfigurationById (string apiToken, string providerId, UpdateHmsPushConfigurationByIdData updateHmsPushConfigurationByIdData = null)

Update an HMS push configuration

## Update an HMS push configuration  Updates a specific HMS (Huawei Mobile Services) push configuration for your client app. You can also update the configurations in your [dashboard](https://dashboard.sendbird.com) under Settings > Application > Notifications.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-an-hms-push-configuration - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdateHmsPushConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var providerId = providerId_example;  // string | 
            var updateHmsPushConfigurationByIdData = new UpdateHmsPushConfigurationByIdData(); // UpdateHmsPushConfigurationByIdData |  (optional) 

            try
            {
                // Update an HMS push configuration
                UpdateHmsPushConfigurationByIdResponse result = apiInstance.UpdateHmsPushConfigurationById(apiToken, providerId, updateHmsPushConfigurationByIdData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdateHmsPushConfigurationById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **providerId** | **string**|  | 
 **updateHmsPushConfigurationByIdData** | [**UpdateHmsPushConfigurationByIdData**](UpdateHmsPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**UpdateHmsPushConfigurationByIdResponse**](UpdateHmsPushConfigurationByIdResponse.md)

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


## UpdatePushNotificationContentTemplate

> UpdatePushNotificationContentTemplateResponse UpdatePushNotificationContentTemplate (string apiToken, string templateName, UpdatePushNotificationContentTemplateData updatePushNotificationContentTemplateData = null)

Update a push notification content template

## Update a push notification content template  Updates a specific push notification content template of an application. The name of a content template is either `default` or `alternative`.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-update-a-push-notification-content-template - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class UpdatePushNotificationContentTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var templateName = templateName_example;  // string | 
            var updatePushNotificationContentTemplateData = new UpdatePushNotificationContentTemplateData(); // UpdatePushNotificationContentTemplateData |  (optional) 

            try
            {
                // Update a push notification content template
                UpdatePushNotificationContentTemplateResponse result = apiInstance.UpdatePushNotificationContentTemplate(apiToken, templateName, updatePushNotificationContentTemplateData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.UpdatePushNotificationContentTemplate: " + e.Message );
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
 **apiToken** | **string**|  | 
 **templateName** | **string**|  | 
 **updatePushNotificationContentTemplateData** | [**UpdatePushNotificationContentTemplateData**](UpdatePushNotificationContentTemplateData.md)|  | [optional] 

### Return type

[**UpdatePushNotificationContentTemplateResponse**](UpdatePushNotificationContentTemplateResponse.md)

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


## ViewDefaultChannelInvitationPreference

> ViewDefaultChannelInvitationPreferenceResponse ViewDefaultChannelInvitationPreference (string apiToken)

View default channel invitation preference

## View default channel invitation preference  Retrieves the default channel invitation preference of an application.  > __Note__: Using the [view channel invitation preference](https://sendbird.com/docs/chat/v3/platform-api/guides/user#2-view-channel-invitation-preference) action, you can retrieve the value of a specific user's channel invitation preference, which can be set individually by user.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-default-channel-invitation-preference

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewDefaultChannelInvitationPreferenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 

            try
            {
                // View default channel invitation preference
                ViewDefaultChannelInvitationPreferenceResponse result = apiInstance.ViewDefaultChannelInvitationPreference(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewDefaultChannelInvitationPreference: " + e.Message );
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
 **apiToken** | **string**|  | 

### Return type

[**ViewDefaultChannelInvitationPreferenceResponse**](ViewDefaultChannelInvitationPreferenceResponse.md)

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


## ViewPushConfigurationById

> ViewPushConfigurationByIdResponse ViewPushConfigurationById (string apiToken, string pushType, string providerId)

View a push configuration

## View a push configuration  Retrieves a specific push configuration of an application. The type of a push configuration is either `fcm`, `huawei`, or `apns`.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-a-push-configuration - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewPushConfigurationByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var pushType = pushType_example;  // string | 
            var providerId = providerId_example;  // string | 

            try
            {
                // View a push configuration
                ViewPushConfigurationByIdResponse result = apiInstance.ViewPushConfigurationById(apiToken, pushType, providerId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewPushConfigurationById: " + e.Message );
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
 **apiToken** | **string**|  | 
 **pushType** | **string**|  | 
 **providerId** | **string**|  | 

### Return type

[**ViewPushConfigurationByIdResponse**](ViewPushConfigurationByIdResponse.md)

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


## ViewPushNotificationContentTemplate

> ViewPushNotificationContentTemplateResponse ViewPushNotificationContentTemplate (string apiToken, string templateName)

View a push notification content template

## View a push notification content template  Retrieves information on a specific push notification content templates of an application. The name of a content template is either `default` or `alternative`.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-a-push-notification-content-template - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewPushNotificationContentTemplateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var templateName = templateName_example;  // string | 

            try
            {
                // View a push notification content template
                ViewPushNotificationContentTemplateResponse result = apiInstance.ViewPushNotificationContentTemplate(apiToken, templateName);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewPushNotificationContentTemplate: " + e.Message );
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
 **apiToken** | **string**|  | 
 **templateName** | **string**|  | 

### Return type

[**ViewPushNotificationContentTemplateResponse**](ViewPushNotificationContentTemplateResponse.md)

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


## ViewSecondaryApiTokenByToken

> ViewSecondaryApiTokenByTokenResponse ViewSecondaryApiTokenByToken (string apiToken, string apiToken2)

View a secondary API token

## View a secondary API token  Retrieves the information on a secondary API token.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-a-secondary-api-token

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewSecondaryApiTokenByTokenExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var apiToken2 = apiToken_example;  // string | 

            try
            {
                // View a secondary API token
                ViewSecondaryApiTokenByTokenResponse result = apiInstance.ViewSecondaryApiTokenByToken(apiToken, apiToken2);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewSecondaryApiTokenByToken: " + e.Message );
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
 **apiToken** | **string**|  | 
 **apiToken2** | **string**|  | 

### Return type

[**ViewSecondaryApiTokenByTokenResponse**](ViewSecondaryApiTokenByTokenResponse.md)

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

