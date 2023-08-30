using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Management : ICollege
    {
        public void CollegeId()
        {
            Console.WriteLine("Management College ID is: 102");
        }

        public void CollegeName()
        {
            Console.WriteLine("This is a Management College");
        }
    }

}
