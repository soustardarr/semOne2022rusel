using NUnit.Framework;
using WorkNumberSix;

namespace TestForSeconder
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(10)]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(50)]
        [TestCase(80)]
        [TestCase(70)]
        [TestCase(1.5)]
        [TestCase(2.6)]
        [TestCase(10.5)]
        [TestCase(9.8)]
        [TestCase(10.7)]
        [TestCase(12.6)]
        public void IntervalFromMinutes_Minutes_returnedSeconds(double minutes)
        {
            double excepted = minutes * 60;

            Seconder actually;
            actually = Seconder.SetIntervalFromMinutes(minutes);

            Assert.AreEqual(excepted, actually.Seconds);
        }

        [TestCase(10)]
        [TestCase(20)]
        [TestCase(30)]
        [TestCase(50)]
        [TestCase(80)]
        [TestCase(70)]
        [TestCase(1.5)]
        [TestCase(2.6)]
        [TestCase(10.5)]
        [TestCase(9.8)]
        [TestCase(10.7)]
        [TestCase(12.6)]
        public void SetIntervalTimeFromTicks_Ticks_returnedSeconds(double ticks)
        {
            double excepted = ticks / 18.2;

            Seconder actually;
            actually = Seconder.SetIntervalTimeFromTicks(ticks);

            Assert.AreEqual(excepted, actually.Seconds);
        }
        [TestCase(10, 20)]
        [TestCase(10, 5)]
        [TestCase(10, 2.9)]
        [TestCase(10, 10.0)]
        [TestCase(10, 10.200)]
        [TestCase(10.5, 20)]
        [TestCase(10, 100)]
        public void OperationSum_S1AndS2_returnedSumS1AndS2(double ticks, double ticks2)
        {
            double x = ticks / 18.2;
            double y = ticks2 / 18.2;
            double excepted = x + y;

            //

            Seconder s1 = Seconder.SetIntervalTimeFromTicks(ticks);
            Seconder s2 = Seconder.SetIntervalTimeFromTicks(ticks2);
            var actually = s1 + s2;

            Assert.AreEqual(excepted, actually.Seconds);
        }
        [TestCase(10, 20)]
        [TestCase(10, 5)]
        [TestCase(10, 2.9)]
        [TestCase(10, 10.0)]
        [TestCase(10, 10.200)]
        [TestCase(10.5, 20)]
        [TestCase(10, 100)]
        public void OperationSubstract_S1AndS2_returnedSeubstractS1AndS2(double minutes, double minutes2)
        {
            double x = minutes * 60;
            double y = minutes * 60;
            double excepted = x - y;

            Seconder s1 = Seconder.SetIntervalFromMinutes(minutes);
            Seconder s2 = Seconder.SetIntervalFromMinutes(minutes);
            var actually = s1 - s2;

            Assert.AreEqual(excepted, actually.Seconds);
        }
    }
}