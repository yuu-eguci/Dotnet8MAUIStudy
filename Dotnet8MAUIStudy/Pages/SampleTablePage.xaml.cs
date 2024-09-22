namespace Dotnet8MAUIStudy.Pages;

public partial class SampleTablePage : ContentPage
{
    public SampleTablePage()
    {
        InitializeComponent();
    }

    // 戻るリンクが押されたときの処理
    private async void OnBackToMainMenuClicked(object sender, EventArgs e)
    {
        // PopAsync で前のページに戻る
        await Shell.Current.Navigation.PopAsync();
    }

    // 印刷ボタンが押されたときの処理
    private async void OnPrintButtonClicked(object sender, EventArgs e)
    {
        // 仮の印刷処理
        await DisplayAlert("印刷", "印刷処理が実行されました！", "OK");
    }
}
