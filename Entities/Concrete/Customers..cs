using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customers : Entity<int> // Müşteriler
    {
        public int UserId { get; set; } // Kullanıcı Id Tüm müşterilerin user ıd si olmalı 

        public Customers()
        {

        }

        public int UsersId { get; set; }
        public User? Users { get; set; } = null;
        public IndividualCustomer? IndividualCustomers { get; set; } = null;
        public CorporateCustomer? CorporateCustomers { get; set; } = null;
    }

}
