﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
    }
}
