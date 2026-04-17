
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Full details of a completed (or in-flight) generation task.
    /// </summary>
    public sealed partial class Generation
    {
        /// <summary>
        /// Task UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_status")]
        public string? AlignmentStatus { get; set; }

        /// <summary>
        /// Model version used (e.g. "v2", "v3").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// CDN URLs for the generated songs. Expire after ~7 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("song_paths")]
        public global::System.Collections.Generic.IList<string>? SongPaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_strength")]
        public float? PromptStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// v2-specific parameters echoed back for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("v2_params")]
        public global::Sonauto.V2Params? V2Params { get; set; }

        /// <summary>
        /// Parameters echoed back for an inpaint generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inpaint_params")]
        public global::Sonauto.InpaintParams? InpaintParams { get; set; }

        /// <summary>
        /// Parameters echoed back for an extend generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_params")]
        public global::Sonauto.ExtendParams? ExtendParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        /// <param name="id">
        /// Task UUID.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp.
        /// </param>
        /// <param name="status"></param>
        /// <param name="alignmentStatus"></param>
        /// <param name="modelVersion">
        /// Model version used (e.g. "v2", "v3").
        /// </param>
        /// <param name="songPaths">
        /// CDN URLs for the generated songs. Expire after ~7 days.
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="lyrics"></param>
        /// <param name="prompt"></param>
        /// <param name="promptStrength"></param>
        /// <param name="tags"></param>
        /// <param name="v2Params">
        /// v2-specific parameters echoed back for the generation.
        /// </param>
        /// <param name="inpaintParams">
        /// Parameters echoed back for an inpaint generation.
        /// </param>
        /// <param name="extendParams">
        /// Parameters echoed back for an extend generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Generation(
            string? id,
            global::System.DateTime? createdAt,
            string? status,
            string? alignmentStatus,
            string? modelVersion,
            global::System.Collections.Generic.IList<string>? songPaths,
            string? errorMessage,
            string? lyrics,
            string? prompt,
            float? promptStrength,
            global::System.Collections.Generic.IList<string>? tags,
            global::Sonauto.V2Params? v2Params,
            global::Sonauto.InpaintParams? inpaintParams,
            global::Sonauto.ExtendParams? extendParams)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.AlignmentStatus = alignmentStatus;
            this.ModelVersion = modelVersion;
            this.SongPaths = songPaths;
            this.ErrorMessage = errorMessage;
            this.Lyrics = lyrics;
            this.Prompt = prompt;
            this.PromptStrength = promptStrength;
            this.Tags = tags;
            this.V2Params = v2Params;
            this.InpaintParams = inpaintParams;
            this.ExtendParams = extendParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Generation" /> class.
        /// </summary>
        public Generation()
        {
        }
    }
}