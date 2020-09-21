using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class loctionGroup
    {
        public ObservableCollection<locationGroup> userlist { get; set; }
        public loctionGroup()
        {
            this.userlist = new ObservableCollection<locationGroup>();
            var group1 = new List<LocationMod>
            {
                                 // فرقة سلمانnorth
                new LocationMod("يركا","نيفين حبيش","1700555606","1700555606","المجلس المحلي يركا الطابق الثالث","neven@rowad.org.il","pin.png"),
                new LocationMod("يانوح جث","نعامه فرج" ,"1700555606","1700555606","المجلس المحلي يانوح-جت الطابق الاول","yanoh.jat@rowad.org.il","pin.png"),
                new LocationMod("دالية الكرمل","ميسا حلبي","1700555606","1700555606","وادي الفش- تحت قسم الجبايه ,دالية الكرمل","daleit.alcarmel@rowad.org.il","pin.png"),
                new LocationMod("كفر كما","نهى شوجان","1700555606","1700555606","المجلس المحلي كفر كما الطابق الثاني","kfar.kama@rowad.org.il","pin.png"),
                new LocationMod("الريحانييه","نهى شوجان","01700555606","1700555606","البنايه متعددة الاهداف الريحانييه","kfar.kama@rowad.org.il","pin.png"),
                new LocationMod("المغار","حلا قزل","1700555606","1700555606","المركز الجماهيري المغار","hala.mghar@rowad.org.il","pin.png"),
                new LocationMod("كسرى سميع","ياسمين مداح","1700555606","1700555606","المجلس المحلي كسرى سميع","jasmin@rowad.org.il","pin.png"),
                new LocationMod("البقيعه" ,"ياسمين مداح","1700555606","1700555606","المركز الجماهيري -البقيعه","","pin.png"),
                new LocationMod("بيت جن","ميثال حرب","9802220 04","1700555606","المجلس المحلي بيت جن","mithal@rowad.org.il","pin.png"),
                new LocationMod("حرفيش","ميثال حرب","1700555606","1700555606","بناية المركز الجماهيري -حرفيش","","pin.png"),
                new LocationMod("ابوسنان","ساره كبيشي","1700555606","1700555606","المجلس المحلي ابو سنان","sarah@rowad.org.il","pin.png"),
                new LocationMod("جولس","ساره كبيشي","04-9561958","1700555606","بيت الشعب, الطابق الثاني - جوليس","","pin.png"),
                new LocationMod("ساجور","رونيا حمود","04-6660065","1700555606","المجلس المحلي-ساجور","ronya@rowad.org.il","pin.png"),
                new LocationMod("عسفيا","دله أبو ركن","1700555606","1700555606","المركز الجماهيري الشارع الرئيسي عسفيا","osifya@rowad.org.il","pin.png"),
                new LocationMod("عين الاسد","كارين مرينه","1700555606","1700555606","المجلس المحلي الرامه الطابق الاول","rama.rowad@rowad.org.il","pin.png"),
                new LocationMod( "الرامه","كارين مرينه","1700555606","1700555606","المجلس المحلي الرامه الطابق الاول","rama.rowad@rowad.org.il","pin.png"),
                new LocationMod( "مسعده وعين قنيا","مرح غيث","1700555606","1700555606","المجلس المحلي مسعده الطابق الثاني","marah@rowad.org.il","pin.png"),

                // فرقة هزار
                new LocationMod("مرّكزة عكا","رمزيه جمل","1700555606","1700555606","مركز الشباب – عكا","akko@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة حيفا","مروى طه","1700555606","1700555606","مركز الكارييرا والتشغيل- بورلا 17 حيفا","rowad.haifa@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة شفاعمرو","زينه تلحمي","1700555606","1700555606","مركز ريان شفاعمرو","rowad.shefaram@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة كوكب ابو الهيجاء","روان خشيبون","1700555606","1700555606","المركز الجماهيري كوكب ابو الهيجا","rowad.ibillin@rwad.org.il","pin.png"),
                new LocationMod("مركزة كفر مندا","روان خشيبون","1700555606","1700555606","المجلس المحلي","","pin.png"),
                new LocationMod("مركزة عيلوط","جيانا عرّام","1700555606","1700555606","","rowad.r.t@rowad.org.il","pin.png"),
                new LocationMod("مركزة الرينه","جيانا عرّام","1700555606","1700555606","المجلس المحلي الرينه","rowad.r.t@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة طرعان","جيانا عرّام","1700555606","1700555606","المكتبه البلديه طرعان","rowad.r.t@rowad.org.il","pin.png"),
                new LocationMod("مرّكز كابول"," ريم عياشي بقاعي", "07-47116877","1700555606","المجلس المحلي","kabul@rowad.org.il","pin.png"),
                new LocationMod("مرّكز شعب","امين بدران","1700555606","1700555606","المدرسه الثانويه الشامله عفو فاعور","rowad.k.sh@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة كفر ياسيف","לקראת גיוס","04-9569870","1700555606","المكتبه البلديه كفر ياسيف","rowad.ky@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة جديْده المكر","وداد مخول","1700555606","1700555606","المركز الجماهيري جديده المكر","rowad.j.m@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة اعبلين","روان خشيبون","1700555606","1700555606","المجلس المحلي","rowad.ibillin@rwad.org.il","pin.png"),
                new LocationMod("مرّكزة طمره","فداء عواد","1700555606","1700555606","مركز ريان – طمره","fedaa@rowad.org.il","pin.png"),
                new LocationMod("مرْكزة سخنين","عسل خلايله","1700555606","1700555606","مركز ريان – سخنين","asal@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة الناصرة","ريم حماتي","1700555606","1700555606","مركز ريان – الناصرة","rowad.naz@rowad.org.il","pin.png"),
                new LocationMod("مرّكزة الناصرة","جمانه صعب","1700555606","1700555606","مركز ريان الناصرة","gumana@rowad.org.il","pin.png"),
                new LocationMod("مركزة اكسال","اصاله دراوشه","1700555606","1700555606","مركز بايس اكسال","iksal@rowad.org.il","pin.png"),
                new LocationMod("يافة الناصره","ميريل حداد","1700555606","1700555606","","yafa.naz@rowad.org.il","pin.png")
            };
            userlist.Add(new locationGroup("مراكز الشمال", group1));

            //this.userlist = new ObservableCollection<locationGroup>();
            var group2 = new List<LocationMod>
            {
                // فرقة شهد almotalt
                new LocationMod( "مرّكزة ام الفحم","مها إغبارية","1700555606","1700555606","المركز الجماهيري ام الفحم","maha@rowad.org.il","pin.png"),
                new LocationMod( "مركّزة كفرقرع","رند عثامنه","1700555606","1700555606","مركز الشباب كفر قرع – بناية المركز الجماهيري الحوارنة","kfarqara@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة عاره-عرعره","سماح جابر","1700555606","1700555606","מרכז תעסוקה", "rowad.kq.ar@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة جسر الزرقاء","ناريمان قشوع","1700555606","1700555606","المجلس المحلي جسر الزرقاء","fredesjeser@rowad.org.il" ,"pin.png"),
                new LocationMod( "مرّكزة الفريديس","ناريمان قشوع","1700555606","1700555606","مركز الشباب الفريديس – بناية المركز الجماهيري","","pin.png"),
                new LocationMod( "مركزة طلعة عاره","دنيا اغباريه","1700555606","1700555606","","donia@rowad.org.il" ,"pin.png"),
                new LocationMod( "مرّكزة يافا-تل ابيب","לקראת גיוס","1700555606","1700555606","بيت الشباب يفت 83","","pin.png"),
                new LocationMod( "مركزة الطيبه","","1700555606","1700555606","مركز ريان الطيبه","","pin.png"),
                new LocationMod( "مرّكزة الطيره","سهراب أبو ربيع","1700555606","1700555606","مركز ريان طيرة","rowad.tira@rowad.org.il" ,"pin.png"),
                new LocationMod( "مرّكزة جت المثلث","الاء ابو مخ","1700555606","1700555606","بناية جمعية الجيل الذهبي الطابق الاول ","rowad.baQ.j@rowad.org.il" ,"pin.png"),
                new LocationMod( "مرّكزة باقه الغربيه","الاء ابو مخ","1700555606","1700555606","قسم المعارف: مركز الشباب باقة بلدية باقة الغربية","Rowad.baq.j@rowad.org.il","pin.png"),
                new LocationMod( "مركزه اللد والرمله","فداء شحاده","1700555606","1700555606","","lod.ramla@aluma.org.il","pin.png"),
                new LocationMod( "كفر قاسم","לקראת גיוס"	,"1700555606","1700555606","","","pin.png"),
                new LocationMod( "مركزة طوبا","ميرا هيب","1700555606"," 1700555606","قسم المعارف مجلس طوبا","mira@rowad.org.il","pin.png"),
                new LocationMod( "مركزة الكعبيه طباش","معالي مزاريب","1700555606","1700555606","","zarazir@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة الزرازير","معالي مزاريب","1700555606","1700555606","المركز الجماهيري الزرازير","zarazir@rowad.org.il","pin.png"),
                new LocationMod( "مركز بسمة طبعون","معالي مزاريب","1700555606","1700555606","","zarazir@rowad.org.il","pin.png"),	
                new LocationMod( "مركزة البطوف","نائله نجيدات","1700555606","1700555606","بطوفنا  - مركز شباب البطوف","rowad.batof@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة البعينه نجيدات","نائله نجيدات","1700555606","1700555606","المجلس المحلي بعينه نجيدات","rowad.batof@rowad.org.il","pin.png"),
                new LocationMod( "مرّكز بير المكسور","نائله نجيدات","1700555606","1700555606","مركز الريان بير المكسور","rowad.batof@rowad.org.il","pin.png"),
                new LocationMod( "مرّكز قرى ميسجاف","جمانه كحيلي","1700555606","1700555606","","Rowad.shibli@rowad.org.il","pin.png"),	
                new LocationMod( "مرّكزة شبلي ام الغنم","جمانه كحيلي","1700555606","1700555606","مركز ريان شبلي","rowad.shibli@rowad.org.il","pin.png"),

                // فرفة هاني
                new LocationMod( "مرّكز شرقي القدس","אסיל עיסא","1700555606","1700555606","","aseel@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","עבד אללה בשיתי","1700555606","1700555606","شعفاط / الشيخ جراح","abdalla@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","فنار كولجاسي","1700555606","1700555606","شعفاط/ الشيخ جراح","pinar@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","אלאא דוויק","1700555606","1700555606","شعفاط/ الشيخ جراح","jerusalem.alaa@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","סלאם מחיסן","1700555606","1700555606","شعفاط / الشيخ جراح","salam@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","داليا أبو سبيتان","1700555606","1700555606","شعفاط / الشيخ جراح","dalia@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة شرقي القدس","רואן אבו קטיש","1700555606","1700555606","","rawan@rowad.org.il","pin.png")

            };
            userlist.Add(new locationGroup("مراكز المثلث والمركز", group2));

            //this.userlist = new ObservableCollection<locationGroup>();
            var group3 = new List<LocationMod>
            {
                // فرقة محمد
                new LocationMod( "مركزة رهط","جوزفين الشيخ","1700555606","1700555606","مركز الشباب رهط","josephine@rowad.org.il","pin.png"),
                new LocationMod( "مركزة رهط","سوزان المطلقي","1700555606","1700555606","مركز الشباب رهط","rahat@rowad.org.il","pin.png"),
                new LocationMod( "مرْكزة حوره","اخلاص السيد","1700555606","1700555606","مركز الشباب حوره", "ikhlas@rowad.org.il","pin.png"),
                new LocationMod( "مركزة عرعرة الجنوب","مروة ابو عرار","1700555606","1700555606","مركز ريان عرعرة النقب", "eman@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة كسيفه","ياسمين الدرارجه","1700555606","1700555606","مركز ريان كسيفه", "kseefa@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة القسّوم","وصال أبو صيام","1700555606","1700555606","","wisal@rowad.org.il","pin.png"),
                new LocationMod( "مركزة شقيب السلام","ابتسام ابو سريحان", "1700555606","1700555606","مركز ريان شجيب السلام","shegev.shalom@rowad.org.il","pin.png"),
                new LocationMod( "مرّكزة تل السبع","فاطمة ابو صعيليك","1700555606","1700555606","مركز ريان تل السبع","telsheva@rowad.org.il","pin.png"),
                new LocationMod( "مركزة اللقية","حنين أبو بدر","1700555606","1700555606","مركز ريان اللقية","rowad.laqya@rowad.org.il","pin.png"),
                new LocationMod( "مركز واحة الصحراء","سامح الهواشلة","1700555606","1700555606","","Sameh@rowad.org.il","pin.png"),
            };
            userlist.Add(new locationGroup("مراكز الجنوب", group3));
        }
            
    }
}
