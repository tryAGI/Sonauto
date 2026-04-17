
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters for inpainting sections of an existing song (v2).
    /// </summary>
    public sealed partial class InpaintV2Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Lyrics for the inpainted sections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lyrics { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        public string? AudioBase64 { get; set; }

        /// <summary>
        /// List of [start_seconds, end_seconds] pairs to regenerate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> Sections { get; set; }

        /// <summary>
        /// Crop the output to just the inpainted sections.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_crop")]
        public bool? SelectionCrop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintV2Request" /> class.
        /// </summary>
        /// <param name="lyrics">
        /// Lyrics for the inpainted sections.
        /// </param>
        /// <param name="sections">
        /// List of [start_seconds, end_seconds] pairs to regenerate.
        /// </param>
        /// <param name="tags"></param>
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
        /// <param name="selectionCrop">
        /// Crop the output to just the inpainted sections.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintV2Request(
            string lyrics,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>> sections,
            global::System.Collections.Generic.IList<string>? tags,
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
            bool? selectionCrop)
        {
            this.Tags = tags;
            this.Lyrics = lyrics ?? throw new global::System.ArgumentNullException(nameof(lyrics));
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
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
            this.SelectionCrop = selectionCrop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintV2Request" /> class.
        /// </summary>
        public InpaintV2Request()
        {
        }
    }
}