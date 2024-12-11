using ReportingModuleServer.Common.Options;

namespace ReportingModuleServer.Presentation.REST.Startup;

public static class MiddlewareInitializer
{
    public static WebApplication ConfigureMiddleware(this WebApplication app)
    {
        if (ApplicationOptions.Instance.IsSwaggerOn)
        {
            ConfigureSwagger(app);
        }

        if (!ApplicationOptions.Instance.useSSL.HasValue || ApplicationOptions.Instance.useSSL.Value)
        {
            app.UseHttpsRedirection();
        }

        ConfigureControllerRoute(app);
        
        return app;
    }

    private static void ConfigureSwagger(WebApplication app)
    {
        app.UseOpenApi();
        app.UseSwaggerUI(_ =>
        {
        });
    }

    private static void ConfigureControllerRoute(WebApplication app)
    {
        app.MapControllerRoute(
             name: "default",
             pattern: "{controller}/{action=Index}/{id?}"
        );

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}