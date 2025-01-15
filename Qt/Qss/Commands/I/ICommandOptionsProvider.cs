// <copyright file="ICommandOptionsProvider.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands.I
{
    using System.Collections.Generic;
    using DarkgridToolkit.Qt.Qss.Model.Command;

    /// <summary>
    /// Provide command options collections.
    /// </summary>
    internal interface ICommandOptionsProvider
    {
        /// <summary>
        /// Get the command options collection from the string options.
        /// </summary>
        /// <param name="options">String options, like --option or --option=value.</param>
        /// <returns>Structured command options collection.</returns>
        CommandOptions Get(List<string> options);
    }
}
