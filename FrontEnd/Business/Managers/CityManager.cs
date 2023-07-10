using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class CityManager : ICityService
    {
        public Task<City> Add(City city)
        {
            throw new NotImplementedException();
        }

        public void Delete(City city)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<City> cities)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<City> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetCityByParentId(int parentId, int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> Paging(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<City> Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
