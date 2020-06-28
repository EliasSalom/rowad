using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rowad.Model
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardModel : ContentView
    {
        public DashBoardModel()
        {
            InitializeComponent();
        }
        public string Text
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public ImageSource Icon
        {
            get
            {
                return img.Source;
            }
            set
            {
                img.Source = value;
            }
        }

        public ImageSource BackGroundImage
        {
            get
            {
                return imgBG.Source;
            }
            set
            {
                imgBG.Source = value;
            }
        }
    }
}