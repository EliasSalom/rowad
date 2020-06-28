using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDFView : ContentPage
    {
        public PDFView()
        {
            InitializeComponent();
            Content = new StackLayout
            {
                Children = {
                    new CustomWebView {
                        Uri = "https://ia801406.us.archive.org/12/items/book_20200318/book.pdf",
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    }
                }
            };
        }
    }
}