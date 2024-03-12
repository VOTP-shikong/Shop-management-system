
namespace Shop_management_system
{
    partial class 会员管理
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
            this.删除会员 = new System.Windows.Forms.Button();
            this.修改密码 = new System.Windows.Forms.Button();
            this.积分管理 = new System.Windows.Forms.Button();
            this.注册会员 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 删除会员
            // 
            this.删除会员.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.删除会员.Location = new System.Drawing.Point(613, 137);
            this.删除会员.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.删除会员.Name = "删除会员";
            this.删除会员.Size = new System.Drawing.Size(267, 120);
            this.删除会员.TabIndex = 10;
            this.删除会员.Text = "删除会员";
            this.删除会员.UseVisualStyleBackColor = true;
            this.删除会员.Click += new System.EventHandler(this.删除会员_Click);
            // 
            // 修改密码
            // 
            this.修改密码.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.修改密码.Location = new System.Drawing.Point(613, 285);
            this.修改密码.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(267, 120);
            this.修改密码.TabIndex = 9;
            this.修改密码.Text = "修改密码";
            this.修改密码.UseVisualStyleBackColor = true;
            this.修改密码.Click += new System.EventHandler(this.修改密码_Click);
            // 
            // 积分管理
            // 
            this.积分管理.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.积分管理.Location = new System.Drawing.Point(223, 285);
            this.积分管理.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.积分管理.Name = "积分管理";
            this.积分管理.Size = new System.Drawing.Size(267, 120);
            this.积分管理.TabIndex = 8;
            this.积分管理.Text = "积分/余额管理";
            this.积分管理.UseVisualStyleBackColor = true;
            this.积分管理.Click += new System.EventHandler(this.积分管理_Click);
            // 
            // 注册会员
            // 
            this.注册会员.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.注册会员.Location = new System.Drawing.Point(223, 137);
            this.注册会员.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.注册会员.Name = "注册会员";
            this.注册会员.Size = new System.Drawing.Size(267, 120);
            this.注册会员.TabIndex = 7;
            this.注册会员.Text = "注册会员";
            this.注册会员.UseVisualStyleBackColor = true;
            this.注册会员.Click += new System.EventHandler(this.注册会员_Click);
            // 
            // 会员管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.删除会员);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.积分管理);
            this.Controls.Add(this.注册会员);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "会员管理";
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.会员管理_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 删除会员;
        private System.Windows.Forms.Button 修改密码;
        private System.Windows.Forms.Button 积分管理;
        private System.Windows.Forms.Button 注册会员;
    }
}