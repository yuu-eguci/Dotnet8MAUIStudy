namespace Dotnet8MAUIStudy.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string userId = UserIdEntry.Text;
        string password = PasswordEntry.Text;

        // ここでログイン処理を実装
        if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert(
                Helpers.TextConstants.GetText("エラー"),
                Helpers.TextConstants.GetText("ユーザーIDまたはパスワードを入力してください"),
                Helpers.TextConstants.GetText("OK"));
        }
        else
        {
            // 仮のログイン成功処理
            await DisplayAlert(
                Helpers.TextConstants.GetText("ログイン成功"),
                $"ようこそ、{userId}さん！",
                Helpers.TextConstants.GetText("OK"));

            // MainMenuPage へ遷移します。
            // ここではルートページ間の絶対ナビゲーションなので `///` です。
            await Shell.Current.GoToAsync($"///{nameof(MainMenuPage)}");
        }
    }
}
