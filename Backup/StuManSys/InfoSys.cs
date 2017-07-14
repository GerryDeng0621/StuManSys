using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuManSys
{
    public partial class InfoSys : Form
    {
        public InfoSys()
        {
            InitializeComponent();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adding a = new Adding();
            a.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update b = new Update();
            b.Show();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query c = new Query();
            c.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
