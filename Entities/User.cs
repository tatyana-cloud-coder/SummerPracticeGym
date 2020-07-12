using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelValidationAttributes;
using System.ComponentModel.DataAnnotations;
namespace Entities
{
    public class User
    {
        public int IDUser { get; set; }
        [Name(ErrorMessage ="Имя должно состоять только из букв и начинаться с заглавной")]
        public string FirstName { get; set; }
        [Name(ErrorMessage = "Фамилия должна состоять только из букв и начинаться с заглавной ")]
        public string LastName { get; set; }
        [TelephoneNumber(ErrorMessage ="Номер телефона должен содержать ровно 11 цифр")]
        public string TelephoneNumber { get; set; }
        [Required(ErrorMessage ="Введите адрес электронной почты")]
        public string EmailAddress { get; set; }
        [Login(ErrorMessage="Логин должен содержать от 8 до 16 букв/цифр")]
        public string Login { get; set; }
        [Password(ErrorMessage ="Пароль должен содержать от 4 до 8 цифр")]
        public string Password{ get; set; }

        public bool IsAdmin()
        {
            return Login == "adminTatyana" && Password == "12345";
        }
    }
}
