using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Товары
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_price.Text = "Цена:";
            label_proizvoditel.Text = "Производитель:";
            if (comboBox_name.Text == "Боксерская груша X-Match черная");
            {
                textBox_opisanie.Text = "Крутая груша для бокса";
                label_proizvoditel.Text += " ООО ГИРЯ";
                label_price.Text += " 8.000 рублей";
                pictureBox_photo.Image = Properties.Resources.А112Т4; 
                    }
                    else if (comboBox_name.Text == "Шведская стенка ROMANA Next, pastel")
                {
                    textBox_opisanie.Text = "Шведская стенка для занятия спортом";
                    label_proizvoditel.Text += " ИП ТОР ";
                    label_price.Text += " 70.000 рублей";
                    pictureBox_photo.Image = Properties.Resources.F746E6;
                }
            else if (comboBox_name.Text == "Набор для хоккея Совтехстром")
            {
                textBox_opisanie.Text = "Отличный набор для игры в хоккей";
                label_proizvoditel.Text += " ИП ТОР";
                label_price.Text += " 5.000 рублей";
                pictureBox_photo.Image = Properties.Resources.клюшка;
            }


        }

        }
    }
}
