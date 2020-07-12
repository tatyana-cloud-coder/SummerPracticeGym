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
namespace WinPL
{
    public partial class CoachGraphic : Form
    {
        private ICoachLogic coachLogic;
        public int idCoach;
        public CoachGraphic()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            string x = "";
            for (int i = 1; i<= 5;i++)
            {
                if (i == 1)
                {
                    x = "Понедельник";
                }
                if (i == 2)
                {
                    x = "Вторник";
                }
                if (i == 3)
                {
                    x = "Среда";
                }
                if (i == 4)
                {
                    x = "Четверг";
                }
                if (i == 5)
                {
                    x = "Пятница";
                }
                int y = coachLogic.CountOfPeople(idCoach, i);
                chart1.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
