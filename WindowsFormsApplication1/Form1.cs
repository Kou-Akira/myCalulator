using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private float pNum = 0;
        private float lNum = 0;
        private int flag = 0;
        private int op = 0;
        private int ac = 0;//clear all and reset
        private int pButton = 0;//num=1,op=2,eq=3
        private int pointModel = 0;
        private float pCount = (float)0.1;
        private int pFlag = 0;
        private int singleFlag = 0;//single op flag
        private int paiFlag = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void cNum(int num)
        {
            if(pointModel==0)
            {
                if (ac == 0 && num != 0)//init
                {
                    textBox1.Text = num.ToString();
                    allEqual.Text = num.ToString();
                    ac = 1;
                }
                else if (ac == 1)
                {
                    textBox1.Text += num.ToString();
                    allEqual.Text += num.ToString();
                }
                if (flag == 0)
                {
                    pNum *= 10;
                    pNum += num;
                }
                else
                {
                    lNum *= 10;
                    lNum += num;
                }
            }
            else
            {
                if(ac==0)
                {
                    textBox1.Text = "0." + num.ToString();
                    allEqual.Text = "0." + num.ToString();
                    ac = 1;
                }
                else
                {
                    textBox1.Text += num.ToString();
                    allEqual.Text += num.ToString();
                }
                if (flag == 0)
                {
                    pNum += num * pCount;
                    pCount *= (float)0.1;
                }
                else
                {
                    lNum += num * pCount;
                    pCount *= (float)0.1;
                }
            }
            
            
        }
        private void reset()
        {
            allEqual.Text = "";
            textBox1.Text = "0";
            pNum = 0;
            lNum = 0;
            flag = 0;
            op = 0;
            ac = 0;
            pButton = 0;
            pointModel = 0;
            singleFlag = 0;
            paiFlag = 0;
        }
        private void cal()
        {
            if (op == 1)//plus
            {
                textBox1.Text = (pNum + lNum).ToString();
                pNum = pNum + lNum;
            }
            else if (op == 2) //divide
            {
                textBox1.Text = (pNum - lNum).ToString();
                pNum = pNum - lNum;
            }
            else if (op == 3) //divide
            {
                textBox1.Text = (pNum * lNum).ToString();
                pNum = pNum * lNum;
            }
            else if (op == 4) //divide
            {
                textBox1.Text = (pNum / lNum).ToString();
                pNum = pNum / lNum;
            }
            else if (op == 5) //mod
            {
                textBox1.Text = (pNum % lNum).ToString();
                pNum = pNum % lNum;
            }
            singleFlag = 0;
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0) 
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(9);
                }
            }        
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(8);
                }
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(7);
                }
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(6);
                }
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(5);
                }
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(4);
                }
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(3);
                }
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(2);
                }
            }
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(1);
                }
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0)
            {
                if (pButton == 3 || singleFlag == 1)
                {
                    reset();
                }
                else if (pButton == 2 && singleFlag == 0)
                {
                    textBox1.Text = "";
                }
                if (singleFlag != 1)
                {
                    pButton = 1;
                    cNum(0);
                }
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            cal();
            pButton = 3;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)//pre button is num
            {
                flag = 1;
                op = 1;
                textBox1.Text = "";
                allEqual.Text += " + ";
            }
            else if (pButton == 1 && op != 0)
            {
                cal();
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = pNum.ToString();
                lNum = 0;
                flag = 1;
                op = 1;
            }
            else if(pButton == 2 && op == 0)
            {
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = "";
                flag = 1;
                op = 1;
            }
            else if (pButton == 2 && op != 0)
            {
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = "";
                flag = 1;
                op = 1;
            }
            else if (pButton == 3)//pre button is equal
            {
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = "";
                lNum = 0;
                flag = 1;
                op = 1;
            }
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }
        private void divide_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)//pre button is num
            {
                flag = 1;
                op = 4;
                textBox1.Text = "";
                allEqual.Text += " / ";
            }
            else if (pButton == 1 && op != 0)
            {
                cal();
                allEqual.Text = pNum.ToString() + " / ";
                textBox1.Text = pNum.ToString();
                lNum = 0;
                flag = 1;
                op = 4;
            }
            else if (pButton == 2 && op == 0)
            {
                allEqual.Text = pNum.ToString() + " / ";
                textBox1.Text = "";
                flag = 1;
                op = 4;
            }
            else if (pButton == 2 && op != 0)
            {
                allEqual.Text = pNum.ToString() + " / ";
                textBox1.Text = "";
                flag = 1;
                op = 4;
            }
            else if (pButton == 3)//pre button is equal
            {
                allEqual.Text = pNum.ToString() + " / ";
                textBox1.Text = "";
                lNum = 0;
                flag = 1;
                op = 4;
            }
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)//pre button is num
            {
                flag = 1;
                op = 3;
                textBox1.Text = "";
                allEqual.Text += " * ";
            }
            else if (pButton == 1 && op != 0)
            {
                cal();
                allEqual.Text = pNum.ToString() + " * ";
                textBox1.Text = pNum.ToString();
                lNum = 0;
                flag = 1;
                op = 3;
            }
            else if (pButton == 2 && op == 0)
            {
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = "";
                flag = 1;
                op = 3;
            }
            else if (pButton == 2 && op != 0)
            {
                allEqual.Text = pNum.ToString() + " + ";
                textBox1.Text = "";
                flag = 1;
                op = 3;
            }
            else if (pButton == 3)//pre button is equal
            {
                allEqual.Text = pNum.ToString() + " * ";
                textBox1.Text = "";
                lNum = 0;
                flag = 1;
                op = 3;
            }
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }

        private void min_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)//pre button is num
            {
                flag = 1;
                op = 2;
                textBox1.Text = "";
                allEqual.Text += " - ";
            }
            else if (pButton == 1 && op != 0)
            {
                cal();
                allEqual.Text = pNum.ToString() + " - ";
                textBox1.Text = pNum.ToString();
                lNum = 0;
                flag = 1;
                op = 2;
            }
            else if (pButton == 2 && op == 0)
            {
                allEqual.Text = pNum.ToString() + " - ";
                textBox1.Text = "";
                flag = 1;
                op = 2;
            }
            else if (pButton == 2 && op != 0)
            {
                allEqual.Text = pNum.ToString() + " - ";
                textBox1.Text = "";
                flag = 1;
                op = 2;
            }
            else if (pButton == 3)//pre button is equal
            {
                allEqual.Text = pNum.ToString() + " - ";
                textBox1.Text = "";
                lNum = 0;
                flag = 1;
                op = 2;
            }
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }

        private void point_Click(object sender, EventArgs e)
        {
            pointModel = 1;
            if(pFlag==0)
            {
                textBox1.Text += ".";
                allEqual.Text += ".";
            }
            pFlag = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();//about
            frm3.ShowDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // if it is a hotkey, return true; otherwise, return false
            switch (keyData)
            {
                case Keys.NumPad0:
                case Keys.D0:
                    //焦点定位到控件button_num_0上，即数字0键上
                    num0.Focus();
                    //执行按钮点击操作
                    num0.PerformClick();
                    return true;
                case Keys.NumPad1:
                case Keys.D1:
                    num1.Focus();
                    num1.PerformClick();
                    return true;
                case Keys.NumPad2:
                case Keys.D2:
                    num2.Focus();
                    num2.PerformClick();
                    return true;
                case Keys.NumPad3:
                case Keys.D3:
                    num3.Focus();
                    num3.PerformClick();
                    return true;
                case Keys.NumPad4:
                case Keys.D4:
                    num4.Focus();
                    num4.PerformClick();
                    return true;
                case Keys.NumPad5:
                case Keys.D5:
                    num5.Focus();
                    num5.PerformClick();
                    return true;
                case Keys.NumPad6:
                case Keys.D6:
                    num6.Focus();
                    num6.PerformClick();
                    return true;
                case Keys.NumPad7:
                case Keys.D7:
                    num7.Focus();
                    num7.PerformClick();
                    return true;
                case Keys.NumPad8:
                case Keys.D8:
                    num8.Focus();
                    num8.PerformClick();
                    return true;
                case Keys.NumPad9:
                case Keys.D9:
                    num9.Focus();
                    num9.PerformClick();
                    return true;
                case Keys.Enter:
                    equal.Focus();
                    equal.PerformClick();
                    return true;
                case Keys.Add:
                    plus.Focus();
                    plus.PerformClick();
                    return true;
                case Keys.Subtract:
                    min.Focus();
                    min.PerformClick();
                    return true;
                case Keys.Multiply:
                    mul.Focus();
                    mul.PerformClick();
                    return true;
                case Keys.Divide:
                    divide.Focus();
                    divide.PerformClick();
                    return true;
                case Keys.Decimal:
                    point.Focus();
                    point.PerformClick();
                    return true;

                //......
                default:
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Sin(t)).ToString();
                allEqual.Text = "sin(" + pNum.ToString() + ")";
                pNum = (float)Math.Sin(t);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "sin(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "sin(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "sin(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "sin(" + lNum.ToString() + ")";
                        break;
                }
                float t = (float)(lNum * 3.141593 / 180);
                lNum = (float)Math.Sin(t);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1) 
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Sin(t)).ToString();
                allEqual.Text = "sin(" + pNum.ToString() + ")";
                pNum = (float)Math.Sin(t);
                lNum = 0;
            }
            else if(pButton == 3)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Sin(t)).ToString();
                allEqual.Text = "sin(" + pNum.ToString() + ")";
                pNum = (float)Math.Sin(t);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Cos(t)).ToString();
                allEqual.Text = "cos(" + pNum.ToString() + ")";
                pNum = (float)Math.Cos(t);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "cos(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "cos(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "cos(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "cos(" + lNum.ToString() + ")";
                        break;
                }
                float t = (float)(lNum * 3.141593 / 180);
                lNum = (float)Math.Cos(t);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Cos(t)).ToString();
                allEqual.Text = "cos(" + pNum.ToString() + ")";
                pNum = (float)Math.Cos(t);
                lNum = 0;
            }
            else if (pButton == 3)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Cos(t)).ToString();
                allEqual.Text = "cos(" + pNum.ToString() + ")";
                pNum = (float)Math.Cos(t);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Tan(t)).ToString();
                allEqual.Text = "tan(" + pNum.ToString() + ")";
                pNum = (float)Math.Tan(t);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "tan(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "tan(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "tan(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "tan(" + lNum.ToString() + ")";
                        break;
                }
                float t = (float)(lNum * 3.141593 / 180);
                lNum = (float)Math.Tan(t);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Tan(t)).ToString();
                allEqual.Text = "tan(" + pNum.ToString() + ")";
                pNum = (float)Math.Tan(t);
                lNum = 0;
            }
            else if (pButton == 3)
            {
                float t = (float)(pNum * 3.141593 / 180);
                textBox1.Text = ((float)Math.Tan(t)).ToString();
                allEqual.Text = "tan(" + pNum.ToString() + ")";
                pNum = (float)Math.Tan(t);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                textBox1.Text = ((float)Math.Sqrt(pNum)).ToString();
                allEqual.Text = "sqrt(" + pNum.ToString() + ")";
                pNum = (float)Math.Sqrt(pNum);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "sqrt(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "sqrt(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "sqrt(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "sqrt(" + lNum.ToString() + ")";
                        break;
                }
                lNum = (float)Math.Sqrt(lNum);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                textBox1.Text = ((float)Math.Sqrt(pNum)).ToString();
                allEqual.Text = "sqrt(" + pNum.ToString() + ")";
                pNum = (float)Math.Sqrt(pNum);
                lNum = 0;
            }
            else if (pButton == 3)
            {
                textBox1.Text = ((float)Math.Sqrt(pNum)).ToString();
                allEqual.Text = "sqrt(" + pNum.ToString() + ")";
                pNum = (float)Math.Sqrt(pNum);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void exp2_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                textBox1.Text = (pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^2";
                pNum = pNum * pNum;
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + lNum.ToString() + "^2";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + lNum.ToString() + "^2";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + lNum.ToString() + "^2";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + lNum.ToString() + "^2";
                        break;
                }
                lNum = lNum * lNum;
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                textBox1.Text = (pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^2";
                pNum = pNum * pNum;
                lNum = 0;
            }
            else if (pButton == 3)
            {
                textBox1.Text = (pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^2";
                pNum = pNum * pNum;
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void exp3_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                textBox1.Text = (pNum * pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^3";
                pNum = pNum * pNum * pNum;
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + lNum.ToString() + "^3";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + lNum.ToString() + "^3";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + lNum.ToString() + "^3";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + lNum.ToString() + "^3";
                        break;
                }
                lNum = lNum * lNum * lNum;
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                textBox1.Text = (pNum * pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^3";
                pNum = pNum * pNum * pNum;
                lNum = 0;
            }
            else if (pButton == 3)
            {
                textBox1.Text = (pNum * pNum * pNum).ToString();
                allEqual.Text = pNum.ToString() + "^3";
                pNum = pNum * pNum * pNum;
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void lnx_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                textBox1.Text = ((float)Math.Log(pNum)).ToString();
                allEqual.Text = "ln(" + pNum.ToString() + ")";
                pNum = (float)Math.Log(pNum);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "ln(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "ln(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "ln(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "ln(" + lNum.ToString() + ")";
                        break;
                }
                lNum = (float)Math.Log(lNum);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                textBox1.Text = ((float)Math.Log(pNum)).ToString();
                allEqual.Text = "ln(" + pNum.ToString() + ")";
                pNum = (float)Math.Log(pNum);
                lNum = 0;
            }
            else if (pButton == 3)
            {
                textBox1.Text = ((float)Math.Log(pNum)).ToString();
                allEqual.Text = "ln(" + pNum.ToString() + ")";
                pNum = (float)Math.Log(pNum);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void log10_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)
            {
                textBox1.Text = ((float)Math.Log10(pNum)).ToString();
                allEqual.Text = "log(" + pNum.ToString() + ")";
                pNum = (float)Math.Log(pNum);
            }
            else if (pButton == 1 && op != 0)
            {
                switch (op)
                {
                    case 1:
                        allEqual.Text = pNum.ToString() + " + " + "log(" + lNum.ToString() + ")";
                        break;
                    case 2:
                        allEqual.Text = pNum.ToString() + " - " + "log(" + lNum.ToString() + ")";
                        break;
                    case 3:
                        allEqual.Text = pNum.ToString() + " * " + "log(" + lNum.ToString() + ")";
                        break;
                    case 4:
                        allEqual.Text = pNum.ToString() + " / " + "log(" + lNum.ToString() + ")";
                        break;
                }
                lNum = (float)Math.Log10(lNum);
                cal();
                lNum = 0;
            }
            else if (pButton == 2 && singleFlag == 1)
            {
                textBox1.Text = ((float)Math.Log10(pNum)).ToString();
                allEqual.Text = "log(" + pNum.ToString() + ")";
                pNum = (float)Math.Log10(pNum);
                lNum = 0;
            }
            else if (pButton == 3)
            {
                textBox1.Text = ((float)Math.Log10(pNum)).ToString();
                allEqual.Text = "log(" + pNum.ToString() + ")";
                pNum = (float)Math.Log10(pNum);
                lNum = 0;
            }
            flag = 1;
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 1;
            paiFlag = 0;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (pButton == 1 && op == 0)//pre button is num
            {
                flag = 1;
                op = 5;
                textBox1.Text = "";
                allEqual.Text += " Mod ";
            }
            else if (pButton == 1 && op != 0)
            {
                cal();
                allEqual.Text = pNum.ToString() + " Mod ";
                textBox1.Text = pNum.ToString();
                lNum = 0;
                flag = 1;
                op = 5;
            }
            else if (pButton == 2 && op == 0)
            {
                allEqual.Text = pNum.ToString() + " Mod ";
                textBox1.Text = "";
                flag = 1;
                op = 5;
            }
            else if (pButton == 2 && op != 0)
            {
                allEqual.Text = pNum.ToString() + " Mod ";
                textBox1.Text = "";
                flag = 1;
                op = 5;
            }
            else if (pButton == 3)//pre button is equal
            {
                allEqual.Text = pNum.ToString() + " Mod ";
                textBox1.Text = "";
                lNum = 0;
                flag = 1;
                op = 5;
            }
            pButton = 2;
            pCount = (float)0.1;
            pointModel = 0;
            pFlag = 0;
            singleFlag = 0;
            paiFlag = 0;
        }

        private void pai_Click(object sender, EventArgs e)
        {
            if (paiFlag == 0 && pButton != 1) 
            {
                if (pButton == 3) 
                {
                    reset();
                    pNum = (float)3.1415926;
                    textBox1.Text = pNum.ToString();
                    allEqual.Text = pNum.ToString();
                }
                else if (singleFlag != 1)
                {
                    if (pButton != 1 && flag == 0)
                    {
                        pNum = (float)3.1415926;
                        textBox1.Text = pNum.ToString();
                        allEqual.Text = pNum.ToString();
                    }
                    else if (pButton == 2 && flag == 1)
                    {
                        lNum = (float)3.1415926;
                        textBox1.Text = lNum.ToString();
                        allEqual.Text += lNum.ToString();
                    }
                }
                else
                {
                    reset();
                    pNum = (float)3.1415926;
                    textBox1.Text = pNum.ToString();
                    allEqual.Text = pNum.ToString();
                }
                pButton = 1;
                pCount = (float)0.1;
                pointModel = 0;
                pFlag = 0;
                singleFlag = 0;
                ac = 1;
                flag = 1;
                paiFlag = 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();//about
            
            frm2.StartPosition = FormStartPosition.Manual;
            Point p = this.Location;
            p.X += 40;
            p.Y += 70;
            frm2.Location = p;
            frm2.ShowDialog();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();//about
            frm3.StartPosition = FormStartPosition.Manual;
            Point p = this.Location;
            p.X += 40;
            p.Y += 70;
            frm3.Location = p;
            frm3.ShowDialog();
        }
    }
}
