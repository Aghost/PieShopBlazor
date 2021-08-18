using System;

namespace PieShop.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}
