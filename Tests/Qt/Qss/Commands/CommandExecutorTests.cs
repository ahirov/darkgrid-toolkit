// <copyright file="CommandExecutorTests.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss.Tests.Commands
{
    using System.Diagnostics.CodeAnalysis;
    using DarkgridToolkit.Qt.Qss.Commands;
    using DarkgridToolkit.Qt.Qss.Commands.I;
    using DarkgridToolkit.Qt.Qss.Model.Command;
    using FluentAssertions;
    using NSubstitute;
    using NSubstitute.ReceivedExtensions;

    /// <summary>
    /// CommandExecutor tests class.
    /// </summary>
    public class CommandExecutorTests
    {
        // System under test
        private CommandExecutor commandExecutor;

        // External dependencies
        private Func<Command, CommandOptions, ICommand> commandFactory;
        private ICommandOptionsProvider commandOptionsProvider;
        private ICommandProvider commandProvider;

        // Test data
        // add fields and properties here

        /// <summary>
        /// Create a command executor instance before each test.
        /// </summary>
        [SetUp]
        [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Setup method")]
        public void Setup()
        {
            this.commandFactory = Substitute.For<Func<Command, CommandOptions, ICommand>>();
            this.commandOptionsProvider = Substitute.For<ICommandOptionsProvider>();
            this.commandProvider = Substitute.For<ICommandProvider>();

            this.commandExecutor = new CommandExecutor(
                this.commandFactory,
                this.commandOptionsProvider,
                this.commandProvider);

            // Configure defaults
            this.commandProvider.Get(default).ReturnsForAnyArgs(Command.Unknown);
        }

        /// <summary>
        /// Execute run command without options.
        /// </summary>
        [Test]
        public void should_execute_run_command()
        {
            // Initiate
            string validCommand = "run";
            List<string> arguments = [validCommand];
            Command command = Command.Run;
            CommandOptions options = [];

            // Configure
            List<string> emptyList = Arg.Is<List<string>>(list => list.Count == 0);
            this.commandOptionsProvider.Get(emptyList).Returns(options);
            this.commandProvider.Get(validCommand).Returns(command);

            // Run
            this.commandExecutor.Run(arguments);

            // Test
            this.commandFactory.Received()(command, options).Received().Run();
        }

        /// <summary>
        /// Get an error on the wrong input.
        /// </summary>
        [Test]
        public void should_get_no_expected_command_error()
        {
            // Initiate
            List<string> arguments = ["error"];

            // Run
            Action action = () => this.commandExecutor.Run(arguments);

            // Test
            action.Should().Throw<InvalidOperationException>();
        }

        /// <summary>
        /// Get an error on empty arguments.
        /// </summary>
        [Test]
        public void should_get_no_arguments_error()
        {
            // Initiate
            List<string> arguments = [];

            // Run
            Action action = () => this.commandExecutor.Run(arguments);

            // Test
            action.Should().Throw<InvalidOperationException>();
        }
    }
}
