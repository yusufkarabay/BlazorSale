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
    public class NHStockDal : RepositoryManager<Stock>, IStockDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHStockDal(NhibernateHelper nHibernateHelper, NhibernateHelper nhibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper=nhibernateHelper;
        }

        public List<Stock> Paging(int skip, int take)
        {
         using (var session = _nhibernateHelper.OpenSession())
            {
                return session.Query<Stock>().Skip(skip).Take(take).ToList();
            }
        }
    }
}
