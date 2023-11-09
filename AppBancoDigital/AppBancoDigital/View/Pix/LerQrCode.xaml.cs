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
    public partial class LerQrCode : ContentPage
    {
        public LerQrCode()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.seta.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.interrogacao.png");

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            zxing.IsScanning = true;
        }

        protected override void OnDisappearing()
        {
            zxing.IsScanning = false;

            base.OnDisappearing();
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.PagarComPix());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}