using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class editscorpion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        lblmsg.Visible = false;

        if (Convert.ToString(Session["username"]) == "admin")
        { 

            if (Page.IsPostBack)
            {
          
            DataSet ds = new DataSet();
            if (txtspecies.Text != "")
                {
                strsql = "select * from scorpions where (species like '%" + txtspecies.Text + "%')";
                SqlCommand cmd = new SqlCommand(strsql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "scorpions");
                gv.DataSource = ds;
                gv.DataBind();
            

                Session["strspecies"] = txtspecies.Text;
    
                if (ds.Tables[0].Rows.Count > 0)
                 {
                //Response.Write(ds.Tables[0].Rows.Count);               

                gv.HeaderRow.Cells[1].Text = "Family";
                gv.HeaderRow.Cells[2].Text = "Genus";
                gv.HeaderRow.Cells[3].Text = "Species";
                gv.HeaderRow.Cells[4].Text = "Country";
                gv.HeaderRow.Cells[5].Text = "Location";
                gv.HeaderRow.Cells[6].Text = "Reproduction";
                gv.HeaderRow.Cells[7].Text = "Feed";
                gv.HeaderRow.Cells[8].Text = "Injury";

                 }
                else
                 {
                  lblmsg.Visible = true;
                 }
                    ds.Dispose();
                }
            else
                {
                  lblmsg.Visible = true;
                }
            }
        }
        else
        {
            Response.Redirect("loginadm.aspx");
        }

    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsql = "select * from scorpions where (species like '%" + Session["strspecies"].ToString() + "%')";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        
        DataSet ds = new DataSet();
        da.Fill(ds, "scorpions");

        if (ds.Tables[0].Rows.Count > 0)
        {
            txtfamily.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString();
            txtgenus.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[1].ToString();
            txtspecies.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[2].ToString();
            txtcountry.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[3].ToString();
            txtlocation.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[4].ToString();
            txtrepro.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
            txtfeed.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString();
            txtinjury.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[7].ToString();
            imgscorpion.ImageUrl = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[8].ToString();
        }

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string strcn, strsqlupdate = "";
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);
        
        cn.Open();

        if (fu.HasFile)
        {
            strsqlupdate = "Update scorpions set family = '" + txtfamily.Text + "' , genus = '" + txtgenus.Text + "' , species = '" + txtspecies.Text + "' , country = '" + txtcountry.Text + "' , location = '" + txtlocation.Text + "' , reproduction = '" + txtrepro.Text + "' , feed = '" + txtfeed.Text + "' , injury = '" + txtinjury.Text + "' , img = '" + "~/imgs/" + fu.FileName + "' where species = '" + Session["strspecies"].ToString() + "'";
        }
        else
        {
            strsqlupdate = "Update scorpions set family = '" + txtfamily.Text + "' , genus = '" + txtgenus.Text + "' , species = '" + txtspecies.Text + "' , country = '" + txtcountry.Text + "' , location = '" + txtlocation.Text + "' , reproduction = '" + txtrepro.Text + "' , feed = '" + txtfeed.Text + "' , injury = '" + txtinjury.Text + "' where species = '" + Session["strspecies"].ToString() + "'";
        }

        SqlCommand cmd = new SqlCommand(strsqlupdate, cn);
        int rowsAffected = cmd.ExecuteNonQuery();

        lblmsg.Visible = true;
        if (rowsAffected > 0)
        {
            lblmsg.Text = "Successfully updated!";
        }
        else
        {
            lblmsg.Text = "No row was updated!";
        }
        cn.Close();
        //Response.Redirect("admcp.aspx");
    }
}