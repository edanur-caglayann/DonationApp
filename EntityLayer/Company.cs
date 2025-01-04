using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Campain> Campains { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
