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
    public partial class PixEnviar : ContentPage
    {
        public PixEnviar()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();            
        }
       
    }
}