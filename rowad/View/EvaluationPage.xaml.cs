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
    public partial class EvaluationPage : ContentPage
    {
        public EvaluationPage(string str)
        {
            InitializeComponent();
            Comment.Text = str;
        }

        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage()).ConfigureAwait(true);
        }
    }
}