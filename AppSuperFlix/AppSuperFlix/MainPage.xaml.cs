using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSuperFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            sub_logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.categorias.png");
            

        }

        
        private async void btnAventura_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }
        }

        private async void btnAcao_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Acao());
            }
            catch(Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }

        }

        private async void btnComedia_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Comedia());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }

        }

        private async void btnTerror_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Terror());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "OK");
            }

        }
    }
}
