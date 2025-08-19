using Tp2MauiApp.Pages;

namespace Tp2MauiApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(EstadoPage), typeof(EstadoPage));
        Routing.RegisterRoute(nameof(SolicitudesPage), typeof(SolicitudesPage));
        Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
    }
}
