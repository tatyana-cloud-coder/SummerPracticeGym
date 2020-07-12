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
    public partial class Groups : Form
    {
        public string login;
        public string password;
        private IGroupLogic groupLogic;
        public Groups()
        {
            InitializeComponent();
            groupLogic = new GroupLogic();
        }

        private void добавитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddGroup().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void просмотретьСписокГруппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var ListOfGroups = groupLogic.GetGroups();
            if (ListOfGroups.Any())
            {
                foreach (var item in ListOfGroups)
                {
                    textBox1.Text += item.ToString() + Environment.NewLine;
                }
            } else
            {
                textBox1.Text = "Список групп пуст!";
            }
        }

        private void удалитьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new RemoveGroup().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void добавитьКлиентаВГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddClientByGroup().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }
    }
}
