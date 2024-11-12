using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DeleteScorpion : System.Web.UI.Page
{
    string strsql = "";
    string strcriteria = "";
    string strsqldelete = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcn;

        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        if (Convert.ToString(Session["username"]) == "admin")
        {

            if (Page.IsPostBack)
            {
                 strcriteria = "";
                 strsql = "";
                 string[] strarr = new string[3];
                 int j = -1;

                 if (txtfamily.Text != "")
                 {
                    j++;
                    strarr[j] = "(family Like N'%" + txtfamily.Text + "%')";
                 }

                 if (txtgenus.Text != "")
                 {
                    j++;
                    strarr[j] = "(genus Like N'%" + txtgenus.Text + "%')";
                 }

                 if (txtspecies.Text != "")
                 {
                    j++;
                    strarr[j] = "(species Like N'%" + txtspecies.Text + "%')";
                 }
                  //-----------------------------------------------------

                 for (int k = 0; k <= j; k++)
                    {
                      if (k == 0)
                      {
                         strcriteria = " where " + strarr[k];
                      }
                      else
                      {
                         strcriteria = strcriteria + " and " + strarr[k];
                      }

                    }

                     strsql = "select * from scorpions " + strcriteria;
                     lblmsg.Visible = false;
            }
             else
            {
              strsql = "select * from scorpions";
            }

              SqlCommand cmd = new SqlCommand(strsql, cn);
              SqlDataAdapter da = new SqlDataAdapter(cmd);

              DataSet ds = new DataSet();
              da.Fill(ds, "scorpions");

              gv.DataSource = ds;
              gv.DataBind();

            if (ds.Tables[0].Rows.Count > 0)
            {
            gv.HeaderRow.Cells[0].Text = "Family";
            gv.HeaderRow.Cells[1].Text = "Genus";
            gv.HeaderRow.Cells[2].Text = "Species";
            gv.HeaderRow.Cells[3].Text = "Country";
            gv.HeaderRow.Cells[4].Text = "Location";
            gv.HeaderRow.Cells[5].Text = "Reproduction";
            gv.HeaderRow.Cells[6].Text = "Feed";
            gv.HeaderRow.Cells[7].Text = "Injury";
             }
            else
            {
            Response.Write("<Script> alert('No scorpion was found') </Script>");
            }
        }
        else
        {
            Response.Redirect("loginadm.aspx");
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        string strcn;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsqldelete = "Delete from scorpions " + strcriteria;

        cn.Open();
        SqlCommand cmd = new SqlCommand(strsqldelete, cn);
        int rowsAffected = cmd.ExecuteNonQuery();

        lblmsg.Visible = true;
        if (rowsAffected > 0)
        {
            lblmsg.Text = "Successfully deleted!";
        }
        else
        {
            lblmsg.Text = "No row was deleted!";
        }
        
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        //string strcn;
        //strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        //SqlConnection cn = new SqlConnection(strcn);

        ////-----------------------------------------------------------

        //SqlCommand cmd = new SqlCommand(strsql, cn);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);

        //DataSet ds = new DataSet();


        //da.Fill(ds, "scorpions");

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    //Response.Write(ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString());
        //    cn.Open();
        //    strsql = "Delete from scorpions where (id = " + ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString() + ")";
        //    cmd = new SqlCommand(strsql, cn);
        //    cmd.ExecuteNonQuery();
        //    lblmsg.Visible = true;
        //}

    }
}