
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Remaining subscription and pay-as-you-go credits.
    /// </summary>
    public sealed partial class CreditsBalance
    {
        /// <summary>
        /// Remaining subscription credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_credits")]
        public int? NumCredits { get; set; }

        /// <summary>
        /// Remaining pay-as-you-go credits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_credits_payg")]
        public int? NumCreditsPayg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsBalance" /> class.
        /// </summary>
        /// <param name="numCredits">
        /// Remaining subscription credits.
        /// </param>
        /// <param name="numCreditsPayg">
        /// Remaining pay-as-you-go credits.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreditsBalance(
            int? numCredits,
            int? numCreditsPayg)
        {
            this.NumCredits = numCredits;
            this.NumCreditsPayg = numCreditsPayg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditsBalance" /> class.
        /// </summary>
        public CreditsBalance()
        {
        }
    }
}