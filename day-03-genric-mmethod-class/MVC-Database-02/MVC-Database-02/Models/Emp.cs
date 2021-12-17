using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Database_02.Models
{
    public class Emp
    {
        public int EID { get; set; }
        public string EName { get; set; }
        public double ESalary { get; set; }
        public string EDsign { get; set; }
        public DateTime Doj { get; set; }

    }
}