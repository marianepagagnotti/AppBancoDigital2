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
    public partial class Cartoes : ContentPage
    {
        public Cartoes()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.seta.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.interrogacao.png");
            simbolo_cartao_digital.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.simbolo.png");
            simbolo_cartao.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.simbolo.png");
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.PgInicial());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_dados_cartaofisico_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_dados_cartaodigital_Clicked(object sender, EventArgs e)
        {

        }
    }
}