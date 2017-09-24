using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWT_MarsTime
{
    class MarsTime : IComparable
    {
        private int _hour, _min;

        public int hour {
            get { return _hour;  }
            set
            {
                if (value > 24 || value < 0) { throw new Exception("MarsTime.hour value out of range."); } else _hour = value;
            }
        }
        public int min { get { return _min; }
            set
            {
                if (value > 99 || value < 0) { throw new Exception("MarsTime.min value out of range."); } else _min = value;
            }
        }

        public MarsTime(int hour, int min)
        {
            this.hour = hour;
            this.min = min;
        }

        public MarsTime(string input)
        {

        }


        public int CompareTo(object obj)
        {
            MarsTime tmp = (MarsTime)obj;

            if (hour.CompareTo(tmp.hour) != 0) { return hour.CompareTo(tmp.hour);  }
            return min.CompareTo(tmp.min);
        }
    }
}
