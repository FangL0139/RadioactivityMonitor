using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactivityMonitor.Tests
{
    public static class TestConstants
    {
        //Value outside of Thresholds for the Alarm class
        public const double LowerThreshold = 16.0;
        public const double HigherThreshold = 22.0;

        //Value within Thresholds for the Alarm class
        public const double BetweenThreshold = 19.0;

        //Value within Thresholds for the Alarm class
        public const long AlarmCheckCount = 2L;
    }
}
