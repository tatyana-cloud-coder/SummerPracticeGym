﻿using System;
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
            var result = value != null ? value.ToString() : "";
            return base.IsValid(value) 
                && 
                result.All(c => Char.IsDigit(c))
                && 
                result.Length >= 4 
                && 
                result.Length <= 8;
        }
    }
}
