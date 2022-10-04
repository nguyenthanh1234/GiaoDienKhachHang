using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDienKhachHang
{
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "" && txtSoDienThoai.Text == "" && txtNhapLaiMatKhau.Text == "" && txtMatKhau.Text == "" && txtEmail.Text == "" && txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo");
            }

        }
        //Sự kiện click nút thoát để ẩn đi form đăng kí tài khoản
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
 
        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
