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
    public partial class UniversityPage : ContentPage
    {
        public string _WebSite;
        public string _calc;
        public UniversityPage(string ArabicName, string HebrowName, string WebSite, string Calc, string LogoImg)
        {
            InitializeComponent();
            arabic_Name.Text = ArabicName;
            hebrow_Name.Text = HebrowName;
            _WebSite = WebSite;
            _calc = Calc;
            logo_img.Source = LogoImg;
        }

        private void Web_Site_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(_WebSite));
        }

        private void Uni_calc_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri(_calc));
        }
    }
}