using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rowad.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class locationPage : ContentPage
    {
        public string mob;
        public locationPage(string Mange, string LocationName, string phone, string mobile, string address, string mail)
        {
            InitializeComponent();
            Name.Text = Mange;
            Loc.Text = LocationName;
            mob = mobile;
            pho.Text = phone;
            Address.Text = address;
            Email.Text = mail;
        }

        private void MakeCall(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:" + mob));
        }

    }
}