// <copyright file="ICommandProvider.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands.I
{
    using DarkgridToolkit.Qt.Qss.Model.Command;

    /// <summary>
    /// Provide command enum items.
    /// </summary>
    internal interface ICommandProvider
    {
        /// <summary>
        /// Get the command enum item from the string name.
        /// </summary>
        /// <param name="commandName">String command name.</param>
        /// <returns>Available command or default Unknown command.</returns>
        Command Get(string commandName);
    }
}
