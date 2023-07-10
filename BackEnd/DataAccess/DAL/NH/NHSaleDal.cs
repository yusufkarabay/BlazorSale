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
    public class NHSaleDal : RepositoryManager<Sale>, ISaleDal
    {
        private readonly NhibernateHelper _nHibernateHelper;
        public NHSaleDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Sale> Paging(int skip, int take)
        {
           using(var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<Sale>().Skip(skip).Take(take).ToList();
            }
        }
    }
}
