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
    public class NHAuhorityDal : RepositoryManager<Authority>, IAuhorityDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHAuhorityDal(NhibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper = nHibernateHelper;
        }
    }
}
