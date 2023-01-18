using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeMonetSystem
{
    //Inherit the functionality of base class Person
    class Student : Person
    {
        public int StudentNumber { get; set; }
        public Student(string fn, string sn, string address, string county, int age, string phone, string email, int patNo)
            : base(fn, sn, address, county, age, phone, email)
        {
            StudentNumber = patNo;
        }
        //Override ToString() method
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append($"Student Number: {StudentNumber}");
            return sb.ToString();
        }
    }
}
