using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class AuthorityMap:ClassMap<Authority>
    {
        public AuthorityMap()
        {
                Table("Authorities");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name").Not.Nullable();
        }
    }
}
