using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyMiniProjectEF
{
    internal class Assets
    {
        public Assets()
        {

        }
        public int Id { get; set; }
        public string AssetType { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }

    }
}
