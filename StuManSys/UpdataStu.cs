using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace StuManSys
{
    public partial class Update : Form
    {
        ArrayList arrLstID;
        int pos = 0;
        Opreate op = new Opreate();
        public Update()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Settxt(DataTable dt) //从数据库获得数据
        {
            string Scholarship;
            //if (bool.Parse(dt.Rows[0]["有否奖学金"].ToString()) == true)
            if (dt.Rows[0]["有否奖学金"].ToString() == "1")
                Scholarship = "是";
            else
            {
                Scholarship = "否";
            }
            NumText.Text = dt.Rows[0]["学号"].ToString();
            NameText.Text = dt.Rows[0]["姓名"].ToString();
            Sex.Text = dt.Rows[0]["性别"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["出生日期"].ToString());
            SpecialText.Text = dt.Rows[0]["民族"].ToString();
            JGText.Text = dt.Rows[0]["籍贯"].ToString();
            RXCJText.Text = dt.Rows[0]["入学成绩"].ToString();
            MajorCombo.Text = dt.Rows[0]["专业名称"].ToString();
            MoneyCombo.Text = Scholarship;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("select 学号 from Stu", "Stu");        
            string[] arrID;
            arrID = new string[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
                arrID[i] = dt.Rows[i]["学号"].ToString();
            arrLstID = new ArrayList(arrID);  // array changes to arrayList
            Sex.DataSource= op.GetDataTable("select distinct 性别 from Stu ", "Stu");
            Sex.DisplayMember = "性别";
            Sex.SelectedIndex = -1;

            MajorCombo.DataSource = op.GetDataTable("select distinct 专业名称 from Stu", "Stu");
            MajorCombo.DisplayMember = "专业名称";
            MajorCombo.SelectedIndex = -1;
        }
        
        private void FirstButton_Click(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("select * from Stu where 学号='" + arrLstID[0] + "'", "Stu");
            pos = 0;
            Settxt(dt);
        }

        private void PreButton_Click(object sender, EventArgs e)
        {
            if (NumText.Text != "")
            {
                if (pos > 0)
                    pos--;
                else
                {
                    MessageBox.Show("已经是第一条了!");
                    return;
                }

                DataTable dt = op.GetDataTable("select  * from Stu where 学号='" + arrLstID[pos] + "'", "Stu");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (NumText.Text != "")
            {
                if (pos < arrLstID.Count - 1)
                    pos++;
                else
                {
                    MessageBox.Show("已经最后一条了！");
                    return;
                }
                DataTable dt = op.GetDataTable("select  * from Stu where 学号='" + arrLstID[pos] + "'", "Stu");
                Settxt(dt);
            }
            else
            {
                MessageBox.Show("操作有误！");
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            DataTable dt = op.GetDataTable("select * from Stu where 学号='" + arrLstID[arrLstID.Count - 1] + "'", "Stu");
            pos = arrLstID.Count - 1;
            Settxt(dt);
        }

        private void UpdataButton_Click(object sender, EventArgs e)
        {
            int Scholarship;
            if (MoneyCombo.Text == "是")
            {
                Scholarship = 1;
            }
            else
            {
                Scholarship = 0;
            }
            DateTime InDate = dateTimePicker1.Value;
            string sql = "update  Stu  set 姓名='" + NameText.Text + "',性别='" + Sex.Text + "',出生日期='" + InDate.ToString() + "',民族='" + SpecialText.Text + "',籍贯='" + JGText.Text + "',入学成绩='" + RXCJText.Text + "',专业名称='" + MajorCombo.Text + "',有否奖学金='" + Scholarship + "' where 学号='" + NumText.Text + "'";
            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("修改成功！");

            }
            else
            {
                MessageBox.Show("修改失败！");

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string sql = "delete from Stu  where 学号='" + arrLstID[pos] + "'";
            arrLstID.RemoveAt(pos);

            if (op.OPSQL(sql))
            {
                ClearText();
                MessageBox.Show("删除成功！");
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
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
    }
}
