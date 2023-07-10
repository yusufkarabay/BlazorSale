using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entities.Entities
{
    public class Customer : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string NameSurname { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Adress { get; set; }
        public virtual City CityId { get; set; }

    }
}
