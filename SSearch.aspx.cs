using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);
        
        lblmsg.Visible = false;
        imgtik.Visible = false;
        

        if (! Page.IsPostBack)
        {
            
            //strsql = Session["strsql"].ToString();
            strsql = "select distinct family from scorpions order by family";
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "scorpions");

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpfamily.Items.Clear();
                drpfamily.Items.Add("Select an item");
                //drpspecies.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    drpfamily.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
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
            
            string[] strarr = new string[3];
            int j = -1;

            if (drpfamily.SelectedIndex > 0)
            {
                j++;
                strarr[j] = "(family = '" + drpfamily.Text + "')";
                
                //strcriteria += " where (family = '" + drpfamily.Text + "')";
            }

            if (drpgenus.SelectedIndex > 0)
            {
                j++;
                strarr[j] = "(genus = '" + drpgenus.Text + "')";
                
                //strcriteria += " and (genus = '" + drpgenus.Text + "')";
            }

            if (drpspecies.SelectedIndex > 0)
            {
                j++;
                strarr[j] = "(species = '" + drpspecies.Text + "')";
                //strcriteria += " and (species = '" + drpspecies.Text + "')";
            }
            //-----------------------------------------------------

            for (int k=0; k<=j; k++)
            {
                if (k == 0)
                  {
                    strcriteria = " where " + strarr[k];
                  }
                else
                  { 
                    strcriteria =  strcriteria + " and " + strarr[k]; 
                  }

            }

            strsql = "select family, genus, species , country from scorpions " + strcriteria + " order by species";
            Session["strcriteria"] = strcriteria;
            //Response.Write(strsql);
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Response.Write(strcriteria);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "scorpions");
            gv.DataSource = ds;
            gv.DataBind();

            if (ds.Tables[0].Rows.Count > 0)
            {
                //Response.Write(ds.Tables[0].Rows.Count);               
                
                gv.HeaderRow.Cells[1].Text = "Family";
                gv.HeaderRow.Cells[2].Text = "Genus";
                gv.HeaderRow.Cells[3].Text = "Species";
                gv.HeaderRow.Cells[4].Text = "Country";
                
            }
            else
            {
                lblmsg.Visible = true;
                imgtik.Visible = true;
            }
            ds.Dispose();

        }

      
        
    }

    protected void drpfamily_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Session["username"] = "TestUser";
        //if (drpfamily.SelectedIndex>0)
        //{
            string strcn, strsql;
            strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
            SqlConnection cn = new SqlConnection(strcn);

            //strsql = Session["strsql"].ToString();
            strsql = "select distinct genus from scorpions where family = '" + drpfamily.Text + "' order by genus";
            SqlCommand cmd = new SqlCommand(strsql, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "scorpions");

            if (ds.Tables[0].Rows.Count > 0)
            {
                drpgenus.Items.Clear();
                drpgenus.Items.Add("Select an item");
                //drpspecies.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                for (int i=0; i< ds.Tables[0].Rows.Count; i++)
                {
                   drpgenus.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                }
                
            }
        //Response.Write(ds.Tables[0].Rows.Count);

        //}
    }

    protected void drpgenus_SelectedIndexChanged(object sender, EventArgs e)
    {
        string strcn, strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        //strsql = Session["strsql"].ToString();
        strsql = "select distinct species from scorpions where (genus = '" + drpgenus.Text + "') order by species";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "scorpions");

        if (ds.Tables[0].Rows.Count > 0)
        {
            drpspecies.Items.Clear();
            drpspecies.Items.Add("Select an item");
            //drpspecies.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drpspecies.Items.Add(ds.Tables[0].Rows[i].ItemArray[0].ToString());
            }
            //gv.DataSource = ds;
            //gv.DataBind();
            //drpgenus.SelectedIndex = 0;


        }
    }

    protected void gv_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        string strcn , strsql;
        strcn = ConfigurationManager.ConnectionStrings["ajumst"].ToString();
        SqlConnection cn = new SqlConnection(strcn);

        //-----------------------------------------------------------
        strsql = "Select * from scorpions " + Session["strcriteria"].ToString() + " order by species";
        SqlCommand cmd = new SqlCommand(strsql, cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();


        da.Fill(ds, "scorpions");

        if (ds.Tables[0].Rows.Count > 0)
        {
            //Response.Write(ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString());
            lbllocation.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[4].ToString();
            //lblreproduction.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
            lblfeed.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[6].ToString();
            lblinjury.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[7].ToString();
            lblreference.Text = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[5].ToString();
            imgscorpion.ImageUrl = ds.Tables[0].Rows[e.NewSelectedIndex].ItemArray[8].ToString();
        }

        

    }

    protected void gv_DataBinding(object sender, EventArgs e)
    {
        lbltik.Visible = true;
        imgtik.Visible = true;
    }
}