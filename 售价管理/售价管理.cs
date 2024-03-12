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
    public partial class 售价管理 : Form
    {
        public 售价管理()
        {
            InitializeComponent();
            string sqlStr = "select * from commodity";
            DataSet ds = MySqlHelper.ExecuteQuery(sqlStr);
            if (ds != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
                //dataGridView1.BackgroundColor = System.Drawing.Color.Green;
            }
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
                商品ID显示.Text = gridViewRow.Cells["cid"].Value.ToString();
                商品名显示.Text = gridViewRow.Cells["cname"].Value.ToString();
                数量显示.Text = gridViewRow.Cells["cnum"].Value.ToString();
            }
        }

        private void 确认按钮_Click(object sender, EventArgs e)
        {
            DataGridViewRow gridViewRow = dataGridView1.CurrentRow;

            string cid = 商品ID显示.Text;
            string pricer = 价格输入.Text;

            string sqlStr = "update commodity set pricer = @pricer where cid = @cid";
            MySqlParameter[] para = new MySqlParameter[]
            {
                    new MySqlParameter("@cid", cid),
                    new MySqlParameter("@pricer", pricer)
            };
            if (MySqlHelper.ExecuteNonQuery(sqlStr, para) > 0)
            {
                string sqlStr_2 = "select * from commodity";
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
}
