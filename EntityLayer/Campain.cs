using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Campain : BaseEntity   
    {
        public int BadgeId { get; set; }
        public int CompanyId { get; set; }
        public DateTime EndDate { get; set; }


        public ICollection<Badge> Badges { get; set; }
    }
}
