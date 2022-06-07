using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DataOperation
    {
        public List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)> MergeData(List<Customer> customers, List<Purchase> purchases)
        {
            var values = (from c in customers from p in purchases where c.Id == p.CustomerId select new { customerName = c.Name, purchaseAmount = p.Amount, purchaseDate = p.PurchasedOn });
            return (List<(string cutomerName, double purchaseAmount, DateTime purchaseDate)>)values;
        }
    }
}