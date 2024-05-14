using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile:Animal
    {
        public string Type { get; set;}
        public string Color { get; set;}

        public bool IsPoisonus { get; set;}

        public string Length { get; set;}
    }
}
