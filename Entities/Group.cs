using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ModelValidationAttributes;
namespace Entities
{
    public class Group
    {
        public int IDGroup { get; set; }
        [Name(ErrorMessage = "Название группы должно состоять только из букв и начинаться с заглавной")]
        public string Name { get; set; }
        public int Number { get; set; }
        [Day(ErrorMessage ="День тренировки должен быть одним из следующих: Понедельник, Вторник, Среда, Четверг, Пятница")]
        public string WorkingDay { get; set; }
        [Required(ErrorMessage ="Определите время начала тренировки")]
        public TimeSpan TimeToBegin { get; set; }
        [Required(ErrorMessage ="Определите время окончания тренировки")]
        public TimeSpan TimeToEnd { get; set; }

        public override string ToString()
        {
            return $"{Name} {Number} {WorkingDay} {TimeToBegin} {TimeToEnd}";
        }
        public static string DayOfWeek (int i)
        {
            if (i == 1) return "Понедельник";
            if (i == 2) return "Вторник";
            if (i == 3) return "Среда";
            if (i == 4) return "Четверг";
            if (i == 5) return "Пятница";
            return null;
        }
        public static int IndexDay (string day)
        {
            if (day == "Понедельник") return 1 ;
            if (day == "Вторник") return 2;
            if (day == "Среда") return 3 ;
            if (day == "Четверг") return 4 ;
            if (day == "Пятница") return 5 ;
            return 0;
        }
    }
}
