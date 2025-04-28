using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 연산자_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*string fruits = "appple";
            int count = 5;
            int price = 2000;

            int totalPrice = count * price;

            textBox_Print.Text += "사과 총 5개의 가격은 :" + totalPrice.ToString() + "원입니다.";
            */


            string num = "15";
            int num2; int num3;
            num2 = int.Parse(num);
            num2 += 10;
            //num3 = num2 + 10;

            textBox_Print.Text += "15에 10을 더하면" + num2 + "입니다.";
        }

        private void textBox_Print_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
