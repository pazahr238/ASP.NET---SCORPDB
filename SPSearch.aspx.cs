using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

public partial class SPSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        lblmsg.Visible = false;
        imgtik.Visible = false;
        

        if (!Page.IsPostBack)
        {
            drppotential.Items.Add("");
            drppotential.SelectedIndex = 3;

            //strsql = Session["strsql"].ToString();
            strsql = "select distinct source from peptides";
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "peptides");

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpsource.Items.Clear();
                drpsource.Items.Add("Select an item");
                //drpspecies.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    drpsource.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }

                //drpfamily.SelectedIndex = 0;
                //drpgenus.SelectedIndex = 0;
                //drpspecies.SelectedIndex = 0;

            }
            ds.Dispose();
        }
        else
        {
            string strcriteria = "";
            string[] strarr = new string[4];
            int j = -1;

            if (txtpepname.Text != "")
            {
                j++;
                strarr[j] = "(pname LIKE '%" + txtpepname.Text + "%')";

                //strcriteria += " where (family = '" + drpfamily.Text + "')";
            }

            if (drpsource.SelectedIndex > 0)
            {
                j++;
                strarr[j] = "(source = '" + drpsource.Text + "')";

                //strcriteria += " and (genus = '" + drpgenus.Text + "')";
            }

            if (drpactivity.SelectedIndex > 0)
            {
                j++;
                strarr[j] = "(activity = '" + drpactivity.Text + "')";
                //strcriteria += " and (species = '" + drpspecies.Text + "')";
            }

            if (drppotential.Text != "")
            {
                j++;
                strarr[j] = "(therapy = '" + drppotential.Text + "')";
                //strcriteria += " and (species = '" + drpspecies.Text + "')";
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

            Session["strcriteria"]  = strcriteria;
            strsql = "select pname from peptides " + strcriteria;
            //Response.Write(strcriteria);
            //Response.Write(strsql);
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Response.Write(strcriteria);

            DataSet ds = new DataSet();
            da.Fill(ds, "peptides");
            gv.DataSource = ds;
            gv.DataBind();

            if (ds.Tables[0].Rows.Count > 0)
            {
                //Response.Write(ds.Tables[0].Rows.Count);

                gv.HeaderRow.Cells[1].Text = "Peptide Name";
                lblclicktik.Visible = true;
                imgtik.Visible = true;
                //gv.HeaderRow.Cells[2].Text = "Source scorpion";
                //gv.HeaderRow.Cells[3].Text = "Activity";
                //gv.HeaderRow.Cells[4].Text = "Therapeutic Potential";
                //gv.HeaderRow.Cells[5].Text = "Sequence";
                //gv.HeaderRow.Cells[6].Text = "Length";
                //gv.HeaderRow.Cells[7].Text = "UniProt ID";
                //gv.HeaderRow.Cells[8].Text = "PDB ID";
                //gv.HeaderRow.Cells[9].Text = "Additional Information";
                //gv.HeaderRow.Cells[10].Text = "Reference";

            }
            else
            {
                lblmsg.Visible = true;
                lblclicktik.Visible = false;
                imgtik.Visible = false;
            }
            ds.Dispose();

        }


    }



    protected void drpsource_SelectedIndexChanged(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        //strsql = Session["strsql"].ToString();
        strsql = "select distinct activity from peptides where source = '" + drpsource.Text + "'";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "peptides");

        if (ds.Tables[0].Rows.Count > 0)
        {
            drpactivity.Items.Clear();
            drpactivity.Items.Add("Select an item");
            //drpspecies.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drpactivity.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            //gv.DataSource = ds;
            //gv.DataBind();
            //drpgenus.SelectedIndex = 0;


        }
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        //-----------------------------------------------------------
        strsql = "Select * from peptides " + Session["strcriteria"].ToString();
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();


        da.Fill(ds, "peptides");

        if (ds.Tables[0].Rows.Count > 0)
        {
            //Response.Write(ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString());
            lblsource.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[1].ToString();
            lblactivity.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[2].ToString();
            //////////// lbltherapic.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[3].ToString();
            lblseq.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[4].ToString();
            lbllength.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
            lbluniprot.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString();
            lblpdbid.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[7].ToString();
            lbladdinf.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[8].ToString();
            lblref.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[9].ToString();
        }
    }
}