using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

public partial class AddScorpion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["username"]) == "admin")
        { 
            if (Page.IsPostBack)
            {
            string strcn , strsql, scorpimgfile;
            strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
            SqlConnection cn = new SqlConnection(strcn);
            cn.Open();

            strsql = "select * from scorpions where (species ='" + txtspecies.Text + "') and (genus ='" + txtgenus.Text + "')";
            SqlCommand cmdcheck = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmdcheck);
            DataSet ds = new DataSet();
            da.Fill(ds, "scorpions");

                 if (ds.Tables[0].Rows.Count > 0)
                  {
                    lblmsg.Visible = true;
                    lblmsg.ForeColor = Color.Red;
                    lblmsg.Text = "This scorpion has been already added! Try another one.";
                  }
                  else
                  if ((txtfamily.Text!="") && (txtgenus.Text!="") && (txtspecies.Text!="") && (txtcountry.Text!=""))
                  {
                    
                    if (fu.HasFile)
                     {
                        scorpimgfile = fu.FileName;
                     }
                    else
                     {
                        scorpimgfile = "nopreview.jpg";
                     }

                    SqlCommand cmd = new SqlCommand("Insert into Scorpions values(N'" + txtfamily.Text + "' , N'" + txtgenus.Text + "' , N'" + txtspecies.Text + "' , N'" + txtcountry.Text + "' , N'" + txtLocation.Text + "' , N'" + txtReproduction.Text + "' , N'" + txtFeed.Text + "' , N'" + txtInjury.Text + "' , '" + "~/imgs/" + scorpimgfile + "')", cn);
                    cmd.ExecuteNonQuery();

                    if (fu.HasFile)
                    {
                        fu.SaveAs(Server.MapPath("imgs") + "/" + fu.FileName);
                    }
                    
                    lblmsg.Visible = true;
                    lblmsg.ForeColor = Color.Green;
                    lblmsg.Text = "Successfully added!";

                   } else
                        {
                           lblmsg.Visible = true;
                           lblmsg.ForeColor = Color.Red;
                           lblmsg.Text = "You must enter the required information!";
                        }

            cn.Close();
            }
        }
        else
        {
            Response.Redirect("loginadm.aspx");
        }
    }
}