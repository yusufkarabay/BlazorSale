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
        List<Sale> GetAll();
        Sale GetById(int id);
        Sale Add(Sale sale);
        Sale Update(Sale sale);
        void Delete(Sale sale);
        List<Sale> Paging(int skip, int take);
    }
}
