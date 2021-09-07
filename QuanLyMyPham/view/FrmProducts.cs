using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMyPham.view;
using QuanLyMyPham.model;
using QuanLyMyPham.DAO;

namespace QuanLyMyPham.view
{
    public partial class FrmProducts : Form
    {
        public List<BillProduct> listbill;
        public FrmProducts()
        {
            InitializeComponent();
            listbill = new List<BillProduct>();
        }
        

        public void FrmProducts_Load(object sender, EventArgs e)
        {
            categoryDAO cDAO = new categoryDAO();
            DataTable dt = cDAO.getCategory();
            foreach(DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["name"]);
            }
              show(0);


        }
        void show(int id)
        {
            dataGridView1.Rows.Clear();
            productDAO pDAO = new productDAO();
            List<product> list = pDAO.getProduct(id);
            foreach(product p in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = p.Id;
                row.Cells[1].Value = p.Name;
                row.Cells[2].Value = p.Price;
                dataGridView1.Rows.Add(row);
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = comboBox1.SelectedIndex+1;
            show(index);
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Visible = true;
            f.AutoSize = true;
        }

        public void btnRemove_Click(object sender, EventArgs e)
        {
            FrmRemove f = new FrmRemove();
            f.Visible = true;
            f.AutoSize = true;
        }

        public void btnRe_Click(object sender, EventArgs e)
        {
            show(0);
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(3))
            {
                int index = dataGridView1.CurrentRow.Index;
                DataGridViewRow row = dataGridView1.Rows[index];
                try
                {
                    int quantity = Convert.ToInt32(row.Cells[4].Value) ;
                    string name = row.Cells[1].Value+"";
                    string xprice = row.Cells[2].Value.ToString().Trim();
                    double price = Convert.ToDouble(xprice);

                    BillProduct b = new BillProduct();
                    b.Name = name;
                    b.Price = price;
                    b.Quantity = quantity;
                    if (checkDuplicate(name))
                    {
                        listbill.Add(b);
                    }
                    else
                    {
                        edit(b);
                        
                    }
                    MessageBox.Show("Thành công!");
                }
                catch
                {
                    MessageBox.Show("lỗi nhập số liệu!");
                    return;
                }


            }
                
        }
        void edit(BillProduct bil)
        {
            
            foreach (BillProduct b in listbill)
            {
                if (b.Name.Equals(bil.Name))
                {
                    b.Quantity = bil.Quantity;
                }
            }
        }
        bool checkDuplicate(string name)
        {
            foreach(BillProduct b in listbill)
            {
                if (b.Name.Equals(name))
                {
                    return false;
                }
            }
            return true;
        }


        
        public void btnBill_Click(object sender, EventArgs e)
        {

            FrmBill f = new FrmBill(listbill);
            f.Visible = true;
            f.AutoSize = true;
            
        }
    }
}
