using EntityFramework.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace EntityFramework.Data
{
    public class CRUDManager
    {
        private DemoDbContext demoDbContext;
        public CRUDManager()
        {
            demoDbContext = new DemoDbContext();

        }
        public void Insert(Employee employee)
        {
            demoDbContext.Employees.Add(employee);
            demoDbContext.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            var employee = demoDbContext.Employees.ToList();
            return employee;
        }
        public void Update(int employeeId, Employee UpdatedEmployee)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee ID:{employeeId} Not Found");
            }

            employee.Name = UpdatedEmployee.Name;
            employee.Address = UpdatedEmployee.Address;


            demoDbContext.Employees.Update(employee);


            demoDbContext.SaveChanges();
        }
        public void Delete(int employeeId)
        {
            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId).FirstOrDefault();
            if (employee == null)
            {
                throw new Exception($"Employee ID:{employeeId} Not Found");
            }


            demoDbContext.Employees.Remove(employee);


            demoDbContext.SaveChanges();
        }
        public Employee GetEmplpoyeeById(int employeeId)
        {

            var employee = demoDbContext.Employees.Where(x => x.ID == employeeId)
                            .AsNoTracking()
                            .Last();

            if (employee == null)
            {
                throw new Exception($"Employee with ID:{employeeId} Not Found");
            }

            return employee;
        }
        public List<EmployeeEducation> GetAllEmployeesEducation()
        {
            var employeeEducations = demoDbContext.EmployeeEducations.ToList();
            return employeeEducations;
        }
        public void Insert(EmployeeEducation employeeEducation)
        {
            demoDbContext.EmployeeEducations.Add(employeeEducation);
            demoDbContext.SaveChanges();
        }
        public void Update(int employeeEducationId, EmployeeEducation modifiedEmployeeEducation)
        {
            var employeeEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == employeeEducationId).FirstOrDefault();
            if (employeeEducation == null)
            {
                throw new Exception($"Employee ID:{employeeEducationId} Not Found");
            }

            employeeEducation.CourseName = modifiedEmployeeEducation.CourseName;
            employeeEducation.UniversityName = modifiedEmployeeEducation.UniversityName;
            employeeEducation.PassingYear = modifiedEmployeeEducation.PassingYear;
            employeeEducation.MarksPercentage = modifiedEmployeeEducation.MarksPercentage;

            
            demoDbContext.EmployeeEducations.Update(employeeEducation);

          
            demoDbContext.SaveChanges();
        }
        public void DeleteEmpEdu(int employeeEducationId)
        {
            var employeeEducation = demoDbContext.EmployeeEducations.Where(x => x.ID == employeeEducationId).FirstOrDefault();
            if (employeeEducation == null)
            {
                throw new Exception($"Employee ID:{employeeEducationId} Not Found");
            }

            
            demoDbContext.EmployeeEducations.Remove(employeeEducation);

           
            demoDbContext.SaveChanges();
        }

    }
}
    

