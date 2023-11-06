using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using static WindowsFormsApp5.Form1;
using System.Diagnostics;

namespace WindowsFormsApp5
{
        public partial class Form1 : Form
        {
        public struct function_v
        {
            public string x;
            public string y;
            public function_v(string _x, string _y)
            {
                x = _x;
                y = _y;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        List<function_v> functions = new List<function_v>();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            DataTable table = new DataTable();
            table.Columns.Add("X", typeof(string));
            table.Columns.Add("Y", typeof(string));

            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double r = 2;
            double y, x = x1;
            if (x >= -4 && x <= 5)
            {
                if (x <= 0)
                {
                    for (int i = 0; x <= 0 && x <= x2; i++)
                    {
                        y = -x * 0.5;
                        functions.Add(new function_v(Convert.ToString(x), Convert.ToString(y)));
                        table.Rows.Add(functions[i].x, functions[i].y);
                        x += dx;
                    }
                }
                functions.Clear();
                if (x <= 2)
                {
                    for (int i = 0; x < 2 && x <= x2; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)) - 2;
                        functions.Add(new function_v(Convert.ToString(x), Convert.ToString(-y)));
                        table.Rows.Add(functions[i].x, functions[i].y);
                        x += dx;
                    }
                }
                functions.Clear();
                if (x <= 4)
                {
                    for (int i = 0; x < 4 && x <= x2; i++)
                    {
                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x - 2, 2));
                        functions.Add(new function_v(Convert.ToString(x), Convert.ToString(y)));
                        table.Rows.Add(functions[i].x, functions[i].y);
                        x += dx;
                    }
                }
                functions.Clear();
                if (x <= 5)
                {
                    for (int i = 0; x <= 5 && x <= x2; i++)
                    {
                        y = -x + 4;
                        functions.Add(new function_v(Convert.ToString(x), Convert.ToString(y)));
                        table.Rows.Add(functions[i].x, functions[i].y);
                        x += dx;
                    }
                }
                functions.Clear();
            } else
            {
                MessageBox.Show("Введите значения Х в интервале от Х=-4 до Х=5.");
            }

            dataGridView1.DataSource = table;
        }
    }
}
