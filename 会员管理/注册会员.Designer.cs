
namespace Shop_management_system
{
    partial class 注册会员
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.密码输入 = new System.Windows.Forms.TextBox();
            this.手机号输入 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.姓名输入 = new System.Windows.Forms.TextBox();
            this.确认按钮 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(356, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(356, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "手机号：";
            // 
            // 密码输入
            // 
            this.密码输入.Location = new System.Drawing.Point(453, 173);
            this.密码输入.Margin = new System.Windows.Forms.Padding(2);
            this.密码输入.Name = "密码输入";
            this.密码输入.Size = new System.Drawing.Size(135, 21);
            this.密码输入.TabIndex = 6;
            // 
            // 手机号输入
            // 
            this.手机号输入.Location = new System.Drawing.Point(453, 231);
            this.手机号输入.Margin = new System.Windows.Forms.Padding(2);
            this.手机号输入.Name = "手机号输入";
            this.手机号输入.Size = new System.Drawing.Size(135, 21);
            this.手机号输入.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(356, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "姓名：";
            // 
            // 姓名输入
            // 
            this.姓名输入.Location = new System.Drawing.Point(453, 287);
            this.姓名输入.Margin = new System.Windows.Forms.Padding(2);
            this.姓名输入.Name = "姓名输入";
            this.姓名输入.Size = new System.Drawing.Size(135, 21);
            this.姓名输入.TabIndex = 9;
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(453, 337);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(133, 33);
            this.确认按钮.TabIndex = 11;
            this.确认按钮.Text = "确认";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 136);
            this.dataGridView1.TabIndex = 12;
            // 
            // 注册会员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.姓名输入);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.密码输入);
            this.Controls.Add(this.手机号输入);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "注册会员";
            this.Text = "注册会员";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 密码输入;
        private System.Windows.Forms.TextBox 手机号输入;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 姓名输入;
        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}