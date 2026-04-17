
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters for a Melodia v3 generation.
    /// </summary>
    public sealed partial class GenerateV3Request
    {
        /// <summary>
        /// Style descriptors (e.g. "rock", "uplifting"). Optional but recommended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Song lyrics. Use `[verse]`, `[chorus]`, and other markers for structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Natural language description of the desired song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Generate an instrumental (no vocals).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental")]
        public bool? Instrumental { get; set; }

        /// <summary>
        /// How closely the model should follow the prompt. Higher = stricter.<br/>
        /// Default Value: 2.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_strength")]
        public float? PromptStrength { get; set; }

        /// <summary>
        /// URL to POST the result to when the task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Output audio format (ogg, mp3, flac, wav, m4a).<br/>
        /// Default Value: ogg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Optional bit rate for the output file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_bit_rate")]
        public int? OutputBitRate { get; set; }

        /// <summary>
        /// When true, the song can be streamed while still generating.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_streaming")]
        public bool? EnableStreaming { get; set; }

        /// <summary>
        /// Audio format used for streaming playback.<br/>
        /// Default Value: ogg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sonauto.JsonConverters.GenerateV3RequestStreamFormatJsonConverter))]
        public global::Sonauto.GenerateV3RequestStreamFormat? StreamFormat { get; set; }

        /// <summary>
        /// Include time-aligned lyrics in the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align_lyrics")]
        public bool? AlignLyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateV3Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateV3Request(
            global::System.Collections.Generic.IList<string>? tags,
            string? lyrics,
            string? prompt,
            bool? instrumental,
            float? promptStrength,
            string? webhookUrl,
            string? outputFormat,
            int? outputBitRate,
            bool? enableStreaming,
            global::Sonauto.GenerateV3RequestStreamFormat? streamFormat,
            bool? alignLyrics)
        {
            this.Tags = tags;
            this.Lyrics = lyrics;
            this.Prompt = prompt;
            this.Instrumental = instrumental;
            this.PromptStrength = promptStrength;
            this.WebhookUrl = webhookUrl;
            this.OutputFormat = outputFormat;
            this.OutputBitRate = outputBitRate;
            this.EnableStreaming = enableStreaming;
            this.StreamFormat = streamFormat;
            this.AlignLyrics = alignLyrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateV3Request" /> class.
        /// </summary>
        public GenerateV3Request()
        {
        }
    }
}