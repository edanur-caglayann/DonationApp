using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User : BaseEntity
    {
        public int CompanyId { get; set; }
        public int BadgeId { get; set; }
        public string UserName { get; set; }
        public string UserSurename { get; set; }

        public ICollection<Company> Companies { get; set; }
        public ICollection<Badge> Badges { get; set; }

    }
}
