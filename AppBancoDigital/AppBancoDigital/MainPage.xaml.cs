using System;
using AppBancoDigital.Model;
using AppBancoDigital.Service;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppBancoDigital
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.muitolegal2.png");
            btn_senhalog.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_visivel.png");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Correntista correntista = await DataServiceCorrentista.Login(new Correntista
                {
                    cpf = txt_cpf.Text.Replace(".", "").Replace("-", ""),
                    senha = txt_senha.Text
                });

                await Navigation.PushAsync(new View.PgInicial());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {

                await Navigation.PushAsync(new View.Cadastro());

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void btn_senhalog_Clicked(object sender, EventArgs e)
        {
            if (txt_senha.IsPassword == true)
            {
                txt_senha.IsPassword = false;
                btn_senhalog.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_naovisivel.png");
            }
            else
            {
                txt_senha.IsPassword = true;
                btn_senhalog.Source = ImageSource.FromResource("AppBancoDigital.NovaPasta1.olho_visivel.png");
            }
        }
    }
}
