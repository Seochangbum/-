using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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



            //Q3,4,5
            /*string productName = "노트북";
            int price = 1200000;
            float discountPercent = 0.15f;
            byte stocks = 8;

            string isAvailable = (stocks > 1) ? "True" : "False";

            double discountPrice = price * (1 - discountPercent);

            textBox_Print.Text += (stocks > 0) ? "구매 가능: 할인 가격은" + discountPrice.ToString() + "입니다" : "품절입니다.";

            textBox_print2.Text = (stocks > 5) ? "여유 있음" : "소량 남음";

            textBox_print3.Text = "상품명:" productName + ", 할인된 가격:" + discountPrice .ToString() + "원, 재고:" + stocks.ToString() + ""입니다
            */


            //중간 실습
            /*int[,,] num2 = new int[,,]
            {
                {
                    { 1, 2, 3 }, { 4, 5, 6 },
                },
                {
                    { 7, 8, 9 }, { 10, 11, 12 }

                }
            };
            textBox_Print.Text = num2[1, 0, 1].ToString();
            */



            /*재그드 배열 실습
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[2] { "카리나", "윈터" };
            jaggedArray[1] = new string[3] { "닝닝", "지젤", "장원영" };
            jaggedArray[2] = new string[1] { "안유진"};


            textBox_Print.Text += "1반 학생 목록: \r\n";
            textBox_Print.Text += "-" + jaggedArray[0][0]; 
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "-" + jaggedArray[0][1];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "2반 학생 목록: \r\n";
            textBox_Print.Text += "-" + jaggedArray[1][0]; 
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "-" + jaggedArray[1][1]; 
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "-" + jaggedArray[1][2];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "3반 학생 목록: \r\n";
            textBox_Print.Text += "-" + jaggedArray[2][0];
            */


            /*string[] array = new string[10];

            array[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            array[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            array[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            array[3] = "그 사람의 그림자는 그랬다.".Replace("그" , "이");
            array[4] = "삼성 갤럭시".Insert(2, " 애플");
            array[5] = "오늘은 왠지 더 배고프다".Remove(6, 2);
            // Remove("오늘은 왠지 더 배고프다".IndexOf("더"), 1)로 해도됨 (참고)
            string[] spiltArray = "이름, 나이, 전화번호".Split(',');
            array[6] = spiltArray[0];
            array[7] = spiltArray[1];
            array[8] = spiltArray[2];
            array[9] = "우리 나라 만세".Substring(5, 3);

            textBox_Print.Text += "1." + array[0].ToString();
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "2." + array[1].ToString();
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "3." + array[2];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "4." + array[3];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "5." + array[4];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "6." + array[5];
            textBox_Print.Text += "\r\n";
            textBox_Print.Text += "7." + array[6];
            textBox_Print.Text += "\r\n ";
            textBox_Print.Text += array[7];
            textBox_Print.Text += " \r\n ";
            textBox_Print.Text += array[8];
            textBox_Print.Text += " \r\n";
            textBox_Print.Text += "8." + array[9];
            */




            int[] resultArray = Divide(30, 15);
          

            
            textBox_Print.Text += "몫: "+ resultArray[0].ToString() + "\r\n";
            textBox_Print.Text += "나머지: "+ resultArray[1].ToString();
            
            

        }

        private int[] Divide(int x, int y)

        {

            int[] result = new int[2];
            result[0] = x / y;
            result[1] = x % y;


            return result;
            


        }   


        private void textBox_Print_TextChanged(object sender, EventArgs e)

        {

        }

        private void textBox_print3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_print2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
         

        







        
        
        
        
        
        


