using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rowad.Model;
using rowad.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UniverstyListPage : ContentPage
    {
        UniversityViewModel uvm;
        public UniverstyListPage()
        {
            InitializeComponent();
            uvm = new UniversityViewModel();
            UniversityList.ItemsSource = uvm.UniversityMods;
        }
        private async void UniversityList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as UniversityMod;
            string ArabicName = info.NameArabic;
            string HebrowName = info.NameHebrow;
            string WebSite = info.UniversityWebSite;
            string Calc = info.UniversityCalculator;
            string LogoImg = info.Image;
            await Navigation.PushAsync(new UniversityPage(ArabicName, HebrowName, WebSite, Calc, LogoImg)).ConfigureAwait(true);
        }
    }
}