namespace Dotnet8MAUIStudy.Controls;

public partial class MyCommonImageButton : ContentView
{
    public MyCommonImageButton()
    {
        InitializeComponent();
    }

    // ボタンのテキストを設定するための BindableProperty
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(MyCommonImageButton),
        default(string),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (MyCommonImageButton)bindable;
            control.CustomButton.Text = (string)newValue;
        });

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    // 背景画像を設定するための BindableProperty
    public static readonly BindableProperty ButtonBackgroundImageSourceProperty = BindableProperty.Create(
        nameof(ButtonBackgroundImageSource),
        typeof(ImageSource),
        typeof(MyCommonImageButton),
        default(ImageSource),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (MyCommonImageButton)bindable;
            // Grid 内の Image に背景画像を設定
            control.BackgroundImage.Source = (ImageSource)newValue;
        });

    public ImageSource ButtonBackgroundImageSource
    {
        get => (ImageSource)GetValue(ButtonBackgroundImageSourceProperty);
        set => SetValue(ButtonBackgroundImageSourceProperty, value);
    }

    // ボタンのクリックイベントを外部で扱えるようにする
    public event EventHandler Clicked
    {
        add => CustomButton.Clicked += value;
        remove => CustomButton.Clicked -= value;
    }

    // ボタンが押されたときの処理（背景画像の透明度を下げる）
    void OnButtonPressed(object sender, EventArgs e)
    {
        BackgroundImage.FadeTo(0.5, 100);  // 背景画像の透明度を50%に
    }

    // ボタンが離されたときの処理（元の透明度に戻す）
    void OnButtonReleased(object sender, EventArgs e)
    {
        BackgroundImage.FadeTo(1.0, 100);  // 背景画像の透明度を元に戻す
    }
}
