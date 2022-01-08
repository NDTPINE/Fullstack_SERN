using CoreBusiness;
using System;
using System.Collections.Generic;


namespace UseCases
{
    public interface ITransactionRepository
    {
        public IEnumerable<Transaction> Get(string cashierName);
        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date);
        void Save(int productId,string productName, double? price, int Soldquantity, string cashierName, int beforeQuantity);
    }
}