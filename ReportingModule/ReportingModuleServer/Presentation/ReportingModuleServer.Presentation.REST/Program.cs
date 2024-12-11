using ReportingModuleServer.Presentation.REST.Startup;

var start = DateTime.Now;

const string AllowAnyOrigin = "_allowAnyOriginPolicy";

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.RegisterOptions();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowAnyOrigin,
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                      });
});

builder.Services.RegisterApplicationServices();
builder.Services.AddHttpClient();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.WebHost.UseContentRoot(Directory.GetCurrentDirectory()).UseIISIntegration();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
var logger = app.Services.GetRequiredService<ILogger<Program>>();
var builtTime = DateTime.Now;
logger.LogDebug("App built in {Milliseconds} Milliseconds", (builtTime - start).Milliseconds);

app.ConfigureMiddleware();
app.UseCors(AllowAnyOrigin);

var beforeRun = DateTime.Now;
logger.LogDebug("App middlewares initialized in {Milliseconds} Milliseconds", (beforeRun - builtTime).Milliseconds);
app.Lifetime.ApplicationStarted.Register(() =>
{
    logger.LogDebug("App started in {Milliseconds} Milliseconds", (DateTime.Now - beforeRun).Milliseconds);
});


app.Run();
