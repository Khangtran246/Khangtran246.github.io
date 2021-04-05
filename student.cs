using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOOP
{
    class Student
    {
        public string Name;

        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
           
            public Student(String stname)
        {
           
        }
        static void Main(string[] args)
        {
            Student h1 = new Student();
        }
        }
    }
