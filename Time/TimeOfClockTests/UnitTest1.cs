using System.Xml.Serialization;
using Time;



namespace TimeOfClockTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_time10_10_10and_time10_10_10_20_20_20Returned()
        {
            //arrange
            var t1 = new TimeOfClock(10, 10, 10);
            var t2 = new TimeOfClock(10, 10, 10);
            // act
            TimeOfClock actual = t1 + t2;
            TimeOfClock ex = new TimeOfClock(20, 20, 20);

            var str = ex.ToString();
            var str2 = actual.ToString();

            //assert
            Assert.AreEqual(str, str2);
        }




        [Test]
        public void Minus__time10_10_10and_time10_10_10_0_0_0Returned()
        {
            var t1 = new TimeOfClock(10, 10, 10);
            var t2 = new TimeOfClock(10,10,10);

            var t3 = t1 - t2;
            var actual = t3.ToString();

            var ex = new TimeOfClock();
            var expected = ex.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiplication_10_10_10and2_Returned_20_20_20()
        {
            var t1 = new TimeOfClock(10, 10, 10);
            int b = 2;

            var t3 = t1 * b;
            var actual = t3.ToString();

            var ex = new TimeOfClock(20,20,20);
            var expected = ex.ToString();

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Div_4_4_4and_2_Returned2_2_2()
        {
            var t1 = new TimeOfClock(4, 4, 4);
            int b = 2;

            var t3 = t1/ b;

            var actual = t3.ToString();

            var exprcted = (new TimeOfClock(2, 2, 2)).ToString();

            Assert.AreEqual(exprcted, actual);
        }

        [Test]
        public void ÑomparisonLess_1_1_1and2_2_2_Returned_True()
        {
            var t1 = new TimeOfClock(1, 1, 1);
            var t2 = new TimeOfClock(2, 2, 2);


            bool actual = t1<t2;
            bool exprcted = true;
            Assert.AreEqual(exprcted, actual);
        }

        [Test]
        public void ÑomparisonMore_1_1_1and2_2_2_Returned_True()
        {
            var t1 = new TimeOfClock(1, 1, 1);
            var t2 = new TimeOfClock(2, 2, 2);


            bool actual = t2 > t1;
            bool exprcted = true;
            Assert.AreEqual(exprcted, actual);
        }






    }
}