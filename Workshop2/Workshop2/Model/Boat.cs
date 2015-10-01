using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2.Model
{
    [Serializable]
    class Boat
    {
        public enum type
        {
            Sailboat,
            Motorsailer,
            Kayak,
            Canoe,
            Other
        }
        private type BoatType;
        public Boat(int i)
        {
            BoatType = (type)i;
            Console.WriteLine(BoatType);
        }

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
