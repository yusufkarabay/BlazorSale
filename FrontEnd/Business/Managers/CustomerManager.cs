using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class CustomerManager : ICustomerService
    {
        public Task<Customer> Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
