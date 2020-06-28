using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BottomBar.XamarinForms;
using System.ComponentModel;
using Xamarin.Forms;
using rowad.ViewModel;
using rowad.Model;
using rowad.View;
using Octane.Xamarin.Forms.VideoPlayer;
using ImageCircle.Forms.Plugin.Abstractions;
using Entry = Microcharts.Entry;
using SkiaSharp;
using Microcharts;
using Xamarin.Forms.Xaml;
using MediaManager;
using MediaManager.Video;
using System.IO;
using Android.Content;
using Android.OS;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabPage : ContentPage
    {
        public HomeTabPage()
        {
            InitializeComponent();
            //CrossMediaManager.Current.PlayFromResource("file:///intro.mp4");

        }
        public async void ImageClicked(object sender, EventArgs e)
        {
            if (sender == img1)
                await Navigation.PushAsync(new VideoPage()).ConfigureAwait(true);
            else if (sender == img2)
                await Navigation.PushAsync(new StudentTest()).ConfigureAwait(true);
            else if (sender == img3)
                await Navigation.PushAsync(new InfoPage()).ConfigureAwait(true);
            else if (sender == img5)
                await Navigation.PushAsync(new PDFView()).ConfigureAwait(true);
            else if (sender == img6)
                await Navigation.PushAsync(new LocListPage()).ConfigureAwait(true);
            else if (sender == img7)
            {
                Device.OpenUri(new Uri("http://iamcareer.adam-milo.co.il/Register"));
            }
            else if (sender == img8)
                await Navigation.PushAsync(new ScholarshipPage()).ConfigureAwait(true);
            else if (sender == img9)
                await Navigation.PushAsync(new CollegeListPage()).ConfigureAwait(true);
            else if (sender == img10)
                await Navigation.PushAsync(new UniverstyListPage()).ConfigureAwait(false);//the page can to go back

        }
    }
}
