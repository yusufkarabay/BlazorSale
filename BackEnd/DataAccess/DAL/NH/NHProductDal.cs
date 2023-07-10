using Core.DB.Helper;
using Core.DB.Interfaces;
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
    public class NHProductDal : RepositoryManager<Product>, IProductDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHProductDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper = nHibernateHelper;
        }

        public List<Product> GetProductsByCategory(int categoryId, int skip, int take)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                return session.Query<Product>().Where(x => x.CategoryId.Id == categoryId).OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
            }
        }
    }
}
