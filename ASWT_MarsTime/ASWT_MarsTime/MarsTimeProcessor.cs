using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWT_MarsTime
{
    public enum MarsTimeIntervalResult
    {
        ERROR, NESTED, OVERLAP, TOUCH, DISJOINT
    }
    static class MarsTimeProcessor
    {
        public static MarsTimeIntervalResult processUserInput(string input_1_1, string input_1_2, string input_2_1, string input_2_2)
        {
            MarsTime mt_1_1, mt_1_2, mt_2_1, mt_2_2;
            try
            {
                mt_1_1 = new MarsTime(input_1_1);
                mt_1_2 = new MarsTime(input_1_2);
                mt_2_1 = new MarsTime(input_2_1);
                mt_2_2 = new MarsTime(input_2_2);
            }
            catch
            {
                return MarsTimeIntervalResult.ERROR;
            }



            return MarsTimeIntervalResult.ERROR;
        }
    }
}
