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
    public partial class 积分管理 : Form
    {
        public 积分管理()
        {
            InitializeComponent();
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                MySqlParameter[] para_2 = new MySqlParameter[]
                {
                        new MySqlParameter("@vnumber", vnumber)
                };
                DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                }
            }
        }
        private bool CheckIfDataExists(string vpassword, string vnumber)//存在检查
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from vip where vpassword = @vpassword and vnumber = @vnumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@vpassword", vpassword),
                new MySqlParameter("@vnumber", vnumber),
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }

        private void 增加按钮_Click(object sender, EventArgs e)
        {
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string score = 更改值输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                string sqlStr = "update vip set score = score + @score where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vpassword", vpassword),
                    new MySqlParameter("@vnumber", vnumber),
                    new MySqlParameter("@score", score)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    MessageBox.Show("修改成功");
                }
                string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                MySqlParameter[] para_2 = new MySqlParameter[]
                {
                        new MySqlParameter("@vnumber", vnumber)
                };
                DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                }
            }
        }

        private void 减少按钮_Click(object sender, EventArgs e)
        {
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string score = 更改值输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                string sqlStr = "update vip set score = score - @score where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vpassword", vpassword),
                    new MySqlParameter("@vnumber", vnumber),
                    new MySqlParameter("@score", score)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    MessageBox.Show("修改成功");
                }
                string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                MySqlParameter[] para_2 = new MySqlParameter[]
                {
                        new MySqlParameter("@vnumber", vnumber)
                };
                DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                }
            }
        }

        private void 余额增加按钮_Click(object sender, EventArgs e)
        {
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string balance = 余额更改值输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                string sqlStr = "update vip set balance = balance + @balance where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vpassword", vpassword),
                    new MySqlParameter("@vnumber", vnumber),
                    new MySqlParameter("@balance", balance)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    MessageBox.Show("修改成功");
                }
                string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                MySqlParameter[] para_2 = new MySqlParameter[]
                {
                        new MySqlParameter("@vnumber", vnumber)
                };
                DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                }
            }
        }

        private void 余额减少按钮_Click(object sender, EventArgs e)
        {
            string vpassword = 密码输入.Text;
            string vnumber = 手机号输入.Text;
            string balance = 余额更改值输入.Text;

            if (!CheckIfDataExists(vpassword, vnumber))
            {
                MessageBox.Show("会员不存在");
            }
            else
            {
                string sqlStr = "update vip set balance = balance - @balance where vnumber = @vnumber";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vpassword", vpassword),
                    new MySqlParameter("@vnumber", vnumber),
                    new MySqlParameter("@balance", balance)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    MessageBox.Show("修改成功");
                }
                string sqlStr_2 = "select * from vip where vnumber = @vnumber";
                MySqlParameter[] para_2 = new MySqlParameter[]
                {
                        new MySqlParameter("@vnumber", vnumber)
                };
                DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
                if (ds != null && ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                    //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                }
            }
        }
    }
}
