
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Envelope returned when a generation task is accepted.
    /// </summary>
    public sealed partial class TaskResponse
    {
        /// <summary>
        /// Identifier used with status/result endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Identifier used with status/result endpoints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskResponse(
            string taskId)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResponse" /> class.
        /// </summary>
        public TaskResponse()
        {
        }
    }
}