using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym.BLL;
using Entities;
namespace WinPL
{
    public partial class AddCoach : Form
    {
        private ICoachLogic coachLogic;
        private IHallLogic hallLogic;
        public AddCoach()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
            hallLogic = new HallLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var hall) && hallLogic.GetNeedHalls(hall).Any()) {
                Coach coach = new Coach
                {
                    FirstName = maskedTextBox1.Text,
                    LastName = maskedTextBox2.Text,
                    TelephoneNumber = maskedTextBox3.Text,
                    MainHall = hall
                };
                coachLogic.AddCoach(coach);
                MessageBox.Show("Тренер добавлен!");
                this.Close();
            } else
            {
                MessageBox.Show("Некорректные данные: посмотрите внимательно и исправьте ошибку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
