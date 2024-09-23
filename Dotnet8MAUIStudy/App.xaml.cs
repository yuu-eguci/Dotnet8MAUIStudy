namespace Dotnet8MAUIStudy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = new Window(MainPage)
            {
                Width = 800,
                Height = 800,
            };
            return window;
        }
    }
}
