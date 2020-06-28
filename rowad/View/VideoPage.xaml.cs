using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rowad.ViewModel;
using rowad.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        VideoView vvc;
        public VideoPage()
        {
            InitializeComponent();
            vvc = new VideoView();
            VideoList.ItemsSource = vvc.videoClasses;
        }

        public void VideoList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as VideoClass;

            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = info.UrlName,
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };


            // Build the page.
            this.Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };
        }

    }
}