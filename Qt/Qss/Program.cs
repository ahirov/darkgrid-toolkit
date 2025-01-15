// <copyright file="Program.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Qt.Qss
{
    using Autofac;
    using DarkgridToolkit.Qt.Qss.Commands.I;
    using DarkgridToolkit.Qt.Qss.IoC;

    /// <summary>
    /// The main program.
    /// </summary>
    internal class Program
    {
        private static IContainer? Container { get; set; }

        /// <summary>
        /// Run the main console application.
        /// </summary>
        /// <param name="arguments">Command and options.</param>
        public static void Main(string[] arguments)
        {
            try
            {
                ContainerBuilder builder = new();
                builder.RegisterModule<ToolkitQtQssModule>();
                Container = builder.Build();

                Container.Resolve<ICommandExecutor>().Run([.. arguments]);
            }
            catch (Exception exception)
            {
                Console.WriteLine("An ERROR is detected. The console application is terminated.");
                Console.WriteLine(exception.Message);
                Console.WriteLine("For more details type 'help'.");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadLine();
            }
        }
    }
}
