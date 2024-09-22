namespace Dotnet8MAUIStudy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // NOTE: ここには、ルートから遷移していくページを登録する。
            //       通常の遷移は `GoToAsync("SamplePage")` でスタックを積んで進んだり、
            //       `Navigation.PopAsync()` でスタックを除いて戻ったりして行う。
            //       裏技で、 `GoToAsync("//MainMenuPage")` などで、
            //       スタックをリセットしてルートのページへ遷移することができる。 (ルート以外は指定不可)
            Routing.RegisterRoute(nameof(Pages.SampleInputPage), typeof(Pages.SampleInputPage));
            Routing.RegisterRoute(nameof(Pages.SampleTablePage), typeof(Pages.SampleTablePage));
            Routing.RegisterRoute(nameof(Pages.VariousControlsPage), typeof(Pages.VariousControlsPage));
        }
    }
}
