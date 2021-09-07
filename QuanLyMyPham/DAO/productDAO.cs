using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMyPham.model;

namespace QuanLyMyPham.DAO
{
    class productDAO
    {
        DataProvider d = new DataProvider();
        public List<product>getProduct(int id)
        {
            List<product> list = new List<product>();
            string sql = "SELECT [id],[name],[categoryId],[price] FROM[dbo].[product] ";
            if (id != 0)
            {
                sql += "Where categoryId =" + id;
            }
            DataTable dt = d.executeQuery(sql);
            foreach(DataRow dr in dt.Rows)
            {
                product p = new product();
                p.Id = Convert.ToInt32(dr["id"]);
                p.Name = dr["name"]+"";
                p.CateID = Convert.ToInt32(dr["categoryId"]);
                p.Price = Convert.ToDouble(dr["price"]);
                list.Add(p);

            }
            return list;
        }
        public void addProduct(int id,string name,double price)
        {
            string sql = "INSERT INTO [dbo].[product]([name],[categoryId],[price]) VALUES ('"+name+"',"+id+","+price+")";

            d.executeNonQuery(sql);
        }
        public void delete(int id)
        {
            string sql = "DELETE FROM [dbo].[product] WHERE id = "+id+"";
            d.executeNonQuery(sql);
        }
    }
}
