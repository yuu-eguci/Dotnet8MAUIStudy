namespace Dotnet8MAUIStudy.Pages;

public partial class SampleInputPage : ContentPage
{
    public SampleInputPage()
    {
        InitializeComponent();

        // 単価が変更されたときに OnPriceOrQuantityChanged メソッドを呼び出す設定です。
        UnitPriceEntry.TextChanged += OnPriceOrQuantityChanged;

        // 数量が変更されたときに OnPriceOrQuantityChanged メソッドを呼び出す設定です。
        QuantityEntry.TextChanged += OnPriceOrQuantityChanged;
    }

    // 製品コードが変更されたときの処理
    private void OnProductCodeChanged(object sender, TextChangedEventArgs e)
    {
        var productCode = e.NewTextValue;

        if (productCode == "0001")
        {
            ProductNameEntry.Text = "みかん";
            UnitPriceEntry.Text = "1000";
        }
        else if (productCode == "0002")
        {
            ProductNameEntry.Text = "デコポン";
            UnitPriceEntry.Text = "3000";
        }
        else if (productCode == "0003")
        {
            ProductNameEntry.Text = "甘夏";
            UnitPriceEntry.Text = "5000";
        }
        else
        {
            // 無効な製品コードのときは空欄にする
            ProductNameEntry.Text = string.Empty;
            UnitPriceEntry.Text = string.Empty;
        }
    }

    // 単価、数量が変更されたときの処理
    private void OnPriceOrQuantityChanged(object sender, TextChangedEventArgs e)
    {
        if (decimal.TryParse(UnitPriceEntry.Text, out var unitPrice) &&
            decimal.TryParse(QuantityEntry.Text, out var quantity))
        {
            // 単価 * 数量を計算して金額にセットします。
            var totalPrice = unitPrice * quantity;
            AmountEntry.Text = totalPrice.ToString();
        }
        else
        {
            // 単価か数量が数値でない場合、金額を空欄にします。
            AmountEntry.Text = string.Empty;
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