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
    public partial class RemoveCoach : Form
    {
        private ICoachLogic coachLogic;
        public RemoveCoach()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var idCoach) && coachLogic.GetNeedCoaches(idCoach).Any())
            {
                coachLogic.RemoveCoach(idCoach);
                MessageBox.Show("Тренер удален!");
            } else
            {
                MessageBox.Show("Тренера с таким ID не существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    }
}
