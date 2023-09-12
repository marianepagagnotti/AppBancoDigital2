using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PixHome : ContentPage
    {
        public PixHome()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.seta.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.interrogacao.png");
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_pagar_pix_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_receber_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.MostrarQrCode());
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.PgInicial());
        }
    }
}