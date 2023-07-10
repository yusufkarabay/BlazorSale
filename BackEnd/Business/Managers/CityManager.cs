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
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal=cityDal;
        }

        public City Add(City city)
        {
          return  _cityDal.Add(city);
        }

        public void Delete(City city)
        {
           _cityDal.Delete(city);
        }

        public void DeleteRange(List<City> cities)
        {
            _cityDal.DeleteRange(cities);
        }

        public List<City> GetAll()
        {
           return _cityDal.GetList();
        }

        public City GetById(int id)
        {
            return _cityDal.Get(x => x.Id == id);
        }

        public List<City> GetCityByParentId(int parentId, int skip, int take)
        {
            return _cityDal.GetByParentId(parentId, skip, take);
        }

        public List<City> Paging(int skip, int take)
        {
           return _cityDal.GetList(x => x.Id > 0).Skip(skip).Take(take).ToList();
        }

        public City Update(City city)
        {
           return _cityDal.Update(city);
        }
    }
}
