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
        public PgInicial()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.pix.png");
            btn_pagar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.cartao.png");
            btn_boleto.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.boleto.png");
            btn_cobrar.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.user.png");
            //btn_olho_naovisivel.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            //btn_envelope.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.user.png");
            //btn_dots.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.user.png");

            //string[] resultsArray = explode(" ", App.DadosCorrentista.nome);
            //string Nome = resultsArray[0];

            //string Saldo = App.DadosConta.saldo.ToString();

            //txt_correntista.Text = Nome;
            //LblSaldo.Text = "R$ " + Saldo;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}