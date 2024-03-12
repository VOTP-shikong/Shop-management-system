
namespace Shop_management_system
{
    partial class 登录界面
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ID输入 = new System.Windows.Forms.TextBox();
            this.密码输入 = new System.Windows.Forms.TextBox();
            this.登录按钮 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID输入
            // 
            this.ID输入.Location = new System.Drawing.Point(455, 154);
            this.ID输入.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID输入.Name = "ID输入";
            this.ID输入.Size = new System.Drawing.Size(135, 21);
            this.ID输入.TabIndex = 0;
            // 
            // 密码输入
            // 
            this.密码输入.Location = new System.Drawing.Point(455, 218);
            this.密码输入.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.密码输入.Name = "密码输入";
            this.密码输入.Size = new System.Drawing.Size(135, 21);
            this.密码输入.TabIndex = 1;
            // 
            // 登录按钮
            // 
            this.登录按钮.Location = new System.Drawing.Point(455, 290);
            this.登录按钮.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.登录按钮.Name = "登录按钮";
            this.登录按钮.Size = new System.Drawing.Size(133, 33);
            this.登录按钮.TabIndex = 2;
            this.登录按钮.Text = "登录";
            this.登录按钮.UseVisualStyleBackColor = true;
            this.登录按钮.Click += new System.EventHandler(this.登录按钮_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(357, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(357, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.登录按钮);
            this.Controls.Add(this.密码输入);
            this.Controls.Add(this.ID输入);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "登录界面";
            this.Text = "超市管理系统（登录）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID输入;
        private System.Windows.Forms.TextBox 密码输入;
        private System.Windows.Forms.Button 登录按钮;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

