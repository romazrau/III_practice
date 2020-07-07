using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw4_student_structForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsScore scoreContainer = new clsScore();

        private void btnSave_Click(object sender, EventArgs e)
        {
            scoreContainer.name = tboxName.Text;
            scoreContainer.ChineseScore = int.Parse(tboxChineseScore.Text);
            scoreContainer.EnglishScore = int.Parse(tboxEnglishScore.Text);
            scoreContainer.MathScore = int.Parse(tboxMathScore.Text);

        }

        private void btnShowSaved_Click(object sender, EventArgs e)
        {
            labScore.Text = scoreContainer.getSaved();

        }

        private void btnShowOutlier_Click(object sender, EventArgs e)
        {
            labOutlier.Text = scoreContainer.getOutlier();

        }
    }
}
