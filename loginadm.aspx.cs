using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class loginadm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            
            string strcn, strsql;
            strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
            SqlConnection cn = new SqlConnection(strcn);
            strsql = "Select * from Users where (email = N'" + username.Text + "') and (password = N'" + password.Text + "')";
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Users");

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "admin@yahoo.com")
                { 
                Session["username"] = "admin";
                Response.Redirect("admcp.aspx");
                }
                else
                {
                    Response.Write("<Script> alert('You can not enter the site!') </Script>");
                }
            }
            else
            {
                Response.Write("<Script> alert('The user is invalid!') </Script>");
            }

        }
        else 
        { 
            if (Convert.ToString(Session["username"]) == "admin") 
            {
                Response.Redirect("admcp.aspx");
            }
        }
    }
}