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
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
            pen.Source = "Rowad_pen.png";
            Rowad_img.Source = "Rowad_Logo.jpg";
            info.Text = "يهدف برنامج رواد التعليم العالي لتوسيع منالية التعليم في المجتمع العربي, البدوي, الدرزي والشركسي\n بجميع الجامعات والكليات المعترف بها من قبل مجلس التعليم العالي.\n ويأتي بسلة خدمات كبيرة ومتنوعة\n لتساعد الطلاب على تخطّي عقبات تقف في طريقهم للوصول إلى الاكاديمية الاسرائيلية.";
            NavigationPage.SetHasBackButton(this, true);
        }
    }
}