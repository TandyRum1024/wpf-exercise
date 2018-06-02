using System;
using System.Collections.Generic;
using System.Data;
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

namespace wpf_noob
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private String Calculate = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            Calculate = "";
            textBox.Text = "";
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "/";
            textBox.Text += "/";
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "*";
            textBox.Text += "x";
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "+";
            textBox.Text += "+";
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "-";
            textBox.Text += "-";
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string result = dt.Compute(Calculate, "") + "";
                Calculate = result;
                textBox.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("잘못된 공식을 입력하였습니다.");
            }
        }

        private void buttonDecimal_Click(object sender, RoutedEventArgs e)
        {
            Calculate += ".";
            textBox.Text += ".";
        }

        private void buttonNo0_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "0";
            textBox.Text += "0";
        }

        private void buttonNo1_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "1";
            textBox.Text += "1";
        }

        private void buttonNo2_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "2";
            textBox.Text += "2";
        }

        private void buttonNo3_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "3";
            textBox.Text += "3";
        }

        private void buttonNo4_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "4";
            textBox.Text += "4";
        }

        private void buttonNo5_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "5";
            textBox.Text += "5";
        }

        private void buttonNo6_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "6";
            textBox.Text += "6";
        }

        private void buttonNo7_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "7";
            textBox.Text += "7";
        }

        private void buttonNo8_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "8";
            textBox.Text += "8";
        }

        private void buttonNo9_Click(object sender, RoutedEventArgs e)
        {
            Calculate += "9";
            textBox.Text += "9";
        }
    }
}
