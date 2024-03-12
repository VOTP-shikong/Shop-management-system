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
    public partial class 新增员工 : Form
    {
        public 新增员工()
        {
            InitializeComponent();
        }


        private bool CheckIfDataExists(string IDnumber)//身份证号查重
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from worker where IDnumber = @IDnumber";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@IDnumber", IDnumber)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }

        private void 确认按钮_Click_1(object sender, EventArgs e)
        {
            //string vid = ID输入.Text;
            string wpassword = 密码输入.Text;
            string wnumber = 手机号输入.Text;
            string wname = 姓名输入.Text;
            string sex = 性别输入.Text;
            string IDnumber = 身份证号输入.Text;
            string position = 职位输入.Text;

            if (!CheckIfDataExists(IDnumber))
            {
                // 数据库中不存在相同的数据，执行插入操作
                string sqlStr = "insert into worker (wpassword, wnumber, wname, sex, IDnumber, position) values (@wpassword, @wnumber, @wname, @sex, @IDnumber, @position)";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@wpassword", wpassword),
                    new MySqlParameter("@wnumber", wnumber),
                    new MySqlParameter("@wname", wname),
                    new MySqlParameter("@sex", sex),
                    new MySqlParameter("@IDnumber", IDnumber),
                    new MySqlParameter("@position", position)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    string sqlStr_2 = "select * from worker where IDnumber = @IDnumber";
                    MySqlParameter[] para_2 = new MySqlParameter[]
                    {
                        new MySqlParameter("@IDnumber", IDnumber)
                    };
                    DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2, para_2);
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
                MessageBox.Show("身份证号已存在，无法注册");
            }
        }
    }
}
