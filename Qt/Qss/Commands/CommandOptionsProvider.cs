// <copyright file="CommandOptionsProvider.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using DarkgridToolkit.Qt.Qss.Commands.I;
    using DarkgridToolkit.Qt.Qss.Model.Command;

    /// <summary>
    /// The implementation of <see cref="ICommandOptionsProvider"/>.
    /// </summary>
    internal class CommandOptionsProvider : ICommandOptionsProvider
    {
        /// <summary>
        /// Match command options from strings and get them as objects.
        /// </summary>
        /// <param name="options">String options, like --option or --option=value.</param>
        /// <returns>Structured command options collection.</returns>
        public CommandOptions Get(List<string> options)
        {
            return [.. options.Select(option => Get(option))];
        }

        private static CommandOption Get(string option)
        {
            string optionPattern = "^--(?<key>[a-zA-Z]+[a-zA-Z-]*)$";
            string optionWithValuePattern = "^--(?<key>[a-zA-Z]+[a-zA-Z-]*)=(?<value>[a-zA-Z0-9.:/_]+)*$";

            Match optionMatch = Regex.Match(option, optionPattern);
            Match optionWithValueMatch = Regex.Match(option, optionWithValuePattern);

            if (optionMatch.Success)
            {
                return new CommandOption()
                {
                    Name = optionMatch.Groups["key"].Value,
                };
            }
            else if (optionWithValueMatch.Success)
            {
                return new CommandOption()
                {
                    Name = optionWithValueMatch.Groups["key"].Value,
                    Value = optionWithValueMatch.Groups["value"].Value,
                };
            }
            else
            {
                throw new InvalidOperationException("Invalid command option format.");
            }
        }
    }
}
