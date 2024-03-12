
namespace Shop_management_system
{
    partial class 会员确认
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
            this.确认按钮 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.密码输入 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.手机号输入 = new System.Windows.Forms.TextBox();
            this.非会员按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(471, 288);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(133, 33);
            this.确认按钮.TabIndex = 25;
            this.确认按钮.Text = "确认";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(374, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "密码：";
            // 
            // 密码输入
            // 
            this.密码输入.Location = new System.Drawing.Point(471, 236);
            this.密码输入.Margin = new System.Windows.Forms.Padding(2);
            this.密码输入.Name = "密码输入";
            this.密码输入.Size = new System.Drawing.Size(135, 21);
            this.密码输入.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(374, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "手机号：";
            // 
            // 手机号输入
            // 
            this.手机号输入.Location = new System.Drawing.Point(471, 180);
            this.手机号输入.Margin = new System.Windows.Forms.Padding(2);
            this.手机号输入.Name = "手机号输入";
            this.手机号输入.Size = new System.Drawing.Size(135, 21);
            this.手机号输入.TabIndex = 19;
            // 
            // 非会员按钮
            // 
            this.非会员按钮.Location = new System.Drawing.Point(433, 456);
            this.非会员按钮.Margin = new System.Windows.Forms.Padding(2);
            this.非会员按钮.Name = "非会员按钮";
            this.非会员按钮.Size = new System.Drawing.Size(200, 50);
            this.非会员按钮.TabIndex = 26;
            this.非会员按钮.Text = "非会员";
            this.非会员按钮.UseVisualStyleBackColor = true;
            this.非会员按钮.Click += new System.EventHandler(this.非会员按钮_Click);
            // 
            // 会员确认
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.非会员按钮);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.密码输入);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.手机号输入);
            this.Name = "会员确认";
            this.Text = "会员确认";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 密码输入;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 手机号输入;
        private System.Windows.Forms.Button 非会员按钮;
    }
}