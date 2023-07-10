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
    public class NHUserAuthorityDal : RepositoryManager<UserAuthority>, IUserAuthorityDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHUserAuthorityDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper=nHibernateHelper;
        }

        public List<Employee> GetEmployeeByAuthority(int authorityId, int skip, int take)
        {

            using (var session = _nhibernateHelper.OpenSession())
            {
                var result = session.Query<UserAuthority>()
                    .Where(x => x.AuthorityId.Id == authorityId)
                    .Select(x => x.EmployeeId).Skip(skip).Take(take).ToList();
                return result;
            }
        }
    }
}
