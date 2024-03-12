
namespace Shop_management_system
{
    partial class 人事管理
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
            this.员工信息修改 = new System.Windows.Forms.Button();
            this.新增员工 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 员工信息修改
            // 
            this.员工信息修改.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.员工信息修改.Location = new System.Drawing.Point(404, 261);
            this.员工信息修改.Margin = new System.Windows.Forms.Padding(2);
            this.员工信息修改.Name = "员工信息修改";
            this.员工信息修改.Size = new System.Drawing.Size(250, 100);
            this.员工信息修改.TabIndex = 6;
            this.员工信息修改.Text = "员工信息修改";
            this.员工信息修改.UseVisualStyleBackColor = true;
            this.员工信息修改.Click += new System.EventHandler(this.员工信息修改_Click);
            // 
            // 新增员工
            // 
            this.新增员工.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新增员工.Location = new System.Drawing.Point(404, 113);
            this.新增员工.Margin = new System.Windows.Forms.Padding(2);
            this.新增员工.Name = "新增员工";
            this.新增员工.Size = new System.Drawing.Size(250, 100);
            this.新增员工.TabIndex = 5;
            this.新增员工.Text = "新增员工";
            this.新增员工.UseVisualStyleBackColor = true;
            this.新增员工.Click += new System.EventHandler(this.新增员工_Click);
            // 
            // 人事管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.员工信息修改);
            this.Controls.Add(this.新增员工);
            this.Name = "人事管理";
            this.Text = "人事管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 员工信息修改;
        private System.Windows.Forms.Button 新增员工;
    }
}