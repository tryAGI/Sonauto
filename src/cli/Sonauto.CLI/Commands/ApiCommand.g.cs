#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class ApiCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(CreditsApiGroupCommand.Create());
                         command.Subcommands.Add(GenerationsApiGroupCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}