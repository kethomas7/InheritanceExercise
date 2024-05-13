﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird:Animal
    {
        public string type { get; set; }
        public string color { get; set; }
        public bool canFly { get; set; }

        public string size { get; set; }
    }
}
