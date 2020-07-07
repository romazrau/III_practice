using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw5_studentGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.LabelEdit = false;
            //listView1.FullRowSelect = true;
            //for (int i = 0; i < 2; i++)
            //{
            //    var item = new ListViewItem($"No.{i}");
            //    item.SubItems.Add($"文字{i}");
            //    listView1.Items.Add(item);
            //}
        }

        clsScore scoreContainer = new clsScore();

        int[] getRandomGrade()
        {
            int[] result = new int[3];
            Random crandom = new Random(Guid.NewGuid().GetHashCode()); //https://ksjolin.pixnet.net/blog/post/150115680
            for (int i = 0; i<result.Length; i++)
            {
                result[i] = crandom.Next(100);
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (tboxName.Text == "")
            {
                MessageBox.Show("名字忘了填欸");
                return;
            }

            if (tboxChineseScore.Text == "")
            {
                MessageBox.Show("國文成績?");
                return;
            }
            
            if (tboxEnglishScore.Text == "")
            {
                MessageBox.Show("英文成績?");
                return;
            }

            if (tboxMathScore.Text == "")
            {
                MessageBox.Show("數學成績?");
                return;
            }

            listView1.Items.Add(scoreContainer.saveData(tboxName.Text, 
                int.Parse(tboxChineseScore.Text), 
                int.Parse(tboxEnglishScore.Text), 
                int.Parse(tboxMathScore.Text)));

            tboxName.Text = "";
            tboxChineseScore.Text = "";
            tboxEnglishScore.Text = "";
            tboxMathScore.Text = "";
        }

        private void btnShowStatistic_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("沒有資料喔");
                return;
            }

            listViewStatistic.Items.AddRange(scoreContainer.getStatistic());

            btnSave.Enabled = false;
            btnAddRandom.Enabled = false;
            btnAddRandom20.Enabled = false;
            btnShowStatistic.Enabled = false;
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            int[] randomG = getRandomGrade();
            int name = scoreContainer.getCount() + 1;
            listView1.Items.Add(scoreContainer.saveData(name.ToString(), randomG[0], randomG[1], randomG[2]));
        }

        private void btnAddRandom20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<20; i++)
            {
                int[] randomG = getRandomGrade();
                int name = scoreContainer.getCount() + 1;
                listView1.Items.Add(scoreContainer.saveData(name.ToString(), randomG[0], randomG[1], randomG[2]));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listViewStatistic.Items.Clear();
            scoreContainer.reset();

            btnSave.Enabled = true;
            btnAddRandom.Enabled = true;
            btnAddRandom20.Enabled = true;
            btnShowStatistic.Enabled = true;
        }
    }
}
