using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Gym.BLL;
namespace WinPL
{
    public partial class SearchCoach : Form
    {
        private ICoachLogic coachLogic;
        private List <RadioButton> ListOfButton;
        public string login;
        public string password;
        public SearchCoach()
        {
            InitializeComponent();
            coachLogic = new CoachLogic();
            ListOfButton = new List<RadioButton>();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ListOfButton)
            {
                Controls.Remove(item);
            }
            ListOfButton.Clear();
            textBox2.Text = "";
            var ListOfCoaches = coachLogic.GetCoaches();
            int y = 100;
            if (textBox1.Text == "")
            {
                foreach (var item in ListOfCoaches)
                {
                    RadioButton rb = new RadioButton();
                    rb.Text = item.FirstName + ' ' + item.LastName;
                    rb.AutoSize = true;
                    rb.Location = new Point(50, y);
                    Controls.Add(rb);
                    ListOfButton.Add(rb);
                    y += 20;
                }
            }
            else
            {
                foreach (var item in ListOfCoaches)
                {
                    if (textBox1.Text != "" && item.FirstName.Contains(textBox1.Text))
                    {
                        RadioButton rb = new RadioButton();
                        rb.Text = item.FirstName + ' ' + item.LastName;
                        rb.AutoSize = true;
                        rb.Location = new Point(50, y);
                        Controls.Add(rb);
                        ListOfButton.Add(rb);
                        y += 20;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            var checkedButton = ListOfButton.FirstOrDefault(r => r.Checked);
            if (checkedButton !=null)
            {
                char[] div = {' '};
                string[] line = checkedButton.Text.Split(div, StringSplitOptions.RemoveEmptyEntries);
                int idCoach = coachLogic.SelectIdNeedCoaches(line[0], line[1]).ElementAt(0);
                var ListOfKinds = coachLogic.GetSportsByCoach(idCoach);
                if (ListOfKinds.Any())
                {
                    foreach (var item in ListOfKinds)
                    {
                        textBox2.Text += coachLogic.GetNamesOfSportsByCoach(item).ElementAt(0) +Environment.NewLine;
                    }
                } else
                {
                    textBox2.Text = "У тренера нет компетенций";
                }
            } else
            {
                MessageBox.Show("Выберите пожалуйста тренера!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                var checkedButton = ListOfButton.FirstOrDefault(r => r.Checked);
                if (checkedButton != null)
                {
                    char[] div = { ' ' };
                    string[] line = checkedButton.Text.Split(div, StringSplitOptions.RemoveEmptyEntries);
                    int idCoach = coachLogic.SelectIdNeedCoaches(line[0], line[1]).ElementAt(0);
                    AddSportByCoach frm = new AddSportByCoach();
                    frm.idCoach = idCoach;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите пожалуйста тренера!");
                }
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkedButton = ListOfButton.FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                char[] div = { ' ' };
                string[] line = checkedButton.Text.Split(div, StringSplitOptions.RemoveEmptyEntries);
                int idCoach = coachLogic.SelectIdNeedCoaches(line[0], line[1]).ElementAt(0);
                CoachGraphic frm = new CoachGraphic();
                frm.idCoach = idCoach;
                frm.ShowDialog();
            } else
            {
                MessageBox.Show("Выберите пожалуйста тренера!");
            }
  

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login == "adminTatyana")
            {
                var checkedButton = ListOfButton.FirstOrDefault(r => r.Checked);
                if (checkedButton != null)
                {
                    char[] div = { ' ' };
                    string[] line = checkedButton.Text.Split(div, StringSplitOptions.RemoveEmptyEntries);
                    int idCoach = coachLogic.SelectIdNeedCoaches(line[0], line[1]).ElementAt(0);
                    AddGroupByCoach frm = new AddGroupByCoach();
                    frm.idCoach = idCoach;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выберите пожалуйста тренера!");
                }
            } else
            {
                MessageBox.Show("Для получения разрешения к данному действию свяжитесь с администратором по телефону +7(927)-000-00-00");
            }
        }
    }
}
