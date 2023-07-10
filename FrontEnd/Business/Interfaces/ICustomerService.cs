using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
        Task<List<Customer>> Paging(int skip, int take);
        Task<Customer> GetById(int id);
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
        void Delete(Customer customer);

    }
}
