using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw7_Method
{
    class clsNumTool
    {
        ArrayList list = new ArrayList();

        public string add(string item)
        {
            list.Add(int.Parse(item));
            string resultText = "";
            foreach (int i in list)
            {
                resultText += $"{i}\b";
            }
            return resultText;
        }

        public string getOddstatistic()
        {
            int numOodd = 0;
            int numOeven = 0;
            foreach(int i in list)
            {
                if(i % 2 == 0)
                {
                    numOeven++;
                }
                else
                {
                    numOodd++;
                }
            }

            return $"奇數共有: {numOodd}個\n偶數共有: {numOeven}個";
        }



        public string getMaxMin()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("請輸入陣列");
                return null;
            }
            int max = int.Parse(list[0].ToString());
            int min = int.Parse(list[0].ToString());
            foreach(int i in list.ToArray())
            {
                if (i > max) max = i;
                if (i < min) min = i;    
            }

            return $"最大值為: {max}\n最小值為: {min}";
        }

        public string getSwap()
        {
            if (!(list.Count == 2))
            {
                MessageBox.Show("陣列數目要是二個");
                return null;
            }
            object[] result = list.ToArray();
            object temp = result[0];
            result[0] = result[1];
            result[1] = temp;

            return $"{result[0]}\b{result[1]}";
        }

        public int getSum()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("請輸入陣列");
                return 0;
            }
            int result = 0;
            for(int i=0; i<list.Count; i++)
            {
                result += int.Parse(list[i].ToString());
            }
            return result;
        }

        public int getMax()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("請輸入陣列");
                return 0;
            }
            int max = int.Parse(list[0].ToString());
            foreach (int i in list.ToArray())
            {
                if (i > max) max = i;
            }
            return max;
        }

        public int getMin()
        {
            if (list.Count == 0)
            {
                MessageBox.Show("請輸入陣列");
                return 0;
            }
            int min = int.Parse(list[0].ToString());
            foreach (int i in list.ToArray())
            {
                if (i < min) min = i;
            }
            return min;
        }

    }
}
