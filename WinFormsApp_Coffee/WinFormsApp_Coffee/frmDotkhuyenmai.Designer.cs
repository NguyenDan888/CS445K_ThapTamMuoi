﻿
namespace WinFormsApp_Coffee
{
    partial class frmDotkhuyenmai
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
            this.btnXoasanpham = new System.Windows.Forms.Button();
            this.btnSuasanpham = new System.Windows.Forms.Button();
            this.btnThemsanpham = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDotkhuyenmai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbMadouong = new System.Windows.Forms.ComboBox();
            this.cbbMadotkm = new System.Windows.Forms.ComboBox();
            this.txtTilegiam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoasanpham
            // 
            this.btnXoasanpham.Location = new System.Drawing.Point(332, 4);
            this.btnXoasanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoasanpham.Name = "btnXoasanpham";
            this.btnXoasanpham.Size = new System.Drawing.Size(156, 79);
            this.btnXoasanpham.TabIndex = 2;
            this.btnXoasanpham.Text = "Xóa sản phẩm";
            this.btnXoasanpham.UseVisualStyleBackColor = true;
            this.btnXoasanpham.Click += new System.EventHandler(this.btnXoasanpham_Click);
            // 
            // btnSuasanpham
            // 
            this.btnSuasanpham.Location = new System.Drawing.Point(169, 5);
            this.btnSuasanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuasanpham.Name = "btnSuasanpham";
            this.btnSuasanpham.Size = new System.Drawing.Size(156, 79);
            this.btnSuasanpham.TabIndex = 1;
            this.btnSuasanpham.Text = "Sửa sản phẩm";
            this.btnSuasanpham.UseVisualStyleBackColor = true;
            this.btnSuasanpham.Click += new System.EventHandler(this.btnSuasanpham_Click);
            // 
            // btnThemsanpham
            // 
            this.btnThemsanpham.Location = new System.Drawing.Point(5, 4);
            this.btnThemsanpham.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemsanpham.Name = "btnThemsanpham";
            this.btnThemsanpham.Size = new System.Drawing.Size(156, 79);
            this.btnThemsanpham.TabIndex = 0;
            this.btnThemsanpham.Text = "Thêm sản phẩm";
            this.btnThemsanpham.UseVisualStyleBackColor = true;
            this.btnThemsanpham.Click += new System.EventHandler(this.btnThemsanpham_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDotkhuyenmai);
            this.panel2.Location = new System.Drawing.Point(12, 112);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 321);
            this.panel2.TabIndex = 6;
            // 
            // dgvDotkhuyenmai
            // 
            this.dgvDotkhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDotkhuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDotkhuyenmai.Location = new System.Drawing.Point(6, 2);
            this.dgvDotkhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDotkhuyenmai.Name = "dgvDotkhuyenmai";
            this.dgvDotkhuyenmai.RowHeadersWidth = 62;
            this.dgvDotkhuyenmai.RowTemplate.Height = 33;
            this.dgvDotkhuyenmai.Size = new System.Drawing.Size(665, 316);
            this.dgvDotkhuyenmai.TabIndex = 0;
            this.dgvDotkhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDotkhuyenmai_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tendotkm";
            this.Column1.HeaderText = "Tên đợt km";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tendouong";
            this.Column2.HeaderText = "Tên đồ uống";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tlgiamgia";
            this.Column3.HeaderText = "Tỷ lệ giảm giá";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntLammoi);
            this.panel1.Controls.Add(this.btnXoasanpham);
            this.panel1.Controls.Add(this.btnSuasanpham);
            this.panel1.Controls.Add(this.btnThemsanpham);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 88);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbMadouong);
            this.panel3.Controls.Add(this.cbbMadotkm);
            this.panel3.Controls.Add(this.txtTilegiam);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(695, 112);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 321);
            this.panel3.TabIndex = 7;
            // 
            // cbbMadouong
            // 
            this.cbbMadouong.FormattingEnabled = true;
            this.cbbMadouong.Location = new System.Drawing.Point(186, 74);
            this.cbbMadouong.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMadouong.Name = "cbbMadouong";
            this.cbbMadouong.Size = new System.Drawing.Size(208, 33);
            this.cbbMadouong.TabIndex = 7;
            // 
            // cbbMadotkm
            // 
            this.cbbMadotkm.FormattingEnabled = true;
            this.cbbMadotkm.Location = new System.Drawing.Point(186, 15);
            this.cbbMadotkm.Margin = new System.Windows.Forms.Padding(4);
            this.cbbMadotkm.Name = "cbbMadotkm";
            this.cbbMadotkm.Size = new System.Drawing.Size(208, 33);
            this.cbbMadotkm.TabIndex = 6;
            // 
            // txtTilegiam
            // 
            this.txtTilegiam.Location = new System.Drawing.Point(186, 134);
            this.txtTilegiam.Margin = new System.Windows.Forms.Padding(4);
            this.txtTilegiam.Name = "txtTilegiam";
            this.txtTilegiam.Size = new System.Drawing.Size(208, 31);
            this.txtTilegiam.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỉ lệ giảm giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đồ uống:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đợt km:";
            // 
            // bntLammoi
            // 
            this.bntLammoi.Location = new System.Drawing.Point(924, 0);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(155, 83);
            this.bntLammoi.TabIndex = 3;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // frmDotkhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDotkhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đợt khuyến mãi";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotkhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXoasanpham;
        private System.Windows.Forms.Button btnSuasanpham;
        private System.Windows.Forms.Button btnThemsanpham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDotkhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbbMadouong;
        private System.Windows.Forms.ComboBox cbbMadotkm;
        private System.Windows.Forms.TextBox txtTilegiam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button bntLammoi;
    }
}