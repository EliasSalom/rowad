using System;
using System.Linq;
using rowad.Model;
using rowad.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocListPage : ContentPage
    {
        private LocationViewModel lvm;
        private locationGroup lolo;
        public LocListPage()
        {
            InitializeComponent();
            
            lvm = new LocationViewModel();
            this.BindingContext =new loctionGroup();
            //LocationList.ItemsSource = locationGroup.LocationMod();
        }
        public async void Location_Tapped(object sender, ItemTappedEventArgs e)
        {
            var info = e.Item as LocationMod;
            string Mange = info.Mange;
            string LocationName = info.LocationName;
            string phone = info.Phone;
            string mobile = info.Mobile;
            string address = info.Address;
            string mail = info.Mail;
            await Navigation.PushAsync(new locationPage(Mange, LocationName, phone, mobile, address, mail)).ConfigureAwait(true);
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var _container = lvm as loctionGroup;
            //LocationList.BeginRefresh();
            //if (String.IsNullOrWhiteSpace(e.NewTextValue)) LocationList.ItemsSource = _container.LocationMods;
            //else LocationList.ItemsSource = _container.LocationMods.Where(i => i.LocationName.Contains(e.NewTextValue));
            //LocationList.EndRefresh();
        }
    }
}