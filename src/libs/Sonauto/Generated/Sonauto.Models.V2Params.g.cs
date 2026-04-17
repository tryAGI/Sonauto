
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// v2-specific parameters echoed back for the generation.
    /// </summary>
    public sealed partial class V2Params
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_strength")]
        public float? BalanceStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Target BPM; "auto", an integer, or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bpm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sonauto.JsonConverters.OneOfJsonConverter<int?, global::Sonauto.V2ParamsBpm?>))]
        public global::Sonauto.OneOf<int?, global::Sonauto.V2ParamsBpm?>? Bpm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V2Params" /> class.
        /// </summary>
        /// <param name="balanceStrength"></param>
        /// <param name="seed"></param>
        /// <param name="bpm">
        /// Target BPM; "auto", an integer, or null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V2Params(
            float? balanceStrength,
            int? seed,
            global::Sonauto.OneOf<int?, global::Sonauto.V2ParamsBpm?>? bpm)
        {
            this.BalanceStrength = balanceStrength;
            this.Seed = seed;
            this.Bpm = bpm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2Params" /> class.
        /// </summary>
        public V2Params()
        {
        }
    }
}