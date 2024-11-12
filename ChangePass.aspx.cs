using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        if (!IsPostBack)
        {
            if (Convert.ToString(Session["username"]) != "admin")
            {
                Response.Redirect("loginadm.aspx");
            }
        }
        else { 
                 if (txtnew.Text == "" || txtrepeat.Text =="")
                 {
                   lblmsg.Text = "Please enter a valid password for new and repeat fields";
                   lblmsg.Visible = true;
                 } 
                 else
                 {
                     if (txtnew.Text != txtrepeat.Text)
                     {
                      lblmsg.Text = "Please enter the same passwords for new and repeat fields";
                      lblmsg.Visible = true;
                     }
                     else
                     {

                      string strcn, strsql;
                      strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
                      SqlConnection cn = new SqlConnection(strcn);

                      strsql = "Update users Set password = '" + txtnew.Text + "' where email = 'admin@yahoo.com'";

                      cn.Open();
                      SqlCommand cmd = new SqlCommand(strsql, cn);
                      cmd.ExecuteNonQuery();


                      Response.Redirect("admcp.aspx");
                     }
                 }
        }


    }
}