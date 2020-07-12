using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class StringReferenceAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                return value.ToString().All(c => Char.IsLetter(c))
                    && Char.IsUpper(value.ToString()[0]);
            } else
            {
                return true;
            }
        }
    }
}
