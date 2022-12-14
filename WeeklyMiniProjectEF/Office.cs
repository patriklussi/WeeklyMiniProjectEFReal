using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMiniProjectEF
{
    internal class Office
    {
        public int Id { get; set; } 
        public string OfficeName { get; set; }  
        public string CurrencyType { get; set; }
        public List<Assets> Assets { get; set; }
    }
}
