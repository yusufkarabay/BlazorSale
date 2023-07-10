using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISaleService
    {
        Task<List<Sale>> GetAll();
        Task<Sale> GetById(int id);
        Task<Sale> Add(Sale sale);
        Task<Sale> Update(Sale sale);
        void Delete(Sale sale);
        Task<List<Sale>> Paging(int skip, int take);
    }
}
