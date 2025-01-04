using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Donation : BaseEntity
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public int PaymentTypeId { get; set; }
        public long Amount { get; set; }
    }

}
