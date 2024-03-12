
namespace Shop_management_system
{
    partial class 收银订单处理
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
            this.商品名称输入 = new System.Windows.Forms.TextBox();
            this.完成订单按钮_现金 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.总价显示 = new System.Windows.Forms.TextBox();
            this.完成订单按钮_余额 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 商品名称输入
            // 
            this.商品名称输入.Location = new System.Drawing.Point(431, 347);
            this.商品名称输入.Margin = new System.Windows.Forms.Padding(2);
            this.商品名称输入.Name = "商品名称输入";
            this.商品名称输入.Size = new System.Drawing.Size(135, 21);
            this.商品名称输入.TabIndex = 74;
            // 
            // 完成订单按钮_现金
            // 
            this.完成订单按钮_现金.Location = new System.Drawing.Point(656, 296);
            this.完成订单按钮_现金.Margin = new System.Windows.Forms.Padding(2);
            this.完成订单按钮_现金.Name = "完成订单按钮_现金";
            this.完成订单按钮_现金.Size = new System.Drawing.Size(150, 50);
            this.完成订单按钮_现金.TabIndex = 73;
            this.完成订单按钮_现金.Text = "完成订单（现金支付）";
            this.完成订单按钮_现金.UseVisualStyleBackColor = true;
            this.完成订单按钮_现金.Click += new System.EventHandler(this.完成订单按钮_现金_Click);
            // 
            // 商品名称
            // 
            this.商品名称.AutoSize = true;
            this.商品名称.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.商品名称.Location = new System.Drawing.Point(319, 348);
            this.商品名称.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.商品名称.Name = "商品名称";
            this.商品名称.Size = new System.Drawing.Size(109, 20);
            this.商品名称.TabIndex = 72;
            this.商品名称.Text = "商品名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(359, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "数量：";
            // 
            // 数量输入
            // 
            this.数量输入.Location = new System.Drawing.Point(433, 394);
            this.数量输入.Margin = new System.Windows.Forms.Padding(2);
            this.数量输入.Name = "数量输入";
            this.数量输入.Size = new System.Drawing.Size(135, 21);
            this.数量输入.TabIndex = 70;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(108, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 136);
            this.dataGridView1.TabIndex = 69;
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(431, 486);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(137, 50);
            this.确认按钮.TabIndex = 68;
            this.确认按钮.Text = "确认添加";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // 序号
            // 
            this.序号.AutoSize = true;
            this.序号.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.序号.Location = new System.Drawing.Point(359, 298);
            this.序号.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.序号.Name = "序号";
            this.序号.Size = new System.Drawing.Size(69, 20);
            this.序号.TabIndex = 67;
            this.序号.Text = "序号：";
            // 
            // 序号显示
            // 
            this.序号显示.Location = new System.Drawing.Point(433, 298);
            this.序号显示.Margin = new System.Windows.Forms.Padding(2);
            this.序号显示.Name = "序号显示";
            this.序号显示.ReadOnly = true;
            this.序号显示.Size = new System.Drawing.Size(135, 21);
            this.序号显示.TabIndex = 66;
            // 
            // 订单编号
            // 
            this.订单编号.AutoSize = true;
            this.订单编号.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单编号.Location = new System.Drawing.Point(320, 184);
            this.订单编号.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.订单编号.Name = "订单编号";
            this.订单编号.Size = new System.Drawing.Size(109, 20);
            this.订单编号.TabIndex = 65;
            this.订单编号.Text = "订单编号：";
            // 
            // 订单时间
            // 
            this.订单时间.AutoSize = true;
            this.订单时间.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.订单时间.Location = new System.Drawing.Point(320, 242);
            this.订单时间.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.订单时间.Name = "订单时间";
            this.订单时间.Size = new System.Drawing.Size(109, 20);
            this.订单时间.TabIndex = 64;
            this.订单时间.Text = "订单时间：";
            // 
            // 订单编号显示
            // 
            this.订单编号显示.Location = new System.Drawing.Point(433, 184);
            this.订单编号显示.Margin = new System.Windows.Forms.Padding(2);
            this.订单编号显示.Name = "订单编号显示";
            this.订单编号显示.ReadOnly = true;
            this.订单编号显示.Size = new System.Drawing.Size(135, 21);
            this.订单编号显示.TabIndex = 63;
            // 
            // 订单时间显示
            // 
            this.订单时间显示.Location = new System.Drawing.Point(433, 242);
            this.订单时间显示.Margin = new System.Windows.Forms.Padding(2);
            this.订单时间显示.Name = "订单时间显示";
            this.订单时间显示.ReadOnly = true;
            this.订单时间显示.Size = new System.Drawing.Size(135, 21);
            this.订单时间显示.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(359, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "总价：";
            // 
            // 总价显示
            // 
            this.总价显示.Location = new System.Drawing.Point(433, 440);
            this.总价显示.Margin = new System.Windows.Forms.Padding(2);
            this.总价显示.Name = "总价显示";
            this.总价显示.ReadOnly = true;
            this.总价显示.Size = new System.Drawing.Size(135, 21);
            this.总价显示.TabIndex = 75;
            // 
            // 完成订单按钮_余额
            // 
            this.完成订单按钮_余额.Location = new System.Drawing.Point(656, 395);
            this.完成订单按钮_余额.Margin = new System.Windows.Forms.Padding(2);
            this.完成订单按钮_余额.Name = "完成订单按钮_余额";
            this.完成订单按钮_余额.Size = new System.Drawing.Size(150, 50);
            this.完成订单按钮_余额.TabIndex = 77;
            this.完成订单按钮_余额.Text = "完成订单（余额支付）";
            this.完成订单按钮_余额.UseVisualStyleBackColor = true;
            this.完成订单按钮_余额.Click += new System.EventHandler(this.完成订单按钮_余额_Click);
            // 
            // 收银订单处理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.完成订单按钮_余额);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.总价显示);
            this.Controls.Add(this.商品名称输入);
            this.Controls.Add(this.完成订单按钮_现金);
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
            this.Name = "收银订单处理";
            this.Text = "收银订单处理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox 商品名称输入;
        private System.Windows.Forms.Button 完成订单按钮_现金;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 总价显示;
        private System.Windows.Forms.Button 完成订单按钮_余额;
    }
}