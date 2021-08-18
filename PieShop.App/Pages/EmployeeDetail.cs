using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using PieShop.Shared;

namespace PieShop.App.Pages
{
    public partial class EmployeeDetail {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public IEnumerable<Employee> Employees { get; set; }
        public List<Role> Roles { get; set; }

        protected override Task OnInitializedAsync() {
            InitializeRoles();
            InitializeEmployees();
            Employee = Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();
        }

        private void InitializeRoles() {
            Roles = new List<Role>() {
                Role.Administrator,
                Role.Employee,
                Role.Customer
            };
        }

        private void InitializeEmployees() {
            var e1 = new Employee {
                EmployeeId = 1,
                RoleId = 1,
                Role = Role.Administrator,
                FirstName = "henk",
                LastName = "henksen",
                EmailAddress = "henkhenksen@henksen.henk"
            };

            var e2 = new Employee {
                EmployeeId = 2,
                RoleId = 2,
                Role = Role.Employee,
                FirstName = "jan",
                LastName = "jansen",
                EmailAddress = "janjansen@jansen.jan"
            };

            Employees = new List<Employee> { e1, e2 };
        }
    }
}
