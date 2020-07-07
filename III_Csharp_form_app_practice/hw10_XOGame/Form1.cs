using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace hw10_XOGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countTurn = 0;
        clsXOdata XOdata = new clsXOdata();


        void btnClick(Button btn, List<int> nums)
        {
            btn.Text = XOdata.btnClicked(nums);
            btn.Enabled = false;
            labTurn.Text = (btn.Text == "X") ? "O" : "X";
            if (XOdata.isOver())
            {
                resetGame();
            } 
            if(++countTurn == 9)
            {
                MessageBox.Show("平手! 按下確定重新開始");
                resetGame();
            }
        }
        void resetGame()
        {
            XOdata.resetData();
            labTurn.Text = "X";
            countTurn = 0;
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = "";
            //Application.Restart(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnClick(button1,
                new List<int> {1,4,7 }
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnClick(button2,
                new List<int> { 1,5 }
                );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnClick(button3,
                new List<int> { 1,6 ,8}
                );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnClick(button4,
                new List<int> { 2,4 }
                );
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnClick(button5,
                new List<int> { 2,5,7,8}
                );
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnClick(button6,
                new List<int> { 2,6 }
                );
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnClick(button7,
                new List<int> { 3,4 ,8}
                );
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnClick(button8,
                new List<int> { 3,5 }
                );
        }

        private void button9_Click(object sender, EventArgs e)
        {
            btnClick(button9,
                new List<int> { 3,6 ,7}
                );
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
            if (e.KeyCode == Keys.R) resetGame();
        }

    }
}
