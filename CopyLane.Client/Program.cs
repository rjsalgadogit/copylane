using CopyLane.Infrastructure.Services;
using CopyLane.Infrastructure.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CopyLane.Client
{
    internal static class Program
    {
        public static IServiceProvider _serviceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

            //Application.Run(new MainForm());
            Application.Run(_serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //ref: https://www.youtube.com/watch?v=-tPVVM-wYKI
            services.AddTransient<MainForm>();
        }
    }
}