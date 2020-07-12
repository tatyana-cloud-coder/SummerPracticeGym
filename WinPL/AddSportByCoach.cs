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
    public partial class AddSportByCoach : Form
    {
        public int idCoach;
        private ICoachLogic coachLogic;
        private IKindOfSportLogic kindOfSportLogic;
        public AddSportByCoach()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
            kindOfSportLogic = new KindOfSportLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameOfKind = textBox1.Text;
            if (kindOfSportLogic.GetNeedKindOfSports(nameOfKind).Any())
            {
                coachLogic.AddSportByCoach(idCoach, nameOfKind);
                MessageBox.Show("Специализация добавлена!");
                Close();
            }  else
            {
                MessageBox.Show("Зал не компетентен в этом виде спорта! Пожалуйста, добавьте его в базу!");
                Close();
            }
        }
    }
}
