using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Engineering : Courses, ICollege
    {
        public Engineering(string code, string name) : base(code, name)
        {
        }

        // Department
        public void CollegeId()
        {
            Console.WriteLine("Engineering College Id is 101");
        }

        public void CollegeName()
        {
            Console.WriteLine("This is an Engineering College");
        }

        public void Practicals() { }


    }


}
