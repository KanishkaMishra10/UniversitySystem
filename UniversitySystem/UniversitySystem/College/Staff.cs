using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Staff : Person
    {
        public float salary { get; set; }

        public override void DepartmentName()
        {
            Console.WriteLine("This is Staff Department");
        }

    }
}
