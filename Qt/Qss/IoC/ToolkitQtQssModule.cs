// <copyright file="ToolkitQtQssModule.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.IoC
{
    using Autofac;
    using DarkgridToolkit.Qt.Qss.Model.Command;

    /// <summary>
    /// Autofac IoC module for DarkgridToolkitQtQss project.
    /// </summary>
    internal class ToolkitQtQssModule : Module
    {
        /// <summary>
        /// Registering types and mapping corresponding interfaces.
        /// </summary>
        /// <param name="builder">Common container.</param>
        /// <exception cref="InvalidOperationException">Not supported command.</exception>
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterAssemblyTypes(typeof(ToolkitQtQssModule).Assembly)
                .AsImplementedInterfaces()
                .SingleInstance();

            builder.Register<Command, CommandOptions, ICommand>((command, options) =>
            {
                Dictionary<Command, Func<CommandOptions, ICommand>> scheme = new()
                {
                    { Command.Help,   (options) => new HelpCommand() },
                    { Command.Info,   (options) => new InfoCommand() },
                    { Command.Config, (options) => new ConfigCommand(options) },
                    { Command.Run,    (options) => new RunCommand(options) },
                };
                if (scheme.TryGetValue(
                    command,
                    out Func<CommandOptions, ICommand>? value))
                {
                    return value(options);
                }

                throw new InvalidOperationException($"'{command}' command not supported.");
            });
        }
    }
}
