namespace Dotnet8MAUIStudy.Pages;

public partial class MainMenuPage : ContentPage
{
    public MainMenuPage()
    {
        InitializeComponent();
    }

    // 入力画面ボタンが押されたときの処理
    private async void OnInputPageButtonClicked(object sender, EventArgs e)
    {
        // 相対的なナビゲーションで、ナビゲーションスタックはクリアされず、次のページがスタックに追加される。
        await Shell.Current.GoToAsync(nameof(SampleInputPage));
    }

    // 明細画面 (キー操作) ボタンが押されたときの処理
    private void OnDetailPageButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert(
            Helpers.TextConstants.GetText("明細画面"),
            Helpers.TextConstants.GetText("明細画面が押されました"),
            Helpers.TextConstants.GetText("OK"));
    }

    // 一覧画面ボタンが押されたときの処理
    private async void OnListPageButtonClicked(object sender, EventArgs e)
    {
        // 相対的なナビゲーションで、ナビゲーションスタックはクリアされず、次のページがスタックに追加される。
        await Shell.Current.GoToAsync(nameof(SampleTablePage));
    }

    // 色々なコントロールボタンが押されたときの処理
    private async void OnControlsPageButtonClicked(object sender, EventArgs e)
    {
        // 相対的なナビゲーションで、ナビゲーションスタックはクリアされず、次のページがスタックに追加される。
        await Shell.Current.GoToAsync(nameof(VariousControlsPage));
    }

    // 特殊なボタンが押されたときの処理
    private void OnSpecialButtonPageClicked(object sender, EventArgs e)
    {
        DisplayAlert(
            Helpers.TextConstants.GetText("特殊なボタン"),
            Helpers.TextConstants.GetText("特殊なボタンが押されました"),
            Helpers.TextConstants.GetText("OK"));
    }

    // ログアウトボタンが押されたときの処理
    private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert(
            Helpers.TextConstants.GetText("ログアウト"),
            Helpers.TextConstants.GetText("ログアウトしますか？"),
            Helpers.TextConstants.GetText("はい"),
            Helpers.TextConstants.GetText("いいえ"));

        if (confirm)
        {
            // ログアウト処理（必要に応じて追加）

            // LoginPage への遷移
            // 絶対的なナビゲーション。ナビゲーションスタックをリセットする。
            // ここではルートページへ絶対ナビゲーションなので `//` です。
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
