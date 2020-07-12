using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class TelephoneNumberAttribute: RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && value.ToString().Length == 11 
                && value.ToString().All(c=>Char.IsDigit(c));
        }

    }
}
