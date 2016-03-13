using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDefaultApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Single Random User
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>UserResponse</returns>
        UserResponse ApiGet (string gender = null, string nat = null);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Single Random User
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>ApiResponse of UserResponse</returns>
        ApiResponse<UserResponse> ApiGetWithHttpInfo (string gender = null, string nat = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Single Random User
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>Task of UserResponse</returns>
        System.Threading.Tasks.Task<UserResponse> ApiGetAsync (string gender = null, string nat = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get Single Random User
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>Task of ApiResponse (UserResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponse>> ApiGetAsyncWithHttpInfo (string gender = null, string nat = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : IDefaultApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DefaultApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DefaultApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  Get Single Random User
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param> 
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param> 
        /// <returns>UserResponse</returns>
        public UserResponse ApiGet (string gender = null, string nat = null)
        {
             ApiResponse<UserResponse> localVarResponse = ApiGetWithHttpInfo(gender, nat);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Get Single Random User
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param> 
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param> 
        /// <returns>ApiResponse of UserResponse</returns>
        public ApiResponse< UserResponse > ApiGetWithHttpInfo (string gender = null, string nat = null)
        {
            
    
            var localVarPath = "/api";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (gender != null) localVarQueryParams.Add("gender", Configuration.ApiClient.ParameterToString(gender)); // query parameter
            if (nat != null) localVarQueryParams.Add("nat", Configuration.ApiClient.ParameterToString(nat)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ApiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ApiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<UserResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponse)));
            
        }

        
        /// <summary>
        ///  Get Single Random User
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>Task of UserResponse</returns>
        public async System.Threading.Tasks.Task<UserResponse> ApiGetAsync (string gender = null, string nat = null)
        {
             ApiResponse<UserResponse> localVarResponse = await ApiGetAsyncWithHttpInfo(gender, nat);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Get Single Random User
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <returns>Task of ApiResponse (UserResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponse>> ApiGetAsyncWithHttpInfo (string gender = null, string nat = null)
        {
            
    
            var localVarPath = "/api";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (gender != null) localVarQueryParams.Add("gender", Configuration.ApiClient.ParameterToString(gender)); // query parameter
            if (nat != null) localVarQueryParams.Add("nat", Configuration.ApiClient.ParameterToString(nat)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ApiGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ApiGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<UserResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserResponse)));
            
        }
        
    }
    
}
