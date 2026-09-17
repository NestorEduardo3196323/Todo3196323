using Microsoft.Extensions.Logging;
using Todo3196323.Data;

namespace Todo3196323;

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

        // Registro de la base de datos y páginas
        builder.Services.AddSingleton<TodoItemDatabase>();
        builder.Services.AddSingleton<TodoListPage>();
        builder.Services.AddTransient<TodoItemPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
    