using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Routine : System.Web.UI.Page
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
    //Method to Insert data into table(Routine)
    protected void BTN_SUBMIT_Click(object sender, EventArgs e)
    {
        if (TXT_SESSION.Text == "")
        {
            LBL_MSG.Text = "Please Enter Session";
            TXT_SESSION.Focus();
        }
        else if (TXT_STD.Text == "")
        {
            LBL_MSG.Text = "Please Enter Standard";
            TXT_STD.Focus();
        }
        else if (TXT_SEC.Text == "")
        {
            LBL_MSG.Text = "Please Enter Section";
            TXT_SEC.Focus();
        }
        else if (TXT_DAY.Text == "")
        {
            LBL_MSG.Text = "Please Enter Day";
            TXT_DAY.Focus();
        }
        else if (TXT_PERIOD.Text == "")
        {
            LBL_MSG.Text = "Please Enter Period";
            TXT_PERIOD.Focus();
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
                string str = "Insert into Routine(Session,Std,Sec,Day,Period,Staff_id)Values('" + TXT_SESSION.Text + "','" + TXT_STD.Text + "','" + TXT_SEC.Text + "','" + TXT_DAY.Text + "','" + TXT_PERIOD.Text + "','" + TXT_STAFF_ID.Text + "')";
                SqlCommand cmd = new SqlCommand(str, Class1.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Class1.cnn.Close();
                LBL_MSG.Text = "Data Saved";
                blank();
            }
        }
    }
    //Method to Select data from table(Routine)
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
            string str = "Select * from Routine";
            SqlCommand cmd = new SqlCommand(str, Class1.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                {
                  if (TXT_SESSION.Text == dr["Session"].ToString())
                    {
                      TXT_STD.Text = dr["Std"].ToString();
                      TXT_SEC.Text = dr["Sec"].ToString();
                      TXT_DAY.Text = dr["Day"].ToString();
                      TXT_PERIOD.Text = dr["Period"].ToString();
                      TXT_STAFF_ID.Text = dr["Staff_Id"].ToString();
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
    //Method to Update data from table(Routine)
    protected void BTN_UPDATE_Click(object sender, EventArgs e)
    {
        try
        {
            Class1.cnn.Open();
            string str = "update Routine set Std='" + TXT_STD.Text + "',Sec='" + TXT_SEC.Text + "',Day='" + TXT_DAY.Text + "',Period='" +TXT_PERIOD.Text+ "',Staff_id='" +TXT_STAFF_ID.Text+ "' Where Session='" + TXT_SESSION.Text + "'";
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
    //Method to Delete data from table(Routine)
    protected void BTN_DELETE_Click(object sender, EventArgs e)
    {
        Class1.cnn.Open();
        string str="Delete Routine where Session='"+TXT_SESSION.Text+"'";
        SqlCommand cmd=new SqlCommand(str,Class1.cnn);
        cmd.ExecuteNonQuery();
        LBL_MSG.Text="Data Deleted...";
        blank();
    }
    //Function to blank textboxes
    public void blank()
    {
        TXT_SESSION.Text="";
        TXT_STD.Text="";
        TXT_SEC.Text="";
        TXT_DAY.Text="";
        TXT_PERIOD.Text="";
        TXT_STAFF_ID.Text="";
        TXT_SESSION.Focus();
    }
}