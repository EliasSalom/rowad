using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using rowad.View;
using System.Diagnostics;

namespace rowad
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = App.BaseImageUrl + "https://raw.githubusercontent.com/sumathij/essential-ui-kit-for-xamarin.forms/master/Images/";
       
        public App()
        {
            InitializeComponent();

            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
