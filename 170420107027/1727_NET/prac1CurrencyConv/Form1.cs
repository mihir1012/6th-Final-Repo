using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace prac1CurrencyConv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Rupees");
            comboBox2.Items.Add("Dollar");
            comboBox2.Items.Add("Franc");
            comboBox2.Items.Add("Euro");
            
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("Rupees");
            comboBox1.Items.Add("Dollar");
            comboBox1.Items.Add("Franc");
            comboBox1.Items.Add("Euro");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Onclick();
        }



        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void Onclick()
        {
            if (textBox1.Text.Equals(""))
            {
                label3.Text = "Please Enter Value";
            }
            else if (comboBox1.SelectedIndex == 2 && comboBox2.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.015);
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.014);
            }
            else if (comboBox1.SelectedIndex == 3 && comboBox2.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.013);
            }
            else if (comboBox1.SelectedIndex == comboBox2.SelectedIndex)
            {
                label3.Text = textBox1.Text;
            }

            else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 71.35);
            }
            else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 2)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.97);
            }
            else if (comboBox2.SelectedIndex == 1 && comboBox1.SelectedIndex == 3)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.89);
            }

            else if (comboBox2.SelectedIndex == 2 && comboBox1.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 73.38);
            }

            else if (comboBox2.SelectedIndex == 2 && comboBox1.SelectedIndex == 1)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.03);
            }

            else if (comboBox2.SelectedIndex == 2 && comboBox1.SelectedIndex == 3)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.92);
            }

            else if (comboBox2.SelectedIndex == 3 && comboBox1.SelectedIndex == 0)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 79.91);
            }

            else if (comboBox2.SelectedIndex == 3 && comboBox1.SelectedIndex == 1)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.12);
            }
            else if (comboBox2.SelectedIndex == 3 && comboBox1.SelectedIndex == 2)
            {
                label3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.09);
            }

        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Onclick();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Onclick();
        }
    }
}
