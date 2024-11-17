using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("HostGrotesk-Bold.ttf", "HostGroteskBold"); 
                    fonts.AddFont("HostGrotesk-Italic.ttf", "HostGroteskItalic");
                    fonts.AddFont("HostGrotesk-Medium.ttf", "HostGroteskMedium");
                    fonts.AddFont("HostGrotesk-Regular.ttf", "HostGroteskRegular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
