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

        public Boat()
        {

    
        }

        public void setBoatType(int boatType)
        {
           
            switch (boatType)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
            }
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
