// <copyright file="RunCommand.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Model.Command
{
    using System;

    /// <summary>
    /// Read configuration file and write qss files.
    /// </summary>
    internal class RunCommand : ICommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunCommand"/> class.
        /// Use default run command options.
        /// </summary>
        public RunCommand()
        {
            // TODO.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunCommand"/> class.
        /// Process run command options.
        /// </summary>
        /// <param name="options">Options collection.</param>
        public RunCommand(CommandOptions options)
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
