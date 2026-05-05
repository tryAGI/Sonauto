#nullable enable

namespace Sonauto
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get credit balance<br/>
        /// Returns remaining subscription credits and pay-as-you-go credits.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.CreditsBalance> GetCreditsBalanceAsync(
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get credit balance<br/>
        /// Returns remaining subscription credits and pay-as-you-go credits.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.AutoSDKHttpResponse<global::Sonauto.CreditsBalance>> GetCreditsBalanceAsResponseAsync(
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}