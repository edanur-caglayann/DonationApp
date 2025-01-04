using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class CompanyAccount : BaseEntity
    {
        public int CompanyId { get; set; }
        public long TotalDonationAmount { get; set; }

        public ICollection<Company> Companies { get; set; }
    }
}
