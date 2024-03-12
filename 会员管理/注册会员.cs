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
    public partial class 注册会员 : Form
    {
        public 注册会员()
        {
            InitializeComponent();
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            //string vid = ID输入.Text;
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string vname = 姓名输入.Text;

            if (!CheckIfDataExists(vnumber))
            {
                // 数据库中不存在相同的数据，执行插入操作
                string sqlStr = "insert into vip (vpassword, vnumber, vname, score, balance) values (@vpassword, @vnumber, @vname, 0, 0)";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vpassword", vpassword),
                    new MySqlParameter("@vnumber", vnumber),
                    new MySqlParameter("@vname", vname)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                    MySqlParameter[] para_2 = new MySqlParameter[]
                    {
                        new MySqlParameter("@vnumber", vnumber)
                    };
                    DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2,para_2);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                    }
                    MessageBox.Show("添加成功");
                }
            }
            else
            {
                MessageBox.Show("手机号已存在，无法注册");
            }
        }

        private bool CheckIfDataExists(string vnumber)//手机号查重
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from vip where vnumber = @vnumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@vnumber", vnumber)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }
    }
}
