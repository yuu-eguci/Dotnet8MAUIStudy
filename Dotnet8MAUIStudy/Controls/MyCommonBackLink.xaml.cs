namespace Dotnet8MAUIStudy.Controls;

public partial class MyCommonBackLink : ContentView
{
    public MyCommonBackLink()
    {
        InitializeComponent();
    }

    // 戻るリンクが押されたときの処理
    private async void OnBackToMainMenuClicked(object sender, EventArgs e)
    {
        try
        {
            // Current.GoToAsync で遷移すると、前に進む感じになっちゃう。
            // ここは戻りたいから、 PopAsync を使う。
            await Shell.Current.Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            // エラーハンドリング、例えばログに記録するなど
            Console.WriteLine($"Navigation failed: {ex.Message}");
        }
    }
}