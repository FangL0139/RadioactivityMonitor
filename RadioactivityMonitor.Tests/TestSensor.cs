using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactivityMonitor.Tests
{
    
    public class TestSensor : ISensor
    {
        private double _fixedValue;
        public TestSensor(double fixedValue)
        {
            _fixedValue = fixedValue;
        }

        public double NextMeasure()
        {
            return _fixedValue;
        }
    }
}
