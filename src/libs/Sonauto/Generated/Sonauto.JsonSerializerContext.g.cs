
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Sonauto
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Sonauto.JsonConverters.GenerateV3RequestStreamFormatJsonConverter),

            typeof(global::Sonauto.JsonConverters.GenerateV3RequestStreamFormatNullableJsonConverter),

            typeof(global::Sonauto.JsonConverters.GenerateV2RequestBpmJsonConverter),

            typeof(global::Sonauto.JsonConverters.GenerateV2RequestBpmNullableJsonConverter),

            typeof(global::Sonauto.JsonConverters.ExtendV2RequestSideJsonConverter),

            typeof(global::Sonauto.JsonConverters.ExtendV2RequestSideNullableJsonConverter),

            typeof(global::Sonauto.JsonConverters.V2ParamsBpmJsonConverter),

            typeof(global::Sonauto.JsonConverters.V2ParamsBpmNullableJsonConverter),

            typeof(global::Sonauto.JsonConverters.OneOfJsonConverter<int?, global::Sonauto.GenerateV2RequestBpm?>),

            typeof(global::Sonauto.JsonConverters.OneOfJsonConverter<int?, global::Sonauto.V2ParamsBpm?>),

            typeof(global::Sonauto.JsonConverters.OneOfJsonConverter<string, global::Sonauto.GenerationStatus>),

            typeof(global::Sonauto.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.GenerateV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.GenerateV3RequestStreamFormat), TypeInfoPropertyName = "GenerateV3RequestStreamFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.GenerateV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.OneOf<int?, global::Sonauto.GenerateV2RequestBpm?>), TypeInfoPropertyName = "OneOfInt32GenerateV2RequestBpm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.GenerateV2RequestBpm), TypeInfoPropertyName = "GenerateV2RequestBpm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.ExtendV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.ExtendV2RequestSide), TypeInfoPropertyName = "ExtendV2RequestSide2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.InpaintV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.GenerationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.Generation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.V2Params))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.InpaintParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.ExtendParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.OneOf<int?, global::Sonauto.V2ParamsBpm?>), TypeInfoPropertyName = "OneOfInt32V2ParamsBpm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.V2ParamsBpm), TypeInfoPropertyName = "V2ParamsBpm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.CreditsBalance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sonauto.OneOf<string, global::Sonauto.GenerationStatus>), TypeInfoPropertyName = "OneOfStringGenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}