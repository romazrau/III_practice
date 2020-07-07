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

            //listview示範程式碼
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

        bool isInputHasNull()
        {
            if (tboxName.Text == "")
            {
                MessageBox.Show("名字忘了填欸");
                return true;
            }

            if (tboxChineseScore.Text == "")
            {
                MessageBox.Show("國文成績?");
                return true;
            }

            if (tboxEnglishScore.Text == "")
            {
                MessageBox.Show("英文成績?");
                return true;
            }

            if (tboxMathScore.Text == "")
            {
                MessageBox.Show("數學成績?");
                return true;
            }
            return false;
        }

        void tboxInputClear()
        {
            tboxName.Text = "";
            tboxChineseScore.Text = "";
            tboxEnglishScore.Text = "";
            tboxMathScore.Text = "";
        }

        public void updataScoreListView(List<ListViewItem> ListItemOfScore)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(ListItemOfScore.ToArray());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (isInputHasNull())
            {
                return;
            }

            updataScoreListView(scoreContainer.saveData(tboxName.Text,
                           int.Parse(tboxChineseScore.Text),
                           int.Parse(tboxEnglishScore.Text),
                           int.Parse(tboxMathScore.Text)));

            tboxInputClear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (isInputHasNull())
            {
                return;
            }

            updataScoreListView(scoreContainer.saveData(tboxName.Text,
                           int.Parse(tboxChineseScore.Text),
                           int.Parse(tboxEnglishScore.Text),
                           int.Parse(tboxMathScore.Text),
                           true));

            tboxInputClear();
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            int[] randomG = getRandomGrade();
            int name = scoreContainer.getCount() + 1;
            updataScoreListView(scoreContainer.saveData(name.ToString(), randomG[0], randomG[1], randomG[2]));
        }


        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            updataScoreListView(scoreContainer.removeLastScorse());
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
            btnInsert.Enabled = false;
            btnShowStatistic.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listViewStatistic.Items.Clear();
            scoreContainer.reset();

            btnSave.Enabled = true;
            btnAddRandom.Enabled = true;
            btnInsert.Enabled = true;
            btnShowStatistic.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("沒有資料喔");
                return;
            }

            if (tboxSearchLower.Text == "" || tboxSearchUpper.Text == "" || int.Parse(tboxSearchLower.Text) >int.Parse(tboxSearchUpper.Text))
            {
                MessageBox.Show("搜尋錯誤");
                return;
            }
            updataScoreListView(scoreContainer.search(int.Parse(tboxSearchLower.Text), int.Parse(tboxSearchUpper.Text)));
        }

    }
}
