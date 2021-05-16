using NUnit.Framework;
using System;

namespace NUnitTPjt
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //Setup mock DB
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Executing Test1!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Executing Test2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("Executing Test3!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Assert.Pass();
        }
    }
}