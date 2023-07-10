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
    public class NHEmployeeDal : RepositoryManager<Employee>, IEmployeeDal
    {
        private readonly NhibernateHelper _nhibernateHelper;
        public NHEmployeeDal(NhibernateHelper nHibernateHelper, NhibernateHelper nhibernateHelper) : base(nHibernateHelper)
        {
            _nhibernateHelper=nhibernateHelper;
        }
    }
}
