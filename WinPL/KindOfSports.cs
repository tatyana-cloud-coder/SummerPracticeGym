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
    public partial class KindOfSports : Form
    {
        public string login;
        public string password;
        private IKindOfSportLogic kindOfSportLogic;
        public KindOfSports()
        {
            InitializeComponent();
            kindOfSportLogic = new KindOfSportLogic();
        }

        private void добавитьВидСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddKindOfSport().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void удалитьВидСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new RemoveKindOfSport().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void просмотретьСписокВидовСпортаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var ListOfKinds = kindOfSportLogic.GetKindOfSports();
            if (ListOfKinds.Any())
            {
                foreach (var  item in ListOfKinds)
                {
                    textBox1.Text += item.ToString() + Environment.NewLine;
                }
            } else
            {
                textBox1.Text = "Нет видов спорта!";
            }
        }

        private void просмотретьРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult f = new KindSchedule().ShowDialog();
        }
    }
}
