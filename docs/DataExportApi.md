# sendbird_platform_sdk.Api.DataExportApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDataExportsByMessageChannelOrUser**](DataExportApi.md#listdataexportsbymessagechanneloruser) | **GET** /v3/export/{data_type} | List data exports by message, channel, or user
[**RegisterAndScheduleDataExport**](DataExportApi.md#registerandscheduledataexport) | **POST** /v3/export/{data_type} | Register and schedule a data export
[**ViewDataExportById**](DataExportApi.md#viewdataexportbyid) | **GET** /v3/export/{data_type}/{request_id} | View a data export



## ListDataExportsByMessageChannelOrUser

> ListDataExportsByMessageChannelOrUserResponse ListDataExportsByMessageChannelOrUser (string apiToken, string dataType, string token = null, int? limit = null)

List data exports by message, channel, or user

## List data exports by message, channel, or user  Retrieves a list of message, channel or user data exports  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-list-data-exports-by-message,-channel,-or-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `data_type`      Type: string      Description: Specifies the type of a data export to retrieve. Acceptable values are messages, channels, users, and failed_webhooks.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ListDataExportsByMessageChannelOrUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var dataType = dataType_example;  // string | 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List data exports by message, channel, or user
                ListDataExportsByMessageChannelOrUserResponse result = apiInstance.ListDataExportsByMessageChannelOrUser(apiToken, dataType, token, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataExportApi.ListDataExportsByMessageChannelOrUser: " + e.Message );
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
 **dataType** | **string**|  | 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**ListDataExportsByMessageChannelOrUserResponse**](ListDataExportsByMessageChannelOrUserResponse.md)

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


## RegisterAndScheduleDataExport

> RegisterAndScheduleDataExportResponse RegisterAndScheduleDataExport (string apiToken, string dataType, RegisterAndScheduleDataExportData registerAndScheduleDataExportData = null)

Register and schedule a data export

## Register and schedule a data export  Registers and schedules a message, channel, or user data export.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-register-and-schedule-a-data-export - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class RegisterAndScheduleDataExportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var dataType = dataType_example;  // string | 
            var registerAndScheduleDataExportData = new RegisterAndScheduleDataExportData(); // RegisterAndScheduleDataExportData |  (optional) 

            try
            {
                // Register and schedule a data export
                RegisterAndScheduleDataExportResponse result = apiInstance.RegisterAndScheduleDataExport(apiToken, dataType, registerAndScheduleDataExportData);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataExportApi.RegisterAndScheduleDataExport: " + e.Message );
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
 **dataType** | **string**|  | 
 **registerAndScheduleDataExportData** | [**RegisterAndScheduleDataExportData**](RegisterAndScheduleDataExportData.md)|  | [optional] 

### Return type

[**RegisterAndScheduleDataExportResponse**](RegisterAndScheduleDataExportResponse.md)

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


## ViewDataExportById

> ViewDataExportByIdResponse ViewDataExportById (string apiToken, string dataType, string requestId)

View a data export

## View a data export  Retrieves information on a message, channel or user data export.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-view-a-data-export - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `data_type`      Type: string      Description: Specifies the type of a targeted data export. Acceptable values are messages, channels,  users, and failed_webhooks.  `request_id`      Type: string      Description: Specifies the unique ID of a data export to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird_platform_sdk.Api;
using sendbird_platform_sdk.Client;
using sendbird_platform_sdk.Model;

namespace Example
{
    public class ViewDataExportByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var apiToken = {{API_TOKEN}};  // string | 
            var dataType = dataType_example;  // string | 
            var requestId = requestId_example;  // string | 

            try
            {
                // View a data export
                ViewDataExportByIdResponse result = apiInstance.ViewDataExportById(apiToken, dataType, requestId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DataExportApi.ViewDataExportById: " + e.Message );
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
 **dataType** | **string**|  | 
 **requestId** | **string**|  | 

### Return type

[**ViewDataExportByIdResponse**](ViewDataExportByIdResponse.md)

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

