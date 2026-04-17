#nullable enable

namespace Sonauto.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtendV2RequestSideNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Sonauto.ExtendV2RequestSide?>
    {
        /// <inheritdoc />
        public override global::Sonauto.ExtendV2RequestSide? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Sonauto.ExtendV2RequestSideExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Sonauto.ExtendV2RequestSide)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Sonauto.ExtendV2RequestSide?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Sonauto.ExtendV2RequestSide? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Sonauto.ExtendV2RequestSideExtensions.ToValueString(value.Value));
            }
        }
    }
}
