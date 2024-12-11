using ReportingModuleServer.Common.Options;

namespace ReportingModuleServer.Presentation.REST.Startup;

public static class OptionsInitializer
{
    public static IConfiguration RegisterOptions(this IConfiguration configuration)
    {
        ApplicationOptions.Configure(configuration);
        ConnectionStringOptions.Configure(configuration);
       
        return configuration;
    }
}
