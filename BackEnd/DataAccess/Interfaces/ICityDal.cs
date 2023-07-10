using Core.DB.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICityDal:IRepositoryService<City>
    {
        List<City> GetByParentId(int parentId, int skip,int take);
        void DeleteRange(List<City> cities);
    }
}
