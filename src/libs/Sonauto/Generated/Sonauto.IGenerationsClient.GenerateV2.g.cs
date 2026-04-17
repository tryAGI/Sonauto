#nullable enable

namespace Sonauto
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Generate a song (Melodia v2)<br/>
        /// Kicks off a v2 generation task. v2 does not stream but supports `num_songs`,<br/>
        /// `balance_strength`, `seed`, and BPM control.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> GenerateV2Async(

            global::Sonauto.GenerateV2Request request,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a song (Melodia v2)<br/>
        /// Kicks off a v2 generation task. v2 does not stream but supports `num_songs`,<br/>
        /// `balance_strength`, `seed`, and BPM control.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="lyrics"></param>
        /// <param name="prompt"></param>
        /// <param name="instrumental">
        /// Default Value: false
        /// </param>
        /// <param name="promptStrength"></param>
        /// <param name="balanceStrength">
        /// Default Value: 0.7
        /// </param>
        /// <param name="seed">
        /// Deterministic seed.
        /// </param>
        /// <param name="webhookUrl"></param>
        /// <param name="numSongs">
        /// Number of song variations to generate (v2 only).<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: ogg
        /// </param>
        /// <param name="outputBitRate"></param>
        /// <param name="alignLyrics">
        /// Default Value: false
        /// </param>
        /// <param name="bpm">
        /// Target BPM; use the string "auto" or an integer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> GenerateV2Async(
            global::System.Collections.Generic.IList<string>? tags = default,
            string? lyrics = default,
            string? prompt = default,
            bool? instrumental = default,
            float? promptStrength = default,
            float? balanceStrength = default,
            int? seed = default,
            string? webhookUrl = default,
            int? numSongs = default,
            string? outputFormat = default,
            int? outputBitRate = default,
            bool? alignLyrics = default,
            global::Sonauto.OneOf<int?, global::Sonauto.GenerateV2RequestBpm?>? bpm = default,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}