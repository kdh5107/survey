using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string q1result = GetQ1Info();
            string q2result = GetQ2Info();
            string q3result = GetQ3Info();
            if(q1result!="" && q2result!="" && q3result != "")
            {
                string result = string.Format("1번 : {0}, 2번 : {1}, 3번 : {2}, 4번 : {3}", q1result, q2result, q3result, q4.Text);
                MessageBox.Show("설문에 참여하셨습니다\n설문내용\n" + result, "알림", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("문항에 전부 답변해주십시오.");
            }

            this.Close();

        }

        private string GetQ3Info()
        {
            if (q3_1.Checked) { return q3_1.Text; }
            if (q3_2.Checked) { return q3_2.Text; }
            if (q3_3.Checked) { return q3_3.Text; }
            if (q3_4.Checked) { return q3_4.Text; }
            if (q3_5.Checked) { return q3_5.Text; }
            return "";
        }

        private string GetQ2Info()
        {
            if (q2_1.Checked) { return q2_1.Text; }
            if (q2_2.Checked) { return q2_2.Text; }
            if (q2_3.Checked) { return q2_3.Text; }
            if (q2_4.Checked) { return q2_4.Text; }
            if (q2_5.Checked) { return q2_5.Text; }
            return "";
        }

        private string GetQ1Info()
        {
            if (q1_1.Checked) { return q1_1.Text; }
            if (q1_2.Checked) { return q1_2.Text; }
            if (q1_3.Checked) { return q1_3.Text; }
            if (q1_4.Checked) { return q1_4.Text; }
            if (q1_5.Checked) { return q1_5.Text; }
            return "";
        }


    }
}
