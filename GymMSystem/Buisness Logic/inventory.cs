using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMSystem.Buisness_Logic
{
    class inventory
    {
        public string name { get; set; }
        public int invID { get; set; }
        public string  make { get; set; }
        public string model { get; set; }
        public double price { get; set; }
        public byte[] photo { get; set; }

    }
}
