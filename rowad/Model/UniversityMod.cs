using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;
using rowad.View;
using rowad.ViewModel;

namespace rowad.Model
{
    class UniversityMod
    {
        public string NameArabic { get; set; }
        public string NameHebrow { get; set; }
        public string UniversityWebSite { get; set; }
        public string UniversityCalculator { get; set; }
        public string Image { get; set; }
        public List<UniversityMod> GetUniversityMods()
        {
            List<UniversityMod> UniversityMods = new List<UniversityMod>()
            {
                new UniversityMod(){ NameArabic="جامعة بن جوريون",NameHebrow="אוניברסיטת בן גוריון",UniversityWebSite="https://in.bgu.ac.il/Pages/default.aspx", UniversityCalculator="https://bgu4u.bgu.ac.il/html/average_calc/index.php",Image="ben_gryon_logo.png"},
                new UniversityMod(){ NameArabic="جامعة بار ايلان",NameHebrow="אוניברסיטת בר אילן",UniversityWebSite="https://www1.biu.ac.il/", UniversityCalculator="https://shoham.biu.ac.il/kabala/",Image="Bar_Ilan_University_logo.png"},
                new UniversityMod(){ NameArabic="جامعة حيفا",NameHebrow="אוניברסיטת חיפה",UniversityWebSite="https://www.haifa.ac.il/index.php/ar/2015-06-09-14-08-48", UniversityCalculator="https://applicants.haifa.ac.il/enrollmentChances/index.html",Image="haifa_logo.png"},
                new UniversityMod(){ NameArabic="جامعة تل-ابيب",NameHebrow="אוניברסיטת תל אביב",UniversityWebSite="https://ar-go.tau.ac.il/", UniversityCalculator="https://go.tau.ac.il/b.a/calc",Image="Tel_Aviv_university_logo.png"},
                new UniversityMod(){ NameArabic="معهد التّخنيون",NameHebrow="הטכניון",UniversityWebSite="https://www.technion.ac.il/", UniversityCalculator="https://admissions.technion.ac.il/calculator/",Image="Technion_Logo.png"},
                new UniversityMod(){ NameArabic="الجامِعة العبريّة في القدس",NameHebrow="האוניברסיטה העברית בירושלים",UniversityWebSite="https://new.huji.ac.il/", UniversityCalculator="http://www.huji.ac.il/dataj/controller/getinfo/TLM-EXPECTEDREK",Image="jorosalem2_logo.png"},
                new UniversityMod(){ NameArabic="جامعة أريئيل",NameHebrow="אוניברסיטת אריאל",UniversityWebSite="https://www.ariel.ac.il/university/minisite/?lm_key=b81333c199&lm_form=24959&lm_supplier=1196&gclid=Cj0KCQjwpPHoBRC3ARIsALfx-_KkBhPltXiEYbHCvDa8ADkwxReoT90s9OpuPfOdcw-Kjkf3iTMDtesaAnWJEALw_wcB", UniversityCalculator="https://www.ariel.ac.il/wp/%D7%9E%D7%97%D7%A9%D7%91%D7%95%D7%9F-%D7%A0%D7%AA%D7%95%D7%A0%D7%99-%D7%A7%D7%91%D7%9C%D7%94/",Image="Bar_Ilan_University2_logo.png"},
                new UniversityMod(){ NameArabic="الجامعة المفتوحة",NameHebrow="האוניברסיטה הפתוחה",UniversityWebSite="https://academic.openu.ac.il/campaigns/join-now/Pages/default.aspx?gclid=Cj0KCQjwpPHoBRC3ARIsALfx-_Js0_YbbtNh7iJxE6XEWYBdPu6Wth1aLhR7qDSmE1Fuma56Vjg7VSgaAmF_EALw_wcB", UniversityCalculator="https://academic.openu.ac.il/campaigns/join-now/Pages/default.aspx?gclid=Cj0KCQjwpPHoBRC3ARIsALfx-_Js0_YbbtNh7iJxE6XEWYBdPu6Wth1aLhR7qDSmE1Fuma56Vjg7VSgaAmF_EALw_wcB",Image="Open_university_israel_logo.png"},
                new UniversityMod(){ NameArabic="معهد وايزمان للعلوم",NameHebrow="מכון ויצמן למדעים",UniversityWebSite="https://www.weizmann.ac.il/pages/he", UniversityCalculator="https://www.weizmann.ac.il/pages/he",Image="Weizmann_Institute_of_Science_logo.png"}
            };
            return UniversityMods;
        }
    }
}
