using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class SaleMap:ClassMap<Sale>
    {
        public SaleMap()
        {
            Table("Sales");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Date);
            Map(x => x.Quantity);
            References(x => x.CustomerId).Columns("CustomerId").Not.LazyLoad();
            References(x => x.ProductId).Columns("ProductId").Not.LazyLoad();
            References(x => x.EmployeeId).Columns("EmployeeId").Not.LazyLoad();

        }
    }
}
