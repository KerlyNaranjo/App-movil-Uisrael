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
    public partial class Registro : ContentPage
    {
        public Registro(string user) {
            InitializeComponent();
            txtLogeedUser.Text = user;
        }
        private void btnCalculate_Clicked(object sender, EventArgs e) {
            double amounth = Convert.ToDouble(txtAmount.Text);
            if (amounth > 1800 || amounth < 0) {
                DisplayAlert("Alerta", "Monto no puede ser mayor a $1800 ni menos que $0", "Aceptar");
            } else {
                double payment = Convert.ToDouble(txtAmount.Text);
                double difference = 1800 - payment;
                difference = (difference + (difference * 0.05)) / 3;
                txtPayment.Text = difference.ToString();
            }
        }
        private async void btnSave_Clicked(object sender, EventArgs e) {
            double total = Convert.ToDouble(txtAmount.Text) + Convert.ToDouble(txtPayment.Text) * 3;
            DisplayAlert("Alerta", "Registro guardado con éxito", "Aceptar");
            await Navigation.PushAsync(new Resumen(txtLogeedUser.Text, txtName.Text, total.ToString()));
        }
    }
}