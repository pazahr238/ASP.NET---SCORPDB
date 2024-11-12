using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string strcn;
            strcn = ConfigurationManager.ConnectionStrings["shop"].ToString();
            SqlConnection cn = new SqlConnection(strcn);

            cn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users values(N'" + fname.Text + "' , N'" + lname.Text + "' , N'" + email.Text + "' , N'" + password.Text + "')", cn);
            cmd.ExecuteNonQuery();

            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //DataSet ds = new DataSet();
            //da.Fill(ds, "Users");

            lblmsg.Visible = true; 

        }

    }
}