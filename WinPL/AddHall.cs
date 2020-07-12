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
    public partial class AddHall : Form
    {
        private IHallLogic hallLogic;
        public AddHall()
        {
            InitializeComponent();
            hallLogic = new HallLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox1.Text;
            if (!hallLogic.GetNeedHalls(name).Any())
            {
                Hall hall = new Hall
                {
                    NameOfHall = name
                };
                hallLogic.AddHall(hall);
                MessageBox.Show("Зал добавлен!");
                Close();
            } else
            {
                MessageBox.Show("Зал с таким названием уже существует!");
            }
        }
    }
}
