using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyMyPham.model;

namespace QuanLyMyPham.view
{
    public partial class FrmBill : Form
    {
        public FrmBill()
        {
            InitializeComponent();
        }
        List<BillProduct> list;
        public FrmBill(List<BillProduct> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void FrmBill_Load(object sender, EventArgs e)
        {
            double total = 0;
            foreach (BillProduct p in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = p.Name;
                row.Cells[1].Value = p.Quantity;
                row.Cells[2].Value = p.Price;
                row.Cells[3].Value = p.Price*p.Quantity;
                total += p.Price * p.Quantity;
                dataGridView1.Rows.Add(row);
            }
            txtTong.Text = "Tổng tất cả: "+total+" k";
        }
    }
}
