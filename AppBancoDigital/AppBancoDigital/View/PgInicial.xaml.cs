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
    public partial class PgInicial : ContentPage
    {
        double saldo;
        double fatura;
        double limite = 2000;
        public PgInicial()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.pix.png");
            btn_pagar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.cartao.png");
            btn_boleto.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.boleto.png");
            btn_lucro.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.lucro.png");
            btn_login.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.user.png");
            btn_opcoes.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.tres_pontos.png");
            btn_olho.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            
            saldo = 132.45;
            fatura = 70.89;
            limite -= fatura;
            LblSaldo.Text = saldo.ToString("C");
            LblFatura.Text = fatura.ToString("C");
            LblLimite.Text = limite.ToString("C");

            
            //txt_correntista.Text = App.DadosCorrentista.nome;


        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void olho_Clicked(object sender, EventArgs e)
        {

        }

        private void opcoes_Clicked(object sender, EventArgs e)
        {

        }
    }
}