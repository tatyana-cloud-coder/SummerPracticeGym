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
    public partial class KindSchedule : Form
    {
        private IKindOfSportLogic kindOfSportLogic;
        public KindSchedule()
        {
            InitializeComponent();
            kindOfSportLogic = new KindOfSportLogic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int day = -1;
            string name = textBox1.Text;
            if (comboBox1.Text == "Понедельник")
            {
                day = 1;
            }
            if (comboBox1.Text == "Вторник")
            {
                day = 2;
            }
            if (comboBox1.Text == "Среда")
            {
                day = 3;
            }
            if (comboBox1.Text == "Четверг")
            {
                day = 4;
            }
            if (comboBox1.Text == "Пятница")
            {
                day = 5;
            }
            if (kindOfSportLogic.GetNeedKindOfSports(name).Any())
            {
                if (day != -1)
                {
                    var Schedule = kindOfSportLogic.Schedule(name, day);
                    if (Schedule.Any())
                    {
                        char[] div = { ',' };
                        foreach (var item in Schedule)
                        {
                            string[] line = item.Split(div, StringSplitOptions.RemoveEmptyEntries);
                            dataGridView1.Rows.Add(line);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполните расписние!");
                    }
                } else
                {
                    MessageBox.Show("Укажите день!");
                }
            } else
            {
                MessageBox.Show("Такого вида спорта не существует!");
            }
        }
    }
}
