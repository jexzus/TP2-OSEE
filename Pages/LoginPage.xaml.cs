using System;
using Microsoft.Maui.Controls;

namespace Tp2MauiApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string usuario = usuarioEntry.Text;
            string contrasena = contrasenaEntry.Text;

            if (usuario == "admin" && contrasena == "admin123")
            {
                // Éxito: navegar a MenuPage
                await DisplayAlert("Login", "¡Bienvenido!", "OK");
                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                // Error: credenciales incorrectas
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "Reintentar");
            }
        }
    }
}
