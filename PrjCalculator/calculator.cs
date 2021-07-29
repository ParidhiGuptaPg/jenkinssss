using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculator
{
    public class calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Sub(int a,int b)
        {
            if(a<b)
            {
                throw new ArgumentException("a should be greater than b");
            }
            return a - b;
        }

    }
}
