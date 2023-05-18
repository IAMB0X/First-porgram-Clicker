using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кликер
{
    public partial class Form1 : Form
    {
        int Bit = 0;
        int multi = 1;
        int upgrade1 = 100;
        int upgrade2 = 1000;
        int upgrade3 = 5000;
        int upgrade4 = 15000;
        int upgradess = 0;
        int clickCount = 0; //записываем сюда кол-во кликов
        int clickCount2 = 0;
        string Log = "Admin";
        string Pass = "0000";
       


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Bit=multi+Bit;
            label5.Text = Convert.ToString(Bit) + " -БИТкоин "; */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upgradee1.Visible = true;
            upgredee2.Visible = true;
            upgredee3.Visible = true;
            upgradee4.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bit >= upgrade1)
            {
                Bit = Bit - upgrade1;
                upgrade1 = upgrade1 + 10;
                multi++;
                label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
                upgradee1.Text = "Стоимость " + Convert.ToString(upgrade1) + "-БИТкоинов";
                Upgrades.Text = "Кол-во апгрейдов: " + Convert.ToString(upgradess++);

            }
            else

                MessageBox.Show("Недостаточно средств," + upgrade1.ToString() + " > " + Bit.ToString(), "Вы банкрот", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Bit >= upgrade2)
            {
                Bit = Bit - upgrade2;
                upgrade2 = upgrade2 + 100;
                multi= multi + 10;
                label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
                upgredee2.Text = "Стоимость " + Convert.ToString(upgrade2) + "-БИТкоинов";
                Upgrades.Text = "Кол-во апгрейдов: " + Convert.ToString(upgradess++);

            }
            else

                MessageBox.Show("Недостаточно средств, " + upgrade2.ToString() + " > " + Bit.ToString(), "Вы банкрот", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Bit >= upgrade3)
            {
                Bit = Bit - upgrade3;
                upgrade3 = upgrade3 + 500;
                timer1.Interval = 500;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();
                timer1.Enabled = true;
               upgredee3.Text = "Стоимость " + Convert.ToString(upgrade3) + "-БИТкоинов";
                Upgrades.Text = "Кол-во апгрейдов: " + Convert.ToString(upgradess++);
            }
            else

                MessageBox.Show("Недостаточно средств, " + upgrade3.ToString() + " > " + Bit.ToString(), "Вы банкрот", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            clickCount++;
            Bit++;
            label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Bit >= upgrade4)
            {
                Bit = Bit - upgrade4;
                upgrade4 = upgrade4 + 1000;
                timer2.Interval = 50;
                timer2.Tick += new EventHandler(timer1_Tick);
                timer2.Start();
                timer2.Enabled = true;
               upgradee4.Text = "Стоимость " + Convert.ToString(upgrade4) + "-БИТкоинов";
                Upgrades.Text = "Кол-во апгрейдов: " + Convert.ToString(upgradess++);
            }
            else
                MessageBox.Show("Недостаточно средств, " + upgrade4.ToString() + " > " + Bit.ToString(), "Вы банкрот", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            clickCount2++;
            Bit++;
            label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            upgradee1.Visible = false;
            upgredee2.Visible = false;
            upgredee3.Visible = false;
            upgradee4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void Button_mouse(object sender, MouseEventArgs e)
        {
            Bit = multi + Bit;
            label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Bit = Convert.ToInt32(Cheat.Text);
            label5.Text = Convert.ToString(Bit) + " -БИТкоин ";
        }

        private void Activate(object sender, MouseEventArgs e)
        {
            Cheat.Enabled = true;
            Cheat.Visible = true;
            Accept.Enabled = true;
            Accept.Visible = true;
        }

        private void Get_btt_Click(object sender, EventArgs e)
        {

            panel1.BringToFront();
            panel1.Visible = true;
            panel2.Visible = false;
        }
    }
}
