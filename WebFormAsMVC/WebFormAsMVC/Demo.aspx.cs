using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormAsMVC
{
    public partial class Demo : System.Web.UI.Page
    {
        public string DbData { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = "我是来自数据库的数据";
            DbData = str;
        }
    }
}