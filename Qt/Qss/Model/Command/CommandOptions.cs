// <copyright file="CommandOptions.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Model.Command
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// Command options collection.
    /// </summary>
    internal class CommandOptions : KeyedCollection<string, CommandOption>
    {
        /// <summary>
        /// Command option key provider.
        /// </summary>
        /// <param name="item">Selected item.</param>
        /// <returns>Key value.</returns>
        protected override string GetKeyForItem(CommandOption item)
        {
            return item.Name;
        }
    }
}
