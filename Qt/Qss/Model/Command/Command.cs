// <copyright file="Command.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Model.Command
{
    using System.ComponentModel;

    /// <summary>
    /// Console application commands.
    /// </summary>
    internal enum Command
    {
        /// <summary>
        /// Command not recognized.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Show help information.
        /// </summary>
        [Description("help")]
        Help = 1,

        /// <summary>
        /// Show configuration information.
        /// </summary>
        [Description("info")]
        Info = 2,

        /// <summary>
        /// Run configuration process.
        /// </summary>
        [Description("config")]
        Config = 3,

        /// <summary>
        /// Run style sheets generation process.
        /// </summary>
        [Description("run")]
        Run = 4,
    }
}
