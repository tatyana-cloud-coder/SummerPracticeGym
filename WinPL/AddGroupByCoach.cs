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
    public partial class AddGroupByCoach : Form
    {
        public int idCoach;
        private ICoachLogic coachLogic;
        private IGroupLogic groupLogic;
        public AddGroupByCoach()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
            groupLogic = new GroupLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameGroup = textBox1.Text;
            if (groupLogic.GetNeedGroups(nameGroup).Any())
            {
                if (!coachLogic.GetNeedNote(nameGroup, idCoach).Any())
                {
                    coachLogic.AddGroupByCoach(idCoach, nameGroup);
                    MessageBox.Show("Группа добавлена к тренеру!");
                    Close();
                } else
                {
                    MessageBox.Show("Такая группа у этого тренера уже есть!");
                }
            } else
            {
                MessageBox.Show("Такой группы не существует!");
            }
        }
    }
}
