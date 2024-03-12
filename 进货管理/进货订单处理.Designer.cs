
namespace Shop_management_system
{
    partial class 进货订单处理
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.完成订单按钮 = new System.Windows.Forms.Button();
            this.商品名称 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.数量输入 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.确认按钮 = new System.Windows.Forms.Button();
            this.序号 = new System.Windows.Forms.Label();
            this.序号显示 = new System.Windows.Forms.TextBox();
            this.订单编号 = new System.Windows.Forms.Label();
            this.订单时间 = new System.Windows.Forms.Label();
            this.订单编号显示 = new System.Windows.Forms.TextBox();
            this.订单时间显示 = new System.Windows.Forms.TextBox();
            this.商品名称输入 = new System.Windows.Forms.TextBox();
            this.单件进货价 = new System.Windows.Forms.Label();
            this.单件进货价输入 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 完成订单按钮
            // 
            this.完成订单按钮.Location = new System.Drawing.Point(1287, 460);
            this.完成订单按钮.Name = "完成订单按钮";
            this.完成订单按钮.Size = new System.Drawing.Size(225, 75);
            this.完成订单按钮.TabIndex = 58;
            this.完成订单按钮.Text = "完成订单";
            this.完成订单按钮.UseVisualStyleBackColor = true;
            this.完成订单按钮.Click += new System.EventHandler(this.完成订单按钮_Click);
            // 
            // 商品名称
            // 
            this.商品名称.AutoSize = true;
            this.商品名称.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.商品名称.Location = new System.Drawing.Point(531, 506);
            this.商品名称.Name = "商品名称";
            this.商品名称.Size = new System.Drawing.Size(163, 30);
            this.商品名称.TabIndex = 54;
            this.商品名称.Text = "商品名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(591, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 53;
            this.label6.Text = "数量：";
            // 
            // 数量输入
            // 
            this.数量输入.Location = new System.Drawing.Point(702, 574);
            this.数量输入.Name = "数量输入";
            this.数量输入.Size = new System.Drawing.Size(200, 28);
            this.数量输入.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 204);
            this.dataGridView1.TabIndex = 51;
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(702, 764);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(206, 75);
            this.确认按钮.TabIndex = 50;
            this.确认按钮.Text = "确认添加";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // 序号
            // 
            this.序号.AutoSize = true;
            this.序号.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.序号.Location = new System.Drawing.Point(591, 430);
            this.序号.Name = "序号";
            this.序号.Size = new System.Drawing.Size(103, 30);
            this.序号.TabIndex = 49;
            this.序号.Text = "序号：";
            // 
            // 序号显示
            // 
            this.序号显示.Location = new System.Drawing.Point(702, 430);
            this.序号显示.Name = "序号显示";
            this.序号显示.ReadOnly = true;
            this.序号显示.Size = new System.Drawing.Size(200, 28);
            this.序号显示.TabIndex = 48;
            // 
            // 订单编号
            // 
            this.订单编号.AutoSize = true;
            this.订单编号.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单编号.Location = new System.Drawing.Point(532, 260);
            this.订单编号.Name = "订单编号";
            this.订单编号.Size = new System.Drawing.Size(163, 30);
            this.订单编号.TabIndex = 47;
            this.订单编号.Text = "订单编号：";
            // 
            // 订单时间
            // 
            this.订单时间.AutoSize = true;
            this.订单时间.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单时间.Location = new System.Drawing.Point(532, 346);
            this.订单时间.Name = "订单时间";
            this.订单时间.Size = new System.Drawing.Size(163, 30);
            this.订单时间.TabIndex = 46;
            this.订单时间.Text = "订单时间：";
            // 
            // 订单编号显示
            // 
            this.订单编号显示.Location = new System.Drawing.Point(702, 260);
            this.订单编号显示.Name = "订单编号显示";
            this.订单编号显示.ReadOnly = true;
            this.订单编号显示.Size = new System.Drawing.Size(200, 28);
            this.订单编号显示.TabIndex = 45;
            // 
            // 订单时间显示
            // 
            this.订单时间显示.Location = new System.Drawing.Point(702, 346);
            this.订单时间显示.Name = "订单时间显示";
            this.订单时间显示.ReadOnly = true;
            this.订单时间显示.Size = new System.Drawing.Size(200, 28);
            this.订单时间显示.TabIndex = 44;
            // 
            // 商品名称输入
            // 
            this.商品名称输入.Location = new System.Drawing.Point(699, 504);
            this.商品名称输入.Name = "商品名称输入";
            this.商品名称输入.Size = new System.Drawing.Size(200, 28);
            this.商品名称输入.TabIndex = 59;
            // 
            // 单件进货价
            // 
            this.单件进货价.AutoSize = true;
            this.单件进货价.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.单件进货价.Location = new System.Drawing.Point(502, 650);
            this.单件进货价.Name = "单件进货价";
            this.单件进货价.Size = new System.Drawing.Size(193, 30);
            this.单件进货价.TabIndex = 61;
            this.单件进货价.Text = "单件进货价：";
            // 
            // 单件进货价输入
            // 
            this.单件进货价输入.Location = new System.Drawing.Point(702, 648);
            this.单件进货价输入.Name = "单件进货价输入";
            this.单件进货价输入.Size = new System.Drawing.Size(200, 28);
            this.单件进货价输入.TabIndex = 60;
            // 
            // 进货订单处理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 886);
            this.Controls.Add(this.单件进货价);
            this.Controls.Add(this.单件进货价输入);
            this.Controls.Add(this.商品名称输入);
            this.Controls.Add(this.完成订单按钮);
            this.Controls.Add(this.商品名称);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.数量输入);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.序号);
            this.Controls.Add(this.序号显示);
            this.Controls.Add(this.订单编号);
            this.Controls.Add(this.订单时间);
            this.Controls.Add(this.订单编号显示);
            this.Controls.Add(this.订单时间显示);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "进货订单处理";
            this.Text = "进货订单处理";
            this.Load += new System.EventHandler(this.进货订单处理_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 完成订单按钮;
        private System.Windows.Forms.Label 商品名称;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 数量输入;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.Label 序号;
        private System.Windows.Forms.TextBox 序号显示;
        private System.Windows.Forms.Label 订单编号;
        private System.Windows.Forms.Label 订单时间;
        private System.Windows.Forms.TextBox 订单编号显示;
        private System.Windows.Forms.TextBox 订单时间显示;
        private System.Windows.Forms.TextBox 商品名称输入;
        private System.Windows.Forms.Label 单件进货价;
        private System.Windows.Forms.TextBox 单件进货价输入;
    }
}