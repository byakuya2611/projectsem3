﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ3.Data
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
    }
}
