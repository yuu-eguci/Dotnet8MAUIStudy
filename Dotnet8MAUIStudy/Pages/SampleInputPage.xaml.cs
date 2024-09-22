namespace Dotnet8MAUIStudy.Pages;

public partial class SampleInputPage : ContentPage
{
	public SampleInputPage()
	{
		InitializeComponent();
	}

    // 登録ボタンが押されたときの処理
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        // 仮の登録処理
        await DisplayAlert("登録完了", "登録が完了しました！", "OK");

        // Current.GoToAsync で遷移すると、前に進む感じになっちゃう。
        // ここは戻りたいから、 PopAsync を使う。
        await Shell.Current.Navigation.PopAsync();
    }
}