using System;
using System.Diagnostics;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracticaApp
{
    
    public partial class DataForm : ContentPage
    {

        public DataForm()
        {
            InitializeComponent();

            btnAlert.Clicked += async (sender, e) =>
            {
                var nombre = name.Text;
                var descripcion = description.Text;
                var answer = await DisplayAlert("Mensaje", "Nombre: " + nombre+"\nDescripcion: "+descripcion,"OK", "Cancelar");
            };

        }

    }
}
