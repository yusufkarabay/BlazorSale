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
    public class NHCategoryDal : RepositoryManager<Category>, ICategoryDal
    {
        private readonly NhibernateHelper _nHibernateHelper;
        public NHCategoryDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<Category> Paging(int skip, int take)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<Category>().OrderBy(x=>x.Name).Skip(skip).Take(take).ToList();
            }
        }
    }
}
