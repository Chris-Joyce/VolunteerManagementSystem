using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VolunteerManagementSystem.Models
{
    public class Opportunity
    {
        public static List<Opportunity> opp;
        public string Center { get; set; }
        public string Date { get; set; }

        public static string AddOpp(string cent, string dat)
        {
            opp = new List<Opportunity>
            {
                new Opportunity()
            { Center = cent, Date = dat }
            };
           
            return "";
        }
    }
}
