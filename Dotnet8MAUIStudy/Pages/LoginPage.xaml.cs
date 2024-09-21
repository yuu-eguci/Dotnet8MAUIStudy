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
            await DisplayAlert("エラー", "ユーザーIDまたはパスワードを入力してください", "OK");
        }
        else
        {
            // 仮のログイン成功処理
            await DisplayAlert("ログイン成功", $"ようこそ、{userId}さん！", "OK");

            // MainMenuPage へ遷移します。
            await Shell.Current.GoToAsync(nameof(MainMenuPage));
        }
    }
}
