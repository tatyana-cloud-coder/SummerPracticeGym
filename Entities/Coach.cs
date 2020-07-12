using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelValidationAttributes;
namespace Entities
{
    public class Coach
    {
        public int IDCoach { get; set;}
        [Name(ErrorMessage ="Имя тренера должно состоять только из букв и начинатся с заглавной")]
        public string FirstName { get; set; }
        [Name(ErrorMessage ="Фамилия тренера должна состоять только из букв и начинаться с заглавной")]
        public string LastName { get; set; }
        [TelephoneNumber(ErrorMessage ="Номер телефона тренера должен содержать ровно 11 цифр")]
        public string TelephoneNumber { get; set; }
        [StringReference(ErrorMessage ="Название зала ответственности тренера должно состоять только из букв и начинаться с заглавной")]
        public string MainHall { get; set;}

        public override string ToString()
        {
            return $" {IDCoach} {FirstName} {LastName} {TelephoneNumber} {MainHall}";
        }


    }
}
