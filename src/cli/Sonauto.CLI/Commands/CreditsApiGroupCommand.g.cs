#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class CreditsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"credits", @"Credits endpoint commands.");
                         command.Subcommands.Add(CreditsGetCreditsBalanceCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}