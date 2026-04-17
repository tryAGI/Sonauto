
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Status payload when `include_alignment=true`.
    /// </summary>
    public sealed partial class GenerationStatus
    {
        /// <summary>
        /// Generation status (e.g. PENDING, RUNNING, SUCCESS, FAILURE).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Lyrics alignment status, or null if not applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_status")]
        public string? AlignmentStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// Generation status (e.g. PENDING, RUNNING, SUCCESS, FAILURE).
        /// </param>
        /// <param name="alignmentStatus">
        /// Lyrics alignment status, or null if not applicable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationStatus(
            string? status,
            string? alignmentStatus)
        {
            this.Status = status;
            this.AlignmentStatus = alignmentStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatus" /> class.
        /// </summary>
        public GenerationStatus()
        {
        }
    }
}