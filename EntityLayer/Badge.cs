﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Badge : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long Amount { get; set; }
    }
}
