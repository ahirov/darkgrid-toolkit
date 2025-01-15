// <copyright file="CommandExecutor.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Commands
{
    using System.Diagnostics.CodeAnalysis;
    using DarkgridToolkit.Qt.Qss.Commands.I;
    using DarkgridToolkit.Qt.Qss.Model.Command;

    /// <summary>
    /// The implementation of <see cref="ICommandExecutor"/>.
    /// </summary>
    internal class CommandExecutor : ICommandExecutor
    {
        private readonly Func<Command, CommandOptions, ICommand> commandFactory;
        private readonly ICommandOptionsProvider commandOptionsProvider;
        private readonly ICommandProvider commandProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandExecutor"/> class.
        /// </summary>
        /// <param name="commandFactory">Command factory method.</param>
        /// <param name="commandOptionsProvider">Command options provider service.</param>
        /// <param name="commandProvider">Command provider service.</param>
        [SuppressMessage("Style", "IDE0290:Use primary constructor", Justification = "Service")]
        public CommandExecutor(
            Func<Command, CommandOptions, ICommand> commandFactory,
            ICommandOptionsProvider commandOptionsProvider,
            ICommandProvider commandProvider)
        {
            this.commandFactory = commandFactory;
            this.commandProvider = commandProvider;
            this.commandOptionsProvider = commandOptionsProvider;
        }

        /// <summary>
        /// Execute a command with options.
        /// </summary>
        /// <param name="arguments">>Command and options.</param>
        /// <exception cref="InvalidOperationException">Invalid inputs.</exception>
        public void Run(List<string> arguments)
        {
            if (arguments.Count != 0)
            {
                string commandArgument = arguments.First();
                Command command = this.commandProvider.Get(commandArgument);

                if (command != default)
                {
                    List<string> optionArguments = arguments.Skip(1).ToList();
                    CommandOptions options = this.commandOptionsProvider.Get(optionArguments);

                    this.commandFactory(command, options).Run();
                }
                else
                {
                    throw new InvalidOperationException("The command was not found.");
                }
            }
            else
            {
                throw new InvalidOperationException("No arguments were found.");
            }
        }
    }
}
