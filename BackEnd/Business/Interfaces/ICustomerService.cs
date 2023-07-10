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
        List<Customer> GetAll();
        List <Customer> Paging(int skip, int take);
        Customer GetById(int id);
        Customer Add(Customer customer);
        Customer Update(Customer customer);
        void Delete(Customer customer);

    }
}
