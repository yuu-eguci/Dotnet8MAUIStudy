using System.Diagnostics;

namespace Dotnet8MAUIStudy.Helpers
{
    public static class TextConstants
    {
        public static readonly Dictionary<string, string> Texts = new()
        {
            // NOTE: 使い方
            //       xaml の場合
            //       xmlns:text="clr-namespace:Dotnet8MAUIStudy.MarkupExtensions"
            //       <Label Text="{text:TextExtension Key='ユーザーID'}" />
            //       cs の場合
            //       Helpers.TextConstants.GetText("ログイン成功")
            // NOTE: コメントアウトすると、指定した文字列がそのまま表示される。
            // { "← 戻る", "Back" },
            // { "登録", "Register" },
            // { "ユーザーID", "User ID" },
            // { "ユーザーIDを入力してください", "Please enter your User ID" },
            // { "パスワード", "Password" },
            // { "パスワードを入力してください", "Please enter your password" },
            // { "ログイン", "Login" },
            // { "入力画面", "Input Screen" },
            // { "明細画面 (キー操作)", "Details Screen (Key Operation)" },
            // { "一覧画面", "List Screen" },
            // { "色々なコントロール", "Various Controls" },
            // { "特殊なボタン", "Special Buttons" },
            // { "ログアウト", "Logout" },
            // { "製品コード", "Product Code" },
            // { "製品名", "Product Name" },
            // { "受注日", "Order Date" },
            // { "単価", "Unit Price" },
            // { "数量", "Quantity" },
            // { "金額", "Amount" },
            // { "製品コードを入力", "Enter Product Code" },
            // { "製品名を入力", "Enter Product Name" },
            // { "単価を入力", "Enter Unit Price" },
            // { "数量を入力", "Enter Quantity" },
            // { "金額を入力", "Enter Amount" },
            // { "印刷", "Print" },
            // { "コンボボックス", "ComboBox" },
            // { "チェックボックス", "CheckBox" },
            // { "チェックボックス1", "CheckBox1" },
            // { "チェックボックス2", "CheckBox2" },
            // { "ラジオボタン", "RadioButton" },
            // { "ツリー", "Tree" },
            // { "ウィンドウタイトル変更", "Change Window Title" },
            // { "メッセージボックス", "Message Box" },
            // { "Power Automate Desktop 入門講座", "Power Automate Desktop Beginner Course" },
            // { "Power Automate Desktop 勉強会", "Power Automate Desktop Workshop" },
            // { "Power Automate Desktop カレッジ", "Power Automate Desktop College" },
            // { "エラー", "Error" },
            // { "ユーザーIDまたはパスワードを入力してください", "Please enter your User ID or password" },
            // { "OK", "OK" },
            // { "印刷処理が実行されました！", "The print process has been executed!" }
            // { "ログイン成功", "Login successful" },
            // { "ようこそ、{0}さん！", "Welcome, {0}!" },
        };

        // 関数でテキストを取得する方法
        public static string GetText(string key)
        {
            if (Texts.TryGetValue(key, out var value))
            {
                return value;
            }

            // キーが見つからなかった場合にコンソールに警告メッセージを出力
            Debug.WriteLine($"[WARN] Text key '{key}' not found in TextConstants.");

            // 万が一キーが存在しない場合は、キー自体を返す
            return key;
        }
    }
}
