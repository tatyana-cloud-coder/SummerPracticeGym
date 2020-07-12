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
    public partial class RemoveClient : Form
    {
        private IClientLogic clientLogic;
        public RemoveClient()
        {
            InitializeComponent();
            clientLogic = new ClientLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var id) && clientLogic.GetNeedClients(id).Any())
            {
                clientLogic.RemoveClient(id);
                MessageBox.Show("Клиент удален!");
                Close();
            } else
            {
                MessageBox.Show("Клиента с таким ID не существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
