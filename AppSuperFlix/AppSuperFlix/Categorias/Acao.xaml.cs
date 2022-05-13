using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSuperFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Acao : ContentPage
    {
        public Acao()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");

            btnDoutorEstranho.Source = ImageSource.FromResource("AppSuperFlix.Posters.Acao.doctorstrange.jpg");
            btnSonic2.Source = ImageSource.FromResource("AppSuperFlix.Posters.Acao.sonic2.jpg");
            btnSpiderMan.Source = ImageSource.FromResource("AppSuperFlix.Posters.Acao.spiderman.jpg");
            btnTheBatman.Source = ImageSource.FromResource("AppSuperFlix.Posters.Acao.batman.jpg");
        }


        private async void btnDoutorEstranho_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.DoutorEstranho());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }

        private async void btnSpiderMan_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.SpiderMan());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }

        private async void btnSonic2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Sonic2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }

        private async void btnTheBatman_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.TheBatman());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }
    }
}