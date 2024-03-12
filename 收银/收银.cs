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
    public partial class 收银 : Form
    {
        string wid;
        public 收银(string wid)
        {
            InitializeComponent();
            this.wid = wid;
        }

        private void 新增收银_Click(object sender, EventArgs e)
        {
            会员确认 会员确认 = new 会员确认(wid);
            会员确认.ShowDialog();
        }
    }
}
