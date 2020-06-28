using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using rowad.ViewModel;
using rowad.Model;
using rowad.View;
using rowad;
using Octane.Xamarin.Forms.VideoPlayer;
using ImageCircle.Forms.Plugin.Abstractions;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;

namespace rowad
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    // [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MainPage());
        }

        private async void fun_Clicked(object sender, EventArgs e)
        {
            if (sender == btn1)
            {
                Device.OpenUri(new Uri("http://www.rowad.org.il/"));
                this.IsPresented = false;
            }
            else if (sender == btn2)
            {
                await Detail.Navigation.PushAsync(new UniverstyListPage()).ConfigureAwait(true);
                this.IsPresented = false;
            }
            else if (sender == btn3)
            {
                await Detail.Navigation.PushAsync(new CollegeListPage()).ConfigureAwait(true);
                this.IsPresented = false;
            }
            else if (sender == btn4)
            {
                await Detail.Navigation.PushAsync(new LocListPage()).ConfigureAwait(true);
                this.IsPresented = false;
            }
            else if (sender == btn5)
            {
                await Detail.Navigation.PushAsync(new MapView()).ConfigureAwait(true);
                this.IsPresented = false;
            }
            else if (sender == btn6)
            {
                await Detail.Navigation.PushAsync(new InfoPage()).ConfigureAwait(true);
                this.IsPresented = false;
            }
        }
    }
}

