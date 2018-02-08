using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double a = 0;
        double b = 0;
        double c = 0;
        bool equal = false;
        string Oper, no1;



        public MainWindow()
        {
            InitializeComponent();
            txtDisplay.Text = "";
        }

        private void CheckIfEqual()
        {
            if (equal)
            {
                txtDisplay.Text = "";
                equal = false;
            }

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            {
                CheckIfEqual();
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            txtDisplay.Text += "0";
        }



        //


        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                a += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                Oper = "+";
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                a += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                Oper = "-";
            }
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                a += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                Oper = "*";
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                a += Convert.ToDouble(txtDisplay.Text);
                txtDisplay.Text = "";
                Oper = "/";
            }
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            equal = true;
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                switch (Oper)
                {
                    case ("+"):
                        b += Convert.ToDouble(txtDisplay.Text);
                        c = a + b;
                        txtDisplay.Text = c.ToString();
                        break;
                    case ("-"):
                        b += Convert.ToDouble(txtDisplay.Text);
                        c = a - b;
                        txtDisplay.Text = c.ToString();
                        break;
                    case ("*"):
                        b += Convert.ToDouble(txtDisplay.Text);
                        c = a * b;
                        txtDisplay.Text = c.ToString();
                        break;
                    case ("/"):
                        b += Convert.ToDouble(txtDisplay.Text);
                        c = a / b;
                        txtDisplay.Text = c.ToString();
                        break;
                    case ("x^y"):
                        txtDisplay.Text = Convert.ToString(System.Math.Pow(Convert.ToDouble(no1)
                                      , Convert.ToDouble(txtDisplay.Text)));
                        break;
                    case ("%"):
                        txtDisplay.Text = Convert.ToString(Convert.ToDouble(no1) % Convert.ToDouble(txtDisplay.Text));
                        break;
                }
            }
            a = 0;
            b = 0;
            c = 0;
        }

        //

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                txtDisplay.Text = "";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                Oper = "";
                txtDisplay.Text = "";
                a = b = c = 0;

            }
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                return;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        //


        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            CheckIfEqual();
            if (txtDisplay.Text.Contains(","))
            {
                return;

            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + ",";
            }
        }


        
    }
}
