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

        //單數處理區---------------------------------------------------------------
        public bool isTboxNumWrong()
        {
            if (tboxNum.Text == "")
            {
                MessageBox.Show("請輸入數字");
                return true;
            }
            return false;
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            if (isTboxNumWrong()) return;
            labShowResult.Text = int.Parse(tboxNum.Text) % 2 == 0 ? "是偶數喔" : "是奇數ㄟ";
        }

        private void btnXmasTree_Click(object sender, EventArgs e)
        {
            if (isTboxNumWrong()) return;
            string output = "";
            int height = int.Parse(tboxNum.Text);
            int MaxWidth = height * 2 - 1;
            for (int i = 1; i <= height; i++)
            {
                for(int j= 0; j < ((MaxWidth - (i * 2 - 1))/2); j++)
                {
                    output += "\b";
                }
                for (int j = 0; j <  (i * 2 - 1); j++)
                {
                    output += "*";
                }
                for (int j = 0; j < ((MaxWidth - (i * 2 - 1))/2); j++)
                {
                    output += "\b";
                }
                output += "\n";
            }
            labShowResult.Text = output;
        }

        private void btnNum2binary_Click(object sender, EventArgs e)
        {
            if (isTboxNumWrong()) return;
            labShowResult.Text = Convert.ToString(int.Parse(tboxNum.Text), 2);
        }

        private void btnLotto6_Click(object sender, EventArgs e)
        {
            Random crandom = new Random(Guid.NewGuid().GetHashCode());  //https://ksjolin.pixnet.net/blog/post/150115680
            List<int> container = new List<int>();
            container.Add(crandom.Next(49));
            while(container.Count < 6)
            {
                int i = crandom.Next(49);
                if (!container.Contains(i))
                {
                    container.Add(i);
                }
            }
            labShowResult.Text = "樂透號碼:\n";
            foreach(int i in container)
            {
                labShowResult.Text += $"{i}\b";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "九九乘法表\n";
            for(int i = 1; i < 10; i++)
            {
                for(int j = 2; j < 10; j++)
                {
                    result += $"{j} x {i} =" + string.Format("{0:2}|", j*i);
                }
                result += "\n";
            }
            labShowResult.Text = result;
        }


        //Loop 處理區--------------------------------------------------------------------------
        int loopFrom;
        int loopTo;
        int loopStep;
        void updataFTS()
        {
            loopFrom = int.Parse(tboxFromLoop.Text);
            loopTo = int.Parse(tboxToLoop.Text);
            loopStep = int.Parse(tboxStepLoop.Text);
       }
        
        bool isTboxLoopWrong()
        {
            if (tboxFromLoop.Text == "" || tboxToLoop.Text == "" || tboxStepLoop.Text == "")
            {
                MessageBox.Show("欄位不可以為空");
                return true;
            }
            return false;
        }

        private void btnLoopFor_Click(object sender, EventArgs e)
        {
            if (isTboxLoopWrong()) return;
            updataFTS();
            int total = 0;
            for(int i = loopFrom; i<(loopTo+1); i+= loopStep){
                total += i;
            }
            labShowResult.Text = $"{loopFrom} 到 {loopTo} 間格 {loopStep}\n加總為: {total}";
        }

        private void btnLoopWhile_Click(object sender, EventArgs e)
        {
            if (isTboxLoopWrong()) return;
            updataFTS();
            int total = 0;
            int i = loopFrom;
            while(i<(loopTo+1))
            {
                total += i;
                i += loopStep;
            }
            labShowResult.Text = $"{loopFrom} 到 {loopTo} 間格 {loopStep}\n加總為: {total}";
        }

        private void btnLoopDo_Click(object sender, EventArgs e)
        {
            if (isTboxLoopWrong()) return;
            updataFTS();
            int total = 0;
            int i = loopFrom;
            do
            {
                total += i;
                i += loopStep;
            } while (i < (loopTo+1));
            labShowResult.Text = $"{loopFrom} 到 {loopTo} 間格 {loopStep}\n加總為: {total}";
        }
    }
}
