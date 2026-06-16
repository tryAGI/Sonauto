#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class GenerationsInpaintV2CommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"",
    };

    private static Option<string> Lyrics { get; } = new(
        name: @"--lyrics")
    {
        Description = @"Lyrics for the inpainted sections.",
        Required = true,
    };

    private static Option<string?> Prompt { get; } = new(
        name: @"--prompt")
    {
        Description = @"",
    };

    private static Option<bool?> Instrumental { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--instrumental",
        description: @"");

    private static Option<float?> PromptStrength { get; } = new(
        name: @"--prompt-strength")
    {
        Description = @"",
    };

    private static Option<float?> BalanceStrength { get; } = new(
        name: @"--balance-strength")
    {
        Description = @"",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"",
    };

    private static Option<int?> NumSongs { get; } = new(
        name: @"--num-songs")
    {
        Description = @"",
    };

    private static Option<string?> OutputFormat { get; } = new(
        name: @"--output-format")
    {
        Description = @"",
    };

    private static Option<int?> OutputBitRate { get; } = new(
        name: @"--output-bit-rate")
    {
        Description = @"",
    };

    private static Option<bool?> AlignLyrics { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--align-lyrics",
        description: @"");

    private static Option<string?> AudioUrl { get; } = new(
        name: @"--audio-url")
    {
        Description = @"",
    };

    private static Option<string?> AudioBase64 { get; } = new(
        name: @"--audio-base64")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>> Sections { get; } = new(
        name: @"--sections")
    {
        Description = @"List of [start_seconds, end_seconds] pairs to regenerate.",
        Required = true,
    };

    private static Option<bool?> SelectionCrop { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--selection-crop",
        description: @"Crop the output to just the inpainted sections.");
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
        var command = new Command(@"inpaint-v2", @"Inpaint a section of a song (v2)
Regenerates one or more sections of an existing clip.");
                        command.Options.Add(Tags);
                        command.Options.Add(Lyrics);
                        command.Options.Add(Prompt);
                        command.Options.Add(Instrumental);
                        command.Options.Add(PromptStrength);
                        command.Options.Add(BalanceStrength);
                        command.Options.Add(Seed);
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(NumSongs);
                        command.Options.Add(OutputFormat);
                        command.Options.Add(OutputBitRate);
                        command.Options.Add(AlignLyrics);
                        command.Options.Add(AudioUrl);
                        command.Options.Add(AudioBase64);
                        command.Options.Add(Sections);
                        command.Options.Add(SelectionCrop);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Sonauto.InpaintV2Request>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Sonauto.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);
                        var lyrics = parseResult.GetRequiredValue(Lyrics);
                        var prompt = CliRuntime.WasSpecified(parseResult, Prompt) ? parseResult.GetValue(Prompt) : (__requestBase is { } __PromptBaseValue ? __PromptBaseValue.Prompt : default);
                        var instrumental = CliRuntime.WasSpecified(parseResult, Instrumental) ? parseResult.GetValue(Instrumental) : (__requestBase is { } __InstrumentalBaseValue ? __InstrumentalBaseValue.Instrumental : default);
                        var promptStrength = CliRuntime.WasSpecified(parseResult, PromptStrength) ? parseResult.GetValue(PromptStrength) : (__requestBase is { } __PromptStrengthBaseValue ? __PromptStrengthBaseValue.PromptStrength : default);
                        var balanceStrength = CliRuntime.WasSpecified(parseResult, BalanceStrength) ? parseResult.GetValue(BalanceStrength) : (__requestBase is { } __BalanceStrengthBaseValue ? __BalanceStrengthBaseValue.BalanceStrength : default);
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : (__requestBase is { } __WebhookUrlBaseValue ? __WebhookUrlBaseValue.WebhookUrl : default);
                        var numSongs = CliRuntime.WasSpecified(parseResult, NumSongs) ? parseResult.GetValue(NumSongs) : (__requestBase is { } __NumSongsBaseValue ? __NumSongsBaseValue.NumSongs : default);
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : (__requestBase is { } __OutputFormatBaseValue ? __OutputFormatBaseValue.OutputFormat : default);
                        var outputBitRate = CliRuntime.WasSpecified(parseResult, OutputBitRate) ? parseResult.GetValue(OutputBitRate) : (__requestBase is { } __OutputBitRateBaseValue ? __OutputBitRateBaseValue.OutputBitRate : default);
                        var alignLyrics = CliRuntime.WasSpecified(parseResult, AlignLyrics) ? parseResult.GetValue(AlignLyrics) : (__requestBase is { } __AlignLyricsBaseValue ? __AlignLyricsBaseValue.AlignLyrics : default);
                        var audioUrl = CliRuntime.WasSpecified(parseResult, AudioUrl) ? parseResult.GetValue(AudioUrl) : (__requestBase is { } __AudioUrlBaseValue ? __AudioUrlBaseValue.AudioUrl : default);
                        var audioBase64 = CliRuntime.WasSpecified(parseResult, AudioBase64) ? parseResult.GetValue(AudioBase64) : (__requestBase is { } __AudioBase64BaseValue ? __AudioBase64BaseValue.AudioBase64 : default);
                        var sections = parseResult.GetRequiredValue(Sections);
                        var selectionCrop = CliRuntime.WasSpecified(parseResult, SelectionCrop) ? parseResult.GetValue(SelectionCrop) : (__requestBase is { } __SelectionCropBaseValue ? __SelectionCropBaseValue.SelectionCrop : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Generations.InpaintV2Async(
                                    tags: tags,
                                    lyrics: lyrics,
                                    prompt: prompt,
                                    instrumental: instrumental,
                                    promptStrength: promptStrength,
                                    balanceStrength: balanceStrength,
                                    seed: seed,
                                    webhookUrl: webhookUrl,
                                    numSongs: numSongs,
                                    outputFormat: outputFormat,
                                    outputBitRate: outputBitRate,
                                    alignLyrics: alignLyrics,
                                    audioUrl: audioUrl,
                                    audioBase64: audioBase64,
                                    sections: sections,
                                    selectionCrop: selectionCrop,
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