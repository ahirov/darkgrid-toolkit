// <copyright file="CommandOption.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Model.Command
{
    /// <summary>
    /// Command option.
    /// </summary>
    internal class CommandOption
    {
        /// <summary>
        /// Gets or sets command option name.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Gets or sets command option value.
        /// </summary>
        public string? Value { get; set; }
    }
}
