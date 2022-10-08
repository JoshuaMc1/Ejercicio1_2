using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public bool validarCampoVacio(string campo)
        {
            return String.IsNullOrEmpty(campo);
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (!validarCampoVacio(txtNombres.Text) && !validarCampoVacio(txtApellidos.Text) && !validarCampoVacio(txtCorreo.Text) && !validarCampoVacio(txtEdad.Text))
            {
                var datos = new Clases.Persona(
                    nombres: txtNombres.Text,
                    apellidos: txtApellidos.Text,
                    edad: int.Parse(txtEdad.Text),
                    correo: txtCorreo.Text);
                var siguiente = new Vistas.Informacion();
                siguiente.BindingContext = datos;
                await Navigation.PushAsync(siguiente);
            }
            else await DisplayAlert("Campos vacios", "Al parecer hay uno o mas campos vacios, debe ingresar todos los datos solicitados.", "Ok");
        }
    }
}
