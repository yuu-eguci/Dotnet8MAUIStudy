namespace Dotnet8MAUIStudy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // ここへ登録すると、 GoToAsync を使ってページ遷移ができる。
            Routing.RegisterRoute(nameof(Pages.LoginPage), typeof(Pages.LoginPage));
            Routing.RegisterRoute(nameof(Pages.MainMenuPage), typeof(Pages.MainMenuPage));
        }
    }
}
