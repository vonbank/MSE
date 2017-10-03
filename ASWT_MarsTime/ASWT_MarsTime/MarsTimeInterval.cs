using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWT_MarsTime
{
    class MarsTimeInterval
    {

        public MarsTime time_start { get; set; }
        public MarsTime time_end { get; set; }


        public MarsTimeInterval(MarsTime tstart, MarsTime tend)
        {
            if (tend < tstart) { throw new Exception("Invalid interval: end < start"); }

            this.time_start = tstart;
            this.time_end = tend;
        }

        public bool Nested(MarsTimeInterval otherInterval)
        {
            if ((this.time_start <= otherInterval.time_start && this.time_end >= otherInterval.time_end) ||
                (otherInterval.time_start <= this.time_start && otherInterval.time_end >= this.time_end))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Overlaps(MarsTimeInterval otherInterval)
        {
            if (this.Nested(otherInterval) == false &&
                ((this.time_start < otherInterval.time_end && this.time_end > otherInterval.time_end) ||
                (this.time_start < otherInterval.time_start && this.time_end > otherInterval.time_start)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Touches(MarsTimeInterval otherInterval)
        {
            if ((this.time_start == otherInterval.time_end ^ this.time_end == otherInterval.time_start) && this.Nested(otherInterval) == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
