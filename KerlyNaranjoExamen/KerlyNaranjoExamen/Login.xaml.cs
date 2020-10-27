using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KerlyNaranjoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnIngresar_Clicked(object sender, EventArgs e) {
            if (txtUser.Text.Equals("estudiante2020") && txtPass.Text.Equals("uisrael2020")) {
                await Navigation.PushAsync(new Registro(txtUser.Text));
            } else {
                DisplayAlert("Mensaje de alerta", "Credenciales incorrectas", "Reintentar");
            }
        }
    }
}