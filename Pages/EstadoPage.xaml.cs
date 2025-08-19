using System;
using Microsoft.Maui.Controls;

namespace Tp2MauiApp.Pages
{
    public partial class EstadoPage : ContentPage
    {
        public EstadoPage()
        {
            InitializeComponent();
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
