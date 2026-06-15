#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(CreditsApiGroupCommand.Create());
                         command.Subcommands.Add(GenerationsApiGroupCommand.Create());
        return command;
    }
}