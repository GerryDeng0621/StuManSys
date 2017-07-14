using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StuManSys
{
    public partial class Query : Form
    {
        Opreate op = new Opreate();
        public Query()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)            //关闭窗口
        {
            this.Close();
            this.Dispose();
        }

        private void QueryButton_Click(object sender, EventArgs e)       //查询
        {

            DataTable dt = op.GetDataTable("select * from Stu where " + comboBox1.Text + " = '" + textBox1.Text + "'", "Stu");
            dataGridView1.DataSource = dt;
        }

        private void Query_Load_1(object sender, EventArgs e)             //加载数据库
         {
            dataGridView1.DataSource = op.GetDataTable("select* from Stu ", "Stu");
            comboBox1.DataSource = op.GetDataTable("select   name   from   syscolumns   where   id=object_id('Stu')", "Stu"); 
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedIndex = -1;
        }
    }
}
