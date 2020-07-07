using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //1001區------------------------------------------------------------------------------
        bool isSide(int i, int lenght)
        {
            return (i == 0 || i == lenght - 1 ) ? true : false;
        } 

        string SquareArraaay2string(int[,] arr, int sideLen)
        {
            string resultText = "";
            for (int i = 0; i < sideLen; i++)
            {
                for (int j = 0; j < sideLen; j++)
                {
                    resultText += $"{arr[i, j]}\b";
                }
                resultText += "\n";
            };
            return resultText;
        }
         
        private void btnGraph1001_Click(object sender, EventArgs e)
        {
            int sideLen = 10;  
            int[,] result = new int[sideLen, sideLen];  
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for(int j=0; j<result.GetLength(1); j++)
                {
                    result[i, j] = isSide(i, sideLen) ? 1 : (isSide(j, sideLen) ? 1 : 0);
                }
            };

            labShowResult.Text = SquareArraaay2string(result, sideLen);

        }

        private void btnGraph0110_Click(object sender, EventArgs e)
        {
            int sideLen = 10;  
            int[,] result = new int[sideLen, sideLen];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = isSide(i, sideLen) ? 0 : (isSide(j, sideLen) ? 0 : 1);
                }
            };

            labShowResult.Text = SquareArraaay2string(result, sideLen);
        }

        private void btnGraph1010_Click(object sender, EventArgs e)
        {
            int sideLen = 10;  
            int[,] result = new int[sideLen, sideLen];
            int ctrl = 0; //控制項
            for (int i = 0; i < result.GetLength(0); i++)
            { 
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = (ctrl % 2 == 0) ? 1 : 0;
                    ctrl++;
                }
                ctrl++;
            };

            labShowResult.Text = SquareArraaay2string(result, sideLen);
        }

        //字串陣列區-------------------------------------------------------------
        clsStringTool stringtool = new clsStringTool();

        private void btnAddString_Click(object sender, EventArgs e)
        {
            if (tboxString.Text == "")
            {
                MessageBox.Show("請輸入名字");
                return;
            }
            labStringArray.Text = stringtool.add(tboxString.Text);
            tboxString.Text = "";
        }

        private void btnGetLongestString_Click(object sender, EventArgs e)
        {
            labShowResult.Text = $"最長的名字為: {stringtool.getLongest()}";
        }

        private void btnGetNumOfC_Click(object sender, EventArgs e)
        {
            labShowResult.Text = $"C或c共有 {stringtool.getNumOfC()} 個";
        }



        //數字陣列區--------------------------------------------------------
        clsNumTool NumTool = new clsNumTool();
        private void btnAddNum_Click(object sender, EventArgs e)
        {
            if (tboxNum.Text == "")
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            labNumArray.Text = NumTool.add(tboxNum.Text);
            tboxNum.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tboxNum.Text == "")
            {
                MessageBox.Show("請輸入數字");
                return;
            }
            labShowResult.Text = int.Parse(tboxNum.Text) % 2 == 0 ? "是偶數喔" : "是奇數ㄟ";
        }

        private void btnGetOdd_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getOddstatistic();
        }

        private void btnGetMaxMin_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getMaxMin();
        }

        private void btnArraySwap_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getSwap();
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getSum().ToString();
        }

        private void btnArrayMax_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getMax().ToString();
        }

        private void btnArrayMin_Click(object sender, EventArgs e)
        {
            labShowResult.Text = NumTool.getMin().ToString();
        }
    }
}
