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
    public partial class Resumen : ContentPage
    {
        public Resumen(string user, string userName, string total)
        {
            InitializeComponent();
            txtLogeedUser.Text = user;
            txtUserName.Text = userName;
            txtTotal.Text = total;
        }
    }
}