using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyonProjesi.Entities
{
    public class WaiterOrder
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string CookTime { get; set; }
        public string Price { get; set; }
        public int MasaId { get; set; }   
        public string Onay { get; set; }
       



    }
}
