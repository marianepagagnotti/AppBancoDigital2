using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagarComPix : ContentPage
    {
        public PagarComPix()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.seta.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.interrogacao.png");
            btn_pagar_qr.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.iconeQR.png");
            btn_pagar_chave.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.chave.png");
            btn_pagar_copiaecola.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.copiaecola.png");
        }

        private void btn_pagar_qr_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_pagar_chave_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_pagar_copiaecola_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.PixHome());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}