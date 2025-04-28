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


            /*Q1
             * string fruits = "appple";
            int count = 5;
            int price = 2000;

            int totalPrice = count * price;

            textBox_Print.Text += "사과 총 5개의 가격은 :" + totalPrice.ToString() + "원입니다.";
            */


            /*Q2
             * string num = "15";
            int num2; int num3;
            num2 = int.Parse(num);
            num2 += 10;
            //num3 = num2 + 10;

            textBox_Print.Text += "15에 10을 더하면" + num2 + "입니다.";
            */


            string productName = "노트북";
            int price = 1200000;
            float discountPercent = 0.15f;
            byte stocks = 8;

            string isAvailable = (stocks > 1) ? "True" : "False";

            double discountPrice = price * (1 - discountPercent);

            textBox_Print.Text += (stocks > 0) ? "구매 가능: 할인 가격은" + discountPrice.ToString() + "입니다" : "품절입니다.";

            textBox_print2.Text = (stocks > 5) ? "여유 있음" : "소량 남음";

            textBox_print3.Text = "상품명:" + productName + ", 할인된 가격:" + discountPrice.ToString() + "원, 재고:" + stocks.ToString() + "개";




        }

        private void textBox_Print_TextChanged(object sender, EventArgs e)
        }
        }
    }
}
