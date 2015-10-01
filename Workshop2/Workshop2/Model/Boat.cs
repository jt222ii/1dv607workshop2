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
        private type _boatType;
        private double _length;
        public Boat(int i, double length)
        {
            BoatType = (type)i;
            Length = length;
        }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public type BoatType
        {
            get
            {
                return _boatType;
            }
            set
            {
                if (type.IsDefined(typeof(type), value))
                {
                    _boatType = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

    }
}
