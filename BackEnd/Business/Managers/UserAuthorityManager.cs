using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class UserAuthorityManager : IUserAuthorityService
    {
        private readonly IUserAuthorityDal _userAuthorityDal;

        public UserAuthorityManager(IUserAuthorityDal userAuthorityDal)
        {
            _userAuthorityDal=userAuthorityDal;
        }

        public UserAuthority Add(UserAuthority userAuthority)
        {
            return _userAuthorityDal.Add(userAuthority);
        }

        public void Delete(UserAuthority userAuthority)
        {
            _userAuthorityDal.Delete(userAuthority);
        }

        public List<UserAuthority> GetAll()
        {
           return _userAuthorityDal.GetList();
        }

        public List<Employee> GetByAuthorityId(int authorityId, int skip, int take)
        {
           return _userAuthorityDal.GetEmployeeByAuthority(authorityId, skip, take);
        }

        public UserAuthority GetById(int id)
        {
            return _userAuthorityDal.Get(x=>x.Id==id);
        }

        public UserAuthority Update(UserAuthority userAuthority)
        {
            return _userAuthorityDal.Update(userAuthority);
        }
    }
}
