using Microsoft.Extensions.Logging;

namespace MauiOefeningen
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<NaamTonenPage>();
            builder.Services.AddSingleton<VakPage>();
            builder.Services.AddSingleton<AfbeeldingenPage>();
            builder.Services.AddSingleton<VragenlijstPage>();
            builder.Services.AddSingleton<GetallenRijPage>();

            builder.Services.AddSingleton<NaamTonenViewModel>();
            builder.Services.AddSingleton<VakViewModel>();
            builder.Services.AddSingleton<AfbeeldingenViewModel>();
            builder.Services.AddSingleton<VragenlijstViewModel>();
            builder.Services.AddSingleton<GetallenRijViewModel>();

            return builder.Build();
        }
    }
}
