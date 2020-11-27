using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class NameAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            var result = value != null ? value.ToString() : "";
            return base.IsValid(value) 
                && 
                result.All(c=>Char.IsLetter(c))
                &&
                Char.IsUpper(result[0]);
        }
    }
}
