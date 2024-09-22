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
        DisplayAlert("明細画面", "明細画面が押されました", "OK");
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
        DisplayAlert("特殊なボタン", "特殊なボタンが押されました", "OK");
    }

    // ログアウトボタンが押されたときの処理
    private async void OnLogoutButtonClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("ログアウト", "ログアウトしますか？", "はい", "いいえ");

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
