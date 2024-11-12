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

public partial class AddPeptide : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["username"]) == "admin")
        {

            if (Page.IsPostBack)
            {
                string strcn, strsql;
                strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
                SqlConnection cn = new SqlConnection(strcn);
                cn.Open();

                strsql = "select * from peptides where (pname = '" + txtpepname.Text + "') and (source = '" + txtsource.Text + "') and (seq = '" + txtseq.Text + "')";
                SqlCommand cmdcheck = new SqlCommand(strsql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmdcheck);
                DataSet ds = new DataSet();
                da.Fill(ds, "peptides");

                if (ds.Tables[0].Rows.Count > 0)
                {
                lblmsg.Visible = true;
                lblmsg.ForeColor = Color.Red;
                lblmsg.Text = "This peptide has been already added! Try another one.";
                }
                else
                {
                //if (fu.HasFile)
                //{
                    SqlCommand cmd = new SqlCommand("Insert into peptides values(N'" + txtpepname.Text + "' , N'" + txtsource.Text + "' , N'" + txtactivity.Text + "' , N'" + drptherapy.Text + "' , N'" + txtseq.Text + "' , " + txtlength.Text + " , N'" + txtuniprot.Text + "' , N'" + txtpdbid.Text + "' , N'" + txtaddinf.Text + "' , N'" + txtref.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    //fu.SaveAs(Server.MapPath("imgs") + "/" + fu.FileName);
                    lblmsg.Visible = true;
                    lblmsg.ForeColor = Color.Green;
                    lblmsg.Text = "Successfully added!";

                    txtpepname.Text = "";
                    txtsource.Text = "";
                    txtactivity.Text = "";
                    txtseq.Text = "";
                    txtlength.Text = "";
                    txtuniprot.Text = "";
                    txtpdbid.Text = "";
                    txtaddinf.Text = "";
                    txtref.Text = "";

                //}
                //else
                //{
                //    lblmsg.Visible = true;
                //    lblmsg.ForeColor = Color.Red;
                //    lblmsg.Text = "You must select a picture.";
                //}

                }

                cn.Close();
                //Response.Write("<script language=javascript>alert('PostBack');</script>");
            }
        }
        else
        {
            Response.Redirect("loginadm.aspx");
        }
    }
}