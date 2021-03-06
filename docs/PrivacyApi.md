# sendbird_platform_sdk.Api.PrivacyApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelTheRegistrationOfGdprRequestById**](PrivacyApi.md#canceltheregistrationofgdprrequestbyid) | **DELETE** /v3/privacy/gdpr/{request_id} | Cancel the registration of a GDPR request
[**ListGdprRequests**](PrivacyApi.md#listgdprrequests) | **GET** /v3/privacy/gdpr | List GDPR requests
[**RegisterGdprRequest**](PrivacyApi.md#registergdprrequest) | **POST** /v3/privacy/gdpr | Register a GDPR request
[**ViewGdprRequestById**](PrivacyApi.md#viewgdprrequestbyid) | **GET** /v3/privacy/gdpr/{request_id} | View a GDPR request



## CancelTheRegistrationOfGdprRequestById

> void CancelTheRegistrationOfGdprRequestById (string apiToken, string requestId)

Cancel the registration of a GDPR request

## Cancel the registration of a GDPR request  Cancels the registration of a specific GDPR request.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-privacy#2-cancel-the-registration-of-a-gdpr-request - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class CancelTheRegistrationOfGdprRequestByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new PrivacyApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var requestId = "requestId_example";  // string | 

            try
            {
                // Cancel the registration of a GDPR request
                apiInstance.CancelTheRegistrationOfGdprRequestById(apiToken, requestId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PrivacyApi.CancelTheRegistrationOfGdprRequestById: " + e.Message );
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
 **requestId** | **string**|  | 

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


## ListGdprRequests

> ListGdprRequestsResponse ListGdprRequests (string apiToken, string token = null, int? limit = null)

List GDPR requests

## List GDPR requests  Retrieves a list of GDPR requests of all types.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-privacy#2-list-gdpr-requests - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListGdprRequestsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new PrivacyApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var token = "token_example";  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List GDPR requests
                ListGdprRequestsResponse result = apiInstance.ListGdprRequests(apiToken, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PrivacyApi.ListGdprRequests: " + e.Message );
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
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**ListGdprRequestsResponse**](ListGdprRequestsResponse.md)

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


## RegisterGdprRequest

> RegisterGdprRequestResponse RegisterGdprRequest (string apiToken, RegisterGdprRequestData registerGdprRequestData = null)

Register a GDPR request

## Register a GDPR request  Registers a specific type of GDPR request to meet the GDPR's requirements.  > __Note__: Currently, only delete and access of the user data are supported. The features for the [right to restriction of processing](https://gdpr-info.eu/art-18-gdpr/) and [right to object](https://gdpr-info.eu/art-21-gdpr/) will be available soon.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-privacy#2-register-a-gdpr-request

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RegisterGdprRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new PrivacyApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var registerGdprRequestData = new RegisterGdprRequestData(); // RegisterGdprRequestData |  (optional) 

            try
            {
                // Register a GDPR request
                RegisterGdprRequestResponse result = apiInstance.RegisterGdprRequest(apiToken, registerGdprRequestData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PrivacyApi.RegisterGdprRequest: " + e.Message );
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
 **registerGdprRequestData** | [**RegisterGdprRequestData**](RegisterGdprRequestData.md)|  | [optional] 

### Return type

[**RegisterGdprRequestResponse**](RegisterGdprRequestResponse.md)

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


## ViewGdprRequestById

> ViewGdprRequestByIdResponse ViewGdprRequestById (string apiToken, string requestId)

View a GDPR request

## View a GDPR request  Retrieves a specific GDPR request.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-privacy#2-view-a-gdpr-request - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewGdprRequestByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new PrivacyApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var requestId = "requestId_example";  // string | 

            try
            {
                // View a GDPR request
                ViewGdprRequestByIdResponse result = apiInstance.ViewGdprRequestById(apiToken, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PrivacyApi.ViewGdprRequestById: " + e.Message );
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
 **requestId** | **string**|  | 

### Return type

[**ViewGdprRequestByIdResponse**](ViewGdprRequestByIdResponse.md)

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

