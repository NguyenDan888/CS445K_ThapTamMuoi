﻿
namespace WinFormsApp_Coffee
{
    partial class frmGiaapdung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKhoadotgia = new System.Windows.Forms.Button();
            this.btnThemdotgia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtMadotgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvGiaapdung = new System.Windows.Forms.DataGridView();
            this.MaDotgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 531);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnKhoadotgia);
            this.panel4.Controls.Add(this.btnThemdotgia);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(566, 76);
            this.panel4.TabIndex = 2;
            // 
            // btnKhoadotgia
            // 
            this.btnKhoadotgia.Location = new System.Drawing.Point(169, 5);
            this.btnKhoadotgia.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoadotgia.Name = "btnKhoadotgia";
            this.btnKhoadotgia.Size = new System.Drawing.Size(156, 68);
            this.btnKhoadotgia.TabIndex = 1;
            this.btnKhoadotgia.Text = "Khóa đợt giá";
            this.btnKhoadotgia.UseVisualStyleBackColor = true;
            this.btnKhoadotgia.Click += new System.EventHandler(this.btnKhoadotgia_Click);
            // 
            // btnThemdotgia
            // 
            this.btnThemdotgia.Location = new System.Drawing.Point(5, 5);
            this.btnThemdotgia.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemdotgia.Name = "btnThemdotgia";
            this.btnThemdotgia.Size = new System.Drawing.Size(156, 68);
            this.btnThemdotgia.TabIndex = 0;
            this.btnThemdotgia.Text = "Thêm đợt giá";
            this.btnThemdotgia.UseVisualStyleBackColor = true;
            this.btnThemdotgia.Click += new System.EventHandler(this.btnThemdotgia_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbtrangthai);
            this.panel3.Controls.Add(this.dateBD);
            this.panel3.Controls.Add(this.txtGiaban);
            this.panel3.Controls.Add(this.txtMadotgia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(580, 89);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 439);
            this.panel3.TabIndex = 1;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Chưa áp dụng",
            "Đã áp dụng",
            "Đã khóa"});
            this.cbtrangthai.Location = new System.Drawing.Point(140, 206);
            this.cbtrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(240, 33);
            this.cbtrangthai.TabIndex = 7;
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBD.Location = new System.Drawing.Point(140, 131);
            this.dateBD.Margin = new System.Windows.Forms.Padding(4);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(240, 31);
            this.dateBD.TabIndex = 6;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(140, 74);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(240, 31);
            this.txtGiaban.TabIndex = 5;
            // 
            // txtMadotgia
            // 
            this.txtMadotgia.Enabled = false;
            this.txtMadotgia.Location = new System.Drawing.Point(140, 14);
            this.txtMadotgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadotgia.Name = "txtMadotgia";
            this.txtMadotgia.Size = new System.Drawing.Size(240, 31);
            this.txtMadotgia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt giá:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvGiaapdung);
            this.panel2.Location = new System.Drawing.Point(5, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 439);
            this.panel2.TabIndex = 0;
            // 
            // dgvGiaapdung
            // 
            this.dgvGiaapdung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaapdung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDotgia,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGiaapdung.Location = new System.Drawing.Point(5, 5);
            this.dgvGiaapdung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaapdung.Name = "dgvGiaapdung";
            this.dgvGiaapdung.RowHeadersWidth = 51;
            this.dgvGiaapdung.RowTemplate.Height = 29;
            this.dgvGiaapdung.Size = new System.Drawing.Size(558, 430);
            this.dgvGiaapdung.TabIndex = 0;
            this.dgvGiaapdung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaapdung_CellClick);
            // 
            // MaDotgia
            // 
            this.MaDotgia.DataPropertyName = "MaDotgia";
            this.MaDotgia.HeaderText = "Mã";
            this.MaDotgia.MinimumWidth = 6;
            this.MaDotgia.Name = "MaDotgia";
            this.MaDotgia.ReadOnly = true;
            this.MaDotgia.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Format = "#,###";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Giá Bán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBatDauAD";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Ngày Bắt Đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmGiaapdung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGiaapdung";
            this.Text = "Giá áp dụng";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKhoadotgia;
        private System.Windows.Forms.Button btnThemdotgia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtMadotgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvGiaapdung;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDotgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}