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
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                carregando.IsRunning = true;
                carregando.IsVisible = true;


                if (txt_name.Text == null | txt_senha.Text == null | txt_cpf.Text == null | txt_senhaconfirm.Text == null)
                {
                    await DisplayAlert("Ops!", "Você provavelmente deixou algo em branco.", "OK");
                }
                else
                {
                    if (txt_senha.Text != txt_senhaconfirm.Text)
                    {

                        await DisplayAlert("Ops!", "As senhas não batem.", "OK");

                    }
                    else
                    {
                        await DataServiceCorrentista.Cadastrar(new Correntista
                        {
                            nome = txt_name.Text,
                            data_nasc = dtpck_datanasc.Date,
                            cpf = txt_cpf.Text,
                            senha = txt_senha.Text
                        });


                        await DisplayAlert("Sucesso!", "Você foi cadastrado.", "OK");
                        await Navigation.PushAsync(new MainPage());

                    }
                }
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
    }

      
    }
