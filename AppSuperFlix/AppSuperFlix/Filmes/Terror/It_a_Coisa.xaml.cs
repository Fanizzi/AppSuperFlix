using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSuperFlix.Filmes.Terror
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class It_a_Coisa : ContentPage
    {
        public It_a_Coisa()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");
            poster.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.it_a_coisa.jpg");


        }
    }
}