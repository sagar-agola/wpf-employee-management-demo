using Core.Enums;
using Core.Models;

namespace Business.Repositories
{
    public static class EmployeeRepository
    {
        private static List<Employee> Employees { get; set; } = new List<Employee>
        {
            new Employee(1, "Sagar", "Agola", DepartmentTypeEnum.ProjectManager, "-"),
            new Employee(1, "Nehal", "Dholakia", DepartmentTypeEnum.BusinessAnalyst, "89000"),
            new Employee(1, "Dharmik", "Ginoya", DepartmentTypeEnum.TeamLeader, "75000"),
            new Employee(1, "Harshil", "Gohel", DepartmentTypeEnum.Developer, "45000"),
            new Employee(1, "Madhav", "Nasit", DepartmentTypeEnum.Developer, "45000"),
            new Employee(1, "Jay", "Gadhavi", DepartmentTypeEnum.QA, "-")
        };

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
