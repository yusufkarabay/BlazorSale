using Core.DB.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IUserAuthorityDal:IRepositoryService<UserAuthority>
    {
        List<Employee> GetEmployeeByAuthority(int authorityId,int skip,int take);
    }
}
