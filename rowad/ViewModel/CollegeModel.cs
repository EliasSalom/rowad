using System;
using System.Collections.Generic;
using System.Text;
using rowad.Model;

namespace rowad.ViewModel
{
    class CollegeModel
    {
        public List<CollegeMod> CollegeMods { get; set; }
        public CollegeModel()
        {
            CollegeMods = new CollegeMod().GetCollegeMods();
        }
    }
}
