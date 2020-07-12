using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class NameAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && value.ToString().All(c=>Char.IsLetter(c))
                &&Char.IsUpper(value.ToString()[0]);
        }

    }
}
