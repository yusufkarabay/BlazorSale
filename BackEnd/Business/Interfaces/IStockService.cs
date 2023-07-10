using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IStockService
    {
        List<Stock> Paging(int skip, int take);
        List<Stock> GetAll();
        Stock GetById(int id);
        Stock Add(Stock stock);
        Stock Update(Stock stock);
        void Delete(Stock stock);
    }
}
