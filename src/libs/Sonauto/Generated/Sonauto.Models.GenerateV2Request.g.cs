
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters for a Melodia v2 generation.
    /// </summary>
    public sealed partial class GenerateV2Request
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
        /// Deterministic seed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Number of song variations to generate (v2 only).<br/>
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
        /// Target BPM; use the string "auto" or an integer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sonauto.JsonConverters.OneOfJsonConverter<int?, global::Sonauto.GenerateV2RequestBpm?>))]
        public global::Sonauto.OneOf<int?, global::Sonauto.GenerateV2RequestBpm?>? Bpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateV2Request" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateV2Request(
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
            global::Sonauto.OneOf<int?, global::Sonauto.GenerateV2RequestBpm?>? bpm)
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
            this.Bpm = bpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateV2Request" /> class.
        /// </summary>
        public GenerateV2Request()
        {
        }
    }
}