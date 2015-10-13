using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Entities.Models;

namespace Entities.DAL
{
    public class ExchangeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ExchangeContext>
    {
        protected override void Seed(ExchangeContext context)
        {
            var brokers = new List<Broker>
            {
            new Broker{BrokerID=1,  LastName="Carson", FirstName="Alexander", Login="AlexanderCarson", Password="123456", Money=0,  RegistrationDate=DateTime.Parse("2005-09-01")},
            new Broker{BrokerID=2, LastName="Nikiforov", FirstName="Sergey", Login="NikiforovSergey", Password="123456", Money=0,  RegistrationDate=DateTime.Parse("2005-09-05")},
            };

            brokers.ForEach(s => context.Brokers.Add(s));
            context.SaveChanges();

            var companies = new List<Company>
            {
            new Company{CompanyID=1, CompanyName="First Company", CompanyDescription="Description of first company", Login="FirstCompany", Money = 0, Password="123456", RegistrationDate=DateTime.Parse("2005-09-10")},
            new Company{CompanyID=1, CompanyName="Second Company", CompanyDescription="Description of second company", Login="SecondCompany", Money = 0, Password="123456", RegistrationDate=DateTime.Parse("2005-09-15")},
            };
            companies.ForEach(s => context.Companies.Add(s));
            context.SaveChanges();

            var stocks = new List<Stock>
            {
            new Stock{StockID=1050, StockName="First stock", CompanyID=1, BrokerID=1, Price = 100, StockDescription="Description of first stock", },
            new Stock{StockID=2050, StockName="Second stock", CompanyID=2, BrokerID=1, Price = 200, StockDescription="Description of second stock", },
            };
            stocks.ForEach(s => context.Stocks.Add(s));
            context.SaveChanges();
            
        }
    }
}