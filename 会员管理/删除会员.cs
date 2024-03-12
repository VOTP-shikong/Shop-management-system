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
    public partial class 删除会员 : Form
    {
        public 删除会员()
        {
            InitializeComponent();
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            //string vid = ID输入.Text;
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string vname = 姓名输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber, vname))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                // 数据库中不存在相同的数据，执行插入操作
                string sqlStr = "delete from vip where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vnumber", vnumber)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    MessageBox.Show("删除成功");
                }
            }
        }
        private bool CheckIfDataExists(string vpassword, string vnumber, string vname)//存在检查
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from vip where vpassword = @vpassword and vnumber = @vnumber and vname = @vname";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@vpassword", vpassword),
                new MySqlParameter("@vnumber", vnumber),
                new MySqlParameter("@vname", vname)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }
    }
}
