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
    public partial class Coaches : Form
    {
        public string login;
        public string password;
        private ICoachLogic coachLogic;
        public Coaches()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
        }

        private void просмотретьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var ListOfCoaches = coachLogic.GetCoaches();
            if (ListOfCoaches.Any())
            {
                foreach (var item in ListOfCoaches)
                {
                    textBox1.Text += item.ToString() + Environment.NewLine;
                }
            } else
            {
                textBox1.Text = "В зале нет ни одного тренера!";
            }
        }

        private void добавитьТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddCoach().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void удалитьТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new RemoveCoach().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void найтиТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCoach f = new SearchCoach();
            f.login = login;
            f.password = password;
            f.ShowDialog();
        }
    }
}
