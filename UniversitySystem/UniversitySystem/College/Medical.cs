using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Medical : ICollege
    {
        public void CollegeId()
        {
            Console.WriteLine("Medical College ID: 103");
        }

        public void CollegeName()
        {
            Console.WriteLine("This is an Medical College");
        }

        public void TotalDoctors()
        {
            Console.WriteLine("There are 1000 Doctors in this college.");
        }
    }


}
