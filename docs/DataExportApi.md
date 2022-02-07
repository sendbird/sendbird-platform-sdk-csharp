# sendbird-platform-sdk.Api.DataExportApi

All URIs are relative to *https://api-APP_ID.sendbird.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListDataExportsByMessageChannelOrUser**](DataExportApi.md#listdataexportsbymessagechanneloruser) | **GET** /v3/export/{data_type} | List data exports by message, channel, or user
[**RegisterAndScheduleDataExport**](DataExportApi.md#registerandscheduledataexport) | **POST** /v3/export/{data_type} | Register and schedule a data export
[**ViewDataExportById**](DataExportApi.md#viewdataexportbyid) | **GET** /v3/export/{data_type}/{request_id} | View a data export



## ListDataExportsByMessageChannelOrUser

> InlineResponse20063 ListDataExportsByMessageChannelOrUser (string dataType, string apiToken = null, string token = null, int? limit = null)

List data exports by message, channel, or user

## List data exports by message, channel, or user  Retrieves a list of message, channel or user data exports  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-list-data-exports-by-message,-channel,-or-user - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `data_type`      Type: string      Description: Specifies the type of a data export to retrieve. Acceptable values are messages, channels, users, and failed_webhooks.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird-platform-sdk.Api;
using sendbird-platform-sdk.Client;
using sendbird-platform-sdk.Model;

namespace Example
{
    public class ListDataExportsByMessageChannelOrUserExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var dataType = dataType_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var token = token_example;  // string |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                // List data exports by message, channel, or user
                InlineResponse20063 result = apiInstance.ListDataExportsByMessageChannelOrUser(dataType, apiToken, token, limit);
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
 **dataType** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **token** | **string**|  | [optional] 
 **limit** | **int?**|  | [optional] 

### Return type

[**InlineResponse20063**](InlineResponse20063.md)

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

> InlineResponse20063ExportedData RegisterAndScheduleDataExport (string dataType, string apiToken = null, RegisterAndScheduleDataExportData registerAndScheduleDataExportData = null)

Register and schedule a data export

## Register and schedule a data export  Registers and schedules a message, channel, or user data export.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-register-and-schedule-a-data-export - -- -- -- -- -- -- -- -- -- -- -- -- -- -

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird-platform-sdk.Api;
using sendbird-platform-sdk.Client;
using sendbird-platform-sdk.Model;

namespace Example
{
    public class RegisterAndScheduleDataExportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var dataType = dataType_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 
            var registerAndScheduleDataExportData = new RegisterAndScheduleDataExportData(); // RegisterAndScheduleDataExportData |  (optional) 

            try
            {
                // Register and schedule a data export
                InlineResponse20063ExportedData result = apiInstance.RegisterAndScheduleDataExport(dataType, apiToken, registerAndScheduleDataExportData);
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
 **dataType** | **string**|  | 
 **apiToken** | **string**|  | [optional] 
 **registerAndScheduleDataExportData** | [**RegisterAndScheduleDataExportData**](RegisterAndScheduleDataExportData.md)|  | [optional] 

### Return type

[**InlineResponse20063ExportedData**](InlineResponse20063ExportedData.md)

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

> InlineResponse20064 ViewDataExportById (string dataType, string requestId, string apiToken = null)

View a data export

## View a data export  Retrieves information on a message, channel or user data export.  https://sendbird.com/docs/chat/v3/platform-api/guides/data-export#2-view-a-data-export - -- -- -- -- -- -- -- -- -- -- -- -- -- -   `data_type`      Type: string      Description: Specifies the type of a targeted data export. Acceptable values are messages, channels,  users, and failed_webhooks.  `request_id`      Type: string      Description: Specifies the unique ID of a data export to retrieve.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using sendbird-platform-sdk.Api;
using sendbird-platform-sdk.Client;
using sendbird-platform-sdk.Model;

namespace Example
{
    public class ViewDataExportByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api-APP_ID.sendbird.com";
            var apiInstance = new DataExportApi(Configuration.Default);
            var dataType = dataType_example;  // string | 
            var requestId = requestId_example;  // string | 
            var apiToken = {{API_TOKEN}};  // string |  (optional) 

            try
            {
                // View a data export
                InlineResponse20064 result = apiInstance.ViewDataExportById(dataType, requestId, apiToken);
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
 **dataType** | **string**|  | 
 **requestId** | **string**|  | 
 **apiToken** | **string**|  | [optional] 

### Return type

[**InlineResponse20064**](InlineResponse20064.md)

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

