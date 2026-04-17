/*
order: 20
title: Poll Status and Get Result
slug: poll-status

Shows how to poll a Sonauto generation task until it succeeds, then fetch the song URLs.
*/

namespace Sonauto.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_PollStatus_AndGetResult()
    {
        //// Start a generation, poll its status until SUCCESS, then download song metadata
        //// (including CDN URLs). Song URLs expire after ~7 days.

        using var client = GetAuthenticatedClient();

        var started = await client.Generations.GenerateV3Async(
            prompt: "A calm piano piece for focused work");

        started.TaskId.Should().NotBeNullOrWhiteSpace();

        string status = "PENDING";
        for (var i = 0; i < 30 && status is not "SUCCESS" and not "FAILURE"; i++)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            var result = await client.Generations.GetGenerationStatusAsync(
                taskId: started.TaskId);
            status = result.Value1 ?? result.Value2?.Status ?? "PENDING";
        }

        if (status != "SUCCESS")
        {
            throw new AssertInconclusiveException($"Generation did not complete within timeout (status={status}).");
        }

        var generation = await client.Generations.GetGenerationAsync(taskId: started.TaskId);
        generation.SongPaths.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Example_GetCreditsBalance()
    {
        //// Check how many Sonauto credits remain on the account.

        using var client = GetAuthenticatedClient();

        var balance = await client.Credits.GetCreditsBalanceAsync();

        (balance.NumCredits ?? 0).Should().BeGreaterThanOrEqualTo(0);
    }
}
