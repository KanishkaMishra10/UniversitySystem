using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Students : Person
    {
        public override void DepartmentName()
        {
            Console.WriteLine("This is Student Department");
        }

        public int CGPA { get; set; }

        public void display_details()
        {
            Console.WriteLine("This is an Engineering College");
        }

    }
}
