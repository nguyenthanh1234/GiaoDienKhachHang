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
    public partial class frmCuaHang : Form
    {
        public frmCuaHang()
        {
            InitializeComponent();
        }

        //Sự kiện khi mà người dùng nhấn vào nút menu danh mục
        private void mnpDanhMuc_Click(object sender, EventArgs e)
        {
            //Hiện trang sản phẩm lên
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == "frmSanPham")
                {
                    f.Activate();
                    return;
                }
            }
            frmSanPham sp = new frmSanPham();
            sp.MdiParent = this;
            sp.Show();

 
           
        }

        //Form cửa hàng khi load lên
        private void frmCuaHang_Load(object sender, EventArgs e)
        {
            mnpDanhMuc_Click(sender, e);    
        }

        //Sự kiện khi mà người dùng nhấn vào nút đăng xuất
        private void tspDangXuat_Click(object sender, EventArgs e)
        {
            //Đóng form cửa hàng và bật trang đăng nhập lên.
            if (MessageBox.Show("Bạn muốn đăng xuất", "Trang cửa hàng cafe", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmDangNhap frm = new frmDangNhap();
                this.Hide();
                frm.ShowDialog();
                
            }
        }

        //Sự kiện khi mà người dùng nhấn vào nút tạo tài khoản
        private void tspTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            //Hiện thông báo, ẩn trang cửa hàng và mở trang tạo tài khoản
            if (MessageBox.Show("Cần thoát trang cửa hàng để tạo tài khoản, bạn có muốn không?", "Trang cửa hàng cafe", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmTaoTaiKhoan frm = new frmTaoTaiKhoan();
                this.Hide();
                frm.ShowDialog();
            }
        }
    }
}
