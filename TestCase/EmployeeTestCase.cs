using NUnit.Framework;
using PrjCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCase
{
    [TestFixture]
    class EmployeeTestCase
    {
        List<EmployeeDetails> li;
        BAL balobj = new BAL();

        [TestCase]
        public void Checknull()
        {
            var employeelist = balobj.AllUsers();
            foreach(var e in employeelist)
            {
                Assert.IsNotNull(e.eid);
                Assert.IsNotNull(e.ename);
                Assert.IsNotNull(e.salary);
            }
        }
        [TestCase]

        public void TLogin()
        {
            Assert.AreEqual("Incorrect username or Password!!!", balobj.Login("123", "123"));
            Assert.AreEqual("Userid or password should contain a value!!!", balobj.Login("", ""));
        }


    }
}
