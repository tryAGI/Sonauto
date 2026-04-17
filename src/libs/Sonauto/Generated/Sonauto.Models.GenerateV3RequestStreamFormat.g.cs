
#nullable enable

namespace Sonauto
{
    /// <summary>
    /// Audio format used for streaming playback.<br/>
    /// Default Value: ogg
    /// </summary>
    public enum GenerateV3RequestStreamFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Ogg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateV3RequestStreamFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateV3RequestStreamFormat value)
        {
            return value switch
            {
                GenerateV3RequestStreamFormat.Mp3 => "mp3",
                GenerateV3RequestStreamFormat.Ogg => "ogg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateV3RequestStreamFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => GenerateV3RequestStreamFormat.Mp3,
                "ogg" => GenerateV3RequestStreamFormat.Ogg,
                _ => null,
            };
        }
    }
}