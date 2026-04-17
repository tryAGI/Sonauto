
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters for extending an existing song (v2).
    /// </summary>
    public sealed partial class ExtendV2Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instrumental")]
        public bool? Instrumental { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_strength")]
        public float? PromptStrength { get; set; }

        /// <summary>
        /// Default Value: 0.7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_strength")]
        public float? BalanceStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_songs")]
        public int? NumSongs { get; set; }

        /// <summary>
        /// Default Value: ogg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_bit_rate")]
        public int? OutputBitRate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align_lyrics")]
        public bool? AlignLyrics { get; set; }

        /// <summary>
        /// URL of the source audio. Either this or audio_base64 is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// Base64-encoded source audio. Either this or audio_url is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// Which side of the source audio to extend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sonauto.JsonConverters.ExtendV2RequestSideJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Sonauto.ExtendV2RequestSide Side { get; set; }

        /// <summary>
        /// How many seconds to generate on the chosen side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_duration")]
        public float? ExtendDuration { get; set; }

        /// <summary>
        /// Seconds of source audio to drop from the chosen side before extending.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_duration")]
        public float? CropDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendV2Request" /> class.
        /// </summary>
        /// <param name="side">
        /// Which side of the source audio to extend.
        /// </param>
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
        /// <param name="audioUrl">
        /// URL of the source audio. Either this or audio_base64 is required.
        /// </param>
        /// <param name="audioBase64">
        /// Base64-encoded source audio. Either this or audio_url is required.
        /// </param>
        /// <param name="extendDuration">
        /// How many seconds to generate on the chosen side.
        /// </param>
        /// <param name="cropDuration">
        /// Seconds of source audio to drop from the chosen side before extending.<br/>
        /// Default Value: 0.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendV2Request(
            global::Sonauto.ExtendV2RequestSide side,
            global::System.Collections.Generic.IList<string>? tags,
            string? lyrics,
            string? prompt,
            bool? instrumental,
            float? promptStrength,
            float? balanceStrength,
            int? seed,
            string? webhookUrl,
            int? numSongs,
            string? outputFormat,
            int? outputBitRate,
            bool? alignLyrics,
            string? audioUrl,
            string? audioBase64,
            float? extendDuration,
            float? cropDuration)
        {
            this.Tags = tags;
            this.Lyrics = lyrics;
            this.Prompt = prompt;
            this.Instrumental = instrumental;
            this.PromptStrength = promptStrength;
            this.BalanceStrength = balanceStrength;
            this.Seed = seed;
            this.WebhookUrl = webhookUrl;
            this.NumSongs = numSongs;
            this.OutputFormat = outputFormat;
            this.OutputBitRate = outputBitRate;
            this.AlignLyrics = alignLyrics;
            this.AudioUrl = audioUrl;
            this.AudioBase64 = audioBase64;
            this.Side = side;
            this.ExtendDuration = extendDuration;
            this.CropDuration = cropDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendV2Request" /> class.
        /// </summary>
        public ExtendV2Request()
        {
        }
    }
}