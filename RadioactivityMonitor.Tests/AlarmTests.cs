namespace RadioactivityMonitor.Tests
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void AlarmOnValueBelowLowThreshold()
        {
            // Arrange
            ISensor sensorLowerAlarm = new TestSensor(TestConstants.LowerThreshold); // Below LowThreshold (17)
            Alarm alarm = new Alarm(sensorLowerAlarm);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn, "Alarm should be on when the value is below the low threshold.");
        }

        [TestMethod]
        public void AlarmOnValueAboveHighThreshold()
        {
            // Arrange
            ISensor sensorHigherAlarm = new TestSensor(TestConstants.HigherThreshold); // Above HighThreshold (21)
            Alarm alarm = new Alarm(sensorHigherAlarm);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn, "Alarm should be on when the value is above the high threshold.");
        }

        [TestMethod]
        public void AlarmOffValueBewteenThresholds()
        {
            // Arrange
            ISensor sensorNoAlarm = new TestSensor(TestConstants.BetweenThreshold); // Within LowThreshold (17) and HighThreshold (21)
            Alarm alarm = new Alarm(sensorNoAlarm);

            // Act
            alarm.Check();

            // Assert
            Assert.IsFalse(alarm.AlarmOn, "Alarm should be off when the value is between the thresholds.");
        }

        [TestMethod]
        public void AlarmCounts()
        {
            // Arrange
            ISensor sensorLowerAlarm = new TestSensor(TestConstants.LowerThreshold); // Below LowThreshold (17)
            Alarm alarm = new Alarm(sensorLowerAlarm);

            // Act - n times
            for (int i = 0; i < TestConstants.AlarmCheckCount; i++)
            {
                alarm.Check();
            }

            // Assert
            Assert.IsTrue(alarm.AlarmOn, "Alarm should be on when the value is below the low threshold.");
            Assert.AreEqual(TestConstants.AlarmCheckCount, alarm.AlarmCount, "Alarm count should be same.");
        }
    }
}