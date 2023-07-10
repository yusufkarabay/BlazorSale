using Entities.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("Employees");
            Id(x => x.Id).Column("Id").GeneratedBy.Increment();
            Map(x => x.NameSurname).Column("NameSurname").Not.Nullable();
            Map(x => x.Phone).Column("Phone");
            Map(x => x.Adress).Column("Address");
            Map(x => x.Email).Column("Email");        
        }
    }
}
