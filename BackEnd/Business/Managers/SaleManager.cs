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
    public class SaleManager : ISaleService
    {
        private readonly ISaleDal _saleDal;

        public SaleManager(ISaleDal saleDal)
        {
            _saleDal=saleDal;
        }

        public Sale Add(Sale sale)
        {
            return _saleDal.Add(sale);
        }

        public void Delete(Sale sale)
        {
           _saleDal.Delete(sale);
        }

        public List<Sale> GetAll()
        {
         return  _saleDal.GetList();
        }

        public Sale GetById(int id)
        {
           return _saleDal.Get(x => x.Id == id);
        }

        public List<Sale> Paging(int skip, int take)
        {
          return  _saleDal.GetList(x => x.Id > 0).Skip(skip).Take(take).ToList();
        }

        public Sale Update(Sale sale)
        {
            return _saleDal.Update(sale);
        }
    }
}
