namespace cn.DiariumSystem.SelfStart
{
    /// <summary>
    /// APP启动加载页
    /// </summary>
    /// <remarks>
    /// <para>类型 基本为  {Shell}</para>
    /// <para>通过 {MainPage}  设置</para>
    /// </remarks>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
