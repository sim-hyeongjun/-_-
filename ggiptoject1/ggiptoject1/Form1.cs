using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ggiptoject1
{

    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Minus,
            Cob,
            Divied,
            Result
        }
        
        Operators  currntOperators = Operators.None;
        Boolean operatorChangeFlage = false;
        decimal firstOperand = 0;
        decimal secondOperand = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {
            Button OPR_Bttn = (Button)sender;
            oper_num(OPR_Bttn.Text);
        }
        private void oper_num(string ope)
        {
            switch (ope)
            {
                case "＋" :
                    firstOperand = decimal.Parse(display.Text);
                    currntOperators = Operators.Add;
                    operatorChangeFlage = true;
                    break;
                case  "－":
                    firstOperand = decimal.Parse(display.Text);
                    currntOperators = Operators.Minus;
                    operatorChangeFlage = true;
                    break;
                case "×":
                    firstOperand = decimal.Parse(display.Text);
                    currntOperators = Operators.Cob;
                    operatorChangeFlage = true;
                    break;
                case "÷":
                    firstOperand = decimal.Parse(display.Text);
                    currntOperators = Operators.Divied;
                    operatorChangeFlage = true;
                    break;
                case "AC":
                    firstOperand = 0;
                    secondOperand = 0;
                    currntOperators = Operators.None;
                    display.Text = "0";
                    break;
                case ".":
                    if (display.Text.Contains(".") == false)
                    {
                        display.Text += ".";
                    }
                    break;
                case "＝":
                    secondOperand = Convert.ToDecimal(display.Text);

                    if (currntOperators == Operators.Add)
                    {
                        double result_Operand = (double)(secondOperand + firstOperand);
                        display.Text = result_Operand.ToString();
                    }
                    else if (currntOperators == Operators.Minus)
                    {
                        firstOperand -= secondOperand;
                        display.Text = firstOperand.ToString();
                    }
                    else if (currntOperators == Operators.Cob)
                    {
                        firstOperand *= secondOperand;
                        display.Text = firstOperand.ToString();
                    }
                    else if (currntOperators == Operators.Divied)
                    {
                        if (secondOperand == 0)
                        {
                            display.Text = "0으로 나눌수 없습니다.";
                        }
                        else
                        {
                            firstOperand /= secondOperand;
                            display.Text = firstOperand.ToString();
                        }
                    }
                    break;

            }
        }

        // 버튼0~9까지 0에 모두 종속
        private void button0_Click(object sender, EventArgs e)
        {
            Button num_Bttn = (Button)sender;
            num_set(num_Bttn.Text);

        }

        /// <summary>
        ///  숫자 버튼 함수
        /// </summary>
        /// <param name="num"></param>
        private void num_set(string num)

        {
            string[] arr1 = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string strnumber = "";
            if (operatorChangeFlage == true)
            {
                display.Text = "";
                operatorChangeFlage = false;
            }
            int i = 0;
            for (i = 0; i < arr1.Length; i++)
            {

                if (arr1[i] == num)
                {
                    strnumber = display.Text += arr1[i];
                    decimal intNumber = decimal.Parse(strnumber);
                    display.Text = intNumber.ToString();
                }
            }    
        }


        // 키보드 조작 함수
        /*
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
                button1_Click(sender, e);
        }
        */
    }
    
}

//연산자 +에 다 묶어서 연산하기 함수 
//IF문 사용
//string[] opre = new string[5] { "+", "-", "×", "÷", "AC" };
//object[] str_opre = new string[5] { Add, Minus, Cob, Divied, AC };
/*
if (str_ope == "＋")
{
    firstOperand = decimal.Parse(display.Text);
    currntOperators = Operators.Add;
    operatorChangeFlage = true;
}
else if (str_ope == "－")
{
    firstOperand = decimal.Parse(display.Text);
    currntOperators = Operators.Minus;
    operatorChangeFlage = true;
}
else if (str_ope == "×")
{
    firstOperand = decimal.Parse(display.Text);
    currntOperators = Operators.Cob;
    operatorChangeFlage = true;
}
else if (str_ope == "÷")
{
    firstOperand = decimal.Parse(display.Text);
    currntOperators = Operators.Divied;
    operatorChangeFlage = true;
}
else if (str_ope == "AC")
{
    firstOperand = 0;
    secondOperand = 0;
    currntOperators = Operators.None;
    display.Text = "0";

}
*/