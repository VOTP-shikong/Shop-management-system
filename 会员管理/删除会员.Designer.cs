
namespace Shop_management_system
{
    partial class 删除会员
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
            this.姓名输入 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.密码输入 = new System.Windows.Forms.TextBox();
            this.手机号输入 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(533, 362);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(133, 33);
            this.确认按钮.TabIndex = 18;
            this.确认按钮.Text = "确认";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(436, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "姓名：";
            // 
            // 姓名输入
            // 
            this.姓名输入.Location = new System.Drawing.Point(533, 310);
            this.姓名输入.Margin = new System.Windows.Forms.Padding(2);
            this.姓名输入.Name = "姓名输入";
            this.姓名输入.Size = new System.Drawing.Size(135, 21);
            this.姓名输入.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(436, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(436, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "手机号：";
            // 
            // 密码输入
            // 
            this.密码输入.Location = new System.Drawing.Point(533, 196);
            this.密码输入.Margin = new System.Windows.Forms.Padding(2);
            this.密码输入.Name = "密码输入";
            this.密码输入.Size = new System.Drawing.Size(135, 21);
            this.密码输入.TabIndex = 13;
            // 
            // 手机号输入
            // 
            this.手机号输入.Location = new System.Drawing.Point(533, 254);
            this.手机号输入.Margin = new System.Windows.Forms.Padding(2);
            this.手机号输入.Name = "手机号输入";
            this.手机号输入.Size = new System.Drawing.Size(135, 21);
            this.手机号输入.TabIndex = 12;
            // 
            // 删除会员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.姓名输入);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.密码输入);
            this.Controls.Add(this.手机号输入);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "删除会员";
            this.Text = "删除会员";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 姓名输入;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 密码输入;
        private System.Windows.Forms.TextBox 手机号输入;
    }
}