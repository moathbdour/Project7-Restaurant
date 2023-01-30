using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project7
{
    
    public partial class WebForm9 : System.Web.UI.Page
    {
        project7Entities data = new project7Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"]!=null)
            {
                int idss = Convert.ToInt32(Request.QueryString["id"]);
                var deletes = data.buffet_menu_items.Find(idss);
                data.buffet_menu_items.Remove(deletes);
                data.SaveChanges();
               // Response.Redirect("WebForm9.aspx");
            }

            var obj = data.buffet_menu_items.ToList();
            GridView1.DataSource= obj;
            GridView1.DataBind();
        }
    }
}