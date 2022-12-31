using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Extraactivity_Report : System.Web.UI.Page
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
    //Method to Insert data into table(Extraactivity_Report)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_REG_NO.Text == "")
        {
            LBL_MSG.Text = "Please Enter Registration No";
            TXT_REG_NO.Focus();
        }
        else if (TXT_REMARKS.Text == "")
        {
            LBL_MSG.Text = "Please Enter Remarks";
            TXT_REMARKS.Focus();
        }
        else if (TXT_DATE.Text == "")
        {
            LBL_MSG.Text = "Please Enter Date";
            TXT_DATE.Focus();
        }
        else if (TXT_STAFF_ID.Text == "")
        {
            LBL_MSG.Text = "Please Enter Staff ID";
            TXT_STAFF_ID.Focus();
        }
        else
        {
            try
            {
                Class1.cnn.Open();
                string str = "insert into Extraactivity_Report(Session,Reg_No,Remarks,Date,Staff_id)values('" + TXT_SESSION.Text + "','" + TXT_REG_NO.Text + "','" + TXT_REMARKS.Text + "','" + TXT_DATE.Text + "','"+TXT_STAFF_ID.Text+"')";
                SqlCommand cmd = new SqlCommand(str, Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text = "Data Saved...";
                blank();
            }
        }
    }
    //Method to Select data from table(Extraactivity_Report)
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
            string str = "select * from Extraactivity_Report";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (TXT_SESSION.Text == dr["Session"].ToString())
                {
                    TXT_REG_NO.Text = dr["REG_NO"].ToString();
                    TXT_REMARKS.Text = dr["REMARKS"].ToString();
                    TXT_DATE.Text = dr["DATE"].ToString();
                    TXT_STAFF_ID.Text = dr["STAFF_ID"].ToString();
                }
                else
                {
                    LBL_MSG.Text = "Session Not Matched";
                    TXT_SESSION.Focus();
                }
            }
            dr.Close();
            Class1.cnn.Close();
        }
    }
    //Method to Update data from table(Extraactivity_Report)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Extraactivity_Report set REG_NO='" + TXT_REG_NO.Text + "',REMARKS='" + TXT_REMARKS.Text + "',DATE='" + TXT_DATE.Text + "',STAFF_ID='"+TXT_STAFF_ID.Text+"'where Session='" + TXT_SESSION.Text + "'";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception) { }
        finally
        {
            Class1.cnn.Close();
            LBL_MSG.Text = "Data Updated...";
            blank();
        }
    }
    //Method to Delete data from table(Extraactivity_Report)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str = "Delete Extraactivity_Report where session='" + TXT_SESSION.Text + "'";
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
        TXT_REG_NO.Text = "";
        TXT_REMARKS.Text = "";
        TXT_DATE.Text = "";
        TXT_STAFF_ID.Text = "";
        TXT_SESSION.Focus();
    }
}