using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSuperFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheBatman : ContentPage
    {
        public TheBatman()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppSuperFlix.Imgs.superflix.png");
            poster.Source = ImageSource.FromResource("AppSuperFlix.Posters.Acao.batman.jpg");
        }
    }
}