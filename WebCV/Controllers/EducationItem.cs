using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCV.Models
{
    public class EducationItem
    {
        public string Institution { get; set; }

        public int StartYear { get; set; }

        public int EndYear { get; set; }

        public string Location { get; set; }

        public string Degree { get; set; }
    }
}
