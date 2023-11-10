using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDMicroExercises.TirePressureMonitoringSystem
{
    [TestClass]
    public class AlarmTest
    {
        [TestMethod]
        public void Foo()
        {
            Alarm alarm = new Alarm();
            Assert.IsFalse(alarm.AlarmOn);
        }
    }
}