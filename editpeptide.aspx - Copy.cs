using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class editpeptide : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["username"]) != "admin")
        {
            Response.Redirect("loginadm.aspx");
        }
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsql = "select * from peptides where (pname like '%" + Session["strpname"].ToString() + "%') and (source like '%" + Session["strsource"].ToString() + "%') and (seq like '%" + Session["strseq"].ToString() + "%')";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();
        da.Fill(ds, "peptides");

        if (ds.Tables[0].Rows.Count > 0)
        {
            txtpname.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString();
            txtsource.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[1].ToString();
            txtactivity.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[2].ToString();
            txttherapy.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[3].ToString();
            txtsequence.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[4].ToString();        
            txtlen.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
            txtunip.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString();
            txtpdb.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[7].ToString();
            txtadinf.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[8].ToString();
            txtref.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[9].ToString();
        }

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        string strcn, strsqlupdate;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        strsqlupdate = "Update peptides set pname = '" + txtpname.Text + "' , source = '" + txtsource.Text + "' , activity = '" + txtactivity.Text + "' , therapy = '" + txttherapy.Text + "' , seq = '" + txtsequence.Text + "' , length = '" + txtlen.Text + "' , uniprot = '" + txtunip.Text + "' , pdbid = '" + txtpdb.Text + "' , addinf = '" + txtadinf.Text + "' , ref = '" + txtref.Text + "' where (pname = '" + Session["strpname"].ToString() + "') and (source = '" + Session["strsource"].ToString() + "') and (seq = '" + Session["strseq"].ToString() + "')";
        //Response.Write(strsqlupdate);
        cn.Open();
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

    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        lblmsg.Visible = false;

        if (Page.IsPostBack)
        {
            DataSet ds = new DataSet();
            if (txtpname.Text != "" && txtsource.Text != "" && txtsequence.Text != "")
            {
                strsql = "select * from peptides where (pname like '%" + txtpname.Text + "%') and (source like '%" + txtsource.Text + "%') and (seq like '%" + txtsequence.Text + "%')";
                SqlCommand cmd = new SqlCommand(strsql, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds, "peptides");
                gv.DataSource = ds;
                gv.DataBind();


                Session["strpname"] = txtpname.Text;
                Session["strsource"] = txtsource.Text;
                Session["strseq"] = txtsequence.Text;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Response.Write(ds.Tables[0].Rows.Count);               

                    gv.HeaderRow.Cells[1].Text = "Peptide name";
                    gv.HeaderRow.Cells[2].Text = "Source";
                    gv.HeaderRow.Cells[3].Text = "Activity";
                    gv.HeaderRow.Cells[4].Text = "Therapy";
                    gv.HeaderRow.Cells[5].Text = "Sequence";
                    gv.HeaderRow.Cells[6].Text = "Length";
                    gv.HeaderRow.Cells[7].Text = "Uniprot";
                    gv.HeaderRow.Cells[8].Text = "Pdbid";
                    gv.HeaderRow.Cells[8].Text = "Add. Info.";
                    gv.HeaderRow.Cells[8].Text = "Reference";

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
}