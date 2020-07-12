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
    public partial class RemoveHall : Form
    {
        private IHallLogic hallLogic;
        public RemoveHall()
        {
            InitializeComponent();
            hallLogic = new HallLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (int.TryParse(textBox1.Text, out var id) && hallLogic.GetNeedHalls(id).Any())
            {
                hallLogic.RemoveHall(id);
                MessageBox.Show("Зал удален!");
                Close();
            } else
            {
                MessageBox.Show("Зала с таким ID не существует!");
            }
        }
    }
}
