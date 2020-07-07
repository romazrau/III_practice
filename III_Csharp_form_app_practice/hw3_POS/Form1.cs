using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw3_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsForFoodLogic foodLogic = new clsForFoodLogic();

        void updataForm()
        {
            labList.Text = foodLogic.GetList();
            labTotal.Text = foodLogic.GetTotal().ToString();
        }

        private void btnM270_Click(object sender, EventArgs e)
        {
            foodLogic.plusM270();
            updataForm();
        }

        private void btnM520_Click(object sender, EventArgs e)
        {
            foodLogic.plusM520();
            updataForm();
        }

        private void btnM710_Click(object sender, EventArgs e)
        {
            foodLogic.plusM710();
            updataForm();
        }

        private void btnM130_Click(object sender, EventArgs e)
        {
            foodLogic.plusM130();
            updataForm();
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + foodLogic.GetTotal(), "確認付款", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnPayCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("總金額: NT$" + foodLogic.GetTotal() + "\n折扣後金額: NT$" + foodLogic.GetTotal()*0.9, "確認付款", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            foodLogic.clearList();
            updataForm();
            labList.Text = "尚未點餐";
        }
    }
}
