#nullable enable

using System.CommandLine;

namespace Sonauto.CLI.Commands;

internal static partial class GenerationsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"generations", @"Generations endpoint commands.");
                         command.Subcommands.Add(GenerationsExtendV2CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGenerateV2CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGenerateV3CommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGetGenerationCommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsGetGenerationStatusCommandApiCommand.Create());
                         command.Subcommands.Add(GenerationsInpaintV2CommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}