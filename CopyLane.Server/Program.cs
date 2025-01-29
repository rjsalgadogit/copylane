using CopyLane.Core.Repositories;
using CopyLane.Core.Repositories.Interfaces;
using CopyLane.Core.Services;
using CopyLane.Core.Services.Interfaces;
using CopyLane.Server.Sequel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sequel.Service;
using Sequel.Service.Interfaces;

namespace CopyLane.Server
{
    internal static class Program
    {
        public static IConfiguration _configuration { get; set; }
        public static IServiceProvider _serviceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Load Configuration
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _configuration = builder.Build();

            // Dependency Injection
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging();
            serviceCollection.AddSingleton(_configuration);
            Registration.Register(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

            //Application.Run(new MainForm());
            Application.Run(_serviceProvider.GetRequiredService<MainForm>());
        }
    }
}