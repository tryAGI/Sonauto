#nullable enable

using Microsoft.Extensions.AI;

namespace Sonauto;

/// <summary>
/// Extensions for using <see cref="SonautoClient"/> as MEAI tools with any <see cref="IChatClient"/>.
/// </summary>
public static class SonautoToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates a song with Melodia v3 from a natural
    /// language prompt, optional lyrics, and style tags. Returns the task id used to poll the result.
    /// </summary>
    /// <param name="client">The Sonauto client.</param>
    [CLSCompliant(false)]
    public static AIFunction AsGenerateSongTool(this SonautoClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                string? prompt,
                string? lyrics,
                string[]? tags,
                bool? instrumental,
                bool? enableStreaming,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Generations.GenerateV3Async(
                    tags: tags,
                    lyrics: lyrics,
                    prompt: prompt,
                    instrumental: instrumental,
                    enableStreaming: enableStreaming,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Generation started. task_id: {response.TaskId}";
            },
            name: "SonautoGenerateSong",
            description: "Starts a Sonauto (Melodia v3) song generation from a natural-language prompt, optional lyrics, and optional style tags. Returns a task_id for polling. Set enableStreaming=true to allow streaming playback.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that polls the current status of a generation task.
    /// </summary>
    /// <param name="client">The Sonauto client.</param>
    [CLSCompliant(false)]
    public static AIFunction AsGetSongStatusTool(this SonautoClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, bool? includeAlignment, CancellationToken cancellationToken) =>
            {
                var result = await client.Generations.GetGenerationStatusAsync(
                    taskId: taskId,
                    includeAlignment: includeAlignment,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                if (result.IsValue1 && result.Value1 is { } statusString)
                {
                    return $"task_id: {taskId}\nstatus: {statusString}";
                }

                if (result.IsValue2 && result.Value2 is { } statusObj)
                {
                    var alignment = string.IsNullOrWhiteSpace(statusObj.AlignmentStatus)
                        ? "n/a"
                        : statusObj.AlignmentStatus;
                    return $"task_id: {taskId}\nstatus: {statusObj.Status}\nalignment_status: {alignment}";
                }

                return $"task_id: {taskId}\nstatus: (unknown)";
            },
            name: "SonautoGetSongStatus",
            description: "Gets the status (PENDING / RUNNING / SUCCESS / FAILURE) of a Sonauto generation task by its task_id. Optionally include lyrics alignment_status.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves a completed generation's metadata and
    /// song download URLs.
    /// </summary>
    /// <param name="client">The Sonauto client.</param>
    [CLSCompliant(false)]
    public static AIFunction AsGetSongTool(this SonautoClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string taskId, CancellationToken cancellationToken) =>
            {
                var generation = await client.Generations.GetGenerationAsync(
                    taskId: taskId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGeneration(generation);
            },
            name: "SonautoGetSong",
            description: "Retrieves a completed Sonauto generation, including the song download URLs, lyrics, and tags.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns the Sonauto account's remaining credit balance.
    /// </summary>
    /// <param name="client">The Sonauto client.</param>
    [CLSCompliant(false)]
    public static AIFunction AsGetCreditsTool(this SonautoClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var balance = await client.Credits.GetCreditsBalanceAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Subscription credits: {balance.NumCredits ?? 0}\nPay-as-you-go credits: {balance.NumCreditsPayg ?? 0}";
            },
            name: "SonautoGetCredits",
            description: "Returns the remaining Sonauto subscription credits and pay-as-you-go credits on the account.");
    }

    private static string FormatGeneration(Generation generation)
    {
        var parts = new List<string>
        {
            $"Generation: {generation.Id ?? "(no id)"}",
            $"Status: {generation.Status ?? "(unknown)"}",
        };

        if (!string.IsNullOrWhiteSpace(generation.ModelVersion))
        {
            parts.Add($"Model: {generation.ModelVersion}");
        }

        if (generation.Tags is { Count: > 0 })
        {
            parts.Add($"Tags: {string.Join(", ", generation.Tags)}");
        }

        if (generation.SongPaths is { Count: > 0 })
        {
            parts.Add("Songs:");
            foreach (var path in generation.SongPaths)
            {
                parts.Add($"  - {path}");
            }
        }

        if (!string.IsNullOrWhiteSpace(generation.ErrorMessage))
        {
            parts.Add($"Error: {generation.ErrorMessage}");
        }

        return string.Join("\n", parts);
    }
}
