using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2_Loan
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        double funcMonthPay(double orig, double time, double rate, double prepay)
        {
            //每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            //(公式中：月利率 ＝ 年利率／12 ； 月數 = 貸款年期 ｘ 12)
            double monthRate = rate / 100 /12;
            double month = time * 12;
            double monthPay;
            if(rate == 0)
            {
                monthPay = (orig - prepay) / month;
            }
            else
            {
                monthPay = (orig - prepay) *
                (Math.Pow((1 + monthRate), month) * monthRate) /
                (Math.Pow((1 + monthRate), month) - 1);
            }
            return monthPay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int getm = Convert.ToInt32(funcMonthPay(double.Parse(tboxOrig.Text), double.Parse(tboxTime.Text), double.Parse(tboxRate.Text), double.Parse(tboxPrePay.Text)));
            MessageBox.Show("月付額: " + getm.ToString() + "元"); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int getm = (int)(double.Parse(tboxTime.Text)* 12 * Convert.ToInt32(funcMonthPay(double.Parse(tboxOrig.Text), double.Parse(tboxTime.Text), double.Parse(tboxRate.Text), double.Parse(tboxPrePay.Text))));
            MessageBox.Show("總付額: " + getm.ToString() + "元"); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int getm = Convert.ToInt32(funcMonthPay(double.Parse(tboxOrig.Text), double.Parse(tboxTime.Text), double.Parse(tboxRate.Text), double.Parse(tboxPrePay.Text)));
            int gety = (int)(double.Parse(tboxTime.Text) * 12 * Convert.ToInt32(funcMonthPay(double.Parse(tboxOrig.Text), double.Parse(tboxTime.Text), double.Parse(tboxRate.Text), double.Parse(tboxPrePay.Text))));

            pop_form formPop = new pop_form(
                tboxOrig.Text, tboxTime.Text, tboxRate.Text, tboxPrePay.Text,
                getm.ToString(), gety.ToString()
                );
            formPop.Show();


        }
    }
}
