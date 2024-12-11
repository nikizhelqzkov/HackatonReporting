using Microsoft.Extensions.Configuration;

namespace ReportingModuleServer.Common.Options;

public class ApplicationOptions
{
    public static ApplicationOptions Instance { get; private set; }

    public static void Configure(IConfiguration configuration)
    {
        Instance = configuration.Get<ApplicationOptions>();
    }

    public bool? useSSL { get; set; }

    public bool IsSwaggerOn { get; set; }

    public string CustomSecurityValidationCode { get; set; }

    public int HttpClientTimeoutInSeconds { get; set; }

}
