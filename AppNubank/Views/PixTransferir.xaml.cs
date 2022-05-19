using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNubank.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixTransferir : ContentPage
    {
        public PixTransferir()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnNext(object sender, EventArgs e)
        {
            if (entChave.Text.Length <= 5)
            {
                DisplayAlert("Alerta","Chave pix inválida.","Ok");
            }
            else
            {
                Navigation.PushAsync(new PixEnviar());
            }
        }
    }
}