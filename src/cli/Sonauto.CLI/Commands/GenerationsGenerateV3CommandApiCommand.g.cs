#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class GenerationsGenerateV3CommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Style descriptors (e.g. ""rock"", ""uplifting""). Optional but recommended.",
    };

    private static Option<string?> Lyrics { get; } = new(
        name: @"--lyrics")
    {
        Description = @"Song lyrics. Use `[verse]`, `[chorus]`, and other markers for structure.",
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"Natural language description of the desired song.",
    };

    private static Option<bool?> Instrumental { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--instrumental",
        description: @"Generate an instrumental (no vocals).");

    private static Option<float?> PromptStrength { get; } = new(
        name: @"--prompt-strength")
    {
        Description = @"How closely the model should follow the prompt. Higher = stricter.",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"URL to POST the result to when the task completes.",
    };

    private static Option<string?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"Output audio format (ogg, mp3, flac, wav, m4a).",
    };

    private static Option<int?> OutputBitRate { get; } = new(
        name: @"--output-bit-rate")
    {
        Description = @"Optional bit rate for the output file.",
    };

    private static Option<bool?> EnableStreaming { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enable-streaming",
        description: @"When true, the song can be streamed while still generating.");

    private static Option<global::Sonauto.GenerateV3RequestStreamFormat?> StreamFormat { get; } = new(
        name: @"--stream-format")
    {
        Description = @"Audio format used for streaming playback.",
    };

    private static Option<bool?> AlignLyrics { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--align-lyrics",
        description: @"Include time-aligned lyrics in the result.");
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Sonauto.TaskResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sonauto.TaskResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"generate-v3", @"Generate a song (Melodia v3, streaming-capable)
Kicks off a v3 generation task. v3 supports streaming playback via the
separate streaming endpoint when `enable_streaming` is `true`.
");
                        command.Options.Add(Tags);
                        command.Options.Add(Lyrics);
                        command.Options.Add(Prompt);
                        command.Options.Add(Instrumental);
                        command.Options.Add(PromptStrength);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(OutputBitRate);
                        command.Options.Add(EnableStreaming);
                        command.Options.Add(StreamFormat);
                        command.Options.Add(AlignLyrics);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Sonauto.GenerateV3Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Sonauto.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : __requestBase is not null ? __requestBase.Tags : default;
                        var lyrics = CliRuntime.WasSpecified(parseResult, Lyrics) ? parseResult.GetValue(Lyrics) : __requestBase is not null ? __requestBase.Lyrics : default;
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : __requestBase is not null ? __requestBase.Prompt : default;
                        var instrumental = CliRuntime.WasSpecified(parseResult, Instrumental) ? parseResult.GetValue(Instrumental) : __requestBase is not null ? __requestBase.Instrumental : default;
                        var promptStrength = CliRuntime.WasSpecified(parseResult, PromptStrength) ? parseResult.GetValue(PromptStrength) : __requestBase is not null ? __requestBase.PromptStrength : default;
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : __requestBase is not null ? __requestBase.WebhookUrl : default;
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : __requestBase is not null ? __requestBase.OutputFormat : default;
                        var outputBitRate = CliRuntime.WasSpecified(parseResult, OutputBitRate) ? parseResult.GetValue(OutputBitRate) : __requestBase is not null ? __requestBase.OutputBitRate : default;
                        var enableStreaming = CliRuntime.WasSpecified(parseResult, EnableStreaming) ? parseResult.GetValue(EnableStreaming) : __requestBase is not null ? __requestBase.EnableStreaming : default;
                        var streamFormat = CliRuntime.WasSpecified(parseResult, StreamFormat) ? parseResult.GetValue(StreamFormat) : __requestBase is not null ? __requestBase.StreamFormat : default;
                        var alignLyrics = CliRuntime.WasSpecified(parseResult, AlignLyrics) ? parseResult.GetValue(AlignLyrics) : __requestBase is not null ? __requestBase.AlignLyrics : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Generations.GenerateV3Async(
                                    tags: tags,
                                    lyrics: lyrics,
                                    prompt: prompt,
                                    instrumental: instrumental,
                                    promptStrength: promptStrength,
                                    webhookUrl: webhookUrl,
                                    outputFormat: outputFormat,
                                    outputBitRate: outputBitRate,
                                    enableStreaming: enableStreaming,
                                    streamFormat: streamFormat,
                                    alignLyrics: alignLyrics,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Sonauto.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}