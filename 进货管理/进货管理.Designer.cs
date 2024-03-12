
namespace Shop_management_system
{
    partial class 进货管理
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
            this.新增进货 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 新增进货
            // 
            this.新增进货.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.新增进货.Location = new System.Drawing.Point(427, 171);
            this.新增进货.Margin = new System.Windows.Forms.Padding(2);
            this.新增进货.Name = "新增进货";
            this.新增进货.Size = new System.Drawing.Size(250, 100);
            this.新增进货.TabIndex = 7;
            this.新增进货.Text = "新增进货订单";
            this.新增进货.UseVisualStyleBackColor = true;
            this.新增进货.Click += new System.EventHandler(this.新增进货_Click);
            // 
            // 进货管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.新增进货);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "进货管理";
            this.Text = "进货管理";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button 新增进货;
    }
}