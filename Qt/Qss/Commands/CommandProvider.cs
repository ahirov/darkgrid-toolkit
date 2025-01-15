// <copyright file="CommandProvider.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands
{
    using System.ComponentModel;
    using DarkgridToolkit.Qt.Qss.Commands.I;
    using DarkgridToolkit.Qt.Qss.Model.Command;
    using EnumUtilities;

    /// <summary>
    /// The implementation of <see cref="ICommandProvider"/>.
    /// </summary>
    internal class CommandProvider : ICommandProvider
    {
        /// <summary>
        /// Find the first available command based on the string command name.
        /// </summary>
        /// <param name="commandName">String command name.</param>
        /// <returns>Available command or default Unknown command.</returns>
        public Command Get(string commandName)
        {
            return EnumUtil<Command>
                    .GetValues()
                    .Where(command => command != Command.Unknown)
                    .FirstOrDefault(command => GetCommandName(command) == commandName);
        }

        private static string GetCommandName(Command command)
        {
            // Command names are stored in description attributes.
            return EnumUtil<Command>
                .GetAttribute<DescriptionAttribute>(command)
                .Description;
        }
    }
}
