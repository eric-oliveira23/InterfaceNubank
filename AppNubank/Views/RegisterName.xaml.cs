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
    public partial class RegisterPass : ContentPage
    {
        public RegisterPass()
        {
            InitializeComponent();
        }
        
        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        async void btnNext(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Models.Usuario
                {
                    nome = entNome.Text
                };

                if (entNome.Text.Length < 3)
                {
                    await DisplayAlert("Alerta", "Insira seu nome!", "Ok");
                }
                else
                {
                    var mainpage = new MainPage();
                    mainpage.BindingContext = usuario;
                    await Navigation.PushAsync(mainpage);
                }

            }
            catch (Exception)
            {
               await DisplayAlert("Alerta", "Insira seu nome!", "Ok");
            }
        }
        
    }
}