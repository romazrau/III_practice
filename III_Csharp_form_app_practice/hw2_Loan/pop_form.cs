using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2_Loan
{
    public partial class pop_form : Form
    {
        public pop_form(string orig, string time, string rate, string prepay, string monthPay, string totalPay)
        {
            InitializeComponent();
            labOrig.Text = orig;
            labTime.Text = time;
            labRate.Text = rate;
            labPrepay.Text = prepay;
            labMonthPay.Text = monthPay;
            labTotalPay.Text = totalPay;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
