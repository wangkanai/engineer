using Engineer.UI;
using Microsoft.Extensions.Logging;

namespace Engineer.UI;

/// <summary>
/// Main entry point for Engineer IDE
/// </summary>
public static class Program
{
    /// <summary>
    /// Main application entry point
    /// </summary>
    /// <param name="args">Command line arguments</param>
    /// <returns>Application task</returns>
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Add Blazor WebView services
        builder.Services.AddMauiBlazorWebView();

        // Add Engineer IDE services
        builder.Services.AddEngineerCore();
        builder.Services.AddEngineerAI();

        // Add logging
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

/// <summary>
/// Extension methods for service registration
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Engineer Core services to the service collection
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>The service collection for chaining</returns>
    public static IServiceCollection AddEngineerCore(this IServiceCollection services)
    {
        // Add core services here
        // services.AddScoped<IContextEngine, ContextEngine>();
        return services;
    }

    /// <summary>
    /// Adds Engineer AI services to the service collection
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>The service collection for chaining</returns>
    public static IServiceCollection AddEngineerAI(this IServiceCollection services)
    {
        // Add AI services here
        // services.AddHttpClient();
        // services.AddScoped<IAiAgent, OpenAiAgent>();
        return services;
    }
}