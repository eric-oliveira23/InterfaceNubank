using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNubank
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentPage
    {
        public View1()
        {
            InitializeComponent();
            lblInicio.FontSize = 40;
        }

        async void btnRegister(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Register());
        }

        async void btnLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Login());
        }
    }
}