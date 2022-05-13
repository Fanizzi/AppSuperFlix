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
    public partial class Terror : ContentPage
    {
        public Terror()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");

            btnMorbius.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.morbius.jpg");
            btnIt_a_coisa.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.it_a_coisa.jpg");
            btnIt_chapter_2.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.It_Chapter_2.jpg");
            btnGuerra_mundial_z.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.Guerra_mundial_z.jpg");

        }

        private async void btnMorbius_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.morbius());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }

        private async void btnIt_a_coisa_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.It_a_Coisa());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }

        }

        private async void btnGuerra_mundial_z_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.Guerra_mundial_z());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }

        private async void btnIt_chapter_2_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Terror.It_capitulo_2());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro...", ex.Message.ToString(), "Ok");
            }
        }
    }
}