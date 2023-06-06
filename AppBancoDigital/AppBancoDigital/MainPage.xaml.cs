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
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string cpf = txt_cpf.Text;
            string senha = txt_senha.Text;

            try
            {
                Correntista correntista = await DataServiceCorrentista.Login(new Correntista
                {
                    cpf = cpf,
                    senha = senha
                });

                await Navigation.PushAsync(new View.Home());

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
    }
}
