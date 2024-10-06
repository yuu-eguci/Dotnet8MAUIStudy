// Spire.PDF ライブラリを使用する
using Spire.Pdf;
using Spire.Pdf.Graphics;
using System.Diagnostics;

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

        // Windows プラットフォームのみ、先へ進む。
        if (DeviceInfo.Platform != DevicePlatform.WinUI)
        {
            await DisplayAlert(
                Helpers.TextConstants.GetText("印刷"),
                Helpers.TextConstants.GetText("このプラットフォームは印刷機能のサポート外です"),
                Helpers.TextConstants.GetText("OK"));
            return;
        }

        // Spire.PDF で PDF を作成
        PdfDocument pdf = CreateSpirePdf();

        // PDF をファイルに保存する
        var tempPath = Path.Combine(Path.GetTempPath(), "SampleTable.pdf");
        pdf.SaveToFile(tempPath);

        // メッセージを表示してからファイルを開く
        message = Helpers.TextConstants.GetText("PDF として開きます。別アプリで印刷してみてください。");
        await DisplayAlert(
            Helpers.TextConstants.GetText("印刷"),
            message,
            Helpers.TextConstants.GetText("OK"));

        // ユーザーが OK を押した後に PDF ファイルを開く
        Process.Start(new ProcessStartInfo
        {
            FileName = tempPath,
            UseShellExecute = true
        });
    }

    // Spire.PDF で PDF を作成するメソッド
    private PdfDocument CreateSpirePdf()
    {
        // PdfDocument のインスタンスを作成
        PdfDocument document = new PdfDocument();
        PdfPageBase page = document.Pages.Add();

        // 日本語フォントを設定
        var japaneseFont = new PdfTrueTypeFont(new System.Drawing.Font("Yu Gothic", 12f), true);
        PdfBrush brush = PdfBrushes.Black;
        float y = 20;

        // タイトルを追加
        page.Canvas.DrawString("商品一覧", japaneseFont, brush, 10, y);
        y += 20;

        // テーブルヘッダーを追加
        string[] headers = { "商品コード", "商品名", "注文日", "単価", "数量", "金額" };
        page.Canvas.DrawString(string.Join(" | ", headers), japaneseFont, brush, 10, y);
        y += 20;

        // 各商品のデータを描画
        foreach (var product in (BindingContext as dynamic).Products)
        {
            string row = $"{product.ProductCode} | {product.ProductName} | {product.OrderDate} | {product.UnitPrice} | {product.Quantity} | {product.Amount}";
            page.Canvas.DrawString(row, japaneseFont, brush, 10, y);
            y += 20;
        }

        return document;
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
