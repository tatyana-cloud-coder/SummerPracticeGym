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
    public partial class Halls : Form
    {
        public string login;
        public string password;
        private IHallLogic hallLogic;
        public Halls()
        {
            InitializeComponent();
            hallLogic = new HallLogic();
        }

        private void добавитьЗалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddHall().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void просмотретьСписокЗаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var ListOfHalls = hallLogic.GetHalls();
            if (ListOfHalls.Any())
            {
                foreach (var item in ListOfHalls)
                {
                    textBox1.Text += item.ToString() +Environment.NewLine;
                }
            } else
            {
                textBox1.Text = "Ни один зал не был добавлен!";
            }
        }

        private void удалитьЗалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new RemoveHall().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }
    }
}
