using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rowad.View;
using rowad.ViewModel;
using rowad.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScholarshipPage : ContentPage
    {
        ScholarshipViewModel svm;
        public ScholarshipPage()
        {
            InitializeComponent();
            svm = new ScholarshipViewModel();
            ScholarshipList.ItemsSource = svm.ScholarshipMods;
        }
        private void ScholarshipList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as ScholarshipMod;
            if (info.WebsiteUrl != "")
            Device.OpenUri(new Uri(info.WebsiteUrl));
        }
    }
}