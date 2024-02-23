using Microsoft.Extensions.Logging;

namespace cn.DiariumSystem.SelfStart
{
    /// <summary>
    /// 项目入口
    /// </summary>
    /// <remarks> 
    /// <para> 注册字体</para>
    /// <para> 依赖注入</para>
    /// </remarks>
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

            return builder.Build();
        }
    }
}
