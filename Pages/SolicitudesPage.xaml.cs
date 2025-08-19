using System;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Tp2MauiApp.Pages
{
    public partial class SolicitudesPage : ContentPage
    {
        public SolicitudesPage()
        {
            InitializeComponent();
        }

        private void OnPickerFrameTapped(object sender, EventArgs e)
        {
            TramitePicker.Focus(); // abre el Picker manualmente
        }

        private async void OnAdjuntarClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Adjuntar", "Simulación de botón adjuntar presionado.", "OK");
        }

        private async void OnEnviarSolicitudClicked(object sender, EventArgs e)
        {
            string dni = DniEntry.Text?.Trim() ?? "";
            string nombre = NombreEntry.Text?.Trim() ?? "";
            string apellido = ApellidoEntry.Text?.Trim() ?? "";
            string tramite = TramitePicker.SelectedItem?.ToString() ?? "";
            string comentarios = ComentariosEditor.Text?.Trim() ?? "";

            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(tramite))
            {
                await DisplayAlert("Error", "Por favor completá todos los campos obligatorios.", "OK");
                return;
            }

            string resumen = $"DNI: {dni}\nNombre: {nombre}\nApellido: {apellido}\nTrámite: {tramite}\nComentarios: {comentarios}";
            await DisplayAlert("Solicitud Enviada", resumen, "OK");
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            DniEntry.Text = string.Empty;
            NombreEntry.Text = string.Empty;
            ApellidoEntry.Text = string.Empty;
            TramitePicker.SelectedIndex = -1;
            ComentariosEditor.Text = string.Empty;
            DniEntry.Focus();
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        private void DniEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nuevoTexto = e.NewTextValue ?? "";
            string soloNumeros = new string(nuevoTexto.Where(char.IsDigit).ToArray());
            if (DniEntry.Text != soloNumeros)
                DniEntry.Text = soloNumeros;
        }

        private void NombreEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nuevoTexto = e.NewTextValue ?? "";
            string textoFiltrado = new string(nuevoTexto.Where(c =>
                char.IsLetter(c) || c == ' ' || c == '\'' || c == '’').ToArray());
            if (NombreEntry.Text != textoFiltrado)
                NombreEntry.Text = textoFiltrado;
        }

        private void ApellidoEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nuevoTexto = e.NewTextValue ?? "";
            string textoFiltrado = new string(nuevoTexto.Where(c =>
                char.IsLetter(c) || c == ' ' || c == '\'' || c == '’').ToArray());
            if (ApellidoEntry.Text != textoFiltrado)
                ApellidoEntry.Text = textoFiltrado;
        }
    }
}
