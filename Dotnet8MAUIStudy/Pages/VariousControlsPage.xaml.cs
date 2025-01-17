namespace Dotnet8MAUIStudy.Pages;

public partial class VariousControlsPage : ContentPage
{
    public VariousControlsPage()
    {
        InitializeComponent();
    }

    // ウィンドウタイトル変更ボタンが押されたときの処理
    private void OnChangeTitleClicked(object sender, EventArgs e)
    {
        // ウィンドウタイトルを変更
        this.Title = Helpers.TextConstants.GetText("タイトルが変更されました");
    }

    // メッセージボックスボタンが押されたときの処理
    private async void OnShowMessageBoxClicked(object sender, EventArgs e)
    {
        // メッセージボックスを表示
        await DisplayAlert(
            Helpers.TextConstants.GetText("メッセージ"),
            Helpers.TextConstants.GetText("これはメッセージボックスです"),
            Helpers.TextConstants.GetText("OK"));
    }
}
