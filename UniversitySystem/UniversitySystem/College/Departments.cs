using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.College
{
    public class Departments
    {
        public string departmentCode;

        public string DepartmentName;
        public void TotalStudents(int stud)
        {
            Console.WriteLine("There are " + stud + " students in this department");
        }

        public Departments(string code, string name)
        {
            this.departmentCode = code;
            this.DepartmentName = name;
        }

    }

}
