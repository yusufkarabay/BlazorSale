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
        Task<List<Employee>> GetByAuthorityId(int authorityId, int skip, int take);
        Task<List<UserAuthority>> GetAll();
        Task<UserAuthority> GetById(int id);
        Task<UserAuthority> Add(UserAuthority userAuthority);
        Task<UserAuthority> Update(UserAuthority userAuthority);
        void Delete(UserAuthority userAuthority);

    }
}
