
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Which side of the source audio to extend.
    /// </summary>
    public enum ExtendV2RequestSide
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtendV2RequestSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtendV2RequestSide value)
        {
            return value switch
            {
                ExtendV2RequestSide.Left => "left",
                ExtendV2RequestSide.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtendV2RequestSide? ToEnum(string value)
        {
            return value switch
            {
                "left" => ExtendV2RequestSide.Left,
                "right" => ExtendV2RequestSide.Right,
                _ => null,
            };
        }
    }
}