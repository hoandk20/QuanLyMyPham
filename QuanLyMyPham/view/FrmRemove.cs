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

namespace QuanLyMyPham.view
{
    public partial class FrmRemove : Form
    {
        public FrmRemove()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productDAO pDAO = new productDAO();
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                pDAO.delete(id);
                MessageBox.Show("Thàng công", "thông báo");
            }
            catch
            {
                MessageBox.Show("lỗi nhập dữ liệu!", "thông báo");
            }
            
        }
    }
}
