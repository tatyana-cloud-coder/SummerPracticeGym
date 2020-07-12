using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Gym.BLL;
namespace WinPL
{
    public partial class AddGroup : Form
    {
        private IGroupLogic groupLogic;
        public AddGroup()
        {
            InitializeComponent();
            groupLogic = new GroupLogic();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string day = comboBox1.Text;
            int workingday = -1;
            if (day == "Понедельник")
            {
                workingday = 1;
            }
            if (day == "Вторник")
            {
                workingday = 2;
            }
            if (day == "Среда")
            {
                workingday = 3;
            }
            if (day == "Четверг")
            {
                workingday = 4;
            }
            if (day == "Пятница")
            {
                workingday = 5;
            }
            if (!groupLogic.GetNeedGroups(name).Any())
            {
                if (TimeSpan.TryParse(maskedTextBox1.Text, out var Begin)&& TimeSpan.TryParse(maskedTextBox2.Text, out var End)) {
                    if (workingday != -1)
                    {
                        if ((End - Begin).Hours >= 2)
                        {
                            Group group = new Group
                            {
                                Name = name,
                                WorkingDay = workingday,
                                TimeToBegin = Begin,
                                TimeToEnd = End
                            };
                            groupLogic.AddGroup(group);
                            MessageBox.Show("Группа добавлена!");
                            Close();
                        } else
                        {
                            MessageBox.Show("Тренировочное время должно быть не менее двух часов!");
                        }
                    } else
                    {
                        MessageBox.Show("Укажите день недели!");
                    }
                } else
                {
                    MessageBox.Show("Некорректные данные!");
                }
            } else
            {
                MessageBox.Show("Группа в таким названием уже существует!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
