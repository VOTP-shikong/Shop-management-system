using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_management_system
{
    public partial class Form2 : Form
    {
        string wid;
        string position;
        public Form2(string wid,string position)
        {
            this.wid = wid;
            this.position = position;
            InitializeComponent();
        }

        private void 进货管理_Click(object sender, EventArgs e)
        {
            if(position=="数据库管理员"|| position== "仓储管理员")
            {
                进货管理 进货管理 = new 进货管理(wid);
                进货管理.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有此操作的权限");
            }
        }

        private void 会员管理_Click(object sender, EventArgs e)
        {
            if (position == "数据库管理员" || position == "前台")
            {
                会员管理 会员管理 = new 会员管理();
                会员管理.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有此操作的权限");
            }
        }

        private void 收银_Click(object sender, EventArgs e)
        {
            if(position == "数据库管理员" || position == "收银员")
            {
                收银 收银 = new 收银(wid);
                收银.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有此操作的权限");
            }
        }

        private void 人事管理_Click(object sender, EventArgs e)
        {
            if (position == "数据库管理员" || position == "经理")
            {
                人事管理 人事管理 = new 人事管理();
                人事管理.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有此操作的权限");
            }
        }

        private void 售价管理按钮_Click(object sender, EventArgs e)
        {
            if (position == "数据库管理员" || position == "经理")
            {
                售价管理 售价管理 = new 售价管理();
                售价管理.ShowDialog();
            }
            else
            {
                MessageBox.Show("您没有此操作的权限");
            }
        }
    }
}
