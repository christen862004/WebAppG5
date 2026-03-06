

using System.ComponentModel.DataAnnotations;
using WebAppG5.Models;

namespace WebAppG5.ViewModel
{
    public class EmployeeWithDeptListViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Employee NAme")]//win
        //[DataType(DataType.EmailAddress)]//win type input
        public string EmpName { get; set; }//Type property determin type input (string =>text ,int=>number ,bool =>checkbox)
        public int Salary { get; set; }
        public string? ImageURL { get; set; }
        public int DepartmentId { get; set; }
        //-------------
        public List<Department> Departments { get; set; }
    }
}
