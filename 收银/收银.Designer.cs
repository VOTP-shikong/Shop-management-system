
namespace Shop_management_system
{
    partial class 收银
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
            this.新增收银 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 新增收银
            // 
            this.新增收银.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新增收银.Location = new System.Drawing.Point(400, 208);
            this.新增收银.Margin = new System.Windows.Forms.Padding(2);
            this.新增收银.Name = "新增收银";
            this.新增收银.Size = new System.Drawing.Size(250, 100);
            this.新增收银.TabIndex = 8;
            this.新增收银.Text = "发起收银";
            this.新增收银.UseVisualStyleBackColor = true;
            this.新增收银.Click += new System.EventHandler(this.新增收银_Click);
            // 
            // 收银
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.新增收银);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "收银";
            this.Text = "收银";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button 新增收银;
    }
}