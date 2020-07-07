using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_student_structForm
{
    class clsScore
    {
        public string name;
        public int ChineseScore;
        public int EnglishScore;
        public int MathScore;

        //public clsScore(string na, int ch, int en, int ma)
        //{
        //    name = na;
        //    ChineseScore = ch;
        //    EnglishScore = en;
        //    MathScore = ma;
        //}

        public string getSaved()
        {
            return $"姓名 : {name}\n" +
                $"國文 : {ChineseScore}\n" +
                $"英文 : {EnglishScore}\n" +
                $"數學 : {MathScore}";
        }

        public string getOutlier()
        {
            string maxScore = ChineseScore > EnglishScore ?
                (ChineseScore > MathScore ? $"國文{ChineseScore}分" : $"數學{MathScore}分") :
                (EnglishScore > MathScore ? $"英文{EnglishScore}分" : $"數學{MathScore}分");

            string minScore = ChineseScore < EnglishScore ?
                (ChineseScore < MathScore ? $"國文{ChineseScore}分" : $"數學{MathScore}分") :
                (EnglishScore < MathScore ? $"英文{EnglishScore}分" : $"數學{MathScore}分");

            return $"最高科目成績為: {maxScore}\n最低科目成績為: {minScore}";

        }
    }
}
