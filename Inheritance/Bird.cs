using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird:Animal
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }

        public string Size { get; set; }
    }
}
