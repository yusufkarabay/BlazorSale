using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Employee:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string NameSurname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Adress { get; set; }

    }
}
