using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppNubank
{
    public partial class MainPage : ContentPage
    {
        double saldo;
        double fatura;
        double limite = 2500;
        public MainPage()
        {
            InitializeComponent();
            
            saldo = 1274.45;
            fatura = 78.87;
            limite -= fatura;
            LblSaldo.Text = saldo.ToString("C");
            LblFatura.Text = fatura.ToString("C");
            LblLimite.Text = limite.ToString("C");
        }

        private void btnHide(object sender, EventArgs e)
        {
            if (LblSaldo.Text == saldo.ToString("C"))
            {                
                eyebutton.Source = "eyes.png";
                LblSaldo.Text = "━━━━━━";
            }
            else
            {               
                LblSaldo.Text = saldo.ToString("C");
                eyebutton.Source = "eyecross.png";
            }
        }

        private void btnPix(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Pix());
        }
    }
}
