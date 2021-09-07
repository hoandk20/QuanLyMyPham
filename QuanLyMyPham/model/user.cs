using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMyPham.model
{
    class user
    {
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string pass;

        public string Password
        {
            get { return pass; }
            set { pass = value; }
        }
        DataProvider d = new DataProvider();


    }
    
}
