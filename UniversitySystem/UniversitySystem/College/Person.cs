using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public abstract class Person
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public abstract void DepartmentName();
    }
}
