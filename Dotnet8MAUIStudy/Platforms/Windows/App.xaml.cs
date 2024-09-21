using Microsoft.UI.Windowing;
using Windows.Graphics;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Dotnet8MAUIStudy.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            var window = Application.Windows[0].Handler?.PlatformView as Microsoft.UI.Xaml.Window;

            if (window != null)
            {
                // WindowId を取得するために WinRT.Interop を使います。
                var windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);

                // AppWindow を取得してサイズを設定します。
                var appWindow = AppWindow.GetFromWindowId(windowId);
                // ウィンドウのサイズを 800x600 に固定
                appWindow.Resize(new SizeInt32(800, 600));

                // ウィンドウのリサイズを無効化
                //appWindow.SetPresenter(AppWindowPresenterKind.Default);
                // ...は、いいや。
            }

        }
    }

}
