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
    public partial class FrmAdd : Form
    {
        public FrmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            categoryDAO cDAO = new categoryDAO();
            DataTable dt = cDAO.getCategory();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["name"]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name.Trim().Length == 0)
            {
                MessageBox.Show("Không thể bỏ trống!", "thông báo");
                return;
            }
            try
            {
                int cate = comboBox1.SelectedIndex+1;
                double price = Convert.ToDouble(txtPrice.Text);
                productDAO p = new productDAO();
                p.addProduct(cate, name, price);
                MessageBox.Show("Thành công", "thông báo");
                txtPrice.Text = "";
                txtName.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("lỗi nhập dữ liệu!", "thông báo");
                return;
            }
           

        }
    }
}
