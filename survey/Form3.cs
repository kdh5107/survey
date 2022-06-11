using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\도형\Documents\Data5.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SURVEYINFO where ID='"+ID.Text+"'and PASSWORD='"+PW.Text+"'", con);
            DataTable newTable = new DataTable();
            sda.Fill(newTable);
            if (newTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MessageBox.Show("설문이 확인되었습니다.");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("설문코드와 비밀번호를 확인하세요.");
            }
        }
    }
}
