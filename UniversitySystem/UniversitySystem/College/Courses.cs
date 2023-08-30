using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversitySystem.College
{
    public class Courses : Departments
    {

        private int base_fees;

        public Courses(string code, string name) : base(code, name)
        {
        }

        public void CalculateExamFees()
        {
            Console.WriteLine("Fees without backlog is: " + base_fees);
        }

        public void CalculateExamFees(int backlog_fees)
        {
            int fees;
            fees = base_fees + backlog_fees;
            Console.WriteLine("Fees without backlog is: " + fees);
        }

    }
}