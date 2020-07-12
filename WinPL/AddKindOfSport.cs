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
    public partial class AddKindOfSport : Form
    {
        private IKindOfSportLogic kindOfSportLogic;
        public AddKindOfSport()
        {
            InitializeComponent();
            kindOfSportLogic = new KindOfSportLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if  (!kindOfSportLogic.GetNeedKindOfSports(name).Any())
            {
                KindOfSport kindOfSport = new KindOfSport
                {
                    NameOfKind = name
                };
                kindOfSportLogic.AddKindOfSport(kindOfSport);
                MessageBox.Show("Вид спорта добавлен!");
                Close();
            } else
            {
                MessageBox.Show("Вид спорта с таким названием уже существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
