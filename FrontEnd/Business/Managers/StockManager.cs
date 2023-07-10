using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class StockManager : IStockService
    {
        public Task<Stock> Add(Stock stock)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stock stock)
        {
            throw new NotImplementedException();
        }

        public Task<List<Stock>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Stock> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Stock>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Stock> Update(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
