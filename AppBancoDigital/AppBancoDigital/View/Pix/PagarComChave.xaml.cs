using AppBancoDigital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBancoDigital.Model;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagarComChave : ContentPage
    {
        public PagarComChave()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.seta.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.interrogacao.png");
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.PagarComPix());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string tipo_chave = pck_chave.SelectedItem.ToString();
            string chave_pix = txt_chave.Text;

            await DataServiceChavePix.Adicionar(new ChavePix
            {
                tipo = tipo_chave,
                chave = chave_pix,
                id_conta = App.DadosConta.Id

            });

            //await Navigation.PushAsync(new View.lista());
        }
    }
}