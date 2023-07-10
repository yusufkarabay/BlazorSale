using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class UserAuthorityMap : ClassMap<UserAuthority>
    {
        public UserAuthorityMap()
        {
            Table("UserAuthorities");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.Name).Column("Name").Not.Nullable();
            Map(x=>x.Password).Column("Password").Not.Nullable();
            References(x => x.EmployeeId).Column("EmployeeId").Not.LazyLoad();
            References(x => x.AuthorityId).Column("AuthorityId").Not.LazyLoad();
        }
    }
}
