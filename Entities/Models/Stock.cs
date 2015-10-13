using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public string StockDescription { get; set; }
        public int CompanyID { get; set; }
        public int BrokerID { get; set; }
        public double Price { get; set; }

        public virtual Broker Broker { get; set; }
        public virtual Company Company { get; set; }
    }
}