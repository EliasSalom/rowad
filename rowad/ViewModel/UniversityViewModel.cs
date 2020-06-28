using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class UniversityViewModel
    {
        public List<UniversityMod> UniversityMods { get; set; }
        public UniversityViewModel()
        {
            UniversityMods = new UniversityMod().GetUniversityMods();
        }
    }
}
