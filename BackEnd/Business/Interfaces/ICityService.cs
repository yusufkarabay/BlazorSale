using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetById(int id);
        City Add(City city);
        City Update(City city);
        void Delete(City city);
        List<City> Paging(int skip, int take);
        void DeleteRange(List<City> cities);
        List<City> GetCityByParentId(int parentId,int skip, int take);
    }
}
