
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Parameters echoed back for an inpaint generation.
    /// </summary>
    public sealed partial class InpaintParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Sections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_crop")]
        public bool? SelectionCrop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="InpaintParams" /> class.
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="selectionCrop"></param>
        /// <param name="audioUrl"></param>
        /// <param name="lyrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintParams(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? sections,
            bool? selectionCrop,
            string? audioUrl,
            string? lyrics)
        {
            this.Sections = sections;
            this.SelectionCrop = selectionCrop;
            this.AudioUrl = audioUrl;
            this.Lyrics = lyrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintParams" /> class.
        /// </summary>
        public InpaintParams()
        {
        }
    }
}