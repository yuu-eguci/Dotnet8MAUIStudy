using System;
using Microsoft.Maui.Controls;
using Dotnet8MAUIStudy.Helpers;

namespace Dotnet8MAUIStudy.MarkupExtensions
{
    // NOTE: 普通に考えると Helpers.TextConstants だけでいいと思うんだけれど、
    //       xaml のアホは直接 static なクラスを参照できない。
    //       そのため、IMarkupExtension<T> を使って、 xaml から参照できるようにしているというわけ。
    public class TextExtension : IMarkupExtension<string>
    {
        public required string Key { get; set; }

        public string ProvideValue(IServiceProvider serviceProvider)
        {
            // TextConstants クラスから、指定された Key に対応するテキストを取得し、返す。
            return TextConstants.GetText(Key);
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }
}
