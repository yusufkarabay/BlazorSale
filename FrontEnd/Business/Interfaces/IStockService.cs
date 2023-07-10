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
        Task<List<Stock>> Paging(int skip, int take);
        Task<List<Stock>> GetAll();
        Task<Stock> GetById(int id);
        Task<Stock> Add(Stock stock);
        Task<Stock> Update(Stock stock);
        void Delete(Stock stock);
    }
}
