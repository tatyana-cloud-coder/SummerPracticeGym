using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelValidationAttributes;
namespace Entities
{
    public class Hall
    {
        public int IDHall { get; set; }
        [Name(ErrorMessage ="Название зала должно состоять только из букв и начинаться с заглавной")]
        public string NameOfHall { get; set; }
        public override string ToString()
        {
            return $"{IDHall} {NameOfHall}";
        }
    }
}
