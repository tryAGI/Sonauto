
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Sonauto (Melodia) API for fast AI song generation with lyrics. Generate full songs<br/>
    /// with natural language prompts, tags, and optional lyrics. Streaming responses let<br/>
    /// playback begin in ~15 seconds while the rest of the song continues to generate.<br/>
    /// Includes v3 (streaming) and v2 (extend / inpaint) generation endpoints, status<br/>
    /// polling, task retrieval, and credit balance.<br/>
    /// No official OpenAPI spec is published; this document was manually compiled from<br/>
    /// https://sonauto.ai/developers/docs.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ISonautoClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Sonauto.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Sonauto.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenerationsClient Generations { get; }

    }
}