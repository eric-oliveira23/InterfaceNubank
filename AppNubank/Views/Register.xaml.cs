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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        string cpf;
        async void btnBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void btnNext(object sender, EventArgs e)
        {
            try
            {
                cpf = entCPF.Text;
                
                if (cpf.Length < 14)
                {
                    await DisplayAlert("Alerta!", "Digite seu CPF", "Ok");
                }
                else
                {
                    await Navigation.PushAsync(new RegisterPassword());
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Alerta!", "Digite seu CPF", "Ok");
            }
        }
    }
}