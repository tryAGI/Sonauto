
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters echoed back for an extend generation.
    /// </summary>
    public sealed partial class ExtendParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("side")]
        public string? Side { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_duration")]
        public float? CropDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public float? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lyrics")]
        public string? Lyrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendParams" /> class.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="cropDuration"></param>
        /// <param name="audioUrl"></param>
        /// <param name="duration"></param>
        /// <param name="lyrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtendParams(
            string? side,
            float? cropDuration,
            string? audioUrl,
            float? duration,
            string? lyrics)
        {
            this.Side = side;
            this.CropDuration = cropDuration;
            this.AudioUrl = audioUrl;
            this.Duration = duration;
            this.Lyrics = lyrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendParams" /> class.
        /// </summary>
        public ExtendParams()
        {
        }
    }
}