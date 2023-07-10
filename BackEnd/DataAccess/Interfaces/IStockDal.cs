﻿using Core.DB.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IStockDal : IRepositoryService<Stock>
    {
        List<Stock> Paging(int skip, int take);
    }
}
