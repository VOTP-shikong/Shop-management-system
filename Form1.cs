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
    public partial class 登录界面 : Form
    {
        public 登录界面()
        {
            InitializeComponent();
        }

        private void 登录按钮_Click(object sender, EventArgs e)
        {
            string wid = ID输入.Text;
            string wpassword = 密码输入.Text;

            // 检查数据库中是否已经存在相同的数据
            if (!CheckIfDataExists(wid, wpassword))
            {
                MessageBox.Show("ID或密码错误");
            }
            else
            {
                string sqlStr = "select position from worker where wid = @wid";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@wid", wid)
                };
                string position = MySqlHelper.getposition(sqlStr, para);
                Form2 form2 = new Form2(wid, position);
                form2.ShowDialog(); // 显示 Form2 窗体
                this.Close();
            }
        }
        private bool CheckIfDataExists(string wid, string wpassword)//登录时的id与密码匹配
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from worker where wid = @wid and wpassword = @wpassword";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@wid", wid),
                new MySqlParameter("@wpassword", wpassword)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }
    }
}
