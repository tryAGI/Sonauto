/*
order: 10
title: Generate a Song
slug: generate-song

Shows how to start a Sonauto song generation and retrieve the resulting task id.
*/

namespace Sonauto.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateSong_V3()
    {
        //// Start a Melodia v3 generation from a natural-language prompt and style tags.
        //// Returns a task_id used to poll for completion.

        using var client = GetAuthenticatedClient();

        var response = await client.Generations.GenerateV3Async(
            prompt: "An upbeat pop-rock song about debugging code at 3am",
            tags: ["pop-rock", "uplifting", "electric guitar"],
            instrumental: false);

        response.TaskId.Should().NotBeNullOrWhiteSpace();
    }

    [TestMethod]
    public async Task Example_GenerateSong_WithLyrics()
    {
        //// Start a generation from explicit lyrics. Use `[verse]` / `[chorus]` markers for
        //// structure. Sonauto aligns the vocals to the lyrics automatically.

        using var client = GetAuthenticatedClient();

        var response = await client.Generations.GenerateV3Async(
            tags: ["acoustic", "folk"],
            lyrics: "[verse]\nWalking down the road alone\n[chorus]\nHome, I'm going home",
            alignLyrics: true);

        response.TaskId.Should().NotBeNullOrWhiteSpace();
    }
}
