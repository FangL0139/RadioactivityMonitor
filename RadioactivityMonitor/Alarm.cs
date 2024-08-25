using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactivityMonitor
{
    public class Alarm
    {
        private const double LowThreshold = 17;
        private const double HighThreshold = 21;

        //Sensor _sensor = new Sensor();
        private ISensor _sensor;

        public bool AlarmOn { get; private set; } = false;
        public long AlarmCount { get; private set; } = 0;

        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }
        public void Check()
        {
            double value = _sensor.NextMeasure();

            if (value < LowThreshold || HighThreshold < value)
            {
                AlarmOn = true;
                AlarmCount += 1;
            }
        }

        //public bool AlarmOn
        //{
        //    get { return _alarmOn; }
        //}
    }

}
