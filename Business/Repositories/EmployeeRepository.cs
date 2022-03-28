using Core.Models;

namespace Business.Repositories
{
    public static class EmployeeRepository
    {
        private static List<Employee> Employees { get; set; }=new List<Employee>();

        public static void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public static List<Employee> GetAll()
        {
            return Employees;
        }
    }
}
