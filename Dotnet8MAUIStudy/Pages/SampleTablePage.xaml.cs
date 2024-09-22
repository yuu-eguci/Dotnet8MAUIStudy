namespace Dotnet8MAUIStudy.Pages;

public partial class SampleTablePage : ContentPage
{
    public SampleTablePage()
    {
        InitializeComponent();

        // 仮のデータを追加
        var products = new List<Product>
        {
            new() { ProductCode = "0001", ProductName = "Power Automate Desktop 入門講座", OrderDate = "2024-09-14", UnitPrice = "10,000", Quantity = "1", Amount = "10,000" },
            new() { ProductCode = "0002", ProductName = "Power Automate Desktop 勉強会", OrderDate = "2024-09-15", UnitPrice = "300,000", Quantity = "2", Amount = "450,000" },
            new() { ProductCode = "0003", ProductName = "Power Automate Desktop カレッジ", OrderDate = "2024-09-17", UnitPrice = "500,000", Quantity = "1", Amount = "500,000" }
        };

        // BindingContext にデータをセット
        BindingContext = new { Products = products };
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

// 仮のデータモデル
public class Product
{
    public required string ProductCode { get; set; }
    public required string ProductName { get; set; }
    public required string OrderDate { get; set; }
    public required string UnitPrice { get; set; }
    public required string Quantity { get; set; }
    public required string Amount { get; set; }
}
