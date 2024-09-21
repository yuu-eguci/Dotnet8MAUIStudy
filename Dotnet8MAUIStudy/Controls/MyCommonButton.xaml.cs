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
}