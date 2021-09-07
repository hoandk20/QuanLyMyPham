using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyMyPham.model;

namespace QuanLyMyPham.DAO
{
    class userDAO
    {
        DataProvider d = new DataProvider();
        public  bool checkLogin(string user, string pass)
        {
            DataTable dt = new DataTable();
            String sql = "Select * from dbo.login where username='"+user+"' and password='"+pass+"'";
            dt = d.executeQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
