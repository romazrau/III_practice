using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_Method
{
    class clsStringTool
    {
        ArrayList list = new ArrayList();

        public string add(string item)
        {
            list.Add(item);
            string resultText = "";
            foreach(string i in list)
            {
                resultText += $"{i}\b";
            }
            return resultText;
        }

        public string getLongest()
        {
            string longest = "";
            foreach(string i in list)
            {
                if (i.Length > longest.Length) longest = i;
            }
            return longest;
        }

        public int getNumOfC()
        {
            int count = 0;
            for (int i=0; i < list.Count; i++)
            {
                foreach (char j in list[i].ToString().ToLower())
                {
                    if (j.ToString() == "c") count++;
                }
            }
            return count;
        }
    }
}
