using EntityFramework.Data;
using EntityFramework.Data.Entities;

namespace ConsoleApp1
{
    public class program
    {
        public static void Main()
        {
            CRUDManager obj = new CRUDManager();
            CRUDManager obj1 = new CRUDManager();

            //Console.WriteLine("New Employee Is Added");
            //obj.Insert(new Employee { Name = "Ramesh", Address = "Amala" });
            //obj.Insert(new Employee { Name = "Sai", Address = "Dehradune" });
            //PrintAllEmployees();

            //Console.WriteLine("Updating Employees Are");
            //obj.Update(4, new Employee { Name = "Sivvvvvvva", Address = "Anakapalli" });
            //obj.Update(2, new Employee { Name = "Srinu", Address = "Karnool" });
            //PrintAllEmployees();

            //Console.WriteLine("Deleting EmployeeId 4");
            //obj.Delete(4);
            //PrintAllEmployees();
            //Console.ReadLine();

            //Console.WriteLine("Retrieving Employee Details ");
            //var employee = obj.GetEmplpoyeeById(7);S
            //Console.WriteLine($"Employee Details Are {employee.Name}");


            //Console.WriteLine("New EmployeeEducation Details Is Added");
            //obj1.Insert(new EmployeeEducation { CourseName = "COMPUTER SCIENCE", UniversityName = "JNTUK", PassingYear = 2021, MarksPercentage = 80 });
            //obj1.Insert(new EmployeeEducation { CourseName = "MECHANICAL", UniversityName = "JNTUH", PassingYear = 2022, MarksPercentage = 90 });
            //PrintAllEmployeesEducation();

            //Console.WriteLine("Updating Education with ID 3");
            //obj.Update(4, new EmployeeEducation { CourseName = "Btech", UniversityName = "adfh", PassingYear = 2022, MarksPercentage = 90 });
            //PrintAllEmployeeEducations();


            //Console.WriteLine("Deleting Employee Education details for ID 1");
            //obj.DeleteEmpEdu(3);
            //PrintAllEmployeeEducations();
        }

        //private static void PrintAllEmployees()
        //{
        //    Console.WriteLine("All Employees Are............");
        //    CRUDManager obj = new CRUDManager();
        //    foreach (Employee employee in obj.GetAllEmployees())
        //    {
        //        Console.WriteLine($"Employee Name is {employee.Name} and address is {employee.Address}");
        //    }
        //}

        private static void PrintAllEmployeesEducation()
        {
            Console.WriteLine("All EmployeesEducation details Are............");
            CRUDManager obj = new CRUDManager();
            foreach (EmployeeEducation employeeeducation in obj.GetAllEmployeesEducation())
            {
                Console.WriteLine($"Employee  CourseName is {employeeeducation.CourseName} and Employee UniversityName is {employeeeducation.UniversityName} and Employee PassingYear is{employeeeducation.PassingYear}and Employee MarksPercentage is{employeeeducation.MarksPercentage}");
            }
        }
    }
}