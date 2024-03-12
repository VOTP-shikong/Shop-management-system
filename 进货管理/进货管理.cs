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
    public partial class 进货管理 : Form
    {
        string wid;
        public 进货管理(string wid)
        {
            InitializeComponent();
            this.wid = wid;
        }

        private void 新增进货_Click(object sender, EventArgs e)
        {
            进货订单处理 进货订单处理 = new 进货订单处理(wid);
            进货订单处理.ShowDialog();
        }
    }
}
