
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerateV2RequestBpm
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateV2RequestBpmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateV2RequestBpm value)
        {
            return value switch
            {
                GenerateV2RequestBpm.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateV2RequestBpm? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateV2RequestBpm.Auto,
                _ => null,
            };
        }
    }
}