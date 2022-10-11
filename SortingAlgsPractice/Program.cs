using System.ComponentModel.Design;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SortingAlgsPractice.Builders;

namespace SortingAlgsPractice;

class Program{
    public static void Main(String[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .UseSerilog((context, services, config) => config.ConfigureLogging(services, context.Configuration))
            .ConfigureServices((context, services) =>
            {
                var configuration = context.Configuration;
                services
                    .AddSingleton<SortController>()
                    .AddLogging();
            })
            .Build();
        
        
        var sortController = host.Services.GetService<SortController>()!;
        sortController.Start();
        
    }
    
}

    
