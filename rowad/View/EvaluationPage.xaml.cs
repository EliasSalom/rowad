﻿using System;
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
        public EvaluationPage()
        {
            InitializeComponent();
            Comment.Text = test();
        }
        public string test()
        {
            string[] answare = new string[7];
            Random random = new Random();
            answare[0] = "القرار فيما يتعلق بالمجال الدّراسيّ والمهنيّ هو قرار ليس سهلًا، وقد أفاد الكثيرون بأنهم يواجهون صعوبات في عمليّة الاختيار. على الرغم من أن القرار صعب ومعقد، الا انه يمكن تسهيله بطرق مختلفة. من المهم عدم السّماح للأفكار والمشاعر السّلبية أن تمنعك من اتخاذ أي قرار.";
            answare[1] = "نوصي باستثمار الوقت والجّهد اللازمان للنظر في المهنة المناسبة لك. ومع ذلك، فمن المهم أيضا عدم تأجيل تنفيذ الخطوات اللازمة لاتخاذ القرار, لأنه من المُمكن أن تخسر بعض الخيارات المتاحة أمامك (المجالات تمتلئ وتغلق, المتطلبات تصبح أكثر والاختيار يقل).";
            answare[2] = "من المُستحسن البحث عن الدّعم والتّشاور مع أقرب الناس لك أو مع أشخاص مهنيين لِجمع المعلومات والاستماع إلى آراء أخرى. لكن من المهم أن تتذكر أن الآخرين لا يعرفون أكثر منك عن المهنة الأفضل والأنسب لك.";
            answare[3] = "من اجل التقدّم في عمليّة الاختيار, من المهم جمع معلومات مفصّلة وتتعلّق بالإمكانيات المختلفة المتاحة لك.";
            answare[4] = "كما نوصي أيضا بالتّحدث مع أشخاص مختصّين يعملون في المجال الذي تهتم\\ين به، والاستفسار منهم كيف تبدو حياتهم اليوميّة، ايجابيّات وسلبيّات المهنة، مسارات تخصّص المهنة، الصّفات والمهارات المطلوبة من العاملين في هذا المجال. نوصي أيضا بالاتصال بمجموعة مهنيّة، أو الجّمعيات والمنظمات المهنيّة التي تعمل في المجال الذي تهتم\'ين به. للكثير منهم توجد مواقع انترنت تعرض معلومات ذات أهمية وصلة.";
            answare[5] = "بعد جمع المعلومات المفصّلة حول كل إمكانيه من الإمكانيات المتاحة أمامك, يُوصى بالمقارنة بينها من حيث الايجابيات والسلبيات لكلٍ منها.";
            answare[6] = "بالإضافة الى ذلك، من المهم أيضا أن تدرك أن المساومة والمرونة هي جزء لا يتجزأ من عمليّة الاختيار في حالات عديدة.";
            return answare[random.Next(0, 6)];
        }
        private async void HomePage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage()).ConfigureAwait(true);
        }
    }
}