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
    public partial class 会员确认 : Form
    {
        string wid;
        public 会员确认(string wid)
        {
            this.wid = wid;
            InitializeComponent();
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            string vnumber = 手机号输入.Text;
            string vpassword = 密码输入.Text;

            // 检查数据库中是否已经存在相同的数据
            if (!CheckIfDataExists(vnumber, vpassword))
            {
                MessageBox.Show("ID或密码错误");
            }
            else
            {
                string sqlStr = "select vid from vip where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vnumber", vnumber)
                };
                string vid = MySqlHelper.getsomething(sqlStr, para);
                收银订单处理 收银订单处理 = new 收银订单处理(wid,vid);
                收银订单处理.ShowDialog();
                this.Close();
            }
        }
        private bool CheckIfDataExists(string vnumber, string vpassword)//登录时的id与密码匹配
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from vip where vnumber = @vnumber and vpassword = @vpassword";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@vnumber", vnumber),
                new MySqlParameter("@vpassword", vpassword)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }

        private void 非会员按钮_Click(object sender, EventArgs e)
        {
            收银订单处理 收银订单处理 = new 收银订单处理(wid, "0");
            收银订单处理.ShowDialog();
            this.Close();
        }
    }
}
