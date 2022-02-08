# sendbird_platform_sdk.Api.ApplicationApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddApnsPushConfiguration**](ApplicationApi.md#addapnspushconfiguration) | **POST** /v3/applications/push/apns | Add an APNs push configuration
[**AddFcmPushConfiguration**](ApplicationApi.md#addfcmpushconfiguration) | **POST** /v3/applications/push/fcm | Add a FCM push configuration
[**AddHmsPushConfiguration**](ApplicationApi.md#addhmspushconfiguration) | **POST** /v3/applications/push/hms | Add an HMS push configuration
[**AddIpToWhitelist**](ApplicationApi.md#addiptowhitelist) | **PUT** /v3/applications/settings/ip_whitelist | Add an IP to a whitelist
[**DeleteAllowedIpsFromWhitelist**](ApplicationApi.md#deleteallowedipsfromwhitelist) | **DELETE** /v3/applications/settings/ip_whitelist | Delete allowed IPs from a whitelist
[**DeleteApnsCertificateById**](ApplicationApi.md#deleteapnscertificatebyid) | **DELETE** /v3/applications/push/apns/cert/{provider_id} | Delete an APNs certificate
[**GenerateSecondaryApiToken**](ApplicationApi.md#generatesecondaryapitoken) | **POST** /v3/applications/api_tokens | Generate a secondary API token
[**ListPushConfigurations**](ApplicationApi.md#listpushconfigurations) | **GET** /v3/applications/push/{push_type} | List push configurations
[**ListPushNotificationContentTemplates**](ApplicationApi.md#listpushnotificationcontenttemplates) | **GET** /v3/applications/push/message_templates | List push notification content templates
[**ListSecondaryApiTokens**](ApplicationApi.md#listsecondaryapitokens) | **GET** /v3/applications/api_tokens | List secondary API tokens
[**RemovePushConfigurationById**](ApplicationApi.md#removepushconfigurationbyid) | **DELETE** /v3/applications/push/{push_type}/{provider_id} | Remove a push configuration
[**RetrieveIpWhitelist**](ApplicationApi.md#retrieveipwhitelist) | **GET** /v3/applications/settings/ip_whitelist | Retrieve an IP whitelist
[**RevokeSecondaryApiTokenByToken**](ApplicationApi.md#revokesecondaryapitokenbytoken) | **DELETE** /v3/applications/api_tokens/{api_token} | Revoke a secondary API token
[**UpdateApnsPushConfigurationById**](ApplicationApi.md#updateapnspushconfigurationbyid) | **PUT** /v3/applications/push/apns/{provider_id} | Update an APNs push configuration
[**UpdateDefaultChannelInvitationPreference**](ApplicationApi.md#updatedefaultchannelinvitationpreference) | **PUT** /v3/applications/default_channel_invitation_preference | Update default channel invitation preference
[**UpdateFcmPushConfigurationById**](ApplicationApi.md#updatefcmpushconfigurationbyid) | **PUT** /v3/applications/push/fcm/{provider_id} | Update a FCM push configuration
[**UpdateHmsPushConfigurationById**](ApplicationApi.md#updatehmspushconfigurationbyid) | **PUT** /v3/applications/push/hms/{provider_id} | Update an HMS push configuration
[**UpdatePushNotificationContentTemplate**](ApplicationApi.md#updatepushnotificationcontenttemplate) | **PUT** /v3/applications/push/message_templates/{template_name} | Update a push notification content template
[**ViewDefaultChannelInvitationPreference**](ApplicationApi.md#viewdefaultchannelinvitationpreference) | **GET** /v3/applications/default_channel_invitation_preference | View default channel invitation preference
[**ViewNumberOfConcurrentConnections**](ApplicationApi.md#viewnumberofconcurrentconnections) | **GET** /v3/applications/ccu | View number of concurrent connections
[**ViewNumberOfDailyActiveUsers**](ApplicationApi.md#viewnumberofdailyactiveusers) | **GET** /v3/applications/dau | View number of daily active users
[**ViewNumberOfMonthlyActiveUsers**](ApplicationApi.md#viewnumberofmonthlyactiveusers) | **GET** /v3/applications/mau | View number of monthly active users
[**ViewNumberOfPeakConnections**](ApplicationApi.md#viewnumberofpeakconnections) | **GET** /v3/applications/peak_connections | View number of peak connections
[**ViewPushConfigurationById**](ApplicationApi.md#viewpushconfigurationbyid) | **GET** /v3/applications/push/{push_type}/{provider_id} | View a push configuration
[**ViewPushNotificationContentTemplate**](ApplicationApi.md#viewpushnotificationcontenttemplate) | **GET** /v3/applications/push/message_templates/{template_name} | View a push notification content template
[**ViewSecondaryApiTokenByToken**](ApplicationApi.md#viewsecondaryapitokenbytoken) | **GET** /v3/applications/api_tokens/{api_token} | View a secondary API token



## AddApnsPushConfiguration

> InlineResponse2003 AddApnsPushConfiguration (string apiToken = null, AddApnsPushConfigurationData addApnsPushConfigurationData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addApnsPushConfigurationData = new AddApnsPushConfigurationData(); // AddApnsPushConfigurationData |  (optional) 

            try
            {
                // Add an APNs push configuration
                InlineResponse2003 result = apiInstance.AddApnsPushConfiguration(apiToken, addApnsPushConfigurationData);
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
 **apiToken** | **string**|  | [optional] 
 **addApnsPushConfigurationData** | [**AddApnsPushConfigurationData**](AddApnsPushConfigurationData.md)|  | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

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

> InlineResponse2001 AddFcmPushConfiguration (string apiToken = null, AddFcmPushConfigurationData addFcmPushConfigurationData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addFcmPushConfigurationData = new AddFcmPushConfigurationData(); // AddFcmPushConfigurationData |  (optional) 

            try
            {
                // Add a FCM push configuration
                InlineResponse2001 result = apiInstance.AddFcmPushConfiguration(apiToken, addFcmPushConfigurationData);
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
 **apiToken** | **string**|  | [optional] 
 **addFcmPushConfigurationData** | [**AddFcmPushConfigurationData**](AddFcmPushConfigurationData.md)|  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

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

> InlineResponse2002 AddHmsPushConfiguration (string apiToken = null, AddHmsPushConfigurationData addHmsPushConfigurationData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addHmsPushConfigurationData = new AddHmsPushConfigurationData(); // AddHmsPushConfigurationData |  (optional) 

            try
            {
                // Add an HMS push configuration
                InlineResponse2002 result = apiInstance.AddHmsPushConfiguration(apiToken, addHmsPushConfigurationData);
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
 **apiToken** | **string**|  | [optional] 
 **addHmsPushConfigurationData** | [**AddHmsPushConfigurationData**](AddHmsPushConfigurationData.md)|  | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

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

> InlineResponse2006 AddIpToWhitelist (string apiToken = null, AddIpToWhitelistData addIpToWhitelistData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var addIpToWhitelistData = new AddIpToWhitelistData(); // AddIpToWhitelistData |  (optional) 

            try
            {
                // Add an IP to a whitelist
                InlineResponse2006 result = apiInstance.AddIpToWhitelist(apiToken, addIpToWhitelistData);
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
 **apiToken** | **string**|  | [optional] 
 **addIpToWhitelistData** | [**AddIpToWhitelistData**](AddIpToWhitelistData.md)|  | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

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

> InlineResponse2006 DeleteAllowedIpsFromWhitelist (List<string> ipWhitelistAddresses, string apiToken = null)

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
            var ipWhitelistAddresses = new List<string>(); // List<string> | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete allowed IPs from a whitelist
                InlineResponse2006 result = apiInstance.DeleteAllowedIpsFromWhitelist(ipWhitelistAddresses, apiToken);
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
 **ipWhitelistAddresses** | [**List&lt;string&gt;**](string.md)|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

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

> InlineResponse20013 DeleteApnsCertificateById (string providerId, string apiToken = null)

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
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Delete an APNs certificate
                InlineResponse20013 result = apiInstance.DeleteApnsCertificateById(providerId, apiToken);
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
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

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

> InlineResponse2007 GenerateSecondaryApiToken (string apiToken = null, GenerateSecondaryApiTokenData generateSecondaryApiTokenData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var generateSecondaryApiTokenData = new GenerateSecondaryApiTokenData(); // GenerateSecondaryApiTokenData |  (optional) 

            try
            {
                // Generate a secondary API token
                InlineResponse2007 result = apiInstance.GenerateSecondaryApiToken(apiToken, generateSecondaryApiTokenData);
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
 **apiToken** | **string**|  | [optional] 
 **generateSecondaryApiTokenData** | [**GenerateSecondaryApiTokenData**](GenerateSecondaryApiTokenData.md)|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

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


## ListPushConfigurations

> InlineResponse20012 ListPushConfigurations (string pushType, string apiToken = null)

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
            var pushType = pushType_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List push configurations
                InlineResponse20012 result = apiInstance.ListPushConfigurations(pushType, apiToken);
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
 **pushType** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

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

> InlineResponse2004 ListPushNotificationContentTemplates (string apiToken = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List push notification content templates
                InlineResponse2004 result = apiInstance.ListPushNotificationContentTemplates(apiToken);
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
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

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

> InlineResponse2008 ListSecondaryApiTokens (string apiToken = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // List secondary API tokens
                InlineResponse2008 result = apiInstance.ListSecondaryApiTokens(apiToken);
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
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

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


## RemovePushConfigurationById

> InlineResponse20013 RemovePushConfigurationById (string pushType, string providerId, string apiToken = null)

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
            var pushType = pushType_example;  // string | 
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Remove a push configuration
                InlineResponse20013 result = apiInstance.RemovePushConfigurationById(pushType, providerId, apiToken);
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
 **pushType** | **string**|  | 
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

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

> InlineResponse2006 RetrieveIpWhitelist (string apiToken = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Retrieve an IP whitelist
                InlineResponse2006 result = apiInstance.RetrieveIpWhitelist(apiToken);
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
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

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

> InlineResponse2007 RevokeSecondaryApiTokenByToken (string apiToken2, string apiToken = null)

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
            var apiToken2 = apiToken_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // Revoke a secondary API token
                InlineResponse2007 result = apiInstance.RevokeSecondaryApiTokenByToken(apiToken2, apiToken);
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
 **apiToken2** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

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

> InlineResponse20014 UpdateApnsPushConfigurationById (string providerId, string apiToken = null, UpdateApnsPushConfigurationByIdData updateApnsPushConfigurationByIdData = null)

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
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateApnsPushConfigurationByIdData = new UpdateApnsPushConfigurationByIdData(); // UpdateApnsPushConfigurationByIdData |  (optional) 

            try
            {
                // Update an APNs push configuration
                InlineResponse20014 result = apiInstance.UpdateApnsPushConfigurationById(providerId, apiToken, updateApnsPushConfigurationByIdData);
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
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateApnsPushConfigurationByIdData** | [**UpdateApnsPushConfigurationByIdData**](UpdateApnsPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

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

> InlineResponse2005 UpdateDefaultChannelInvitationPreference (string apiToken = null, UpdateDefaultChannelInvitationPreferenceData updateDefaultChannelInvitationPreferenceData = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateDefaultChannelInvitationPreferenceData = new UpdateDefaultChannelInvitationPreferenceData(); // UpdateDefaultChannelInvitationPreferenceData |  (optional) 

            try
            {
                // Update default channel invitation preference
                InlineResponse2005 result = apiInstance.UpdateDefaultChannelInvitationPreference(apiToken, updateDefaultChannelInvitationPreferenceData);
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
 **apiToken** | **string**|  | [optional] 
 **updateDefaultChannelInvitationPreferenceData** | [**UpdateDefaultChannelInvitationPreferenceData**](UpdateDefaultChannelInvitationPreferenceData.md)|  | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

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

> InlineResponse20014 UpdateFcmPushConfigurationById (string providerId, string apiToken = null, UpdateFcmPushConfigurationByIdData updateFcmPushConfigurationByIdData = null)

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
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateFcmPushConfigurationByIdData = new UpdateFcmPushConfigurationByIdData(); // UpdateFcmPushConfigurationByIdData |  (optional) 

            try
            {
                // Update a FCM push configuration
                InlineResponse20014 result = apiInstance.UpdateFcmPushConfigurationById(providerId, apiToken, updateFcmPushConfigurationByIdData);
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
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateFcmPushConfigurationByIdData** | [**UpdateFcmPushConfigurationByIdData**](UpdateFcmPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

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

> InlineResponse20014 UpdateHmsPushConfigurationById (string providerId, string apiToken = null, UpdateHmsPushConfigurationByIdData updateHmsPushConfigurationByIdData = null)

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
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updateHmsPushConfigurationByIdData = new UpdateHmsPushConfigurationByIdData(); // UpdateHmsPushConfigurationByIdData |  (optional) 

            try
            {
                // Update an HMS push configuration
                InlineResponse20014 result = apiInstance.UpdateHmsPushConfigurationById(providerId, apiToken, updateHmsPushConfigurationByIdData);
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
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updateHmsPushConfigurationByIdData** | [**UpdateHmsPushConfigurationByIdData**](UpdateHmsPushConfigurationByIdData.md)|  | [optional] 

### Return type

[**InlineResponse20014**](InlineResponse20014.md)

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

> InlineResponse20015 UpdatePushNotificationContentTemplate (string templateName, string apiToken = null, UpdatePushNotificationContentTemplateData updatePushNotificationContentTemplateData = null)

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
            var templateName = templateName_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var updatePushNotificationContentTemplateData = new UpdatePushNotificationContentTemplateData(); // UpdatePushNotificationContentTemplateData |  (optional) 

            try
            {
                // Update a push notification content template
                InlineResponse20015 result = apiInstance.UpdatePushNotificationContentTemplate(templateName, apiToken, updatePushNotificationContentTemplateData);
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
 **templateName** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **updatePushNotificationContentTemplateData** | [**UpdatePushNotificationContentTemplateData**](UpdatePushNotificationContentTemplateData.md)|  | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

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

> InlineResponse2005 ViewDefaultChannelInvitationPreference (string apiToken = null)

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
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View default channel invitation preference
                InlineResponse2005 result = apiInstance.ViewDefaultChannelInvitationPreference(apiToken);
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
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

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


## ViewNumberOfConcurrentConnections

> InlineResponse200 ViewNumberOfConcurrentConnections (string apiToken = null)

View number of concurrent connections

## View number of concurrent connections  Retrieves the number of devices and opened browser tabs which are currently connected to Sendbird server.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-concurrent-connections

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfConcurrentConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View number of concurrent connections
                InlineResponse200 result = apiInstance.ViewNumberOfConcurrentConnections(apiToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewNumberOfConcurrentConnections: " + e.Message );
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


## ViewNumberOfDailyActiveUsers

> InlineResponse20011 ViewNumberOfDailyActiveUsers (string apiToken = null, string date = null)

View number of daily active users

## View number of daily active users  Retrieves the number of daily active users of the application (DAU).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-daily-active-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfDailyActiveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var date = date_example;  // string |  (optional) 

            try
            {
                // View number of daily active users
                InlineResponse20011 result = apiInstance.ViewNumberOfDailyActiveUsers(apiToken, date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewNumberOfDailyActiveUsers: " + e.Message );
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
 **date** | **string**|  | [optional] 

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

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


## ViewNumberOfMonthlyActiveUsers

> InlineResponse20010 ViewNumberOfMonthlyActiveUsers (string apiToken = null, string date = null)

View number of monthly active users

## View number of monthly active users  Retrieves the number of monthly active users of the application (MAU).  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-monthly-active-users - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfMonthlyActiveUsersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var date = date_example;  // string |  (optional) 

            try
            {
                // View number of monthly active users
                InlineResponse20010 result = apiInstance.ViewNumberOfMonthlyActiveUsers(apiToken, date);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewNumberOfMonthlyActiveUsers: " + e.Message );
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
 **date** | **string**|  | [optional] 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

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


## ViewNumberOfPeakConnections

> InlineResponse2009 ViewNumberOfPeakConnections (string timeDimension, int startYear, int startMonth, int endYear, int endMonth, string apiToken = null, int? startDay = null, int? endDay = null)

View number of peak connections

## View number of peak connections  Retrieves the number of concurrently connected devices to Sendbird server during the requested time period.  https://sendbird.com/docs/chat/v3/platform-api/guides/application#2-view-number-of-peak-connections - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewNumberOfPeakConnectionsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new ApplicationApi(Configuration.Default);
            var timeDimension = timeDimension_example;  // string | 
            var startYear = 56;  // int | 
            var startMonth = 56;  // int | 
            var endYear = 56;  // int | 
            var endMonth = 56;  // int | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var startDay = 56;  // int? |  (optional) 
            var endDay = 56;  // int? |  (optional) 

            try
            {
                // View number of peak connections
                InlineResponse2009 result = apiInstance.ViewNumberOfPeakConnections(timeDimension, startYear, startMonth, endYear, endMonth, apiToken, startDay, endDay);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ApplicationApi.ViewNumberOfPeakConnections: " + e.Message );
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
 **timeDimension** | **string**|  | 
 **startYear** | **int**|  | 
 **startMonth** | **int**|  | 
 **endYear** | **int**|  | 
 **endMonth** | **int**|  | 
 **apiToken** | **string**|  | [optional] 
 **startDay** | **int?**|  | [optional] 
 **endDay** | **int?**|  | [optional] 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

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

> InlineResponse20012 ViewPushConfigurationById (string pushType, string providerId, string apiToken = null)

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
            var pushType = pushType_example;  // string | 
            var providerId = providerId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a push configuration
                InlineResponse20012 result = apiInstance.ViewPushConfigurationById(pushType, providerId, apiToken);
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
 **pushType** | **string**|  | 
 **providerId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

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

> InlineResponse20015 ViewPushNotificationContentTemplate (string templateName, string apiToken = null)

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
            var templateName = templateName_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a push notification content template
                InlineResponse20015 result = apiInstance.ViewPushNotificationContentTemplate(templateName, apiToken);
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
 **templateName** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20015**](InlineResponse20015.md)

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

> InlineResponse2007 ViewSecondaryApiTokenByToken (string apiToken2, string apiToken = null)

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
            var apiToken2 = apiToken_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a secondary API token
                InlineResponse2007 result = apiInstance.ViewSecondaryApiTokenByToken(apiToken2, apiToken);
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
 **apiToken2** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

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

