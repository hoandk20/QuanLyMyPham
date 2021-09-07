using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMyPham.model
{
    class product
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string  name;

        public string  Name
        {
            get { return name; }
            set { name = value; }
        }
        private int cateID;

        public int CateID
        {
            get { return cateID; }
            set { cateID = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }





    }
}
