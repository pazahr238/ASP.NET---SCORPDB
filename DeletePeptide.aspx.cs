using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class DeletePeptide : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcn , strsql;

        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        if (Convert.ToString(Session["username"]) == "admin")
        {

            //if (Page.IsPostBack)
            //    {
            //     strsql = "select * from peptides where pname Like N'%" + txtpepname.Text + "%'";
            //     lblmsg.Visible = false;
            //    }
            //else
            //   {
                  strsql = "select * from peptides";
             //  }

            btndelete.Enabled = false;

            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "peptides");

            gv.DataSource = ds;
            gv.DataBind();

            if (ds.Tables[0].Rows.Count > 0)
            {
                gv.HeaderRow.Cells[1].Text = "Peptide Name";
                gv.HeaderRow.Cells[2].Text = "Source";
                gv.HeaderRow.Cells[3].Text = "Activity";
                gv.HeaderRow.Cells[4].Text = "Therapy";
                gv.HeaderRow.Cells[5].Text = "Sequence";
                gv.HeaderRow.Cells[6].Text = "Length";
                gv.HeaderRow.Cells[7].Text = "UniProt ID";
                gv.HeaderRow.Cells[8].Text = "PDB ID";
                gv.HeaderRow.Cells[9].Text = "Add. Info.";
                gv.HeaderRow.Cells[10].Text = "Reference";

                gv.Attributes.Add("style", "word-break:break-all; word-wrap:break-word");

            }
             else
             {
               Response.Write("<Script> alert('No Peptide was found') </Script>");
             }
        }
        else
        {
            Response.Redirect("loginadm.aspx");
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        //string strcn , strsql;
        //strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        //SqlConnection cn = new SqlConnection(strcn);

        //strsql = "Delete from peptides where pname Like N'%" + txtpepname.Text + "%'";

        //cn.Open();
        //SqlCommand cmd = new SqlCommand(strsql, cn);
        //int rowsAffected = cmd.ExecuteNonQuery();

        //lblmsg.Visible = true;
        //if (rowsAffected > 0)
        //{
        //    lblmsg.Text = "Successfully deleted!";
        //}
        //else
        //{
        //    lblmsg.Text = "No row was deleted!";
        //}
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsql = "select * from peptides";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();


        da.Fill(ds, "Peptides");

        if (ds.Tables[0].Rows.Count > 0)
        {
            //Response.Write(ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString());
            cn.Open();
            strsql = "Delete from Peptides where (uniprot = '" + ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString() + "')";
            cmd = new SqlCommand(strsql, cn);
            cmd.ExecuteNonQuery();
            lblmsg.Visible = true;

        }

        Response.Redirect("deletepeptide.aspx");

        

    }



    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string strcn, strsql;

        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsql = "select * from peptides where pname Like N'%" + txtpepname.Text + "%'";
        lblmsg.Visible = false;

        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();
        da.Fill(ds, "peptides");

        gv.DataSource = ds;
        gv.DataBind();

        if (ds.Tables[0].Rows.Count > 0)
        {
            gv.HeaderRow.Cells[1].Text = "Peptide Name";
            gv.HeaderRow.Cells[2].Text = "Source";
            gv.HeaderRow.Cells[3].Text = "Activity";
            gv.HeaderRow.Cells[4].Text = "Therapy";
            gv.HeaderRow.Cells[5].Text = "Sequence";
            gv.HeaderRow.Cells[6].Text = "Length";
            gv.HeaderRow.Cells[7].Text = "UniProt ID";
            gv.HeaderRow.Cells[8].Text = "PDB ID";
            gv.HeaderRow.Cells[9].Text = "Add. Info.";
            gv.HeaderRow.Cells[10].Text = "Reference";
        }
        else
        {
            Response.Write("<Script> alert('No Peptide was found') </Script>");
        }

    }
}