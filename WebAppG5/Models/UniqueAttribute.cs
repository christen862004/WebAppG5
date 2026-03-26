using System.ComponentModel.DataAnnotations;

namespace WebAppG5.Models
{
    public class UniqueAttribute:ValidationAttribute
    {
        StepsContext context;
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Employee? empFromReq = validationContext.ObjectInstance as Employee;

            context =validationContext.GetService<StepsContext>();// new StepsContext();
            string name = value.ToString();

            Employee empFromdb= context.Employees
                .FirstOrDefault(e => e.Name ==name && e.DepartmentId == empFromReq.DepartmentId);//name unique per epartment
            if (empFromdb == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Name Alreay Exist");
        }
    }
}
