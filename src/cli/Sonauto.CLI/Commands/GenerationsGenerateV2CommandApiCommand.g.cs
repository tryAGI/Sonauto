#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class GenerationsGenerateV2CommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"",
    };

    private static Option<string?> Lyrics { get; } = new(
        name: @"--lyrics")
    {
        Description = @"",
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
        Description = @"Deterministic seed.",
    };

    private static Option<string?> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"",
    };

    private static Option<int?> NumSongs { get; } = new(
        name: @"--num-songs")
    {
        Description = @"Number of song variations to generate (v2 only).",
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

    private static Option<global::Sonauto.OneOf<int?, global::Sonauto.GenerateV2RequestBpm?>?> Bpm { get; } = new(
        name: @"--bpm")
    {
        Description = @"Target BPM; use the string ""auto"" or an integer.",
    };
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
        var command = new Command(@"generate-v2", @"Generate a song (Melodia v2)
Kicks off a v2 generation task. v2 does not stream but supports `num_songs`,
`balance_strength`, `seed`, and BPM control.
");
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
                        command.Options.Add(Bpm);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Sonauto.GenerateV2Request>(
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
                        var balanceStrength = CliRuntime.WasSpecified(parseResult, BalanceStrength) ? parseResult.GetValue(BalanceStrength) : __requestBase is not null ? __requestBase.BalanceStrength : default;
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : __requestBase is not null ? __requestBase.Seed : default;
                        var webhookUrl = CliRuntime.WasSpecified(parseResult, WebhookUrl) ? parseResult.GetValue(WebhookUrl) : __requestBase is not null ? __requestBase.WebhookUrl : default;
                        var numSongs = CliRuntime.WasSpecified(parseResult, NumSongs) ? parseResult.GetValue(NumSongs) : __requestBase is not null ? __requestBase.NumSongs : default;
                        var outputFormat = CliRuntime.WasSpecified(parseResult, OutputFormat) ? parseResult.GetValue(OutputFormat) : __requestBase is not null ? __requestBase.OutputFormat : default;
                        var outputBitRate = CliRuntime.WasSpecified(parseResult, OutputBitRate) ? parseResult.GetValue(OutputBitRate) : __requestBase is not null ? __requestBase.OutputBitRate : default;
                        var alignLyrics = CliRuntime.WasSpecified(parseResult, AlignLyrics) ? parseResult.GetValue(AlignLyrics) : __requestBase is not null ? __requestBase.AlignLyrics : default;
                        var bpm = CliRuntime.WasSpecified(parseResult, Bpm) ? parseResult.GetValue(Bpm) : __requestBase is not null ? __requestBase.Bpm : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Generations.GenerateV2Async(
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
                                    bpm: bpm,
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