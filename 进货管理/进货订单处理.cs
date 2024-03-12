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
    public partial class 进货订单处理 : Form
    {
        string iid;//订单号
        int i = 1;//序号
        int sum = 0;
        public 进货订单处理(string wid)
        {
            string time = DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmssfff");//创建一个进货订单
            InitializeComponent();
            string sqlStr_0 = "insert into inorder (time, wid) values (@time, @wid)";
            MySqlParameter[] para_0 = new MySqlParameter[]
            {
                new MySqlParameter("@time", time),
                new MySqlParameter("@wid", wid)
            };
            MySqlHelper.ExecuteNonQuery(sqlStr_0, para_0);

            string sqlStr_01 = "select iid from inorder where time = @time";//返回这笔订单的订单号
            MySqlParameter[] para_01 = new MySqlParameter[]
            {
                new MySqlParameter("@time", time),
            };
            iid = MySqlHelper.getsomething(sqlStr_01, para_01);
            订单编号显示.Text = iid;
            订单时间显示.Text = time;
            序号显示.Text = Convert.ToString(i);
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            string cname = 商品名称输入.Text;
            string cnum = 数量输入.Text;
            string pricer = 单件进货价输入.Text;
            if (!CheckIfDataExists(cname))//如果是新商品就先加入商品表里
            {
                // 数据库中不存在相同的数据，执行插入操作
                string sqlStr = "insert into commodity (cname, cnum) values (@cname, 0)";
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@cname", cname)
                };
                MySqlHelper.ExecuteNonQuery(sqlStr, para);
            }

            string sqlStr_2 = "select cid from commodity where cname = @cname";//找到商品对应的id
            MySqlParameter[] para_2 = new MySqlParameter[]
            {
                new MySqlParameter("@cname", cname)
            };
            string cid = MySqlHelper.getsomething(sqlStr_2, para_2);

            string sqlStr_3 = "update commodity set cnum = cnum + @cnum where cid = @cid";//根据id为商品增加对应的数量
            MySqlParameter[] para_3 = new MySqlParameter[]
            {
                new MySqlParameter("@cnum", cnum),
                new MySqlParameter("@cid", cid)
            };
            MySqlHelper.ExecuteNonQuery(sqlStr_3, para_3);

            string sqlStr_4 = "insert into inorder_detail (iid, cid, cnum, pricer) values (@iid, @cid, @cnum, @pricer)";//为详细信息表加一行数据
            MySqlParameter[] para_4 = new MySqlParameter[]
            {
                    new MySqlParameter("@iid", iid),
                    new MySqlParameter("@cid", cid),
                    new MySqlParameter("@cnum", cnum),
                    new MySqlParameter("@pricer", pricer)
            };
            MySqlHelper.ExecuteNonQuery(sqlStr_4, para_4);

            string sqlStr_5 = "select inorder_detail.*, commodity.cname from inorder_detail join commodity on inorder_detail.cid = commodity.cid where inorder_detail.iid = @iid";//显示本次订单的信息
            MySqlParameter[] para_5 = new MySqlParameter[]
            {
                        new MySqlParameter("@iid", iid)
            };
            DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_5, para_5);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            }
            sum = sum + (Convert.ToInt32(cnum) * Convert.ToInt32(pricer));
            i++;//序号+1
            序号显示.Text = Convert.ToString(i);
            商品名称输入.Clear();
            数量输入.Clear();
            单件进货价输入.Clear();
        }
        private bool CheckIfDataExists(string cname)//商品是否存在
        {
            // 编写查询数据库的代码，检查是否存在相同的数据
            // 如果存在相同的数据，则返回 true，否则返回 false
            // 这里假设存在名为 CheckIfDataExists 的方法来实现这个逻辑
            // 以下为示例代码，实际情况下需要根据数据库结构和具体逻辑进行编写
            string sqlStr = "select count(*) from commodity where cname = @cname";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@cname", cname)
            };
            int count = Convert.ToInt32(MySqlHelper.ExecuteScalar(sqlStr, para));
            return count > 0;
        }

        private void 完成订单按钮_Click(object sender, EventArgs e)
        {
            string sqlStr = "update inorder set price = @sum where iid = @iid";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@sum", sum),
                new MySqlParameter("@iid", iid)
            };
            if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
            {
                MessageBox.Show("修改成功");
            }
            this.Close();
        }

        private void 进货订单处理_Load(object sender, EventArgs e)
        {

        }
    }
}
//详细页还没做
/*
 
UPDATE inorder SET price = (SELECT SUM(price) FROM inorder_detail WHERE inorder_detail.iid = inorder.iid) WHERE iid = 'a';



SELECT inorder_detail.*, commodity.cname FROM inorder_detail JOIN commodity ON inorder_detail.cid = commodity.cid WHERE inorder_detail.iid = 'a';

 */