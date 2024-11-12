using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admcp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {    
        if (Convert.ToString(Session["username"]) != "admin")
        {
            Response.Redirect("loginadm.aspx");
        }

    }

    protected void btnexit_Click(object sender, EventArgs e)
    {
        Session["username"] = "";
        Response.Redirect("loginadm.aspx");
    }
}