using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppSuperFlix.Filmes;

namespace AppSuperFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);

            logo_acao.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");

            btnUncharted.Source = ImageSource.FromResource("AppSuperFlix.Posters.Aventura.uncharted.jpg");
            btnJumanji.Source = ImageSource.FromResource("AppSuperFlix.Posters.Aventura.jumanji.jpg");
            btnContra_o_Gelo.Source = ImageSource.FromResource("AppSuperFlix.Posters.Aventura.contra_o_gelo.jpg");
            btnHotelTransylvaniaTransformania.Source = ImageSource.FromResource("AppSuperFlix.Posters.Aventura.hotel_transylvania_transformania.jpg");
        }

        private async void btnHotelTransylvaniaTransformania_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Hotel_Transylvania_Transformania());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }

        private async void btnUncharted_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Uncharted());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }

        private async void btnContra_o_Gelo_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Contra_o_Gelo());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }

        private async void btnJumanji_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Aventura.Jumanji());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }
    }
}