using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw8_MyClac
{
    public enum clacAction
    {
        none = 0,
        plus = 1,
        minus = 2,
        mutify = 3,
        divided = 4,
        squared = 5,
    }

    class clsClac
    {

        double totalNum = 0;
        string inputingString = "";
        int OperaterReady = (int)clacAction.none; 

        public void inputNum(string i)
        {
            inputingString += i;
        }

        void UpdataTotalNum()
        {
            switch (OperaterReady) //處理上一次運算子與顯示下一次運算子
            {
                case (int)clacAction.plus:
                    totalNum += double.Parse(inputingString);
                    break;
                case (int)clacAction.minus:
                    totalNum -= double.Parse(inputingString);
                    break;
                case (int)clacAction.mutify:
                    totalNum *= double.Parse(inputingString);
                    break;
                case (int)clacAction.divided:
                    totalNum /= double.Parse(inputingString);
                    break;
            }
            totalNum = Math.Round(totalNum, 4);
            inputingString = "";
        }

        public string squareCalc()  //不同於其他，平方運算直接顯示結果
        {
            if(OperaterReady == (int)clacAction.none)
            {
                totalNum = double.Parse(inputingString);
            }
            else if (OperaterReady != (int)clacAction.none && inputingString != "")
            {
                UpdataTotalNum();
            }

            double result = Math.Pow(totalNum, 2);
            inputingString = Math.Round(result, 4).ToString();
            OperaterReady = (int)clacAction.none;
            totalNum = 0;
            return inputingString;
        }

        public string getCalculateResult(string operStr, int oper)
        {
            if (inputingString == "") //處理更改運算子事件
            {
                OperaterReady = oper;
                return $"{totalNum.ToString()}\b{operStr}\b";
            }

            if (OperaterReady == (int)clacAction.none) //第一個運算子輸入事件
            {
                totalNum = double.Parse(inputingString);

                OperaterReady = oper;
                inputingString = "";
                return $"{totalNum.ToString()}\b{operStr}\b";
            }

            UpdataTotalNum();   //處理上一次運算子與顯示下一次運算子
  
            OperaterReady = oper;
            return $"{totalNum}\b{operStr}\b";
        }

        public string Ans()
        {
            if(OperaterReady == (int)clacAction.none)
            {
                return inputingString;
            }
            else if (!(inputingString == ""))
            {
                UpdataTotalNum();
            }

            OperaterReady = (int)clacAction.none;
            inputingString = totalNum.ToString();
            totalNum = 0;
            return inputingString;
        }

        public void clear()
        {
            inputingString = "";
            totalNum = 0;
            OperaterReady = (int)clacAction.none;
        }

        public string remove(string output)
        {
            if (inputingString == "" && (!(OperaterReady == (int)clacAction.none)))
            {
                OperaterReady = (int)clacAction.none;
                inputingString = totalNum.ToString();
                totalNum = 0;
            }else if (OperaterReady == (int)clacAction.none)
            {
                if (inputingString == "") return "";
                inputingString = inputingString.Substring(0, inputingString.Length - 1);     
            }
            else 
            {
                inputingString = inputingString.Substring(0, inputingString.Length - 1);
                return output.Substring(0, output.Length - 1);
            }
        
            return inputingString;
        }

    }
}
