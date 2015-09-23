using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    class Boat
    {
        private double length;

        public Boat(double Length)
        {
            length = Length;
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

    }
}
