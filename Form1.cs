using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sieczne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double a = Convert.ToDouble(punktA.Text);
            double b = Convert.ToDouble(punktB.Text);

            /*
            if (b < a)
            {
                double zmienna = a;
                a = b;
                b = zmienna;
            }
            */
            
            double z_A = Convert.ToDouble(zmienna1.Text);
            double z_B = Convert.ToDouble(zmienna2.Text);
            double z_C = Convert.ToDouble(zmienna3.Text);
            
            double eps = Convert.ToDouble(epsilon.Text);


            
            //////////////////////////// Ax^3 +Bsin + C = 0
            double f_a_1 = z_A * Math.Pow(a, 3) + z_B * Math.Sin(a) + z_C;
            double f_b_1 = z_A * Math.Pow(b, 3) + z_B * Math.Sin(b) + z_C;
            // 3Ax ^ 2 + B * cos(x)
            // 6*A*x + B* -sin
            double f_a_2 = 6 * z_A * a + z_B * (-Math.Sin(a));
            double f_b_2 = 6 * z_A * b + z_B * (-Math.Sin(b));
            







            /*
            //////////////////////////////////////////////////////////////// x^3-x-4,5
            double f_a_1 = Math.Pow(a, 3) - a - 4.5;
            double f_b_1 = Math.Pow(b, 3) - b - 4.5;
            // 3x^2-1
            // 6x
            double f_a_2 = 6 * a;
            double f_b_2 = 6 * b;
            */

            /*
            //////////////////////////////////////////////////////////////// x^3+cos(x)+1
            double f_a_1 = Math.Pow(a, 3) + Math.Cos(a) + 1;
            double f_b_1 = Math.Pow(b, 3) + Math.Cos(b) + 1;
            // 3x^2-1
            // 6x-cos
            double f_a_2 = 6 * a-Math.Cos(a);
            double f_b_2 = 6 * b - Math.Cos(b);
            */








            double x = 0;
            double f_x = 0;
            bool to_a = false;

            if (f_a_1 < 0 && f_b_1 > 0 && f_b_2 > 0)
            {
                x = a;
                to_a = true;
                f_x = f_a_1;
            }
            else if (f_a_1 > 0 && f_b_1 < 0 && f_a_2 > 0)
            {
                x = b;
                to_a = false;
                f_x = f_b_1;
            }
            else if (f_a_1 > 0 && f_b_1 < 0 && f_b_2 < 0)
            {
                x = a;
                to_a = true;
                f_x = f_a_1;
            }
            else if (f_a_1 < 0 && f_b_1 > 0 && f_a_2 < 0)
            {
                x = b;
                to_a = false;
                f_x = f_b_1;
            }
            do
            {
                if (to_a)
                {
                    x = x - f_x / (f_b_1 - f_x) * (b - x);
                }
                else
                {
                    x = x - f_x / (f_x - f_a_1) * (x - a);
                }
                f_x = z_A * Math.Pow(x, 3) + z_B * Math.Sin(x) + z_C;
                //f_x = Math.Pow(x, 3) - x - 4.5;
                //f_x = Math.Pow(x, 3) + Math.Cos(x) + 1;
                listBox1.Items.Add($"{x}\t\t{f_x}");
            } while(Math.Abs(f_x) > eps);
        }
    }
}
