using Core.Enums;

namespace Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DepartmentTypeEnum Department { get; set; }
        public string Salary { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(LastName))
                {
                    return FirstName;
                }
                else
                {
                    return $"{ FirstName } { LastName }";
                }
            }
        }
    }
}
