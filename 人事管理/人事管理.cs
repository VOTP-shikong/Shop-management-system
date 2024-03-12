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
    public partial class 人事管理 : Form
    {
        public 人事管理()
        {
            InitializeComponent();
        }

        private void 新增员工_Click(object sender, EventArgs e)
        {
            新增员工 新增员工 = new 新增员工();
            新增员工.ShowDialog();
        }

        private void 员工信息修改_Click(object sender, EventArgs e)
        {
            员工信息修改 员工信息修改 = new 员工信息修改();
            员工信息修改.ShowDialog();
        }
    }
}
