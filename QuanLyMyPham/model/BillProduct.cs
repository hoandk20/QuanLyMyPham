using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMyPham.model
{
   public class BillProduct
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
