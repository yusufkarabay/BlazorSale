
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserAuthority 
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Employee EmployeeId { get; set; }
        public virtual Authority AuthorityId { get; set; }
        public virtual string Password { get; set; }

    }
}
