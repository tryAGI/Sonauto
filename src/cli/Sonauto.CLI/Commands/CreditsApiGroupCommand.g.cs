#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static class CreditsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"credits", @"Credits endpoint commands.");
                         command.Subcommands.Add(CreditsGetCreditsBalanceCommandApiCommand.Create());
        return command;
    }
}