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
    public partial class AddClientByGroup : Form
    {
        private IGroupLogic groupLogic;
        private IClientLogic clientLogic;
        public AddClientByGroup()
        {
            InitializeComponent();
            groupLogic = new GroupLogic();
            clientLogic = new ClientLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameGroup = textBox2.Text;
            if (int.TryParse(textBox1.Text, out var id) && clientLogic.GetNeedClients(id).Any())
            {
                if (groupLogic.GetNeedGroups(nameGroup).Any())
                {
                    if (!groupLogic.GetNeedClientByGroup(nameGroup, id).Any())
                    {
                        groupLogic.AddClientByGroup(nameGroup, id);
                        MessageBox.Show("Клиент добавлен в группу!");
                        Close();
                    } else
                    {
                        MessageBox.Show("Данный клиент уже числится в этой группе!");
                    }
                } else
                {
                    MessageBox.Show("Группы с таким названием не существует!");
                }
            } else
            {
                MessageBox.Show("Некорректный ID!");
            }
        }
    }
}
