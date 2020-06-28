using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

using Foundation;
using rowad;
using rowad.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace rowad.iOS
{
    class CustomWebViewRenderer : ViewRenderer<CustomWebView, UIWebView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<CustomWebView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				SetNativeControl(new UIWebView());
			}
			if (e.OldElement != null)
			{
				// Cleanup
			}
			if (e.NewElement != null)
			{
				var customWebView = Element as CustomWebView;
				string fileName = Path.Combine(NSBundle.MainBundle.BundlePath, string.Format("https://ia801406.us.archive.org/12/items/book_20200318/book.pdf", WebUtility.UrlEncode(customWebView.Uri)));
				Control.LoadRequest(new NSUrlRequest(new NSUrl(fileName, false)));
				Control.ScalesPageToFit = true;
			}
		}
	}
}