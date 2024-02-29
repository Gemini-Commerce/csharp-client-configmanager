/*
 * configmanager/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using configmanager.Client;
using configmanager.Model;

namespace configmanager.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigManagerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object ConfigManagerBulkSetConfigs(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ConfigManagerBulkSetConfigsWithHttpInfo(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ConfigmanagerConfigResponse</returns>
        ConfigmanagerConfigResponse ConfigManagerGetConfig(ConfigmanagerGetConfigRequest body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ConfigmanagerConfigResponse</returns>
        ApiResponse<ConfigmanagerConfigResponse> ConfigManagerGetConfigWithHttpInfo(ConfigmanagerGetConfigRequest body, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ConfigmanagerGetTenantIdByCodeResponse</returns>
        ConfigmanagerGetTenantIdByCodeResponse ConfigManagerGetTenantIdByCode(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ConfigmanagerGetTenantIdByCodeResponse</returns>
        ApiResponse<ConfigmanagerGetTenantIdByCodeResponse> ConfigManagerGetTenantIdByCodeWithHttpInfo(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigManagerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ConfigManagerBulkSetConfigsAsync(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConfigManagerBulkSetConfigsWithHttpInfoAsync(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ConfigmanagerConfigResponse</returns>
        System.Threading.Tasks.Task<ConfigmanagerConfigResponse> ConfigManagerGetConfigAsync(ConfigmanagerGetConfigRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ConfigmanagerConfigResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigmanagerConfigResponse>> ConfigManagerGetConfigWithHttpInfoAsync(ConfigmanagerGetConfigRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ConfigmanagerGetTenantIdByCodeResponse</returns>
        System.Threading.Tasks.Task<ConfigmanagerGetTenantIdByCodeResponse> ConfigManagerGetTenantIdByCodeAsync(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ConfigmanagerGetTenantIdByCodeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ConfigmanagerGetTenantIdByCodeResponse>> ConfigManagerGetTenantIdByCodeWithHttpInfoAsync(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigManagerApi : IConfigManagerApiSync, IConfigManagerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigManagerApi : IConfigManagerApi
    {
        private configmanager.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigManagerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigManagerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigManagerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigManagerApi(string basePath)
        {
            this.Configuration = configmanager.Client.Configuration.MergeConfigurations(
                configmanager.Client.GlobalConfiguration.Instance,
                new configmanager.Client.Configuration { BasePath = basePath }
            );
            this.Client = new configmanager.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new configmanager.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = configmanager.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigManagerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigManagerApi(configmanager.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configmanager.Client.Configuration.MergeConfigurations(
                configmanager.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new configmanager.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new configmanager.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = configmanager.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigManagerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConfigManagerApi(configmanager.Client.ISynchronousClient client, configmanager.Client.IAsynchronousClient asyncClient, configmanager.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = configmanager.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public configmanager.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public configmanager.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public configmanager.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public configmanager.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object ConfigManagerBulkSetConfigs(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0)
        {
            configmanager.Client.ApiResponse<Object> localVarResponse = ConfigManagerBulkSetConfigsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public configmanager.Client.ApiResponse<Object> ConfigManagerBulkSetConfigsWithHttpInfo(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerBulkSetConfigs");
            }

            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerBulkSetConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/configmanager.ConfigManager/BulkSetConfigs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerBulkSetConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ConfigManagerBulkSetConfigsAsync(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            configmanager.Client.ApiResponse<Object> localVarResponse = await ConfigManagerBulkSetConfigsWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<configmanager.Client.ApiResponse<Object>> ConfigManagerBulkSetConfigsWithHttpInfoAsync(ConfigmanagerBulkSetConfigsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerBulkSetConfigs");
            }


            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerBulkSetConfigs";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/configmanager.ConfigManager/BulkSetConfigs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerBulkSetConfigs", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ConfigmanagerConfigResponse</returns>
        public ConfigmanagerConfigResponse ConfigManagerGetConfig(ConfigmanagerGetConfigRequest body, int operationIndex = 0)
        {
            configmanager.Client.ApiResponse<ConfigmanagerConfigResponse> localVarResponse = ConfigManagerGetConfigWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ConfigmanagerConfigResponse</returns>
        public configmanager.Client.ApiResponse<ConfigmanagerConfigResponse> ConfigManagerGetConfigWithHttpInfo(ConfigmanagerGetConfigRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerGetConfig");
            }

            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerGetConfig";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ConfigmanagerConfigResponse>("/configmanager.ConfigManager/GetConfig", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerGetConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ConfigmanagerConfigResponse</returns>
        public async System.Threading.Tasks.Task<ConfigmanagerConfigResponse> ConfigManagerGetConfigAsync(ConfigmanagerGetConfigRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            configmanager.Client.ApiResponse<ConfigmanagerConfigResponse> localVarResponse = await ConfigManagerGetConfigWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ConfigmanagerConfigResponse)</returns>
        public async System.Threading.Tasks.Task<configmanager.Client.ApiResponse<ConfigmanagerConfigResponse>> ConfigManagerGetConfigWithHttpInfoAsync(ConfigmanagerGetConfigRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerGetConfig");
            }


            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerGetConfig";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ConfigmanagerConfigResponse>("/configmanager.ConfigManager/GetConfig", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerGetConfig", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ConfigmanagerGetTenantIdByCodeResponse</returns>
        public ConfigmanagerGetTenantIdByCodeResponse ConfigManagerGetTenantIdByCode(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0)
        {
            configmanager.Client.ApiResponse<ConfigmanagerGetTenantIdByCodeResponse> localVarResponse = ConfigManagerGetTenantIdByCodeWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ConfigmanagerGetTenantIdByCodeResponse</returns>
        public configmanager.Client.ApiResponse<ConfigmanagerGetTenantIdByCodeResponse> ConfigManagerGetTenantIdByCodeWithHttpInfo(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerGetTenantIdByCode");
            }

            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerGetTenantIdByCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ConfigmanagerGetTenantIdByCodeResponse>("/configmanager.ConfigManager/GetTenantIdByCode", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerGetTenantIdByCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ConfigmanagerGetTenantIdByCodeResponse</returns>
        public async System.Threading.Tasks.Task<ConfigmanagerGetTenantIdByCodeResponse> ConfigManagerGetTenantIdByCodeAsync(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            configmanager.Client.ApiResponse<ConfigmanagerGetTenantIdByCodeResponse> localVarResponse = await ConfigManagerGetTenantIdByCodeWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="configmanager.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ConfigmanagerGetTenantIdByCodeResponse)</returns>
        public async System.Threading.Tasks.Task<configmanager.Client.ApiResponse<ConfigmanagerGetTenantIdByCodeResponse>> ConfigManagerGetTenantIdByCodeWithHttpInfoAsync(ConfigmanagerGetTenantIdByCodeRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new configmanager.Client.ApiException(400, "Missing required parameter 'body' when calling ConfigManagerApi->ConfigManagerGetTenantIdByCode");
            }


            configmanager.Client.RequestOptions localVarRequestOptions = new configmanager.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = configmanager.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = configmanager.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "ConfigManagerApi.ConfigManagerGetTenantIdByCode";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ConfigmanagerGetTenantIdByCodeResponse>("/configmanager.ConfigManager/GetTenantIdByCode", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ConfigManagerGetTenantIdByCode", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
