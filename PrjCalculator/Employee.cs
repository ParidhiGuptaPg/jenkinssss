using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculator
{
    public class EmployeeDetails
    {
        public int eid { get; set; }
        public string ename{get;set;}
        public int salary { get; set; }
    }
    public class BAL
    {
        public List<EmployeeDetails> AllUsers()
        {
            List<EmployeeDetails> li = new List<EmployeeDetails>();
            li.Add(new EmployeeDetails { eid = 1001, ename = "sai", salary = 45000 });
            li.Add(new EmployeeDetails { eid = 1002, ename = "Abi", salary = 40000 });
            li.Add(new EmployeeDetails { eid = 1003, ename = "Sri", salary = 35000 });
            return li;
        }

        public string Login(string userid,string password)
        {
            if(string.IsNullOrEmpty(userid)||string.IsNullOrEmpty(password))
            {
                return "Userid or password should contain a value!!!";
            }
            else
            {
                if(userid=="Admin" && password=="123")
                {
                    return "Admin Logged In!!!";
                }
                return "Incorrect username or Password!!!";
            }
        }
    }
    
   
    class Employee
    {
    }
}
