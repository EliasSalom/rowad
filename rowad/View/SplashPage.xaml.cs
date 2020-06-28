using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        Image splashImage;
        public SplashPage()
        {
            InitializeComponent();
            LogoAnimation();
        }
        public async Task LogoAnimation()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 4000);
            Application.Current.MainPage = new MainPage();
        }
    }
}