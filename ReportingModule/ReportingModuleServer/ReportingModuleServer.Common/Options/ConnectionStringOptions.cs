using Microsoft.Extensions.Configuration;

namespace ReportingModuleServer.Common.Options;

public class ConnectionStringOptions
{
    public const string ConnectionStringsSection = "ConnectionStrings";
    public static ConnectionStringOptions Instance { get; private set; }

    public static void Configure(IConfiguration configuration)
    {
        Instance = configuration.GetSection(ConnectionStringsSection).Get<ConnectionStringOptions>();
    }
    public string FmcSqlConnectionString { get; set; } = string.Empty;
}


