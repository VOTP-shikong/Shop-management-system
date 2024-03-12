using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shop_management_system
{
    public partial class 会员管理 : Form
    {
        public 会员管理()
        {
            InitializeComponent();
        }

        private void 注册会员_Click(object sender, EventArgs e)
        {
            注册会员 注册会员 = new 注册会员();
            注册会员.ShowDialog();
        }

        private void 删除会员_Click(object sender, EventArgs e)
        {
            删除会员 删除会员 = new 删除会员();
            删除会员.ShowDialog();
        }

        private void 积分管理_Click(object sender, EventArgs e)
        {
            积分管理 积分管理 = new 积分管理();
            积分管理.ShowDialog();
        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            修改密码 修改密码 = new 修改密码();
            修改密码.ShowDialog();
        }

        private void 会员管理_Load(object sender, EventArgs e)
        {

        }
    }
}
