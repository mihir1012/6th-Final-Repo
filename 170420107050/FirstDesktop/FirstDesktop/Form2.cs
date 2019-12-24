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
    public partial class Form2 : Form
    {
        Double a, b;
        public Form2()
        {
            InitializeComponent();
        }

       
        void assign()
        {
            a = Convert.ToDouble(Value1.Text);
            b = Convert.ToDouble(Value2.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Sub_Click(object sender, EventArgs e)
        {
            assign();
            Result.Text = Convert.ToString(a - b);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            assign();
            Result.Text = Convert.ToString(a / b);
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            assign();
            Result.Text = Convert.ToString(a * b);
        }
        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), expression);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            String s = Value1.Text;
            Result.Text = Convert.ToString(Evaluate(s));
            /*   assign();
               Result.Text = Convert.ToString(a + b);*/

        }
    }
}
