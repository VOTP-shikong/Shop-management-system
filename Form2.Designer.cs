
namespace Shop_management_system
{
    partial class Form2
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
            this.进货管理 = new System.Windows.Forms.Button();
            this.收银 = new System.Windows.Forms.Button();
            this.人事管理 = new System.Windows.Forms.Button();
            this.会员管理 = new System.Windows.Forms.Button();
            this.售价管理按钮 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 进货管理
            // 
            this.进货管理.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.进货管理.Location = new System.Drawing.Point(159, 167);
            this.进货管理.Name = "进货管理";
            this.进货管理.Size = new System.Drawing.Size(300, 150);
            this.进货管理.TabIndex = 3;
            this.进货管理.Text = "进货管理";
            this.进货管理.UseVisualStyleBackColor = true;
            this.进货管理.Click += new System.EventHandler(this.进货管理_Click);
            // 
            // 收银
            // 
            this.收银.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.收银.Location = new System.Drawing.Point(382, 389);
            this.收银.Name = "收银";
            this.收银.Size = new System.Drawing.Size(300, 150);
            this.收银.TabIndex = 4;
            this.收银.Text = "收银";
            this.收银.UseVisualStyleBackColor = true;
            this.收银.Click += new System.EventHandler(this.收银_Click);
            // 
            // 人事管理
            // 
            this.人事管理.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.人事管理.Location = new System.Drawing.Point(1154, 167);
            this.人事管理.Name = "人事管理";
            this.人事管理.Size = new System.Drawing.Size(300, 150);
            this.人事管理.TabIndex = 5;
            this.人事管理.Text = "人事管理";
            this.人事管理.UseVisualStyleBackColor = true;
            this.人事管理.Click += new System.EventHandler(this.人事管理_Click);
            // 
            // 会员管理
            // 
            this.会员管理.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.会员管理.Location = new System.Drawing.Point(650, 167);
            this.会员管理.Name = "会员管理";
            this.会员管理.Size = new System.Drawing.Size(300, 150);
            this.会员管理.TabIndex = 6;
            this.会员管理.Text = "会员管理";
            this.会员管理.UseVisualStyleBackColor = true;
            this.会员管理.Click += new System.EventHandler(this.会员管理_Click);
            // 
            // 售价管理按钮
            // 
            this.售价管理按钮.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.售价管理按钮.Location = new System.Drawing.Point(915, 389);
            this.售价管理按钮.Name = "售价管理按钮";
            this.售价管理按钮.Size = new System.Drawing.Size(300, 150);
            this.售价管理按钮.TabIndex = 7;
            this.售价管理按钮.Text = "商品售价管理";
            this.售价管理按钮.UseVisualStyleBackColor = true;
            this.售价管理按钮.Click += new System.EventHandler(this.售价管理按钮_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1656, 886);
            this.Controls.Add(this.售价管理按钮);
            this.Controls.Add(this.会员管理);
            this.Controls.Add(this.人事管理);
            this.Controls.Add(this.收银);
            this.Controls.Add(this.进货管理);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "超市管理系统（主页面）";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 进货管理;
        private System.Windows.Forms.Button 收银;
        private System.Windows.Forms.Button 人事管理;
        private System.Windows.Forms.Button 会员管理;
        private System.Windows.Forms.Button 售价管理按钮;
    }
}