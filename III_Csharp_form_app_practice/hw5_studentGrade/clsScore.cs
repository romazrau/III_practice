using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5_studentGrade
{
    class clsScore
    {
        int count = 0; 
        int totalChineseScore = 0;
        int maxChineseScore;
        int minChineseScore;

        int totalEnglishScore = 0;
        int maxEnglishScore;
        int minEnglishScore;

        int totalMathScore = 0;
        int maxMathScore;
        int minMathScore;

        public int getCount()
        {
            return count;
        }

        public void reset()
        {
            count = 0;
            totalChineseScore = 0;
            totalEnglishScore = 0;
            totalMathScore = 0;
        }

        public ListViewItem saveData(string name, int ChineseScore, int EnglishScore, int MathScore)
        {
            int personalTotal = ChineseScore + EnglishScore + MathScore;

            string maxScore = ChineseScore > EnglishScore ?
                (ChineseScore > MathScore ? $"國文{ChineseScore}" : $"數學{MathScore}") :
                (EnglishScore > MathScore ? $"英文{EnglishScore}" : $"數學{MathScore}");

            string minScore = ChineseScore < EnglishScore ?
                (ChineseScore < MathScore ? $"國文{ChineseScore}" : $"數學{MathScore}") :
                (EnglishScore < MathScore ? $"英文{EnglishScore}" : $"數學{MathScore}");

            //整體資料處理
            totalChineseScore += ChineseScore;
            totalEnglishScore += EnglishScore;
            totalMathScore += MathScore;

            if (count == 0)  //最大最小初始化
            {
                maxChineseScore = minChineseScore = ChineseScore;
                maxEnglishScore = minEnglishScore = EnglishScore;
                maxMathScore = minMathScore = MathScore;
            }
            else
            {
                if (maxChineseScore < ChineseScore) maxChineseScore = ChineseScore;
                if (minChineseScore > ChineseScore) minChineseScore = ChineseScore;

                if (maxEnglishScore < EnglishScore) maxEnglishScore = EnglishScore;
                if (minEnglishScore > EnglishScore) minEnglishScore = EnglishScore;

                if (maxMathScore < MathScore) maxMathScore = MathScore;
                if (minMathScore > MathScore) minMathScore = MathScore;
            }

            count++;


            //輸出
            var item = new ListViewItem(name);
            item.SubItems.Add(ChineseScore.ToString());
            item.SubItems.Add(EnglishScore.ToString());
            item.SubItems.Add(MathScore.ToString());
            item.SubItems.Add(personalTotal.ToString());
            item.SubItems.Add((personalTotal / 3).ToString());
            item.SubItems.Add(minScore.ToString());
            item.SubItems.Add(maxScore.ToString());
          
            return item;
        }

        public ListViewItem[] getStatistic()
        {
            var item = new ListViewItem("總分");
            item.SubItems.Add(totalChineseScore.ToString());
            item.SubItems.Add(totalEnglishScore.ToString());
            item.SubItems.Add(totalMathScore.ToString());

            var itemAvg = new ListViewItem("平均");
            itemAvg.SubItems.Add((totalChineseScore / count).ToString("F1"));
            itemAvg.SubItems.Add((totalEnglishScore / count).ToString("F1"));
            itemAvg.SubItems.Add((totalMathScore / count).ToString("F1"));

            var itemMax = new ListViewItem("最高分");
            itemMax.SubItems.Add(maxChineseScore.ToString());
            itemMax.SubItems.Add(maxEnglishScore.ToString());
            itemMax.SubItems.Add(maxMathScore.ToString());

            var itemMin = new ListViewItem("最低分");
            itemMin.SubItems.Add(minChineseScore.ToString());
            itemMin.SubItems.Add(minEnglishScore.ToString());
            itemMin.SubItems.Add(minMathScore.ToString());

            return new ListViewItem[] {item, itemAvg, itemMax, itemMin};
        }

    }
}
