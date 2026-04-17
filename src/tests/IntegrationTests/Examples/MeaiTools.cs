/*
order: 30
title: MEAI Tools
slug: meai-tools

Shows how to use Sonauto as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Sonauto.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_AsGenerateSongTool()
    {
        //// Use the generate-song tool. It can be passed to any IChatClient via ChatOptions.Tools.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsGenerateSongTool();

        tool.Name.Should().Be("SonautoGenerateSong");
        tool.Description.Should().Contain("Sonauto");
    }

    [TestMethod]
    public void Example_AsGetSongStatusTool()
    {
        //// Use the get-status tool to poll a generation by its task_id.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsGetSongStatusTool();

        tool.Name.Should().Be("SonautoGetSongStatus");
        tool.Description.Should().Contain("status");
    }

    [TestMethod]
    public void Example_AsGetSongTool()
    {
        //// Use the get-song tool to fetch the completed generation's download URLs.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsGetSongTool();

        tool.Name.Should().Be("SonautoGetSong");
        tool.Description.Should().Contain("download");
    }

    [TestMethod]
    public void Example_AsGetCreditsTool()
    {
        //// Use the credits tool to check remaining account credits.

        using var client = GetAuthenticatedClient();

        AIFunction tool = client.AsGetCreditsTool();

        tool.Name.Should().Be("SonautoGetCredits");
        tool.Description.Should().Contain("credits");
    }
}
