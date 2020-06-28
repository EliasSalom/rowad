using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rowad.ViewModel;
using rowad.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollegeListPage : ContentPage
    {
        private CollegeModel Cm;
        public CollegeListPage()
        {
            InitializeComponent();
            Cm = new CollegeModel();
            CollegeList.ItemsSource = Cm.CollegeMods;
        }

        private void CollegeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as CollegeMod;
            Device.OpenUri(new Uri(info.CallegeWebSite));
        }
    }
}