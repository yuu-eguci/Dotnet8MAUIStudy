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
        this.Title = "タイトルが変更されました";
    }

    // メッセージボックスボタンが押されたときの処理
    private async void OnShowMessageBoxClicked(object sender, EventArgs e)
    {
        // メッセージボックスを表示
        await DisplayAlert("メッセージ", "これはメッセージボックスです", "OK");
    }
}
