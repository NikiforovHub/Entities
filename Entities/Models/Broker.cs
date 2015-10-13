using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Models
{
    public class Broker
    {
        public int BrokerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}