namespace Dotnet8MAUIStudy.Controls;

public partial class MyCommonButton : ContentView
{
    public MyCommonButton()
    {
        InitializeComponent();
    }

    // ボタンのテキストを設定するための BindableProperty
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(MyCommonButton),
        default(string),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (MyCommonButton)bindable;
            control.CustomButton.Text = (string)newValue;
        });

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // ボタンのクリックイベントを外部で扱えるようにする
    public event EventHandler Clicked
    {
        add => CustomButton.Clicked += value;
        remove => CustomButton.Clicked -= value;
    }

    // ボタンが押されたときの処理（縮小アニメーションと色変更）
    void OnButtonPressed(object sender, EventArgs e)
    {
        CustomButton.BackgroundColor = Colors.DarkGreen; // 押したときに色を変える
        CustomButton.ScaleTo(0.95, 100);  // ボタンを少し縮小
    }

    // ボタンが離されたときの処理（元のサイズと色に戻す）
    void OnButtonReleased(object sender, EventArgs e)
    {
        CustomButton.BackgroundColor = Colors.Green; // 元の色に戻す
        CustomButton.ScaleTo(1.0, 100);  // ボタンを元のサイズに戻す
    }
}
