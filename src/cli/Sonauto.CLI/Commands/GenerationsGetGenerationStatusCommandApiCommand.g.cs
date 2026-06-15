#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class GenerationsGetGenerationStatusCommandApiCommand
{
    private static Argument<string> TaskId { get; } = new(
        name: @"task-id")
    {
        Description = @"The task identifier returned by a generation request.",
    };

    private static Option<bool?> IncludeAlignment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-alignment",
        description: @"When true, response also includes the lyrics `alignment_status`.");

                    private static string FormatResponse(ParseResult parseResult, global::Sonauto.OneOf<string, global::Sonauto.GenerationStatus> value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Sonauto.OneOf<string, global::Sonauto.GenerationStatus> value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-generation-status", @"Get generation status
Returns the current status (e.g. PENDING, RUNNING, SUCCESS, FAILURE) for a task.");
                        command.Arguments.Add(TaskId);
                        command.Options.Add(IncludeAlignment);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var taskId = parseResult.GetRequiredValue(TaskId);
                        var includeAlignment = parseResult.GetValue(IncludeAlignment);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Generations.GetGenerationStatusAsync(
                                    taskId: taskId,
                                    includeAlignment: includeAlignment,
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