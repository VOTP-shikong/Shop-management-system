
namespace Shop_management_system
{
    partial class 售价管理
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
            this.选中按钮 = new System.Windows.Forms.Button();
            this.性别 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.确认按钮 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.数量显示 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.商品ID显示 = new System.Windows.Forms.TextBox();
            this.商品名显示 = new System.Windows.Forms.TextBox();
            this.价格输入 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // 选中按钮
            // 
            this.选中按钮.Location = new System.Drawing.Point(770, 273);
            this.选中按钮.Margin = new System.Windows.Forms.Padding(2);
            this.选中按钮.Name = "选中按钮";
            this.选中按钮.Size = new System.Drawing.Size(150, 50);
            this.选中按钮.TabIndex = 58;
            this.选中按钮.Text = "确认选中";
            this.选中按钮.UseVisualStyleBackColor = true;
            this.选中按钮.Click += new System.EventHandler(this.选中按钮_Click);
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.Location = new System.Drawing.Point(398, 391);
            this.性别.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(69, 20);
            this.性别.TabIndex = 54;
            this.性别.Text = "价格：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 136);
            this.dataGridView1.TabIndex = 51;
            // 
            // 确认按钮
            // 
            this.确认按钮.Location = new System.Drawing.Point(770, 449);
            this.确认按钮.Margin = new System.Windows.Forms.Padding(2);
            this.确认按钮.Name = "确认按钮";
            this.确认按钮.Size = new System.Drawing.Size(150, 50);
            this.确认按钮.TabIndex = 50;
            this.确认按钮.Text = "确认修改";
            this.确认按钮.UseVisualStyleBackColor = true;
            this.确认按钮.Click += new System.EventHandler(this.确认按钮_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(399, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "数量：";
            // 
            // 数量显示
            // 
            this.数量显示.Location = new System.Drawing.Point(472, 341);
            this.数量显示.Margin = new System.Windows.Forms.Padding(2);
            this.数量显示.Name = "数量显示";
            this.数量显示.ReadOnly = true;
            this.数量显示.Size = new System.Drawing.Size(135, 21);
            this.数量显示.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(379, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "商品ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(379, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "商品名：";
            // 
            // 商品ID显示
            // 
            this.商品ID显示.Location = new System.Drawing.Point(472, 227);
            this.商品ID显示.Margin = new System.Windows.Forms.Padding(2);
            this.商品ID显示.Name = "商品ID显示";
            this.商品ID显示.ReadOnly = true;
            this.商品ID显示.Size = new System.Drawing.Size(135, 21);
            this.商品ID显示.TabIndex = 45;
            // 
            // 商品名显示
            // 
            this.商品名显示.Location = new System.Drawing.Point(472, 285);
            this.商品名显示.Margin = new System.Windows.Forms.Padding(2);
            this.商品名显示.Name = "商品名显示";
            this.商品名显示.ReadOnly = true;
            this.商品名显示.Size = new System.Drawing.Size(135, 21);
            this.商品名显示.TabIndex = 44;
            // 
            // 价格输入
            // 
            this.价格输入.Location = new System.Drawing.Point(472, 390);
            this.价格输入.Margin = new System.Windows.Forms.Padding(2);
            this.价格输入.Name = "价格输入";
            this.价格输入.Size = new System.Drawing.Size(135, 21);
            this.价格输入.TabIndex = 59;
            // 
            // 售价管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 591);
            this.Controls.Add(this.价格输入);
            this.Controls.Add(this.选中按钮);
            this.Controls.Add(this.性别);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.确认按钮);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.数量显示);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.商品ID显示);
            this.Controls.Add(this.商品名显示);
            this.Name = "售价管理";
            this.Text = "售价管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 选中按钮;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button 确认按钮;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox 数量显示;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox 商品ID显示;
        private System.Windows.Forms.TextBox 商品名显示;
        private System.Windows.Forms.TextBox 价格输入;
    }
}