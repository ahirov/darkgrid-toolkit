// <copyright file="ConfigCommand.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Model.Command
{
    using System;

    /// <summary>
    /// Process options and write configuration file.
    /// </summary>
    internal class ConfigCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigCommand"/> class.
        /// Use default configuration options.
        /// </summary>
        public ConfigCommand()
        {
            // TODO.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigCommand"/> class.
        /// Process configuration options.
        /// </summary>
        /// <param name="options">Options collection.</param>
        public ConfigCommand(CommandOptions options)
        {
            // TODO.
        }

        /// <summary>
        /// Execute the command.
        /// </summary>
        /// <exception cref="NotImplementedException">Temp.</exception>
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
