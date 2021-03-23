using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using w7lab;

namespace w7lab.tests
{
    // TODO: Replace examples and use TDD development by writing your own tests

    [TestFixture]
    public class CustomMathTest
    {
        static int ExpectedResult;

        [SetUp]
        public static void Init()
        {
        }

        [Test]
        public void Multiply_1()
        {
            ExpectedResult = 20;
            int ActualResult = Program.CustomMath.multiply(4, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void Multiply_2()
        {
            ExpectedResult = 0;
            int ActualResult = Program.CustomMath.multiply(0, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void Multiply_3()
        {
            ExpectedResult = -25;
            int ActualResult = Program.CustomMath.multiply(5, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }

    [TestFixture]
    public class DivisibleNbTest
    {
        static bool ExpectedResult;
        bool ActualResult;

        [SetUp]
        public static void Init()
        {
        }

        [Test]
        public void DivisbleTest_1()
        {
            ExpectedResult = true;
            ActualResult = DivisibleNb.isDivisible(5, 5, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void DivisbleTest_2()
        {
            ExpectedResult = true;
            ActualResult = DivisibleNb.isDivisible(5, 5, 5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [Test]
        public void DivisbleTest_3()
        {
            ExpectedResult = true;
            ActualResult = DivisibleNb.isDivisible(-10, 0, 10);
            Assert.Throws<DivideByZeroException>(DivisibleNb.isDivisible(-10, 0, 10), );
        }
    }
}
