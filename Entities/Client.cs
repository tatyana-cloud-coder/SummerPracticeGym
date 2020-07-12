using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelValidationAttributes;
namespace Entities
{
    public class Client
    {
        public int IDClient { get; set; }
        [Name(ErrorMessage ="Имя клиента должно состоять только из букв и начинаться с заглавной")]
        public string FirstName { get; set;}
        [Name(ErrorMessage = "Фамилия клиента должна состоять только из букв и начинаться с заглавной ")]
        public string LastName { get; set; }
        [TelephoneNumber(ErrorMessage ="Номер телефона клиента должен состоять ровно из 11 цифр")]
        public string TelephoneNumber { get; set; }
        [StringReference(ErrorMessage = "Имя любимого тренера должно состять только из букв и начинаться с заглавной")]
        public string FirstNameOfFavoriteCoach { get; set; }
        [StringReference(ErrorMessage = "Фамилия любимого тренера должна состять только из букв и начинаться с заглавной")]
        public string LastNameOfFavoriteCoach { get; set; }

        public override string ToString()
        {
            return $"{IDClient} {FirstName} {LastName} {TelephoneNumber} {FirstNameOfFavoriteCoach} {LastNameOfFavoriteCoach}";
        }

    }
}
