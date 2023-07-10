using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal=stockDal;
        }

        public Stock Add(Stock stock)
        {
            return _stockDal.Add(stock);
        }

        public void Delete(Stock stock)
        {
           _stockDal.Delete(stock);
        }

        public List<Stock> GetAll()
        {
          return  _stockDal.GetList();
        }

        public Stock GetById(int id)
        {
           return _stockDal.Get(x => x.Id == id);
        }

        public List<Stock> Paging(int skip, int take)
        {
            return _stockDal.Paging(skip, take);
        }

        public Stock Update(Stock stock)
        {
          return  _stockDal.Update(stock);
        }
    }
}
