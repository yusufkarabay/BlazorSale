using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class StockMap:ClassMap<Stock>
    {
        public StockMap()
        {
             Table("Stocks");
             Id(x=>x.Id).Column("Id").GeneratedBy.Increment();
            Map(x=>x.Name).Column("Name");
            Map(x=>x.Quantity).Column("Quantity");         
            Map(x=>x.Date).Column("Date");
            References(x=>x.CategoryId).Column("CategoryId").Not.LazyLoad();
            References(x=>x.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(x=>x.ProductId).Column("ProductId").Not.LazyLoad();
          
        

        }
    }
}
