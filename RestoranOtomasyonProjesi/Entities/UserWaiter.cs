using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranOtomasyonProjesi.Entities
{
    public class UserWaiter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Gender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
       
       
    }
}
