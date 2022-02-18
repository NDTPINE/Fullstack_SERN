using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases;

namespace Plugin.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext db;

        public TransactionRepository(MarketContext db)
        {
            this.db = db;
        }
        public IEnumerable<Transaction> Get(string cashierName)
        {
            return db.Transactions.Where(x =>
                    x.CashierName.ToLower() == cashierName.ToLower()).ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return db.Transactions.Where(x =>
                    x.CashierName.ToLower() == cashierName.ToLower() && x.TimeStamp.Date == date.Date);
        }

        public void Save(int productId, string productName, double? price, int Soldquantity, string cashierName, int beforeQuantity)
        {
            var transaction = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price.Value,
                BeforeQuantity = beforeQuantity,
                SoldQuantity = Soldquantity,
                CashierName = cashierName
            };
            db.Transactions.Add(transaction);
            db.SaveChanges();
        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDay, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp.Date >= startDay.Date && x.TimeStamp.Date <= endDate.Date.AddDays(1).Date);
            else
                return db.Transactions.Where(x =>
                    x.CashierName.ToLower() == cashierName.ToLower() &&
                    x.TimeStamp.Date >= startDay.Date && x.TimeStamp.Date <= endDate.Date.AddDays(1).Date);
        }
    }
}
