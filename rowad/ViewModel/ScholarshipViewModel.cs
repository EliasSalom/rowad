using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class ScholarshipViewModel
    {
        public List<ScholarshipMod> ScholarshipMods { get; set; }
        public ScholarshipViewModel()
        {
            ScholarshipMods = new ScholarshipMod().GetScholarshipMods();
        }
    }
}
