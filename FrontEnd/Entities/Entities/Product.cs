
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Category CategoryId { get; set;}
        public virtual decimal Price { get; set; }
        //public virtual int Stock { get; set; }
        //public virtual string Description { get; set; }
        //public virtual string Image { get; set; }
        public virtual DateTime Date { get; set;}
    }
}
