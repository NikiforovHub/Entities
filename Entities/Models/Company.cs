using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public double Money { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}