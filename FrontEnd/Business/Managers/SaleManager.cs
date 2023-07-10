using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class SaleManager : ISaleService
    {
        public Task<Sale> Add(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sale>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Sale> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Sale>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Sale> Update(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
