using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculator
{
    [TestFixture]
    class Calculatortestcase
    {
        calculator cobj = new calculator();
        [TestCase]

        public void Add()
        {
            Assert.AreEqual(30, cobj.Add(10, 20));
        }
        [TestCase]
        public void Sub()
        {
            Assert.AreEqual(30, cobj.Sub(50, 20));
        }
        [TestCase]
        public void ArgExcep()
        {
            Assert.Catch<ArgumentException>(() => cobj.Sub(5, 9));
        }

    }
}
