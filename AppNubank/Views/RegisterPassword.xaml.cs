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
    public partial class RegisterPassword : ContentPage
    {
        public RegisterPassword()
        {
            InitializeComponent();
        }
        string senha;
        async void btnNext(object sender, EventArgs e)
        {
            try
            {
                senha = entPass.Text;

                if (entPass.Text.Length < 4)
                {
                    await DisplayAlert("Alerta", "Senha digitada inválida.", "Ok");
                }
                else
                {
                    await Navigation.PushAsync(new RegisterPass());
                }
            }

            catch (Exception)
            {
                await DisplayAlert("Alerta", "Dados digitados inválidos.", "Ok");
            }
        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

        
    }
