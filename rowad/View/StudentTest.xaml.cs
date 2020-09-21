using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using rowad.ViewModel;
using rowad.Model;
using rowad.View;
using SQLite;
using Android.Content;
using Android.OS;
using System.IO;
using Xamarin.Essentials;
using Rg.Plugins.Popup.Extensions;
using static rowad.View.WebPageLoad;

namespace rowad
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentTest : ContentPage
    {
        QuestionView qV;
        public string Qwez;
        int i = 0;
        int[] arry = new int[36];
        int someInt;
        Double progras=0.0;
        public StudentTest()
        {
            InitializeComponent();            
              qV = new QuestionView();
              answare.IsVisible = false;
              goodbad.IsVisible = false;
              Send.Text = "يلا";
              Rowad_Logo.Source = "rowad.png";
        }
        
        private async void Send_Clicked(object sender, EventArgs e)
        {
            if(i==0)
            {
            await DisplayAlert("", "تظهر أمامك في الصفحات التالية" +
                " جمل تصف الصعوبات المختلفة في اختيار موضوع دراسي أو مهنة." +
                " سجّل/ي عند كل جملة درجة ملاءمتها لك: " +
                "ضع/ي دائرة حول الرقم 1 إذا كانت الجملة لا تلائمك أبدًا، " +
                "وحول الرقم 9 إذا كانت الجملة ملائمة جدًّا لك. " +
                "يمكنك أيضًا وضع دائرة حول أي رقم بين 1 و 9 إذا كان ملائمًا لك.", "اكمل").ConfigureAwait(true);
                Rowad_Logo.IsVisible = false;
            }
            answare.IsVisible = true;
            goodbad.IsVisible = true;
            Send.Text = "التالي";
            if (i<34)
            {
                QuizMod quizMod = (from s in qV.QuizMods
                                   where (s.number == i)
                                   select s).FirstOrDefault();

                quiz_titel.Text = quizMod.Question;
                Console.WriteLine(i);
                arry[i] = someInt;
                answare.Value = 0;
                progras+=0.029;
                ProgBar.Progress = progras;
                ahoz.Text = i+1 +"/34";
                i++;
            }
            else
            {
                await Navigation.PushPopupAsync(new Popup()).ConfigureAwait(true);
                WebView webView = new WebView
                {
                    Source = new UrlWebViewSource
                    {
                        Url = "https://shlomital.formtitan.com/ruad_app",
                    },
                    VerticalOptions = LayoutOptions.FillAndExpand
                };


                // Build the page.
                this.Content = new StackLayout
                {
                    Children =
                {
                    webView
                }
                };
            }
        }
        private void Answare_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double x = answare.Value;
            someInt = Convert.ToInt32(x);
            title_label.Text = someInt.ToString();
        }
        public int CheckTest(int[] AnswreArray)
        {
            int Validity = 0,total=0,counter=1;
            int[] SumArray = new int[3];
            int[] AvargeArray = new int[3];
            if (AnswreArray[7] <= 5 || AnswreArray[12] > 5) 
            {
                Validity += 1;
                if (AnswreArray[12] > 5)
                    Validity += 1;
                else {
                    CheckAnsware(Validity);
                    return 0;
                }
            }
            else
            {
                for (; counter < 12; counter++)
                {
                    if (counter != 7)
                        SumArray[0] += AnswreArray[counter];
                }
                AvargeArray[0] = SumArray[0] / 3;
                counter++;

                for (; counter < 25; counter++)
                {
                    SumArray[1] += AnswreArray[counter];
                }
                AvargeArray[1] = SumArray[0] / 4;

                for (; counter < 34; counter++)
                {
                    SumArray[2] += AnswreArray[counter];
                }
                AvargeArray[2] = SumArray[2] / 3;
            }
            return total = SumArray[0] + SumArray[1] + SumArray[2];
        }
        public async void CheckAnsware(int a)
        {
            if (a == 1)
            {
                await DisplayAlert("تحذير", "تحليل اجوبتك يظهر انك لم تكن بكامل تركيزك عندما اجبت على الاستبيان. ولذلك، نرجو التطرق الى النتيجة بتحفظ ", "اكمل").ConfigureAwait(true);
                i=1;
                progras = 0.0;
            }
            else if (a == 2)
            {
                await DisplayAlert("تحذير", "تحليل اجوبتك يظهر بأنك لم تكن بكامل تركيزك عندما اجبت على الاستبيان. ولذلك، لا يمكن اعطاؤك النتيجة . من المفضل تعبئة الاستبيان مرة أخرى.", "اكمل").ConfigureAwait(true);
                i = 1;
                progras = 0.0;
            }
        }
    }
}