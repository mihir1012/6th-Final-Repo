using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDesktop
{
    public partial class Form3 : Form
    {
        int flag = 0;
        public Form3()
        {
            InitializeComponent();

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // col11.Text.ToString(" ");

        }



        public void game()
        {
            if(col11.Text=="X" && col21.Text == "X" && col31.Text == "X" ||
                col12.Text=="X" && col22.Text == "X" && col32.Text == "X" ||
                col13.Text == "X" && col23.Text == "X" && col33.Text == "X" ||
                col11.Text == "X" && col12.Text == "X" && col13.Text == "X" ||
                col21.Text == "X" && col22.Text == "X" && col23.Text == "X" ||
                col31.Text == "X" && col32.Text == "X" && col33.Text == "X" ||
                col11.Text == "X" && col22.Text == "X" && col33.Text == "X" ||
                col31.Text == "X" && col22.Text == "X" && col31.Text == "X" ||
                )
                { 
                DialogResult result = MessageBox.Show("Player X win, want to play Again", "Tic-Tac-Toe",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form3 fr3 = new Form3();
                    fr3.Show();
                    this.Hide();
                   
                }
                else if (result == DialogResult.No)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }else if(
                 col11.Text == "O" && col21.Text == "O" && col31.Text == "O" ||
                 col12.Text == "O" && col22.Text == "O" && col32.Text == "O" ||
                col13.Text == "O" && col23.Text == "O" && col33.Text == "O" ||
                col11.Text == "O" && col12.Text == "O" && col13.Text == "O" ||
                col21.Text == "O" && col22.Text == "O" && col23.Text == "O" ||
                col31.Text == "O" && col32.Text == "O" && col33.Text == "O" ||
                col11.Text == "O" && col22.Text == "O" && col33.Text == "O" ||
                col31.Text == "O" && col22.Text == "O" && col31.Text == "O")
                {
                DialogResult result = MessageBox.Show("Player O win, want to play Again", "Tic-Tac-Toe", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Form3 fr3 = new Form3();
                    fr3.Show();
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {

                    System.Windows.Forms.Application.Exit();
                }

            }
            
        }
            private void Col11_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col11.Text = "X";
                    flag++;
                }
                else
                {
                    col11.Text = "O";
                    flag--;
                }
            col11.Click -= Col11_Click;
                game();

            }

            private void Col12_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col12.Text = "X";
                    flag++;
                }
                else
                {
                    col12.Text = "O";
                    flag--;
                }
            col12.Click -= Col12_Click;
            game();

        }

            private void Col13_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col13.Text = "X";
                    flag++;
                }
                else
                {
                    col13.Text = "O";
                    flag--;
                }
            col13.Click -= Col13_Click;
            game();
        }

            private void Col21_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col21.Text = "X";
                    flag++;
                }
                else
                {
                    col21.Text = "O";
                    flag--;
                }
            col21.Click -= Col21_Click;
            game();
        }

            private void Col22_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col22.Text = "X";
                    flag++;
                }
                else
                {
                    col22.Text = "O";
                    flag--;
                }
            col22.Click -= Col22_Click;
            game();

        }

            private void Col23_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col23.Text = "X";
                    flag++;
                }
                else
                {
                    col23.Text = "O";
                    flag--;
                }
            col23.Click -= Col23_Click;
            game();

        }

            private void Col31_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col31.Text = "X";
                    flag++;
                }
                else
                {
                    col31.Text = "O";
                    flag--;
                }
            col31.Click -= Col31_Click;
            game();

        }

            private void Col32_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col32.Text = "X";
                    flag++;
                }
                else
                {
                    col32.Text = "O";
                    flag--;
                }
            col32.Click -= Col32_Click;
            game();
        }

            private void Col33_Click(object sender, EventArgs e)
            {
                if (flag == 0)
                {
                    col33.Text = "X";
                    flag++;
                }
                else
                {
                    col33.Text = "O";
                    flag--;
                }
            col33.Click -= Col33_Click;
            game();

            }
        }
    
    }



