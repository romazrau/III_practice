using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw10_XOGame
{
    enum XO
    {
        O = 0,
        X = 1,
    }
    class clsXOdata
    {
        int player = (int)XO.O;
        List<int> oList = new List<int>();
        List<int> xList = new List<int>();

        public string btnClicked(List<int> nums)
        {
            player = (player == (int)XO.O) ? (int)XO.X : (int)XO.O;

            if(player == (int)XO.O)
            {
                oList.AddRange(nums.ToArray());
                oList.Sort();
            }
            else
            {
                xList.AddRange(nums.ToArray());
                xList.Sort();
            }

            return (player == (int)XO.O) ? "O" : "X";
        }

        public bool isOver()
        {
            int count = 1;           //是否連線
            int xtemp = xList[0];    //記錄迴圈正在count的數字
            for (int i=1; i<xList.Count(); i++)
            {
                if(xtemp == xList[i])
                {
                    count++;
                    if (count == 3)
                    {
                        MessageBox.Show("X 手獲勝!");
                        return true;
                    }
                }
                else
                {
                    xtemp = xList[i];
                    count = 1;
                }
            }

            if (oList.Count() == 0) return false;

            count = 1;
            int otemp = oList[0];
            for (int i = 1; i < oList.Count(); i++)
            {
                if (otemp == oList[i])
                {
                    count++;
                    if (count == 3)
                    {
                        MessageBox.Show("O 手獲勝!");
                        return true;
                    }
                }
                else
                {
                    otemp = oList[i];
                    count = 1;
                }
            }
            return false;
        }
        public void resetData()
        {
            player = (int)XO.O;
            oList = new List<int>();
            xList = new List<int>();
        }

    }
}
