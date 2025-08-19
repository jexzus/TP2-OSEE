using Tp2MauiApp.Pages;

namespace Tp2MauiApp.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnNuevaSolicitudClicked(object sender, EventArgs e)
        {
            if (sender is VisualElement visualElement)
            {
                await AnimateButtonPress(visualElement);
                await Shell.Current.GoToAsync(nameof(SolicitudesPage));
            }
        }

        private async void OnEstadoSolicitudClicked(object sender, EventArgs e)
        {
            if (sender is VisualElement visualElement)
            {
                await AnimateButtonPress(visualElement);
                await Shell.Current.GoToAsync(nameof(EstadoPage));
            }
        }

        private async Task AnimateButtonPress(VisualElement element)
        {
            await Task.WhenAll(
                element.ScaleTo(0.95, 50, Easing.CubicOut),
                element.TranslateTo(0, 2, 50, Easing.CubicOut)
            );

            await Task.WhenAll(
                element.ScaleTo(1.0, 100, Easing.CubicOut),
                element.TranslateTo(0, 0, 100, Easing.CubicOut)
            );
        }
    }
}
