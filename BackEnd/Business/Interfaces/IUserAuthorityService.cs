using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserAuthorityService
    {
        List<Employee> GetByAuthorityId(int authorityId, int skip, int take);
        List<UserAuthority> GetAll();
        UserAuthority GetById(int id);
        UserAuthority Add(UserAuthority userAuthority);
        UserAuthority Update(UserAuthority userAuthority);
        void Delete(UserAuthority userAuthority);

    }
}
