// デバイス情報を取得するために Microsoft.Maui.Devices 名前空間を使用。
using Microsoft.Maui.Devices;

namespace Dotnet8MAUIStudy.Pages;

public partial class SampleTablePage : ContentPage
{
    public SampleTablePage()
    {
        InitializeComponent();

        // 仮のデータを追加
        var products = new List<Product>
        {
            new() { ProductCode = "0001", ProductName = Helpers.TextConstants.GetText("みかん"), OrderDate = "2024-09-14", UnitPrice = "10,000", Quantity = "1", Amount = "10,000" },
            new() { ProductCode = "0002", ProductName = Helpers.TextConstants.GetText("デコポン"), OrderDate = "2024-09-15", UnitPrice = "300,000", Quantity = "2", Amount = "450,000" },
            new() { ProductCode = "0003", ProductName = Helpers.TextConstants.GetText("甘夏"), OrderDate = "2024-09-17", UnitPrice = "500,000", Quantity = "1", Amount = "500,000" }
        };

        // BindingContext にデータをセット
        BindingContext = new { Products = products };
    }

    // 印刷ボタンが押されたときの処理
    private async void OnPrintButtonClicked(object sender, EventArgs e)
    {
        string message;

        // Windows プラットフォームの判定。
        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            message = Helpers.TextConstants.GetText("OK!");
        }
        else
        {
            message = Helpers.TextConstants.GetText("このプラットフォームは印刷機能のサポート外です");
        }

        await DisplayAlert(
            Helpers.TextConstants.GetText("印刷"),
            message,
            Helpers.TextConstants.GetText("OK"));
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
