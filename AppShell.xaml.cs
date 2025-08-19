namespace Tp2MauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Usar AppShell como contenedor principal
            MainPage = new AppShell();
        }
    }
}
