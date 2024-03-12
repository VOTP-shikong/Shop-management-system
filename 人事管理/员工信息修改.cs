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
    public partial class 员工信息修改 : Form
    {
        public 员工信息修改()
        {
            InitializeComponent();
            string sqlStr = "select * from worker";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            }
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            DataGridViewRow gridViewRow = dataGridView1.CurrentRow;

            string wid = gridViewRow.Cells["wid"].Value.ToString();
            string wpassword = 密码输入.Text;
            string wnumber = 手机号输入.Text;
            string wname = 姓名输入.Text;
            string sex = 性别输入.Text;
            string IDnumber = 身份证号输入.Text;
            string position = 职位输入.Text;

            if (!CheckIfDataExists(wid,IDnumber))
            {
                // 数据库中不存在相同的数据，执行插入操作
                string sqlStr = "update worker set wpassword = @wpassword, wnumber = @wnumber, wname = @wname, sex = @sex, IDnumber = @IDnumber, position = @position where wid = @wid";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@wid", wid),
                    new MySqlParameter("@wpassword", wpassword),
                    new MySqlParameter("@wnumber", wnumber),
                    new MySqlParameter("@wname", wname),
                    new MySqlParameter("@sex", sex),
                    new MySqlParameter("@IDnumber", IDnumber),
                    new MySqlParameter("@position", position)
                };
                if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
                {
                    string sqlStr_2 = "select * from worker";
                    DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_2);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
                    }
                    MessageBox.Show("修改成功");
                }
            }
        }
        private bool CheckIfDataExists(string wid, string IDnumber)//身份证号查重
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from worker where IDnumber = @IDnumber and wid != @wid";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@wid", wid),
                new MySqlParameter("@IDnumber", IDnumber)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }

        private void 选中按钮_Click(object sender, EventArgs e)
        {
            DataGridViewRow gridViewRow = dataGridView1.CurrentRow;
            if (gridViewRow == null)
            {
                MessageBox.Show("请选择要修改数据的员工");
                return;
            }
            else
            {
                密码输入.Text = gridViewRow.Cells["wpassword"].Value.ToString();
                手机号输入.Text = gridViewRow.Cells["wnumber"].Value.ToString();
                姓名输入.Text = gridViewRow.Cells["wname"].Value.ToString();
                性别输入.Text = gridViewRow.Cells["sex"].Value.ToString();
                身份证号输入.Text = gridViewRow.Cells["IDnumber"].Value.ToString();
                职位输入.Text = gridViewRow.Cells["position"].Value.ToString();
            }
        }
    }
}
