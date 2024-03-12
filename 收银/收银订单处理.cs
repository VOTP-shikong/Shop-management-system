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
    public partial class 收银订单处理 : Form
    {
        string oid;//订单号
        int i = 1;//序号
        int sum = 0;
        string vid2;
        public 收银订单处理(string wid,string vid)
        {
            vid2 = vid;
            string time = DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmssfff");//创建一个收银订单
            InitializeComponent();
            if(vid=="0")//不是会员
            {
                string sqlStr = "insert into outorder (time, wid) values (@time, @wid)";
                MySqlParameter[] para = new MySqlParameter[]
                {
                new MySqlParameter("@time", time),
                new MySqlParameter("@wid", wid)
                };
                MySqlHelper.ExecuteNonQuery(sqlStr, para);
            }
            else
            {
                string sqlStr_0 = "insert into outorder (time, wid, vid) values (@time, @wid, @vid)";
                MySqlParameter[] para_0 = new MySqlParameter[]
                {
                new MySqlParameter("@time", time),
                new MySqlParameter("@wid", wid),
                new MySqlParameter("@vid", vid)
                };
                MySqlHelper.ExecuteNonQuery(sqlStr_0, para_0);
            }
            
            string sqlStr_01 = "select oid from outorder where time = @time";//返回这笔订单的订单号
            MySqlParameter[] para_01 = new MySqlParameter[]
            {
                new MySqlParameter("@time", time),
            };
            oid = MySqlHelper.getsomething(sqlStr_01, para_01);
            订单编号显示.Text = oid;
            订单时间显示.Text = time;
            序号显示.Text = Convert.ToString(i);
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            string cname = 商品名称输入.Text;
            string cnum = 数量输入.Text;
            int cpricer = 0;//单行总价
            string sqlStr_2 = "select cid from commodity where cname = @cname";//找到商品对应的id
            MySqlParameter[] para_2 = new MySqlParameter[]
            {
                new MySqlParameter("@cname", cname)
            };
            string cid = MySqlHelper.getsomething(sqlStr_2, para_2);

            string sqlStr_3 = "update commodity set cnum = cnum - @cnum where cid = @cid";//根据id为商品减少对应的数量
            MySqlParameter[] para_3 = new MySqlParameter[]
            {
                new MySqlParameter("@cnum", cnum),
                new MySqlParameter("@cid", cid)
            };
            MySqlHelper.ExecuteNonQuery(sqlStr_3, para_3);

            string sqlStr_32 = "select pricer from commodity where cid = @cid";//拿到商品的单价
            MySqlParameter[] para_32 = new MySqlParameter[]
            {
                new MySqlParameter("@cid", cid)
            };
            string n = MySqlHelper.getsomething(sqlStr_32, para_32);
            cpricer = Convert.ToInt32(cnum) * Convert.ToInt32(n);//算出单行总价

            string sqlStr_4 = "insert into outorder_detail (oid, cid, cnum, pricer) values (@oid, @cid, @cnum, @pricer)";//为详细信息表加一行数据
            MySqlParameter[] para_4 = new MySqlParameter[]
            {
                    new MySqlParameter("@oid", oid),
                    new MySqlParameter("@cid", cid),
                    new MySqlParameter("@cnum", cnum),
                    new MySqlParameter("@pricer", cpricer)
            };
            MySqlHelper.ExecuteNonQuery(sqlStr_4, para_4);

            string sqlStr_5 = "select commodity.cname, outorder_detail.cnum, commodity.pricer, outorder_detail.pricer from outorder_detail join commodity on outorder_detail.cid = commodity.cid where outorder_detail.oid = @oid";//显示本次订单的信息
            MySqlParameter[] para_5 = new MySqlParameter[]
            {
                        new MySqlParameter("@oid", oid)
            };
            DataSet ds = MySqlHelper.ExecuteQuery(sqlStr_5, para_5);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            }
            sum = sum + cpricer;
            i++;//序号+1
            序号显示.Text = Convert.ToString(i);
            商品名称输入.Clear();
            数量输入.Clear();
        }

        private void 完成订单按钮_现金_Click(object sender, EventArgs e)
        {
            string category = "现金支付";
            string sqlStr = "update outorder set price = @sum, category = @category where oid = @oid";
            MySqlParameter[] para = new MySqlParameter[]
            {
                new MySqlParameter("@sum", sum),
                new MySqlParameter("@category", category),
                new MySqlParameter("@oid", oid)
            };
            if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
            {
                MessageBox.Show("现金支付成功");
            }
            this.Close();
        }

        private void 完成订单按钮_余额_Click(object sender, EventArgs e)
        {
            if(vid2=="0")//不是会员
            {
                MessageBox.Show("非会员订单无法使用");
            }
            else//是会员
            {
                string sqlStr = "select balance from vip where vid = @vid";//拿到会员的余额
                MySqlParameter[] para = new MySqlParameter[]
                {
                    new MySqlParameter("@vid", vid2)
                };
                string n = MySqlHelper.getsomething(sqlStr, para);
                int balance = Convert.ToInt32(n);
                if (balance<sum)
                {
                    MessageBox.Show("余额不足");
                }
                else
                {
                    string sqlStr_2 = "update vip set balance = balance - @sum where vid = @vid";//扣除余额
                    MySqlParameter[] para_2 = new MySqlParameter[]
                    {
                        new MySqlParameter("@sum", sum),
                        new MySqlParameter("@vid", vid2)
                    };
                    MySqlHelper.ExecuteNonQuery(sqlStr_2, para_2);

                    string category = "余额支付";
                    string sqlStr_3 = "update outorder set price = @sum, category = @category where oid = @oid";
                    MySqlParameter[] para_3 = new MySqlParameter[]
                    {
                        new MySqlParameter("@sum", sum),
                        new MySqlParameter("@category", category),
                        new MySqlParameter("@oid", oid)
                    };
                    if (MySqlHelper.ExecuteNonQuery(sqlStr_3, para_3) > 0)
                    {
                        MessageBox.Show("余额支付成功");
                        this.Close();
                    }
                }
            }
        }
    }
}
