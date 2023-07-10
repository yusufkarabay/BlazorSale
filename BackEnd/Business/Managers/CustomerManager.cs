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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal=customerDal;
        }

        public Customer Add(Customer customer)
        {
            return _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetList();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(x => x.Id==id);
        }

        public List<Customer> Paging(int skip, int take)
        {
            return _customerDal.Paging(skip, take);
        }

        public Customer Update(Customer customer)
        {
            return _customerDal.Update(customer);
        }
    }
}
