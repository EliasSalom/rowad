using System;
using System.Collections.Generic;
using System.Text;

namespace rowad.Model
{
    class CollegeMod
    {
        public string NameArabic { get; set; }
        public string NameHebrow { get; set; }
        public string CallegeWebSite { get; set; }
        public string Image { get; set; }
        public List<CollegeMod> GetCollegeMods()
        {
            List<CollegeMod> CollegeMods = new List<CollegeMod>()
            {
                new CollegeMod(){ NameArabic="افيكا – الكلية الأكاديمية للهندسة في تل ابيب",NameHebrow="אפקה - המכללה האקדמית להנדסה בתל-אביב",CallegeWebSite="https://www.afeka.ac.il/",Image="Afeka.png"},
                new CollegeMod(){ NameArabic="بتسلئيل  - المعهد العالي لحرف الفنون بالقدس",NameHebrow="בצלאל -אקדמיה לאומנות ועיצוב ירושלים",CallegeWebSite="http://www.bezalel.ac.il/",Image="Batslal.png"},
                new CollegeMod(){ NameArabic="الأكاديمية للموسيقى والرقص في القدس",NameHebrow="האקדמיה למוסיקה ולמחול בירושלים ",CallegeWebSite="https://www.jamd.ac.il/",Image="MusecCollage.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية احفا",NameHebrow="המכללה האקדמית אחוה ",CallegeWebSite="https://www.achva.ac.il/",Image="AhvaCollage.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية اشكلون",NameHebrow="המכללה האקדמית אשקלון",CallegeWebSite="https://www.aac.ac.il/",Image="Ashklon.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية الجليل الغربي",NameHebrow="המכללה האקדמית גליל מערבי",CallegeWebSite="https://www.wgalil.ac.il/",Image="GalelMarbe.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية هداسا, القدس",NameHebrow="המכללה האקדמית הדסה, ירושלים ",CallegeWebSite="https://www.hac.ac.il/",Image="Hadasa.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية كينرت غور الأردن",NameHebrow="המכללה האקדמית עמק הירדן",CallegeWebSite="https://www.kinneret.ac.il/Web/Default.aspx",Image="KanertCollage.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للهندسة سامي شمعون",NameHebrow="המכללה האקדמית להנדסה סמי שמעון",CallegeWebSite="https://www.sce.ac.il/",Image="SameShemon.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية سبير ",NameHebrow="המכללה האקדמית ספיר ",CallegeWebSite="https://www.sapir.ac.il/",Image="Sapher.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية عيميك يزرعيل ",NameHebrow="המכללה האקדמית עמק יזרעאל",CallegeWebSite="https://www.yvc.ac.il/",Image="EmkYsrael.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية صفد ",NameHebrow="המכללה האקדמית צפת ",CallegeWebSite="https://www.zefat.ac.il/",Image="tsfat.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية تل ابيب يافا",NameHebrow="המכללה האקדמית תל אביב -יפו ",CallegeWebSite="https://www.mta.ac.il/he-il/",Image="TelAvevCollage.png"},
                new CollegeMod(){ NameArabic="الكلية الاكاديمية تل حاي",NameHebrow="המכללה האקדמית תל חי ",CallegeWebSite="https://www.telhai.ac.il/",Image="TalHay.png"},
                new CollegeMod(){ NameArabic="مركز روبين الأكاديمي",NameHebrow="המרכז האקדמי רופין",CallegeWebSite="https://www.ruppin.ac.il/Pages/hp.aspx",Image="Ropen.jpg"},
                new CollegeMod(){ NameArabic="المركز التكنولوجي حولون",NameHebrow="מכון טכנולוגי חולון ",CallegeWebSite="https://www.hit.ac.il/",Image="HolonTech.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للهندسة اورط براوده",NameHebrow="מכללה האקדמית להנדסה אורט בראודה",CallegeWebSite="http://www.braude.ac.il/",Image="OrtProwda.png"},                
                new CollegeMod(){ NameArabic="عزرائيلي الكلية الأكاديمية للهندسة في القدس",NameHebrow="עזריאלי המכללה האקדמית להנדסה בירושלים",CallegeWebSite="https://www.jce.ac.il/",Image="Israely.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية شنكار",NameHebrow="שנקר הנדסה עיצוב אמנות",CallegeWebSite="https://www.shenkar.ac.il/he",Image="Shanker.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للمجتمع والفنون",NameHebrow="המכללה האקדמית לחברה ואומנויות ",CallegeWebSite=" https://www.asa.ac.il/",Image="Omnot.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية لإسرائيل رمات غان",NameHebrow="המכללה האקדמית לישראל ברמת גן",CallegeWebSite="https://www.iac.ac.il/",Image="RamatGan.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية نتانيا",NameHebrow="המכללה האקדמית נתניה ",CallegeWebSite="https://www.netanya.ac.il/Pages/default.aspx",Image="Natanya.png"},
                new CollegeMod(){ NameArabic="المسار الاكاديمي لكلية الإدارة",NameHebrow="המסלול האקדמי של המכללה למנהל",CallegeWebSite="https://www.colman.ac.il/",Image="MangerCollage.png"},
                new CollegeMod(){ NameArabic="المركز الأكاديمي للحقوق والإدارة ",NameHebrow="המרכז האקדמי למשפט ולעסקים",CallegeWebSite="",Image="BussnesCollage.png"},
                new CollegeMod(){ NameArabic="المركز الاكاديمي بيريس",NameHebrow="המרכז האקדמי פרס",CallegeWebSite="https://www.pac.ac.il/",Image="prasCollage.jpg"},
                new CollegeMod(){ NameArabic="المركز الأكاديمي أبواب العلم والحقوق",NameHebrow="המרכז האקדמי שערי מדע ומשפט",CallegeWebSite="https://mishpat.ac.il/",Image="ShareMada.png"},
                new CollegeMod(){ NameArabic="المركز المتعدد المجالات هرتسليا",NameHebrow="המרכז הבינתחומי הרצליה",CallegeWebSite="https://www.idc.ac.il/he/pages/home.aspx",Image="HertzlyaCollage.png"},
                new CollegeMod(){ NameArabic="المركز الأكاديمي اور يهودا",NameHebrow="המרכז האקדמי אור יהודה",CallegeWebSite="https://www.mla.ac.il/",Image="OrYahoda.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية اونو ",NameHebrow="הקריה האקדמית אונו ",CallegeWebSite="https://www.ono.ac.il/",Image="OneCollage.png"},
                new CollegeMod(){ NameArabic="القاسمي كليه أكاديمية للتربية والتعليم",NameHebrow="אלקאסמי -מכללה אקדמית לחינוך",CallegeWebSite="https://www.qsm.ac.il/he/?mod=articles&ID=468",Image="Alkaseme.png"},
                
                new CollegeMod(){ NameArabic="الكلية الأكاديمية بيت يبرل",NameHebrow="המכללה האקדמית בית-ברל ",CallegeWebSite="https://www.beitberl.ac.il/",Image="BetBerll.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية العربية للتربية في إسرائيل - حيفا",NameHebrow="המכללה האקדמית הערבית לחינוך בישראל -חיפה",CallegeWebSite="http://www.arabcol.ac.il/",Image="ArabicCollage.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية فنجيت",NameHebrow="המכללה האקדמית וינגייט",CallegeWebSite="https://www.wincol.ac.il/",Image="Venged.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية التربية والرياضة اوهلو كتسرين ",NameHebrow="המכללה האקדמית לחינוך ולספורט אוהלו בקצרין ",CallegeWebSite="http://www.ohalo.ac.il/",Image="OhloCollage.jpg"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للتربية على اسم دافيد يلين ",NameHebrow="המכללה האקדמית לחינוך דוד ילין",CallegeWebSite="https://www.dyellin.ac.il/",Image="DodYalen.png"},
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للتربية على اسم كي",NameHebrow="המכללה האקדמית לחינוך קיי",CallegeWebSite="https://www.kaye.ac.il/",Image="Key.png"},
                new CollegeMod(){ NameArabic="الكليه الاكاديميه للتربيه على اسم ا.د. جوردون",NameHebrow="המכללה האקדמית לחינוך א.ד. גורדון",CallegeWebSite="https://www.gordon.ac.il/",Image="Gorden.png"},
                new CollegeMod(){ NameArabic="المركز الأكاديمي للتصميم والتعليم فيتسو",NameHebrow="המרכז האקדמי לעיצוב ולחינוך ויצו – נרי בלומפילד",CallegeWebSite="https://www.wizodzn.ac.il/",Image="Vetsav.png"},
                
                new CollegeMod(){ NameArabic="الكلية الأكاديمية للتربية -اورانيم ",NameHebrow="המכללה האקדמית לחינוך אורנים ",CallegeWebSite="http://www.oranim.ac.il/sites/heb/pages/default.aspx",Image="Oranem.png"},
                
                new CollegeMod(){ NameArabic="كليه لفينسكي للتربية",NameHebrow="מכללת לוינסקי לחינוך ",CallegeWebSite="https://www.levinsky.ac.il/",Image="Lenske.png"},
                new CollegeMod(){ NameArabic="كليه سخنين الأكاديمية لأعداد وتأهيل المعلمين ",NameHebrow="מכללת סכנין – מכללה אקדמית להכשרת עובדי הוראה ",CallegeWebSite="http://www.sakhnin.ac.il/",Image="Skhnin.png"},
                new CollegeMod(){ NameArabic="كليه سمينار هكيبوتسيم للتربية -التكنولوجيا والفنون ",NameHebrow="סמינר הקיבוצים – המכללה לחינוך לטכנולוגיה ולאומנויות",CallegeWebSite="https://www.smkb.ac.il/",Image="SamenarHakebotsem.png"}
            };
            return CollegeMods;
        }
    }
}
