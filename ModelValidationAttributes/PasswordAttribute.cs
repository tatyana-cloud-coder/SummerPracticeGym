using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class PasswordAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && value.ToString().All(c => Char.IsDigit(c))
               && value.ToString().Length >= 4 && value.ToString().Length <= 8;
        }
    }
}
