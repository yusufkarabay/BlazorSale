using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class UserAuthorityManager : IUserAuthorityService
    {
        public Task<UserAuthority> Add(UserAuthority userAuthority)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserAuthority userAuthority)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserAuthority>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetByAuthorityId(int authorityId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<UserAuthority> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserAuthority> Update(UserAuthority userAuthority)
        {
            throw new NotImplementedException();
        }
    }
}
