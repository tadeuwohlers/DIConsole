using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddScoped<ICalculator, Calc>();
            services.AddScoped<Worker, Worker>();

            var providers = services.BuildServiceProvider();
            var worker = providers.GetService<Worker>();

            worker.Sum("1", "2");
        }
    }
}