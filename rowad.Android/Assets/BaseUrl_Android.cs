using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using rowad.Droid;
using Xamarin.Forms;
using static rowad.View.WebPageLoad;

[assembly: Dependency(typeof(BaseUrl_Android))]
namespace rowad.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }

    }
}