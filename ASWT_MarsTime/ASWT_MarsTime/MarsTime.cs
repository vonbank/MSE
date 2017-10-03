using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
            if (Regex.IsMatch(input, ("^[0-9]{2}:?[0-9]{2}$")))
            {
                input = input.Replace(":", "");
                this.hour = int.Parse(input.Substring(0, 2));
                this.min = int.Parse(input.Substring(2, 2));
            }
            else { throw new Exception("Invalid input format. (use 00:00)");  }
        }


        public int CompareTo(object obj)
        {
            MarsTime tmp = (MarsTime)obj;

            if (hour.CompareTo(tmp.hour) != 0) { return hour.CompareTo(tmp.hour);  }
            return min.CompareTo(tmp.min);
        }

        public static bool operator <(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) < 0;
        }

        public static bool operator >(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) > 0;
        }

        public static bool operator ==(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) == 0;
        }

        public static bool operator !=(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) != 0;
        }

        public static bool operator <=(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) <= 0;
        }

        public static bool operator >=(MarsTime mt1, MarsTime mt2)
        {
            return mt1.CompareTo(mt2) >= 0;
        }
    }
}
