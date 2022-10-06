using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace SortingAlgsPractice.Builders;

public static class LoggingConfiguration
{
    public static void ConfigureLogging(
        this LoggerConfiguration loggerConfiguration,
        IServiceProvider services,
        IConfiguration configuration)
    {
        loggerConfiguration
            .MinimumLevel.ControlledBy(new LoggingLevelSwitch(LogEventLevel.Debug))
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning);
        
        loggerConfiguration.WriteTo.Console(LogEventLevel.Debug);
    }
}