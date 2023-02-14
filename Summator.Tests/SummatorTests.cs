using NUnit.Framework;

namespace Summator.Tests
{
    [TestFixture] //not obligatory
    public class SummatorTests
    {
        [Test]
       public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7});

            long expected = 12;

            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_MultiplePossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7, 8, 9, 10 });

            long expected = 39;

            Assert.That(actual == expected);
        }

        [Test]
        public static void Test_Sum_OnePositiveNumber()
        {
            long actual = Summator.Sum(new int[] {5 });

            Assert.That(actual == 5);
        }

        [Test]
        public static void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public static void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public static void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(actual, 6000000000);
        }

        [Test]
        public static void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.That(expected == actual);
        }

        [Test]
        public static void Test_Sum_RangeOFNumbers()
        {
            Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            long number = 7;
            Assert.That(number, Is.InRange(1, 10));
        }

        [Test]
        public static void Test_Text_ContainsStringExpected()
        {
            string fullName = Summator.Text("Michael B", "Jordan");

            Assert.That(fullName, Does.Contain("B"));
        }

        [Test]
        public static void Test_Date_DataFormat()
        {
            string date = Summator.Date(7 / 11 / 2021);

            Assert.That(date, Does.Match(@"^\d{1,2}/\d{1,2}/\d{4}$"));
        }
    }
}