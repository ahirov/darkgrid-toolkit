// <copyright file="ICommandExecutor.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands.I
{
    /// <summary>
    /// Executor of the selected command with options.
    /// </summary>
    internal interface ICommandExecutor
    {
        /// <summary>
        /// Execute a command with options.
        /// </summary>
        /// <param name="arguments">Command and options.</param>
        void Run(List<string> arguments);
    }
}
