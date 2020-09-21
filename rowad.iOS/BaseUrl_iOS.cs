using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using rowad.iOS;
using UIKit;
using Xamarin.Forms;
using static rowad.View.WebPageLoad;

[assembly: Dependency(typeof(BaseUrl_iOS))]
namespace rowad.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}