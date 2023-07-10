using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Authority:IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
