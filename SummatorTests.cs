using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator.Test
{
    public class Tests
    {
        [Test]
        public void Test_SumTwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_SumOnePositiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_SumTwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_BigValues_sum()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(actual, 8000000000);

        }

        [Test]
        public void Test_AverageTwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });

            int expected = 6;

            Assert.That(expected == actual);
        }


    }
}