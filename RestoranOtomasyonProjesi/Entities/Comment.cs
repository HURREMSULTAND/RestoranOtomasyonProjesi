using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyonProjesi.Entities
{
    public  class Comment
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Surname { get; set; }
        public int OrderId { get; set; } 
         
        public int Rating { get; set; }
        public string Description { get; set; }



    }
}
