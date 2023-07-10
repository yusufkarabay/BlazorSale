using Core.DB.Helper;
using Core.DB.Manager;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL.NH
{
    public class NHCustomerDal : RepositoryManager<Customer>, ICustomerDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHCustomerDal(NhibernateHelper nHibernateHelper, NhibernateHelper nhibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper=nhibernateHelper;
        }

        public List<Customer> Paging(int skip, int take)
        {
          using(var session = _nhibernateHelper.OpenSession())
            {
              return session.Query<Customer>().Skip(skip).Take(take).ToList();
          }
        }
    }
}
