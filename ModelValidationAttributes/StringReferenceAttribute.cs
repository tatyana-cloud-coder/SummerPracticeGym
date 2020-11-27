using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class StringReferenceAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var result = value != null ? value.ToString() : "";
            if (value != null)
            {
                return result.All(c => Char.IsLetter(c))
                    && 
                    Char.IsUpper(result[0]);
            } else
            {
                return true;
            }
        }
    }
}
