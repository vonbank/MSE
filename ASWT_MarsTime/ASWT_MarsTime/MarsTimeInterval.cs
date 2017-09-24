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

    }
}
