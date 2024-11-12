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

    //string cs = ConfigurationManager.ConnectionStrings["ajumst"].ConnectionString;
    //SqlConnection con;
    //SqlDataAdapter adapt;
    //DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["username"]) != "admin")
        {
            Response.Redirect("loginadm.aspx");
        }

        gv.Attributes.Add("style", "word-break:break-all; word-wrap:break-word");
        //if (!IsPostBack)
        //{
        //    ShowData();
        //}
    }

    protected void ShowData()
    {
        //dt = new DataTable();
        //con = new SqlConnection(cs);
        //con.Open();
        //adapt = new SqlDataAdapter("Select * from peptides", con);
        //adapt.Fill(dt);
        //if (dt.Rows.Count > 0)
        //{
        //    gv.DataSource = dt;
        //    gv.DataBind();

        //    gv.Attributes.Add("style", "word-break:break-all; word-wrap:break-word");
        //}
        //con.Close();
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        //string strcn, strsql;
        //strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        //SqlConnection cn = new SqlConnection(strcn);

        //strsql = "select * from peptides where (pname like '%" + Session["strpname"].ToString() + "%') and (source like '%" + Session["strsource"].ToString() + "%') and (seq like '%" + Session["strseq"].ToString() + "%')";
        //SqlCommand cmd = new SqlCommand(strsql, cn);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);

        //DataSet ds = new DataSet();
        //da.Fill(ds, "peptides");

        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //    txtpname.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[0].ToString();
        //    txtsource.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[1].ToString();
        //    txtactivity.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[2].ToString();
        //    txttherapy.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[3].ToString();
        //    txtsequence.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[4].ToString();        
        //    txtlen.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
        //    txtunip.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString();
        //    txtpdb.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[7].ToString();
        //    txtadinf.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[8].ToString();
        //    txtref.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[9].ToString();
        //}

    }

    protected void btnsave_Click(object sender, EventArgs e)
    {
        //string strcn, strsqlupdate;
        //strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        //SqlConnection cn = new SqlConnection(strcn);

        //strsqlupdate = "Update peptides set pname = '" + txtpname.Text + "' , source = '" + txtsource.Text + "' , activity = '" + txtactivity.Text + "' , therapy = '" + txttherapy.Text + "' , seq = '" + txtsequence.Text + "' , length = '" + txtlen.Text + "' , uniprot = '" + txtunip.Text + "' , pdbid = '" + txtpdb.Text + "' , addinf = '" + txtadinf.Text + "' , ref = '" + txtref.Text + "' where (pname = '" + Session["strpname"].ToString() + "') and (source = '" + Session["strsource"].ToString() + "') and (seq = '" + Session["strseq"].ToString() + "')";
        ////Response.Write(strsqlupdate);
        //cn.Open();
        //SqlCommand cmd = new SqlCommand(strsqlupdate, cn);
        //int rowsAffected = cmd.ExecuteNonQuery();

        //lblmsg.Visible = true;
        //if (rowsAffected > 0)
        //{
        //    lblmsg.Text = "Successfully updated!";
        //}
        //else
        //{
        //    lblmsg.Text = "No row was updated!";
        //}

    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        //string strcn, strsql;
        //strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        //SqlConnection cn = new SqlConnection(strcn);

        //lblmsg.Visible = false;

        ////if (Page.IsPostBack)
        ////{
        //    DataSet ds = new DataSet();
        //    if (txtpname.Text != "" && txtsource.Text != "" /*&& txtsequence.Text != ""*/)
        //    {
        //        strsql = "select * from peptides where (pname like N'%" + txtpname.Text + "%') and (source like N'%" + txtsource.Text + "%')"; // and (seq like '%" + txtsequence.Text + "%')
        //        SqlCommand cmd = new SqlCommand(strsql, cn);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        da.Fill(ds, "peptides");
        //        gv.DataSource = ds;
        //        gv.DataBind();


        //        Session["strpname"] = txtpname.Text;
        //        Session["strsource"] = txtsource.Text;
        //        //Session["strseq"] = txtsequence.Text;

        //        if (ds.Tables[0].Rows.Count > 0)
        //        {
        //            //Response.Write(ds.Tables[0].Rows.Count);               

        //            gv.HeaderRow.Cells[1].Text = "Peptide name";
        //            gv.HeaderRow.Cells[2].Text = "Source";
        //            gv.HeaderRow.Cells[3].Text = "Activity";
        //            gv.HeaderRow.Cells[4].Text = "Therapy";
        //            gv.HeaderRow.Cells[5].Text = "Sequence";
        //            gv.HeaderRow.Cells[6].Text = "Length";
        //            gv.HeaderRow.Cells[7].Text = "Uniprot";
        //            gv.HeaderRow.Cells[8].Text = "Pdbid";
        //            gv.HeaderRow.Cells[8].Text = "Add. Info.";
        //            gv.HeaderRow.Cells[8].Text = "Reference";

        //            gv.Attributes.Add("style", "word-break:break-all; word-wrap:break-word");

        //        }
        //        else
        //        {
        //            lblmsg.Visible = true;
        //        }
        //        ds.Dispose();

        //    }
        //    else
        //    {
        //        lblmsg.Visible = true;
        //    }

        //}
    }

    protected void gv_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //gv.EditIndex = e.NewEditIndex;
        //ShowData();
    }

    protected void gv_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Label lblpname = gv.Rows[e.RowIndex].FindControl("lbl_pname") as Label;
        //Label lblsource = gv.Rows[e.RowIndex].FindControl("lbl_source") as Label;
        //Label lblactivity = gv.Rows[e.RowIndex].FindControl("lbl_activity") as Label;
        //Label lbltherapy = gv.Rows[e.RowIndex].FindControl("lbl_therapy") as Label;
        //Label lblseq = gv.Rows[e.RowIndex].FindControl("lbl_seq") as Label;
        //Label lbllength = gv.Rows[e.RowIndex].FindControl("lbl_length") as Label;
        //Label lbluniprot = gv.Rows[e.RowIndex].FindControl("lbl_uniprot") as Label;
        //Label lblpdbid = gv.Rows[e.RowIndex].FindControl("lbl_pdbid") as Label;
        //Label lbladdinf = gv.Rows[e.RowIndex].FindControl("lbl_addinf") as Label;
        //Label lblref = gv.Rows[e.RowIndex].FindControl("lbl_ref") as Label;

        //TextBox txtpname = gv.Rows[e.RowIndex].FindControl("txt_pname") as TextBox;
        //TextBox txtsource = gv.Rows[e.RowIndex].FindControl("txt_source") as TextBox;
        //TextBox txtactivity = gv.Rows[e.RowIndex].FindControl("txt_activity") as TextBox;
        //TextBox txttherapy = gv.Rows[e.RowIndex].FindControl("txt_therapy") as TextBox;
        //TextBox txtseq = gv.Rows[e.RowIndex].FindControl("txt_seq") as TextBox;
        //TextBox txtlength = gv.Rows[e.RowIndex].FindControl("txt_length") as TextBox;
        //TextBox txtuniprot = gv.Rows[e.RowIndex].FindControl("txt_uniprot") as TextBox;
        //TextBox txtpdbid = gv.Rows[e.RowIndex].FindControl("txt_pdbid") as TextBox;
        //TextBox txtaddinf = gv.Rows[e.RowIndex].FindControl("txt_addinf") as TextBox;
        //TextBox txtref = gv.Rows[e.RowIndex].FindControl("txt_ref") as TextBox;

        //con = new SqlConnection(cs);
        //con.Open();
        
        //string mymsg = "Update Peptides set pname=N'" + txtpname.Text + "', source=N'" + txtsource.Text + "', activity=N'" + txtactivity.Text + "', therapy=N'" + txttherapy.Text + "', seq=N'" + txtseq.Text + "', length=" + txtlength.Text + ", uniprot=N'" + txtuniprot.Text + "', pdbid=N'" + txtpdbid.Text + "', addinf=N'" + txtaddinf.Text + "', ref=N'" + txtref.Text + "' WHERE (pname=N'" + lblpname.Text + "') and (source=N'" + lblsource.Text + "') and (activity=N'" + lblactivity.Text + "') and (therapy=N'" + lbltherapy.Text + "') and (seq=N'" + lblseq.Text + "') and (length=" + lbllength.Text + ") and (uniprot=N'" + lbluniprot.Text + "') and (pdbid=N'" + lblpdbid.Text + "') and (addinf=N'" + lbladdinf.Text + "') and (ref=N'" + lblref.Text + "')";
        //lblmsg.Text = mymsg;
        //SqlCommand cmd = new SqlCommand(mymsg, con);
        ////cmd.ExecuteNonQuery();
        //con.Close();
        
        //gv.EditIndex = -1;
        
        //ShowData();
    }

    protected void gv_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //gv.EditIndex = -1;
        //ShowData();
    }

   
}