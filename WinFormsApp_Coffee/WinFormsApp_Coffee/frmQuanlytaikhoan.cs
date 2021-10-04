﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp_Coffee.DAO;

namespace WinFormsApp_Coffee
{
    public partial class frmQuanlytaikhoan : Form
    {
        public frmQuanlytaikhoan()
        {
            InitializeComponent();
            loadTaiKhoan();
            loadCbLoaiTK();
        }
        void loadTaiKhoan()
        {
            dgvQuanlytaikhoan.DataSource = QuanLyTaiKhoanDAO.Instance.loadDanhSachTaiKhoan();
            ccbTrangthaitk.SelectedIndex = 0;
        }
        //phương thức xóa dữ liệu có trong textbox, dataTimePicker, Combobox
        void xoaDuLieu()
        {
            txtMataikhoan.Clear();
            txtTendangnhap.Clear();
            txtMatkhau.Clear();
            txtTen.Clear();
            DateNgaysinh.Value = DateTime.Today;
            txtGioitinh.Clear();
            txtCmnd.Clear();
            txtEmail.Clear();
            txtSdt.Clear();
            ccbTrangthaitk.SelectedIndex = 0;
            txtMataikhoan.Focus();
            
        }
        //Tạo sự kiện thêm bàn
        private void btnThemdouong_Click(object sender, EventArgs e)
        {
            if(txtTendangnhap.Text == "" || txtMatkhau.Text == "" || txtTen.Text == "" || txtGioitinh.Text == "" || txtCmnd.Text == "" || txtSdt.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                string tendangnhap = txtTendangnhap.Text;
                string matkhau = txtMatkhau.Text;
                string ten = txtTen.Text;
                DateTime ngaysinh = DateNgaysinh.Value;
                string gioitinh = txtGioitinh.Text;
                string cmnd = txtCmnd.Text;
                string email = txtEmail.Text;
                string sdt = txtSdt.Text;
                int loaitk = ccbLoaitk.SelectedIndex;
                int trangthai = ccbTrangthaitk.SelectedIndex;
               
                    if(QuanLyTaiKhoanDAO.Instance.themTaiKhoan(tendangnhap, matkhau, ten , ngaysinh , gioitinh , cmnd , email , sdt , loaitk , trangthai))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!");
                        loadTaiKhoan();
                        xoaDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại");
                    }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSuatk_Click(object sender, EventArgs e)
        {
            if (txtMataikhoan.Text == "" || txtTendangnhap.Text == "" || txtMatkhau.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                int mataikhoan = Int32.Parse(txtMataikhoan.Text);
                string tendangnhap = txtTendangnhap.Text;
                string matkhau = txtMatkhau.Text;
                string ten = txtTen.Text;
                DateTime ngaysinh = DateNgaysinh.Value;
                string gioitinh = txtGioitinh.Text;
                string cmnd = txtCmnd.Text;
                string email = txtEmail.Text;
                string sdt = txtSdt.Text;
                int loaitk = ccbLoaitk.SelectedIndex;
                int trangthai = ccbTrangthaitk.SelectedIndex;
                if(QuanLyTaiKhoanDAO.Instance.suaThongTinTaiKhoan(mataikhoan, tendangnhap , matkhau , ten , ngaysinh , gioitinh , cmnd , email , sdt , loaitk , trangthai))
                {
                    MessageBox.Show("Sửa thông tin tài khoản thành công");
                    loadTaiKhoan();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn đã nhập sai kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Phương thức xử lý khi kích chuột vào datagridview tự động dữ liệu sẽ hiện lên textbox
        private void dgvQuanlytaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtMataikhoan.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[0].Value + "";
            txtTendangnhap.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[1].Value + "";
            txtMatkhau.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[2].Value + "";
            txtTen.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[3].Value + "";
            DateNgaysinh.Value = Convert.ToDateTime(dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[4].Value);
            txtGioitinh.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[5].Value + "";
            txtCmnd.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[6].Value + "";
            txtEmail.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[7].Value + "";
            txtSdt.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[8].Value + "";
            ccbLoaitk.Text = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[10].Value + "";
            ccbTrangthaitk.SelectedItem = dgvQuanlytaikhoan.Rows[e.RowIndex].Cells[9].Value + "";           
        }

        private void btnXoatk_Click(object sender, EventArgs e)
        {
            if(txtMataikhoan.Text == "" || txtTendangnhap.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhấp chuột vào tài khoản muốn xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa tài khoản không?", "Thông báo", MessageBoxButtons.YesNo,//Hiển thị form xác nhận có muốn xóa tài khoản ?
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }
            else
            {
                int mataikhoan = Int32.Parse(txtMataikhoan.Text);
                if (QuanLyTaiKhoanDAO.Instance.xoaTaiKhoan(mataikhoan))//Gọi phương thức xóa bàn từ DAO
                {
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTaiKhoan();
                    xoaDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }          
        }
        //load combobox trang thai
        void loadCbLoaiTK()
        {
            ccbLoaitk.DataSource = QuanLyTaiKhoanDAO.Instance.loadLoaiTK();
            ccbLoaitk.DisplayMember = "tenloaitk";
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
        }
    }
}
