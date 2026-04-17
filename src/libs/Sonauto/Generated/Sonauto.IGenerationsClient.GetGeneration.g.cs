#nullable enable

namespace Sonauto
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Get a completed generation<br/>
        /// Retrieves the full generation result, including song URLs, lyrics, and tags.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.Generation> GetGenerationAsync(
            string taskId,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}