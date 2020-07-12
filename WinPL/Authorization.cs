using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPL
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = maskedTextBox1.Text;
            string password = maskedTextBox2.Text;
            if ((login == "adminTatyana" && password == "12345") || (login == "userTatyana" && password == "54321"))
            {
                Gym frm = new Gym();
                frm.login = maskedTextBox1.Text;
                frm.password = maskedTextBox2.Text;
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("Неправильный логин/пароль! Повторите авторизацию!");
            }
        }
    }
}
