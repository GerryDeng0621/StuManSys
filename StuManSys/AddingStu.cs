using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace StuManSys
{
    public partial class Adding : Form
    {
        Opreate op = new Opreate();
        public Adding()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        public void ClearText()//清空数据
        {
            NumText.Text = "";
            NameText.Text = "";
            Sex.Text = "";
            SpecialText.Text = "";
            JGText.Text = "";
            RXCJText.Text = "";
            MajorCombo.Text = "";
        }

        public int judge(string a)
        {
            int Scholarship;
            if (a == "是")
            {
                Scholarship = 1;
            }
            else
            {
                Scholarship = 0;
            }
            return Scholarship;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DateTime InDate = dateTimePicker1.Value;
            string sql = "insert into Stu(学号,姓名,性别,出生日期,民族,籍贯,入学成绩,专业名称,有否奖学金) values('" + NumText.Text + "','" + NameText.Text + "','" + Sex.Text + "','" + InDate.ToString() + "','" + SpecialText.Text + "','" + JGText.Text + "','" + float.Parse(RXCJText.Text) + "','" + MajorCombo.Text + "','" + judge(MoneyCombo.Text) + "')";
            if (NumText.Text != "")
            {
                if (op.OPSQL(sql))
                {
                    ClearText();
                    MessageBox.Show("新建成功！");
                }
                else
                {
                    MessageBox.Show("创建失败！");
                }
            }
            else
                MessageBox.Show("学号不能为空！");
        }

        private void Adding_Load_1(object sender, EventArgs e)
        {
            DataTable dt1 = op.GetDataTable("select distinct 性别 from Stu ", "Stu");
            Sex.DataSource = dt1;
            Sex.DisplayMember = "性别";
            Sex.SelectedIndex = -1;

            DataTable dt2 = op.GetDataTable("select distinct 专业名称 from Stu ", "Stu");
            MajorCombo.DataSource = dt2;
            MajorCombo.DisplayMember = "专业名称";
            MajorCombo.SelectedIndex = -1;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
