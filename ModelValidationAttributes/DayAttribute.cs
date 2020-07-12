using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class DayAttribute: RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            return base.IsValid(value) && (value.ToString() == "Понедельник" || 
                value.ToString() == "Вторник" || value.ToString() == "Среда"
                || value.ToString() == "Четверг" || value.ToString() == "Пятница");
        }
    }
}
