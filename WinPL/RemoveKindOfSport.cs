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
    public partial class RemoveKindOfSport : Form
    {
        private IKindOfSportLogic kindOfSportLogic;
        public RemoveKindOfSport()
        {
            InitializeComponent();
            kindOfSportLogic = new KindOfSportLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse (textBox1.Text, out var id) && kindOfSportLogic.GetNeedKindOfSports(id).Any())
            {
                kindOfSportLogic.RemoveKindOfSport(id);
                MessageBox.Show("Вид спорта удален!");
                Close();
            } else
            {
                MessageBox.Show("Вида спорта с таким ID не существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
