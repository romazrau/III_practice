using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_introUself
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string output = "Hello, 我是" + tboxNameEngilsh.Text
                + ",\n英文名子是 " + tboxNameEngilsh.Text
                + ",\n性別是" + tboxGender.Text
                + ",\n星座是" + tboxStarS.Text
                + ",\n很高興認識你。";
            MessageBox.Show(output);

        }

        private void btnSqayHi_Click(object sender, EventArgs e)
        {
            string output = "Hi, 我是" + tboxNameEngilsh.Text
                + ",\n英文名子是 " + tboxNameEngilsh.Text
                + ",\n性別是" + tboxGender.Text
                + ",\n星座是" + tboxStarS.Text
                + ",\n很高興認識你。";
            MessageBox.Show(output);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
