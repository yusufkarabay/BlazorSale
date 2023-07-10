using Entities.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table("Products");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name").Not.Nullable();
            Map(x => x.Price).Column("Price");
            References(x => x.CategoryId).Column("CategoryId").Not.LazyLoad();
            Map(x=>x.Date).Column("Date").Not.Nullable();
        }
    }
}
