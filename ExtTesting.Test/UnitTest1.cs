using System.Collections.Generic;
using NUnit.Framework;

namespace ExtTesting.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var ints = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                ints.Add(i);
            }
            var sum = ints.MySum();
            Assert.AreEqual(sum, 45);
        }
    }
}