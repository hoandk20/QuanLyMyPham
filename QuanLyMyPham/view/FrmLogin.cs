using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMyPham.DAO;
using QuanLyMyPham.view;

namespace QuanLyMyPham
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if(user.Trim() == "" || pass.Trim() == "")
            {
                MessageBox.Show("không thể bỏ trống!", "Thông báo");
                return;
            }
            userDAO uDAO = new userDAO();
            if (uDAO.checkLogin(user, pass))
            {
                MessageBox.Show("đăng nhập thành công!", "Thông báo");
                this.Hide();
                FrmProducts f = new FrmProducts();
                f.Visible = true;
                f.AutoSize = true;
            }
            else
            {
                MessageBox.Show("tài khoản hoặc mật khẩu ko chính xác!", "Thông báo");
            }
            

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
