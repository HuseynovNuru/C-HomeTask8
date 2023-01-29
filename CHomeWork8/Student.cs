using System;
using System.Collections.Generic;
using System.Text;

namespace CHomeWork8
{
    internal class Student:Human
    {
        public string GroupNo;

        public Student(string groupNo,string fullname):base(fullname)
        {
            GroupNo = groupNo;
            Fullname= fullname;
        }
    }
}
