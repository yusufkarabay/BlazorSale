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
        List<Authority> GetAll();
        Authority GetById(int id);
        Authority Add(Authority authority);
        Authority Update(Authority authority);
        void Delete(Authority authority);


    }
}
