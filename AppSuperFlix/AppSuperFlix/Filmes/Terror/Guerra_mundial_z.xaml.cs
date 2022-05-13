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
    public partial class Guerra_mundial_z : ContentPage
    {
        public Guerra_mundial_z()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");
            poster.Source = ImageSource.FromResource("AppSuperFlix.Posters.Terror.Guerra_mundial_z.jpg");
        }
    }
}