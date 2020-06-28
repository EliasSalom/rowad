using System;
using System.Collections.Generic;
using System.Text;

namespace rowad.Model
{
    class VideoClass
    {
        public string VideoName { get; set; }
        public string UrlName { get; set; }
        public string Image { get; set; }
        public List<VideoClass> GetVideoClasses()
        {
            List<VideoClass> videoClasses = new List<VideoClass>()
            {   
                new VideoClass(){ VideoName="مين احنا",UrlName="https://youtu.be/7CLP9g3yhoQ",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة مواد",UrlName="https://youtu.be/FsBiKd9JN7o",Image="Bird.png" },
                new VideoClass(){ VideoName="بسيخولوجيا",UrlName="https://youtu.be/Bhsi4N_tnKU",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة زراعية",UrlName="https://youtu.be/_8zxliW1YDc",Image="Bird.png" },
                new VideoClass(){ VideoName="طب بيطري",UrlName="https://youtu.be/ubDAKzKAAF0",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة جينات",UrlName="https://youtu.be/BqIvzILC3MI",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة طيارات",UrlName="https://youtu.be/dWyLg7YATLA",Image="Bird.png" },
                new VideoClass(){ VideoName="معالج نطق وسمع",UrlName="https://youtu.be/fowF8vKpcok",Image="Bird.png" },
                new VideoClass(){ VideoName="تصميم صناعي",UrlName="https://youtu.be/YcHtH159Vvc",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة ماكنات",UrlName="https://youtu.be/kbC_3YbayWA",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة غذاء وبيوتكنولوجيا",UrlName="https://youtu.be/g4NqKwd1vAM",Image="Bird.png" },
                new VideoClass(){ VideoName="علم الدماغ",UrlName="https://youtu.be/NI-b6OK-9Uc",Image="Bird.png" },
                new VideoClass(){ VideoName="علم الحاسوب",UrlName="https://youtu.be/ljgYHdycRE0",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة برمجة",UrlName="https://youtu.be/eFMW7wXEuik",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة صناعة وإدارة",UrlName="https://youtu.be/_N1nPcsHbzI",Image="Bird.png" },
                new VideoClass(){ VideoName="هندسة كهرباء",UrlName="https://youtu.be/q0j-0AwrJ28",Image="Bird.png" },
                new VideoClass(){ VideoName="علم الطب",UrlName="https://youtu.be/6dWU54ZMBLE",Image="Bird.png" },
                new VideoClass(){ VideoName="علم التغذية",UrlName="https://youtu.be/0IE5EGqYEu0",Image="Bird.png" },
                new VideoClass(){ VideoName="موسيقى",UrlName="https://youtu.be/OqbFomtm5Yg",Image="Bird.png" },
                new VideoClass(){ VideoName="العلاج الوظيفي",UrlName="https://youtu.be/iQPmCPeRMvI",Image="Bird.png" }
            };
            return videoClasses;
        }
    }
}
