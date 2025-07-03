using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Validation
{
    public class DateFromTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime datevalue)
            {
                return datevalue.Date >= DateTime.Today;
            }
            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} must be today or future date";
        }
    }
}
