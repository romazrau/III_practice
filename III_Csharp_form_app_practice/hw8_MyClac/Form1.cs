using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw8_MyClac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string showText = "0";
        clsClac clacContainer = new clsClac();

        void updataShow()
        {
            labShow.Text = showText;
        }

        void addItem(string i)
        {
            showText += i;
            clacContainer.inputNum(i);
            updataShow();
        }

        void operatorInput(string operString, int oper )
        {
            showText = clacContainer.getCalculateResult(operString, oper);
            updataShow();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addItem("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addItem("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addItem("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addItem("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addItem("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addItem("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addItem("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addItem("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addItem("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addItem("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!(showText[showText.Length - 1].ToString().Equals(".")))
            {
                addItem(".");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operatorInput("+", (int)clacAction.plus);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operatorInput("-", (int)clacAction.minus);
        }

        private void btnMutify_Click(object sender, EventArgs e)
        {
            operatorInput("x", (int)clacAction.mutify);
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            operatorInput("/", (int)clacAction.divided);
        }

        private void btnSquared_Click(object sender, EventArgs e)
        {
            showText = clacContainer.squareCalc();
            updataShow();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            showText = clacContainer.Ans();
            updataShow();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            showText = "0";
            updataShow();
            clacContainer.clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            showText =  clacContainer.remove(showText);
            if (showText == "") showText = "0";
            updataShow();
        }
    }
}
