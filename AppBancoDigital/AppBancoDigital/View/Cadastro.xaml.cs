using AppBancoDigital.Model;
using AppBancoDigital.Service;
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
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_visivel.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {


                await DataServiceCorrentista.Cadastrar(new Correntista
                {
                    nome = txt_name.Text,
                    data_nasc = dtpck_datanasc.Date,
                    cpf = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty),
                    senha = txt_senha.Text
                });

                await DisplayAlert("Sucesso!", "Você foi cadastrado.", "OK");
                await Navigation.PushAsync(new MainPage());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");

            }
            finally
            {
                carregando.IsRunning = false;
                carregando.IsVisible = false;
            }
        }



        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btn_senha_Clicked(object sender, EventArgs e)
        {
            if (txt_senha.IsPassword == true)
            {
                txt_senha.IsPassword = false;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            }
            else
            {
                txt_senha.IsPassword = true;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_visivel.png");
            }
        }

        private void btn_confirme_senha_Clicked(object sender, EventArgs e)
        {
            if (txt_confirme_senha.IsPassword == true)
            {
                txt_confirme_senha.IsPassword = false;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            }
            else
            {
                txt_confirme_senha.IsPassword = true;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_visivel.png");
            }
        }
    }


}
