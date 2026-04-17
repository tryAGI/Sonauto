#nullable enable

namespace Sonauto
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Inpaint a section of a song (v2)<br/>
        /// Regenerates one or more sections of an existing clip.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> InpaintV2Async(

            global::Sonauto.InpaintV2Request request,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint a section of a song (v2)<br/>
        /// Regenerates one or more sections of an existing clip.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="lyrics">
        /// Lyrics for the inpainted sections.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="instrumental">
        /// Default Value: false
        /// </param>
        /// <param name="promptStrength"></param>
        /// <param name="balanceStrength">
        /// Default Value: 0.7
        /// </param>
        /// <param name="seed"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="numSongs">
        /// Default Value: 1
        /// </param>
        /// <param name="outputFormat">
        /// Default Value: ogg
        /// </param>
        /// <param name="outputBitRate"></param>
        /// <param name="alignLyrics">
        /// Default Value: false
        /// </param>
        /// <param name="audioUrl"></param>
        /// <param name="audioBase64"></param>
        /// <param name="sections">
        /// List of [start_seconds, end_seconds] pairs to regenerate.
        /// </param>
        /// <param name="selectionCrop">
        /// Crop the output to just the inpainted sections.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> InpaintV2Async(
            string lyrics,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> sections,
            global::System.Collections.Generic.IList<string>? tags = default,
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
            string? audioUrl = default,
            string? audioBase64 = default,
            bool? selectionCrop = default,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}