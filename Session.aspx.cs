using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Session : System.Web.UI.Page
{
    //Call Page Load Event,to Check Connection
    protected void Page_Load(object sender, EventArgs e)
    {
        //Exception Handling
        try
        {
            Class1.cnn.Open();
            Response.Write("Database Connected");
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
        }
    }
    //Method to Insert data into table(Session)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_S_PERIOD.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session Period";
            TXT_S_PERIOD.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "Insert into Session(Session,S_Period)Values('" + TXT_SESSION.Text + "','" + TXT_S_PERIOD.Text + "')";
                SqlCommand cmd = new SqlCommand(str, Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text="Data Saved...";
                blank();
            }
        }
    }
    //Method to Select data from table(Session)
    protected void BTN_SEARCH_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else
        {
            Class1.cnn.Open();
            string str = "Select * from Session";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_SESSION.Text == dr["Session"].ToString())
                {
                    TXT_S_PERIOD.Text = dr["S_Period"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Session Not Matched";
                    TXT_S_PERIOD.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Session)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "Update Session set S_Period='" + TXT_S_PERIOD.Text + "' Where Session='" + TXT_SESSION.Text + "'";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text = "Data Updated";
            blank();
        }
    }
    //Method to Delete data from table(Session)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Session Where Session='" + TXT_SESSION.Text + "'";
        SqlCommand cmd = new SqlCommand(str, Class1.cnn);
        cmd.ExecuteNonQuery();
        Class1.cnn.Close();
        LBL_MSG.Text = "Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_SESSION.Text = "";
        TXT_S_PERIOD.Text = "";
        TXT_SESSION.Focus();
    }
}