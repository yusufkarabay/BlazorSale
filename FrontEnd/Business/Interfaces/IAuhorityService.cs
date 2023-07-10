using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IAuhorityService
    {
        Task<List<Authority>> GetAll();
        Task<Authority> GetById(int id);
        Task<Authority> Add(Authority authority);
        Task<Authority> Update(Authority authority);
        void Delete(Authority authority);


    }
}
