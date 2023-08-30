using UniversitySystem.College;

public class University
{
    public static void Main(String[] args)
    {

        Engineering eng=new Engineering("1", "CS");
        eng.TotalStudents(300);
        eng.CalculateExamFees();
        eng.CalculateExamFees(2000);

        Staff staff=new Staff();
        staff.DepartmentName();

        Students stud = new Students();
        stud.DepartmentName();


    }
}