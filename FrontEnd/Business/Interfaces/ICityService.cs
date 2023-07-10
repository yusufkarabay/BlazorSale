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
        Task<List<City>> GetAll();
        Task<City> GetById(int id);
        Task<City> Add(City city);
        Task<City> Update(City city);
        void Delete(City city);
        Task<List<City>> Paging(int skip, int take);
        void DeleteRange(List<City> cities);
        Task<List<City>> GetCityByParentId(int parentId, int skip, int take);
    }
}
