
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// 
    /// </summary>
    public enum V2ParamsBpm
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ParamsBpmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ParamsBpm value)
        {
            return value switch
            {
                V2ParamsBpm.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ParamsBpm? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ParamsBpm.Auto,
                _ => null,
            };
        }
    }
}