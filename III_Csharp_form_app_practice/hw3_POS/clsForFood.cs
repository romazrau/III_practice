using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_POS
{
    class clsForFoodLogic
    {
        int num_m270 = 0;
        int num_m520 = 0;
        int num_m710 = 0;
        int num_m130 = 0;
        int total = 0;

        public string GetList()
        {
            string MeauList = ""; 

            if(this.num_m270 > 0)
            {
                MeauList += "奴爾哈赤火鍋 x" + this.num_m270 + "共NT$ " + this.num_m270 * 270 + "元\n";
            }

            if (this.num_m520 > 0)
            {
                MeauList += "帕華洛帝義大利麵 x" + this.num_m520 + "共NT$ " + this.num_m520 * 520 + "元\n";
            }

            if (this.num_m710 > 0)
            {
                MeauList += "普通的飯糰 x" + this.num_m710 + "共NT$ " + this.num_m710 * 710 + "元\n";
            }

            if (this.num_m130 > 0)
            {
               MeauList += "帝王拿波海帶湯 x" + this.num_m130 + "共NT$ " + this.num_m130 * 130 + "元\n";
            }

            return MeauList;
        }

        public void plusM270()
        {
            num_m270++;
            total += 270;
        }

        public void plusM520()
        {
            num_m520++;
            total += 520;
        }

        public void plusM710()
        {
            num_m710++;
            total += 710;
        }

        public void plusM130()
        {
            num_m130++;
            total += 130;
        }

        public int GetTotal()
        {
            return total;
        }

        public void clearList()
        {
            this.num_m130 = 0;
            this.num_m270 = 0;
            this.num_m520 = 0;
            this.num_m710 = 0;
            this.total = 0;
        }

    }
}
