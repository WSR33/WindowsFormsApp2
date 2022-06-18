using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class vhod : Form
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void label_capcha_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a;
            a = rnd.Next(10000, 99999);
            label_capcha.Text = a.ToString();
        }

        private void button_capcha_Click(object sender, EventArgs e)
        {
            if (textBox_capcha.Text == label_capcha.Text)
            {
                MessageBox.Show("Капча введена верно");
            }
            else
            {
                MessageBox.Show("Капча введена не верно");
            }
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(73, 140, 81);
        }

        
         
            }
    }
    
