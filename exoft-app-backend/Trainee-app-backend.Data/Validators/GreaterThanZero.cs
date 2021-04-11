using System;
using System.ComponentModel.DataAnnotations;

namespace Trainee_app_backend.Data.Validators
{
    public class GreaterThanZero : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return value != null && int.TryParse(value.ToString(), out int i) && i > 0;
        }
    }
}
