# configmanager.Api.ConfigManagerApi

All URIs are relative to *https://config-manager.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfigManagerBulkSetConfigs**](ConfigManagerApi.md#configmanagerbulksetconfigs) | **POST** /configmanager.ConfigManager/BulkSetConfigs | BulkSetConfigs |
| [**ConfigManagerGetConfig**](ConfigManagerApi.md#configmanagergetconfig) | **POST** /configmanager.ConfigManager/GetConfig | GetConfig |
| [**ConfigManagerGetTenantIdByCode**](ConfigManagerApi.md#configmanagergettenantidbycode) | **POST** /configmanager.ConfigManager/GetTenantIdByCode |  |

<a id="configmanagerbulksetconfigs"></a>
# **ConfigManagerBulkSetConfigs**
> Object ConfigManagerBulkSetConfigs (ConfigmanagerBulkSetConfigsRequest body)

BulkSetConfigs

Bulk set configs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using configmanager.Api;
using configmanager.Client;
using configmanager.Model;

namespace Example
{
    public class ConfigManagerBulkSetConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://config-manager.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigManagerApi(config);
            var body = new ConfigmanagerBulkSetConfigsRequest(); // ConfigmanagerBulkSetConfigsRequest | 

            try
            {
                // BulkSetConfigs
                Object result = apiInstance.ConfigManagerBulkSetConfigs(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerBulkSetConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfigManagerBulkSetConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // BulkSetConfigs
    ApiResponse<Object> response = apiInstance.ConfigManagerBulkSetConfigsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerBulkSetConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ConfigmanagerBulkSetConfigsRequest**](ConfigmanagerBulkSetConfigsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="configmanagergetconfig"></a>
# **ConfigManagerGetConfig**
> ConfigmanagerConfigResponse ConfigManagerGetConfig (ConfigmanagerGetConfigRequest body)

GetConfig

Get a config

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using configmanager.Api;
using configmanager.Client;
using configmanager.Model;

namespace Example
{
    public class ConfigManagerGetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://config-manager.api.gogemini.io";
            // Configure OAuth2 access token for authorization: standardAuthorization
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ConfigManagerApi(config);
            var body = new ConfigmanagerGetConfigRequest(); // ConfigmanagerGetConfigRequest | 

            try
            {
                // GetConfig
                ConfigmanagerConfigResponse result = apiInstance.ConfigManagerGetConfig(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerGetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfigManagerGetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetConfig
    ApiResponse<ConfigmanagerConfigResponse> response = apiInstance.ConfigManagerGetConfigWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerGetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ConfigmanagerGetConfigRequest**](ConfigmanagerGetConfigRequest.md) |  |  |

### Return type

[**ConfigmanagerConfigResponse**](ConfigmanagerConfigResponse.md)

### Authorization

[standardAuthorization](../README.md#standardAuthorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="configmanagergettenantidbycode"></a>
# **ConfigManagerGetTenantIdByCode**
> ConfigmanagerGetTenantIdByCodeResponse ConfigManagerGetTenantIdByCode (ConfigmanagerGetTenantIdByCodeRequest body)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using configmanager.Api;
using configmanager.Client;
using configmanager.Model;

namespace Example
{
    public class ConfigManagerGetTenantIdByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://config-manager.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigManagerApi(config);
            var body = new ConfigmanagerGetTenantIdByCodeRequest(); // ConfigmanagerGetTenantIdByCodeRequest | 

            try
            {
                ConfigmanagerGetTenantIdByCodeResponse result = apiInstance.ConfigManagerGetTenantIdByCode(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerGetTenantIdByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfigManagerGetTenantIdByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConfigmanagerGetTenantIdByCodeResponse> response = apiInstance.ConfigManagerGetTenantIdByCodeWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigManagerApi.ConfigManagerGetTenantIdByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ConfigmanagerGetTenantIdByCodeRequest**](ConfigmanagerGetTenantIdByCodeRequest.md) |  |  |

### Return type

[**ConfigmanagerGetTenantIdByCodeResponse**](ConfigmanagerGetTenantIdByCodeResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

