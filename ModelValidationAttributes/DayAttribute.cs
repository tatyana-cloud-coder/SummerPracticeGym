using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace ModelValidationAttributes
{
    public class DayAttribute: RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            //var result = value.ToString();
            var result = value != null ? value.ToString() : "";
            return base.IsValid(value)
                &&
                (result == "Понедельник"
                ||
                result == "Вторник"
                ||
                result == "Среда"
                ||
                result == "Четверг"
                ||
                result == "Пятница"); 
        }
    }
}
