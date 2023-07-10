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
    public class NHCityDal : RepositoryManager<City>, ICityDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHCityDal(NhibernateHelper nHibernateHelper, NhibernateHelper nhibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper=nhibernateHelper;
        }

        public List<City> GetByParentId(int parentId, int skip, int take)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                var result = session.Query<City>().Where(x => x.ParentId == parentId).OrderBy(x => x.Name).Skip(skip).Take(take).ToList();
                return result;
            }
        }

        public void DeleteRange(List<City> cities)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                foreach (var item in cities)
                {
                    session.Delete(item);
                }
                session.Flush();
                session.Clear();
            }
        }
    }
}
