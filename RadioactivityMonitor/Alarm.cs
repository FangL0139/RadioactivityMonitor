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

        bool _alarmOn = false;
        private long _alarmCount = 0;

        public Alarm(ISensor sensor)
        {
            _sensor = sensor;
        }
        public void Check()
        {
            double value = _sensor.NextMeasure();

            if (value < LowThreshold | HighThreshold < value)
            {
                _alarmOn = true;
                _alarmCount += 1;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }

}
