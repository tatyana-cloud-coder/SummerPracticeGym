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
    public partial class AddClient : Form
    {
        private IClientLogic clientLogic;
        private ICoachLogic coachLogic;
        public AddClient()
        {
            InitializeComponent();
            clientLogic = new ClientLogic();
            coachLogic = new CoachLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var coach) && coachLogic.GetNeedCoaches(coach).Any())
            {
                Client client = new Client
                {
                    FirstName = maskedTextBox1.Text,
                    LastName = maskedTextBox2.Text,
                    TelephoneNumber = maskedTextBox3.Text,
                    IDfavoriteCoach = coach
                };
                clientLogic.AddClient(client);
                MessageBox.Show("Клиент добавлен!");
                Close();
            } else
            {
                MessageBox.Show("Некорректные данные: посмотрите внимательно и исправьте ошибку!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
