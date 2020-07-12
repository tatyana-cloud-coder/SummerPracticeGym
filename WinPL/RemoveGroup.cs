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
    public partial class RemoveGroup : Form
    {
        private IGroupLogic groupLogic;
        public RemoveGroup()
        {
            InitializeComponent();
            groupLogic = new GroupLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            var DeletedGroup = groupLogic.SelectDeletedGroup(name);
            if (DeletedGroup.Any())
            {
                groupLogic.RemoveGroup(DeletedGroup.ElementAt(0));
                MessageBox.Show("Группа удалена!");
                Close();
            } else
            {
                MessageBox.Show("Группы с таким названием не существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
