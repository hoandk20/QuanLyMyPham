using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMyPham.DAO;
using QuanLyMyPham.model;

namespace QuanLyMyPham.view
{
    class categoryDAO
    {
        DataProvider d = new DataProvider();
        public DataTable getCategory()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT [id],[name]FROM[dbo].[category]";
            dt = d.executeQuery(sql);
           return dt;
        }

    }
}
