using Fluxor;
using Microsoft.Extensions.Logging;

namespace ReplicaApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            // Add Fluxor dependencies and scan assembly for any Fluxor related code such as sates, reducers, etc.
            // Note: Fluxor state management requires a singleton lifetime because the main .NET MAUI app has a
            // different scope than each BlazorWebView components and we need to share state across all
            // scopes of the app.
            builder.Services.AddFluxor(options =>
                options
                    .ScanAssemblies(typeof(MauiProgram).Assembly)
                    .WithLifetime(StoreLifetime.Singleton)
            );

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
