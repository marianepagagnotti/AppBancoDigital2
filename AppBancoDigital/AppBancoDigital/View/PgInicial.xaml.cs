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

            
            string[] resultsArray = explode(" ", App.DadosCorrentista.nome);
            string nome = resultsArray[0];

            txt_correntista.Text = "Olá, " + nome;
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