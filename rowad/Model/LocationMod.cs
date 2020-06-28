using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;
using rowad.View;
using rowad.ViewModel;

namespace rowad.Model
{
    public class LocationMod
    {
        public string LocationName { get; set; }
        public string Mange { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
        public string Image { get; set; }
        public LocationMod(string LocationName, string Mange, string Phone, string Mobile, string Address, string Mail, string Image)
        {
            this.LocationName = LocationName;
            this.Mange = Mange;
            this.Phone = Phone;
            this.Mobile = Mobile;
            this.Address = Address;
            this.Mail = Mail;
            this.Image = Image;
        }
        /*public List<LocationMod> GetLocationMods()
         {
             List<LocationMod> LocationMods = new List<LocationMod>()
             {
                 //north loction manager: salman swed
                 new LocationMod(){ LocationName="مرّكز- يركا",Mange="نيفين حبيش",Phone="04-9568111",Mobile="1700555606",Address="المجلس المحلي يركا, الطابق الثالث صندوق بريد 1, 24967",Mail="neven@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكز- يانوح جت",Mange="نعامه فرج",Phone="04-9979072",Mobile="1700555606",Address="المجلس المحلي يانوح-جت الطابق الاول",Mail="office@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة- دالية الكرمل",Mange="ميسا حلبي",Phone="",Mobile="1700555606",Address="وادي الفش- تحت قسم الجبايه,30056,دالية الكرمل",Mail="office@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة كفر كما",Mange="نهى شوجان",Phone="04-6760775",Mobile="1700555606",Address="المجلس المحلي كفر كمى الطابق الثاني",Mail="kfar.kama@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة- الريحانييه",Mange="نهى شوجان",Phone="04-6987506",Mobile="1700555606",Address="البنايه متعددة الاهداف-الريحانيه",Mail="kfar.kama@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة المغار",Mange="حلا قيزل",Phone="04-6781698",Mobile="1700555606",Address="المركز الجماهيري ص.ب 2432 , المغار",Mail="hala.mghar@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة كسرى سميع",Mange="ياسمين مداح",Phone="046708729",Mobile="1700555606",Address="لمجلس المحلي كسرى سميع ص.ب 399",Mail="jasmin@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة البقيعه",Mange="ياسمين مداح",Phone="04-9572912",Mobile="1700555606",Address="مركز الشباب-البقيعه",Mail="jasmin@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة بيت جن",Mange="ميثال حرب",Phone="04-9802220",Mobile="1700555606",Address="المجلس المحلي بيت جن",Mail="mithal@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة حرفيش",Mange="ميثال حرب",Phone="04-9571205",Mobile="1700555606",Address="بناية المجلس المحلي القديمه",Mail="mithal@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة ابوسنان",Mange="ساره كبيشي",Phone="04-9568848",Mobile="1700555606",Address="المجلس المحلي ابو سنان",Mail="sarah@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة جولس",Mange="ساره كبيشي",Phone="04-9561958",Mobile="1700555606",Address="بيت الشعب, الطابق الاول-جوليس",Mail="sarah@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مركزة الساجور",Mange="رونيا حمود",Phone="04-6660065",Mobile="1700555606",Address="المجلس المحلي-ساجور",Mail="ronya@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة عسفيا",Mange="قريباً",Phone="04-6708729",Mobile="1700555606",Address="المركز الجماهيري الشارع الرئيسي",Mail="kamal57@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة عين الاسد",Mange="كارين مرينه",Phone="04-9580670",Mobile="1700555606",Address="المجلس المحلي الرامه الطابق الاول",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="مرّكزة الرامه",Mange="كارين مرينه",Phone="04-9580670",Mobile="1700555606",Address="المجلس المحلي الرامه الطابق الاول",Mail="rama.rowad@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مركزه مجدل شمس والغجر",Mange="قريباً",Phone="قريباً",Mobile="1700555606",Address="قريباً",Mail="office@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="مركزه مسعده وبقعاتا وعين قنيا",Mange="مرح غيث",Phone="04-6981480",Mobile="1700555606",Address="المجلس المحلي مسعدة الطابق الثاني",Mail="marah@rowad.org.il",Image="pin.png"},
                 //manager: hazar obed
                 new LocationMod(){ LocationName="مرّكزة عكا",Mange="رمزيه جمل",Phone="",Mobile="",Address="مركز الشباب-عكا",Mail="akko@rowad.org.il",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"},
                 new LocationMod(){ LocationName="",Mange="",Phone="",Mobile="",Address="",Mail="",Image="pin.png"}
             };
             return LocationMods;
         }*/
    }
    public class locationGroup : List<LocationMod>
    {
        public string GroupName { get; private set; }
        public locationGroup(string groupName, List<LocationMod> locationMods) : base(locationMods)
        {
            this.GroupName = groupName;
        }
    }

}
