using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_mvc.Models
{

    public class WorldCupData
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string TeamLogo { get; set; }
        public int NoWC { get; set; }
    }
}