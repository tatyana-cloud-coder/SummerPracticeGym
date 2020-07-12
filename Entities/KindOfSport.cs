using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelValidationAttributes;
namespace Entities
{
    public class KindOfSport
    {
        public int IDKindOfSport{ get; set;}
        [Name(ErrorMessage ="Название вида спорта должно состоять только из букв и начинаться с заглавной")]
        public string NameOfKind { get; set; }
        public override string ToString()
        {
            return $"{IDKindOfSport} {NameOfKind}";
        }
    }
}
