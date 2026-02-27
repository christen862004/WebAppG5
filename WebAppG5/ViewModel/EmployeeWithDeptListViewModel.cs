

using WebAppG5.Models;

namespace WebAppG5.ViewModel
{
    public class EmployeeWithDeptListViewModel
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string? ImageURL { get; set; }
        public int DepartmentId { get; set; }
        //-------------
        public List<Department> Departments { get; set; }
    }
}
