namespace RadioactivityMonitor.Tests
{
    [TestClass]
    public class AlarmTests
    {
        [TestMethod]
        public void AlarmOnValueBelowLowThreshold()
        {
            // Arrange
            ISensor sensor = new TestSensor(TestConstants.LowerThreshold); // Below LowThreshold (17)
            Alarm alarm = new Alarm(sensor);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn, "Alarm should be on when the value is below the low threshold.");
        }

        [TestMethod]
        public void AlarmOnValueAboveHighThreshold()
        {
            // Arrange
            ISensor sensor = new TestSensor(TestConstants.HigherThreshold); // Above HighThreshold (21)
            Alarm alarm = new Alarm(sensor);

            // Act
            alarm.Check();

            // Assert
            Assert.IsTrue(alarm.AlarmOn, "Alarm should be on when the value is above the high threshold.");
        }

        [TestMethod]
        public void AlarmOffValueBewteenThresholds()
        {
            // Arrange
            ISensor sensor = new TestSensor(TestConstants.BetweenThreshold); // Within LowThreshold (17) and HighThreshold (21)
            Alarm alarm = new Alarm(sensor);

            // Act
            alarm.Check();

            // Assert
            Assert.IsFalse(alarm.AlarmOn, "Alarm should be off when the value is between the thresholds.");
        }
    }
}