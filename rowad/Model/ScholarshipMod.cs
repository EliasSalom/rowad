using System;
using System.Collections.Generic;
using System.Text;

namespace rowad.Model
{
    class ScholarshipMod
    {
        public string ArabicName { get; set; }
        public string HebrowName { get; set; }
        public string WebsiteUrl { get; set; }
        public string Image { get; set; }
        public List<ScholarshipMod> GetScholarshipMods()
        {
            List<ScholarshipMod> ScholarshipMods = new List<ScholarshipMod>()
            {
                new ScholarshipMod(){ ArabicName="منحة ارتقاء",HebrowName="מלגת אירתקאא",WebsiteUrl="https://irteka.co.il/main.asp?IDsector=192",Image="ertekaa.png"},
                new ScholarshipMod(){ ArabicName="منحة دعم: مجلس التعليم العالي ووزارة التربية",HebrowName="מלגת סיוע :מלג ומשרד חינוך ",WebsiteUrl="https://che.org.il/%D7%9E%D7%A2%D7%A0%D7%A7%D7%99%D7%9D-%D7%95%D7%94%D7%9C%D7%95%D7%95%D7%90%D7%95%D7%AA-%D7%9C%D7%A1%D7%98%D7%95%D7%93%D7%A0%D7%98%D7%99%D7%9D-%D7%91%D7%9E%D7%95%D7%A1%D7%93%D7%95%D7%AA-%D7%9C%D7%94/",Image="malag.jpg"},
                new ScholarshipMod(){ ArabicName="سفراء روتشيلد",HebrowName="שגרירי רוטשלד",WebsiteUrl="https://rothschildcp.com/%D7%AA%D7%9B%D7%A0%D7%99%D7%AA-%D7%A9%D7%92%D7%A8%D7%99%D7%A8%D7%99-%D7%A8%D7%95%D7%98%D7%A9%D7%99%D7%9C%D7%93%D7%A2%D7%A9%D7%99%D7%94-%D7%97%D7%91%D7%A8%D7%AA%D7%99%D7%AA-%D7%9E%D7%A9%D7%9E%D7%A2/",Image="rotsheld.png"},
                new ScholarshipMod(){ ArabicName="منحة موشال",HebrowName="מלגת מושל",WebsiteUrl="",Image="moshal.jpg"},
                new ScholarshipMod(){ ArabicName="صندوق غروس",HebrowName="קרן גרוס",WebsiteUrl="https://www.gruss.org.il/",Image="gross.jpg"},
                new ScholarshipMod(){ ArabicName="منحة بيراح ",HebrowName="מלגת פרח",WebsiteUrl="http://www.perach.org.il/",Image="perah.png"},
                new ScholarshipMod(){ ArabicName="صندوق الصداقة",HebrowName="הקרן לידידות",WebsiteUrl="http://www.yedidut.org.il/",Image="logo_keren_yedid.png"},
                new ScholarshipMod(){ ArabicName="صندوق الحاجة رقية بيادسي",HebrowName="קרן רוקייה ביאדסה ",WebsiteUrl="http://wiki.sheatufim.org.il/%D7%A7%D7%A8%D7%9F:%D7%A7%D7%A8%D7%9F_%D7%A8%D7%95%D7%A7%D7%99%D7%99%D7%94_%D7%91%D7%99%D7%90%D7%93%D7%A1%D7%94_%D7%9C%D7%AA%D7%9E%D7%99%D7%9B%D7%94_%D7%91%D7%A1%D7%98%D7%95%D7%93%D7%A0%D7%98%D7%99%D7%9D_%D7%94%D7%A2%D7%A8%D7%91%D7%99%D7%9D_Rokia_Biadsa_Foundation",Image=""},
                new ScholarshipMod(){ ArabicName="منحة بني معروف للطائفة الدرزية",HebrowName="קרן בני מערוף ",WebsiteUrl="",Image=""},
                new ScholarshipMod(){ ArabicName="منحه على اسم وسام خميس",HebrowName="מלגה על שם ויסאם חמיס",WebsiteUrl="http://www.wesam-fund.org/index.html",Image="wessam_chamesa.png"},
                new ScholarshipMod(){ ArabicName="منحة شوليخ",HebrowName="מלגת מנהיגי שוליך",WebsiteUrl="http://www.schulichleaders.co.il/#top",Image="sholech_manager.png"},
                new ScholarshipMod(){ ArabicName="منحة ميماديم للتعليم",HebrowName="מלגת ממדים ללימודים",WebsiteUrl="https://www.hachvana.mod.gov.il/education/Pages/mimadim.aspx",Image="mmadem.jpg"},
                new ScholarshipMod(){ ArabicName="منحة ايساف",HebrowName="מלגת  אייסף",WebsiteUrl="https://www.isef.org.il/%D7%9E%D7%9C%D7%92%D7%95%D7%AA",Image="aeesf.png"},
                new ScholarshipMod(){ ArabicName="منحة جمعية الثقافة العربية",HebrowName="מלגת התרבות הערבית",WebsiteUrl="",Image=""},
                new ScholarshipMod(){ ArabicName="بوابة الاكاديمية",HebrowName="שער לאקדמיה",WebsiteUrl="http://www.rowad.org.il/%D8%A8%D9%88%D8%A7%D8%A8%D8%A9-%D8%A7%D9%84%D8%A3%D9%83%D8%A7%D8%AF%D9%8A%D9%85%D9%8A%D8%A9-%D7%A9%D7%A2%D7%A8-%D7%9C%D7%90%D7%A7%D7%93%D7%9E%D7%99%D7%94/?lang=he",Image=""},
                new ScholarshipMod(){ ArabicName="برنامج هيسجيم لهايتك",HebrowName="הישגים להייטק ",WebsiteUrl="https://aluma.org.il/program/%D7%94%D7%99%D7%A9%D7%92%D7%99%D7%9D-%D7%9C%D7%94%D7%99%D7%99%D7%98%D7%A7-3/",Image="hightech.png"},
                new ScholarshipMod(){ ArabicName="متدربون للتربية اللا منهجيه في كلية اورانيم",HebrowName="צוערים לחינוך בלתי פורמאלי ושלטון מקומי  ",WebsiteUrl="",Image=""},
                new ScholarshipMod(){ ArabicName="منحة بنك مركنتيل",HebrowName="מלגת בנק מרכנתיל",WebsiteUrl="",Image="mercantel.png"},
                new ScholarshipMod(){ ArabicName="منحة بنك هبوعاليم وجمعية امانينا",HebrowName="מלגת בנק הפועלים",WebsiteUrl="",Image=""},
                new ScholarshipMod(){ ArabicName="منحة الوقف الإسلامي",HebrowName="מלגת הווקף האיסלאמי",WebsiteUrl="",Image=""}
            };
            return ScholarshipMods;
        }
    }
}
