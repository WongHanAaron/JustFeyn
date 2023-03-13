using CommunityToolkit.Maui;
using JustFeyn.Ui.Services;
using JustFeyn.Ui.ViewModels;
using JustFeyn.Ui.Views;
using Microsoft.Extensions.Logging;

namespace JustFeyn.Ui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit MediaElement by adding the below line of code
                .UseMauiCommunityToolkitMediaElement()
                // After initializing the .NET MAUI Community Toolkit, optionally add additional fonts
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("materialdesignicons-webfont.ttf", "MaterialDesignIcons");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.RegisterViews();
            builder.RegisterServices();
            builder.RegisterViewModels();

            return builder.Build();
        }
    }
}