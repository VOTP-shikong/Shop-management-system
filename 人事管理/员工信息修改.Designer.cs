
namespace Shop_management_system
{
    partial class 员工信息修改
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
            this.职位输入 = new System.Windows.Forms.ComboBox();
            this.性别输入 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.身份证号输入 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.确认按钮 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.姓名输入 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.密码输入 = new System.Windows.Forms.TextBox();
            this.手机号输入 = new System.Windows.Forms.TextBox();
            this.选中按钮 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 职位输入
            // 
            this.职位输入.FormattingEnabled = true;
            this.职位输入.Items.AddRange(new object[] {
            "数据库管理员",
            "经理",
            "收银员",
            "仓储管理员",
            "前台"});
            this.职位输入.Location = new System.Drawing.Point(472, 470);
            this.职位输入.Name = "职位输入";
            this.职位输入.Size = new System.Drawing.Size(133, 20);
            this.职位输入.TabIndex = 42;
            // 
            // 性别输入
            // 
            this.性别输入.FormattingEnabled = true;
            this.性别输入.Items.AddRange(new object[] {
            "男",
            "女"});
            this.性别输入.Location = new System.Drawing.Point(472, 356);
            this.性别输入.Name = "性别输入";
            this.性别输入.Size = new System.Drawing.Size(133, 20);
            this.性别输入.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(375, 470);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "职位：";
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.Location = new System.Drawing.Point(375, 356);
            this.性别.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(69, 20);
            this.性别.TabIndex = 39;
            this.性别.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(359, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "身份证号：";
            // 
            // 身份证号输入
            // 
            this.身份证号输入.Location = new System.Drawing.Point(472, 414);
            this.身份证号输入.Margin = new System.Windows.Forms.Padding(2);
            this.身份证号输入.Name = "身份证号输入";
            this.身份证号输入.Size = new System.Drawing.Size(135, 21);
            this.身份证号输入.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 136);
            this.dataGridView1.TabIndex = 36;
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(770, 414);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(150, 50);
            this.确认按钮.TabIndex = 35;
            this.确认按钮.Text = "确认修改";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(375, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "姓名：";
            // 
            // 姓名输入
            // 
            this.姓名输入.Location = new System.Drawing.Point(472, 306);
            this.姓名输入.Margin = new System.Windows.Forms.Padding(2);
            this.姓名输入.Name = "姓名输入";
            this.姓名输入.Size = new System.Drawing.Size(135, 21);
            this.姓名输入.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(375, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(375, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "手机号：";
            // 
            // 密码输入
            // 
            this.密码输入.Location = new System.Drawing.Point(472, 192);
            this.密码输入.Margin = new System.Windows.Forms.Padding(2);
            this.密码输入.Name = "密码输入";
            this.密码输入.Size = new System.Drawing.Size(135, 21);
            this.密码输入.TabIndex = 30;
            // 
            // 手机号输入
            // 
            this.手机号输入.Location = new System.Drawing.Point(472, 250);
            this.手机号输入.Margin = new System.Windows.Forms.Padding(2);
            this.手机号输入.Name = "手机号输入";
            this.手机号输入.Size = new System.Drawing.Size(135, 21);
            this.手机号输入.TabIndex = 29;
            // 
            // 选中按钮
            // 
            this.选中按钮.Location = new System.Drawing.Point(770, 238);
            this.选中按钮.Margin = new System.Windows.Forms.Padding(2);
            this.选中按钮.Name = "选中按钮";
            this.选中按钮.Size = new System.Drawing.Size(150, 50);
            this.选中按钮.TabIndex = 43;
            this.选中按钮.Text = "确认选中";
            this.选中按钮.UseVisualStyleBackColor = true;
            this.选中按钮.Click += new System.EventHandler(this.选中按钮_Click);
            // 
            // 员工信息修改
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.选中按钮);
            this.Controls.Add(this.职位输入);
            this.Controls.Add(this.性别输入);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.身份证号输入);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.姓名输入);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.密码输入);
            this.Controls.Add(this.手机号输入);
            this.Name = "员工信息修改";
            this.Text = "员工信息修改";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox 职位输入;
        private System.Windows.Forms.ComboBox 性别输入;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 身份证号输入;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 姓名输入;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 密码输入;
        private System.Windows.Forms.TextBox 手机号输入;
        private System.Windows.Forms.Button 选中按钮;
    }
}