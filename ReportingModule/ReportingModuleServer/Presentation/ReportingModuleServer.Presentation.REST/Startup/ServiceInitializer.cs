using Microsoft.EntityFrameworkCore;
using NSwag.Generation.Processors.Security;
using NSwag;
using ReportingModuleServer.Application.Service.Shared;
using ReportingModuleServer.Common.Options;
using ReportingModuleServer.Infrastructure.DataAccess.Shared.DataProviders;
using ReportingModuleServer.Infrastructure.DataAccess.Sql.Context;
using ReportingModuleServer.Infrastructure.DataAccess.Sql.DataProviders;
using System.Text.Json.Serialization;

namespace ReportingModuleServer.Presentation.REST.Startup;

public static class ServiceInitializer
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        RegisterDbDependencies(services);
        RegisterServiceDependencies(services);
        RegisterDataProviderDependencies(services);

        RegisterSwagger(services);
        RegisterControllers(services);
        return services;
    }

    private static void RegisterDbDependencies(IServiceCollection services)
    {
        services.AddDbContext<ReportsContext>(optionsAction =>
        {
            optionsAction.UseSqlServer(ConnectionStringOptions.Instance.FmcSqlConnectionString);
        });
    }

    private static void RegisterServiceDependencies(IServiceCollection services)
    {
        //For Services
        services.AddScoped<IRentAndFeesReportService, RentAndFeesReportService>();
        //Shared

    }

    private static void RegisterDataProviderDependencies(IServiceCollection services)
    {
        //For DataProvider
        services.AddScoped<IReportDataProvider, ReportDataProvider>();

        //Shared
    }

    private static void RegisterSwagger(IServiceCollection services)
    {
        services.AddOpenApiDocument(options =>
        {
            options.AddSecurity("Bearer", Enumerable.Empty<string>(), new OpenApiSecurityScheme
            {
                Type = OpenApiSecuritySchemeType.ApiKey,
                Scheme = "bearer",
                In = OpenApiSecurityApiKeyLocation.Header,
                Name = "Authorization",
                Description = "Enter JWT token.",
            });

            options.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("Bearer"));
            
            options.PostProcess = document =>
            {
                document.Info = new OpenApiInfo
                {
                    Title = "Reports Module API",
                };
            };
        });

        services.AddEndpointsApiExplorer();
    }

    private static void RegisterControllers(IServiceCollection services)
    {
        services.AddControllers();
    }
}
