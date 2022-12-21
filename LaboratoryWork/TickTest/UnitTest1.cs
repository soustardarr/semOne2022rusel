using NUnit.Framework.Internal.Commands;
using WorkNumberSix;

namespace TickTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static void Sum_1second_and_18_4tick_Return_37_02()
        {

            var t1 = Ticker.SetIntervalFromTicks(18.4);
            var t2 = Ticker.SetIntervalFromSeconds(1.0);
            var sum = (t1 + t2).ToString();

            string res = "37 ticks 02 seconds 00 minuts";
            Assert.AreEqual(res,sum);
        }

        [Test]
        public static void Minus_1second_and_18_4tick_Return_0()
        {

            var t1 = Ticker.SetIntervalFromTicks(18.4);
            var t2 = Ticker.SetIntervalFromSeconds(1.0);
            var sum = (t1 - t2).ToString();

            string res = "00 ticks 00 seconds 00 minuts";
            Assert.AreEqual(res, sum);
        }

    }
}