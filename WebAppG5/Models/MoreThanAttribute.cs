using System.ComponentModel.DataAnnotations;

namespace WebAppG5.Models
{
    public class MoreThanAttribute:ValidationAttribute
    {
        private  int compareVal;

        public MoreThanAttribute(int CompareVal)
        {
            compareVal = CompareVal;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int val =int.Parse(value.ToString());
            if (val > compareVal)
                return ValidationResult.Success;
            return new ValidationResult($"Val must be more than {compareVal}");
        }
    }
}
