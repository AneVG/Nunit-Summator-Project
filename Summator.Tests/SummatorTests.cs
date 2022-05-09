using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_OnePositiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5 });
            Assert.That(actual == 5);
        }
        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(actual, 6000000000);
        }
        [Test]
        public void Test_Average_TwoPositiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;
            Assert.That(expected == actual);
        }
    }
}