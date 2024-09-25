namespace Dotnet8MAUIStudy.Pages;

public partial class SampleInputPage : ContentPage
{
	public SampleInputPage()
	{
		InitializeComponent();
	}

    // 製品コードが変更されたときの処理
    private void OnProductCodeChanged(object sender, TextChangedEventArgs e)
    {
        var productCode = e.NewTextValue;

        if (productCode == "0001")
        {
            ProductNameEntry.Text = "みかん";
            UnitPriceEntry.Text = "10000";
        }
        else if (productCode == "0002")
        {
            ProductNameEntry.Text = "デコポン";
            UnitPriceEntry.Text = "300000";
        }
        else if (productCode == "0003")
        {
            ProductNameEntry.Text = "甘夏";
            UnitPriceEntry.Text = "500000";
        }
        else
        {
            // 無効な製品コードのときは空欄にする
            ProductNameEntry.Text = string.Empty;
            UnitPriceEntry.Text = string.Empty;
        }
    }

    // 登録ボタンが押されたときの処理
    private async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        // 仮の登録処理
        await DisplayAlert(
            Helpers.TextConstants.GetText("登録完了"),
            Helpers.TextConstants.GetText("登録が完了しました！"),
            Helpers.TextConstants.GetText("OK"));

        // Current.GoToAsync で遷移すると、前に進む感じになっちゃう。
        // ここは戻りたいから、 PopAsync を使う。
        await Shell.Current.Navigation.PopAsync();
    }
}