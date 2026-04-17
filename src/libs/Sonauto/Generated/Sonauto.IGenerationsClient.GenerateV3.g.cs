#nullable enable

namespace Sonauto
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Generate a song (Melodia v3, streaming-capable)<br/>
        /// Kicks off a v3 generation task. v3 supports streaming playback via the<br/>
        /// separate streaming endpoint when `enable_streaming` is `true`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sonauto.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> GenerateV3Async(

            global::Sonauto.GenerateV3Request request,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a song (Melodia v3, streaming-capable)<br/>
        /// Kicks off a v3 generation task. v3 supports streaming playback via the<br/>
        /// separate streaming endpoint when `enable_streaming` is `true`.
        /// </summary>
        /// <param name="tags">
        /// Style descriptors (e.g. "rock", "uplifting"). Optional but recommended.
        /// </param>
        /// <param name="lyrics">
        /// Song lyrics. Use `[verse]`, `[chorus]`, and other markers for structure.
        /// </param>
        /// <param name="prompt">
        /// Natural language description of the desired song.
        /// </param>
        /// <param name="instrumental">
        /// Generate an instrumental (no vocals).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="promptStrength">
        /// How closely the model should follow the prompt. Higher = stricter.<br/>
        /// Default Value: 2.0
        /// </param>
        /// <param name="webhookUrl">
        /// URL to POST the result to when the task completes.
        /// </param>
        /// <param name="outputFormat">
        /// Output audio format (ogg, mp3, flac, wav, m4a).<br/>
        /// Default Value: ogg
        /// </param>
        /// <param name="outputBitRate">
        /// Optional bit rate for the output file.
        /// </param>
        /// <param name="enableStreaming">
        /// When true, the song can be streamed while still generating.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamFormat">
        /// Audio format used for streaming playback.<br/>
        /// Default Value: ogg
        /// </param>
        /// <param name="alignLyrics">
        /// Include time-aligned lyrics in the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sonauto.TaskResponse> GenerateV3Async(
            global::System.Collections.Generic.IList<string>? tags = default,
            string? lyrics = default,
            string? prompt = default,
            bool? instrumental = default,
            float? promptStrength = default,
            string? webhookUrl = default,
            string? outputFormat = default,
            int? outputBitRate = default,
            bool? enableStreaming = default,
            global::Sonauto.GenerateV3RequestStreamFormat? streamFormat = default,
            bool? alignLyrics = default,
            global::Sonauto.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}