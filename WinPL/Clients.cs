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
    public partial class Clients : Form
    {
        public string login;
        public string password;
        private IClientLogic clientLogic;
        public Clients()
        {
            InitializeComponent();
            clientLogic = new ClientLogic();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new AddClient().ShowDialog();
            }  else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void удалитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                DialogResult f = new RemoveClient().ShowDialog();
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void просмотретьСписокКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            var ListOfClients = clientLogic.GetClients();
            if (ListOfClients.Any())
            {
                foreach (var item in ListOfClients)
                {
                    textBox1.Text += item.ToString() + Environment.NewLine;
                }
            } else
            {
                textBox1.Text = "Нет ни одного клиента!";
            }
        }
    }
}
