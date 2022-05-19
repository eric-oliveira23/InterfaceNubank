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
    public partial class Pix : ContentPage
    {
        public Pix()
        {
            InitializeComponent();
        }

        private void btnBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btnTransferir(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixTransferir());
        }

        private void btnReceber(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PixReceber());
        }
    }
}