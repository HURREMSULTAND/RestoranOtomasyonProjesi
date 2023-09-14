using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyonProjesi.Entities
{
    public class CustomerOrder
    {
        public int Id { get; set; } 
        public int WaiterId { get; set; }
        public int TableId { get; set; }
        public int  TotalOrderPay { get; set; }
       public  string PaymentMethod { get; set; }
      
    }
}
