using AINewsApp.Services;
using AINewsApp.View;
using AINewsApp.ViewModel;
using Microsoft.Extensions.Logging;

namespace AINewsApp;

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
        builder.Services.AddSingleton<AINewsService>();
        builder.Services.AddSingleton<AINewsViewModel>();
        builder.Services.AddSingleton<AINewsPage>();
        builder.Services.AddSingleton<AINewsDetailPage>();
        builder.Services.AddSingleton<AINewsDetailViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
