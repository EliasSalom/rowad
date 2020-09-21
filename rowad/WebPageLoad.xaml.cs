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
    public partial class WebPageLoad : ContentPage
    {
        public interface IBaseUrl { string Get(); }
        public WebPageLoad()
        {
            InitializeComponent();
            var source = new HtmlWebViewSource();
            source.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            //webviewjava.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            webviewjava.Source = source;
            webviewjava.Source = "index.html";

        }
        

    }
}