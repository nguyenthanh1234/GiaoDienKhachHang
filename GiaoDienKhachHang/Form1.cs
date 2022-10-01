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
    public partial class frmDangNhap : Form
    {
        //Khởi tạo form đăng nhập
        public frmDangNhap()
        {
            InitializeComponent();
        }

        //Form đăng nhập hiện lên lúc bắt đầu
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbQuyen.SelectedIndex = 0;
        }

        //Sự kiện khi nhấn vào nút đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Chặn người dùng đăng nhập khi chưa nhập giá trị cho ô tên đăng nhập và mật khẩu
            if (txtTenDangNhap.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập giá trị", "Thông báo");
            }
            else
            {
                //Hiện form cửa hàng ra
                frmCuaHang ch = new frmCuaHang();
                this.Hide();
                ch.ShowDialog();
            }

        }

        //Sự kiện khi nhấn vào nút tạo tài khoản
        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //Hiện frm tạo tài khoản
            frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
            frm.ShowDialog();
        }

        //Sự kiện khi nhấn vào nút đăng nhập không cần mật khẩu
        private void btnDangNhapKCMK_Click(object sender, EventArgs e)
        {
            //Hiện frm cửa hàng
            frmCuaHang frm = new frmCuaHang();
            this.Hide();
            frm.ShowDialog();

        }
    }
}
