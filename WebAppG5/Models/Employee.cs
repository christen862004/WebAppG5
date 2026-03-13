using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppG5.Models
{
    public class Employee
    {
        public int Id { get; set; }

        //[Required] //by default
       // [StringLength(25,MinimumLength =3)]
        [MaxLength(25)]
        [MinLength(3 ,ErrorMessage ="Name must be More than 2 char ")]
        [Unique]
        public string Name { get; set; }//not allow null db

        //[Range(8000,25000)]
        //[MoreThan(8000)]
        [Remote("CheckSalary","Employee",AdditionalFields = "Name")]//Employee/CheckSalary?Salary=6666 ==> json
        public int Salary { get; set; }
        
        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must be jpg or png")]//biuu998.png
        public string? ImageURL { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        
        public Department? Department { get; set; }
    }
}
