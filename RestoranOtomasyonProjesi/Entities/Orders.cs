using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyonProjesi.Entities
{
    public  class Orders

    {
        public int Id { get; set; }
        public int WaiterId { get; set; }
        public int TableId { get; set; }
        public int TotalOrderPay { get; set; }

        public string PaymentMethod { get; set; }
        public int MasaId { get; set; } 
        public string Onay { get; set; }
        

    }
}
