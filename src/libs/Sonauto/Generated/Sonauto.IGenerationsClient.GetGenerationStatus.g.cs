#nullable enable

namespace Sonauto
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Get generation status<br/>
        /// Returns the current status (e.g. PENDING, RUNNING, SUCCESS, FAILURE) for a task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="includeAlignment">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.OneOf<string, global::Sonauto.GenerationStatus>> GetGenerationStatusAsync(
            string taskId,
            bool? includeAlignment = default,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}