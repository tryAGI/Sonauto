#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static class GenerationsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"generations", @"Generations endpoint commands.");
                         command.Subcommands.Add(GenerationsExtendV2CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGenerateV2CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGenerateV3CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGetGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGetGenerationStatusCommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsInpaintV2CommandApiCommand.Create());
        return command;
    }
}